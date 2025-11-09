using ClinicaSePriseApp.Entidades;
using ClinicaSePriseApp.Servicios;
using ClinicaSePriseApp.Utilidades;
using ClinicaSePriseApp.Vistas.Auxiliares;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaSePriseApp.Vistas
{
    public partial class ProfAgendaDiaria : Form
    {
        private static E_Profesional _Profesional;
        private static DateOnly _Fecha;
        private TarjetaTurno _tarjetaSeleccionada;

        public ProfAgendaDiaria()
        {
            InitializeComponent();
            _Profesional = null;
            DateTime dateTime = DateTime.Now;
            _Fecha = DateOnly.FromDateTime(dateTime);
            this.Resize += ProfAgendaDiaria_Resize;
            this.Size = new Size(1024, 768);
            this.MinimumSize = new Size(1024, 768);
            this.WindowState = FormWindowState.Maximized;
        }

        public ProfAgendaDiaria(E_Profesional profesional)
        {
            InitializeComponent();
            _Profesional = profesional;
            DateTime dateTime = DateTime.Now;
            _Fecha = DateOnly.FromDateTime(dateTime);
        }

        private void ProfAgendaDiaria_Load(object sender, EventArgs e)
        {
            AjustarPaneles();
            CargarAgenda();
        }

        private void ProfAgendaDiaria_Resize(object sender, EventArgs e)
        {
            AjustarPaneles();
        }

        private void AjustarPaneles()
        {
            if (_Profesional == null) return;

            mainTLP.BackColor = PaletaColores.Skyblue;
            menuTLP.BackColor = PaletaColores.Grey;
            contentLbl.BackColor = PaletaColores.Grey;
            contentLbl.Font = new Font(Fuente.TIPOGRAFIA, Fuente.Title, FontStyle.Regular);
            contentLbl.Text = $"    {_Fecha}  |  Dr. {_Profesional.NombreCompleto}";

            foreach (Control boton in menuTLP.Controls)
            {
                boton.Dock = DockStyle.Fill;

                if (boton == btnVolver)
                {
                    boton.BackColor = PaletaColores.Pink;
                }
                else if (boton == picLogo)
                {
                    boton.BackColor = Color.Transparent;
                }
                else
                {
                    boton.BackColor = PaletaColores.DarkBlue;
                }

                boton.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);
                boton.ForeColor = Color.White;
            }
        }

        private void CargarAgenda()
        {
            if (_Profesional == null) return;

            var turnosDelDia = TurnoService.ObtenerTurnosDelDia(_Profesional, _Fecha);
            DistribuirTarjetas(turnosDelDia);
        }

        private void DistribuirTarjetas(List<E_Turno> turnos)
        {
            int fila = 0, columna = 0;
            _tarjetaSeleccionada = null;

            cardsTLP.Controls.Clear();
            cardsTLP.RowStyles.Clear();

            int filasNecesarias = (int)Math.Ceiling(turnos.Count / 3.0);
            cardsTLP.RowCount = filasNecesarias;

            for (int i = 0; i < cardsTLP.RowCount; i++)
            {
                cardsTLP.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }

            foreach (var turno in turnos)
            {
                var tarjeta = new TarjetaTurno(turno);
                tarjeta.Dock = DockStyle.Fill;
                tarjeta.Margin = new Padding(10);

                tarjeta.TarjetaClickeada += (s, e) =>
                {
                    SeleccionarTarjeta(tarjeta);
                };

                cardsTLP.Controls.Add(tarjeta, columna, fila);

                columna++;
                if (columna >= 3)
                {
                    columna = 0;
                    fila++;
                }
            }
        }

        private void SeleccionarTarjeta(TarjetaTurno tarjeta)
        {
            if (_tarjetaSeleccionada != null)
            {
                _tarjetaSeleccionada.EstaSeleccionado = false;
            }

            _tarjetaSeleccionada = tarjeta;
            _tarjetaSeleccionada.EstaSeleccionado = true;

            this.Invalidate();
            this.Refresh();
        }

        // Botones
        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if (_tarjetaSeleccionada == null)
            {
                DialogResult resultado = MessageBox.Show(
                "Seleccione un Turno para ver su detalle.",
                "Confirmar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );

                return;
            }

            if (_tarjetaSeleccionada.Turno.Estado == Entidades.Enums.EstadoTurno.DISPONIBLE)
            {
                DialogResult resultado = MessageBox.Show(
                "El Turno seleccionado aún no fue reservado.",
                "Confirmar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );

                return;
            }

            var turno = TurnoService.ObtenerTurnoPorID(_tarjetaSeleccionada.Turno.IdTurno);

            if (turno == null)
            {
               DialogResult resultado = MessageBox.Show(
               "Error al cargar el Turno.",
               "Confirmar",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error
               );

                return;
            }

            AuxDetalleTurno detalleTurno = new AuxDetalleTurno(turno, _Profesional);            
            detalleTurno.ShowDialog();
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            int turnoID = 0;
            var agenda = TurnoService.ObtenerTurnosDelDia(_Profesional, _Fecha);

            turnoID = agenda.FirstOrDefault(t => t.Estado == Entidades.Enums.EstadoTurno.ABONADO)?.IdTurno ?? 0;

            if (turnoID == 0)
            {
                DialogResult resultado = MessageBox.Show(
                "No hay Pacientes en espera.",
                "Confirmar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );

                return;
            }

            var turno = TurnoService.ObtenerTurnoPorID(turnoID);

            turno.Estado = Entidades.Enums.EstadoTurno.EN_ATENCION;

            ProfADAtencionMedica atencionMedica = new ProfADAtencionMedica(_Profesional, turno);
            this.Hide();
            atencionMedica.FormClosed += (s, args) => this.Close();
            atencionMedica.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Desea volver al Dashboard?",
                "Confirmar Regreso",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );

            if (resultado == DialogResult.Cancel) return;

            DashProfesional dashProfesional = new DashProfesional(_Profesional);
            this.Hide();
            dashProfesional.FormClosed += (s, args) => this.Close();
            dashProfesional.Show();
        }
    }
}
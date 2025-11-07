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
    public partial class ProfADAtencionMedica : Form
    {
        private static E_Profesional _Profesional;

        private static E_Turno _Turno;

        private static E_Paciente _Paciente;

        public ProfADAtencionMedica()
        {
            InitializeComponent();
        }

        public ProfADAtencionMedica(E_Profesional profesional, E_Turno turno)
        {
            InitializeComponent();

            _Profesional = profesional;

            _Turno = turno;

            _Paciente = PacienteService.ObtenerPacientePorID(_Turno.IdPaciente);
            if (_Paciente == null)
            {
                MessageBox.Show(
                    "Error al cargar los datos del paciente.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                this.Close();
                return;
            }

            entradasTLP.ColumnStyles.Clear();
            entradasTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            entradasTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            entradasTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));

            AjustarPaneles();

            CargarEstilos();

            CargarDatos();
        }

        private void AjustarPaneles()
        {
            if (_Profesional == null) return;

            mainTLP.BackColor = PaletaColores.celeste;
            menuTLP.BackColor = PaletaColores.bgGris;
            contentLbl.BackColor = PaletaColores.bgGris;

            foreach (Control boton in menuTLP.Controls)
            {
                boton.Dock = DockStyle.Fill;

                if (boton == btnVolver)
                {
                    boton.BackColor = PaletaColores.rosa;
                }
                else if (boton == picLogo)
                {
                    boton.BackColor = Color.Transparent;
                }
                else if (boton == btnLLamar)
                {
                    boton.BackColor = PaletaColores.azulVerde;
                }                
                else
                {
                    boton.BackColor = PaletaColores.azulOscuro;
                }

                boton.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);
                boton.ForeColor = Color.White;
            }
        }

        private void CargarEstilos()
        {
            var fecha = DateOnly.FromDateTime(DateTime.Now);

            contentLbl.Text = $"    {fecha}  |  {_Paciente.NombreCompleto}";
            lblPacienteInfo.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);
            lblHistoria.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);

            foreach (Control label in infoPacTLP.Controls)
            {
                label.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);
                label.ForeColor = Color.White;
            }
        }

        private void CargarDatos()
        {
            lblDNI.Text = $"DNI: {_Paciente.Dni}";
            lblGenero.Text = $"Género: {_Paciente.Genero}";
            lblFechaNac.Text = $"Fecha de Nacimiento: {_Paciente.FechaNacimiento}";
            var edad = CalcularEdad(_Paciente.FechaNacimiento);
            lblEdad.Text = $"Edad: {edad} años";
            lblOS.Text = $"Obra Social: {_Paciente.ObraSocial}";
            lblNumAfiliado.Text = $"N° {_Paciente.NumeroAfiliado}";
            lblTelefono.Text = $"Teléfono: {_Paciente.Telefono}";
            lblEmail.Text = $"Email: {_Paciente.Email}";
            lblDireccion.Text = $"Dirección: {_Paciente.Direccion}";

            CargarEntradas();
        }

        private void CargarEntradas()
        {
            if (_Paciente == null || string.IsNullOrEmpty(_Paciente.HistoriaClinica.IdHistoriaClinica.ToString())) return;

            var entradas = _Paciente.HistoriaClinica.Entradas
                .OrderByDescending(e => e.FechaEntrada)
                .ToList();

            entradasTLP.Controls.Clear();
            entradasTLP.RowStyles.Clear();

            entradasTLP.RowCount = entradas.Count + 1;
            AgregarHeader(0);

            if (entradas.Count == 0)
            {
                entradasTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
                entradasTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));

                Label lblMensaje = new Label();
                lblMensaje.Text = "No hay entradas registradas en la historia clínica";
                lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
                lblMensaje.Dock = DockStyle.Fill;
                lblMensaje.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Italic);
                lblMensaje.ForeColor = Color.White;

                entradasTLP.Controls.Add(lblMensaje, 0, 1);
                entradasTLP.SetColumnSpan(lblMensaje, 3);
                return;
            }

            entradasTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));

            for (int i = 0; i < entradas.Count; i++)
            {
                entradasTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
                AgregarFilaEntrada(entradas[i], i + 1);
            }
        }

        private void AgregarHeader(int fila)
        {
            Label lblHeaderFecha = new Label();
            lblHeaderFecha.Text = "FECHA";
            lblHeaderFecha.TextAlign = ContentAlignment.MiddleCenter;
            lblHeaderFecha.Dock = DockStyle.Fill;
            lblHeaderFecha.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);
            lblHeaderFecha.ForeColor = Color.White;
            lblHeaderFecha.BackColor = PaletaColores.azulOscuro;

            Label lblHeaderProfesional = new Label();
            lblHeaderProfesional.Text = "PROFESIONAL";
            lblHeaderProfesional.TextAlign = ContentAlignment.MiddleCenter;
            lblHeaderProfesional.Dock = DockStyle.Fill;
            lblHeaderProfesional.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);
            lblHeaderProfesional.ForeColor = Color.White;
            lblHeaderProfesional.BackColor = PaletaColores.azulOscuro;

            Label lblHeaderObservaciones = new Label();
            lblHeaderObservaciones.Text = "ENTRADA";
            lblHeaderObservaciones.TextAlign = ContentAlignment.MiddleCenter;
            lblHeaderObservaciones.Dock = DockStyle.Fill;
            lblHeaderObservaciones.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);
            lblHeaderObservaciones.ForeColor = Color.White;
            lblHeaderObservaciones.BackColor = PaletaColores.azulOscuro;

            entradasTLP.Controls.Add(lblHeaderFecha, 0, fila);
            entradasTLP.Controls.Add(lblHeaderProfesional, 1, fila);
            entradasTLP.Controls.Add(lblHeaderObservaciones, 2, fila);
        }

        private void AgregarFilaEntrada(E_Entrada entrada, int fila)
        {
            Label lblFecha = new Label();
            lblFecha.Text = entrada.FechaEntrada.ToString("dd/MM/yyyy");
            lblFecha.TextAlign = ContentAlignment.MiddleCenter;
            lblFecha.Dock = DockStyle.Fill;
            lblFecha.Font = new Font(Fuente.TIPOGRAFIA, Fuente.M, FontStyle.Bold);
            lblFecha.ForeColor = PaletaColores.azulOscuro;
            lblFecha.BackColor = Color.White;
            lblFecha.Padding = new Padding(5, 0, 0, 0);

            Label lblMedico = new Label();
            var profesional = ProfesionalService.ObtenerProfesionalPorID(entrada.IdProfesional);
            lblMedico.Text = profesional != null ? $"Dr. {profesional.NombreCompleto}" : "Médico no encontrado";
            lblMedico.TextAlign = ContentAlignment.MiddleCenter;
            lblMedico.Dock = DockStyle.Fill;
            lblMedico.Font = new Font(Fuente.TIPOGRAFIA, Fuente.M, FontStyle.Bold);
            lblMedico.ForeColor = PaletaColores.azulOscuro;
            lblMedico.BackColor = Color.White;
            lblMedico.Padding = new Padding(5, 0, 0, 0);

            Button btnVer = new Button();
            btnVer.Text = string.IsNullOrEmpty(entrada.Observaciones) ? "Sin observaciones" : "VER";
            btnVer.Enabled = !string.IsNullOrEmpty(entrada.Observaciones);
            btnVer.Dock = DockStyle.Fill;
            btnVer.Font = new Font(Fuente.TIPOGRAFIA, Fuente.S, FontStyle.Bold);
            btnVer.BackColor = btnVer.Enabled ? PaletaColores.azulClaro : Color.Gray;
            btnVer.ForeColor = Color.White;
            btnVer.Margin = new Padding(0);

            if (btnVer.Enabled)
            {
                btnVer.Click += (s, e) => MostrarObservaciones(entrada);
            }

            entradasTLP.Controls.Add(lblFecha, 0, fila);
            entradasTLP.Controls.Add(lblMedico, 1, fila);
            entradasTLP.Controls.Add(btnVer, 2, fila);
        }

        private void MostrarObservaciones(E_Entrada entrada)
        {
            MessageBox.Show(
                entrada.Observaciones,
                $"Observaciones - {entrada.FechaEntrada:dd/MM/yyyy}",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private int CalcularEdad(DateOnly fechaNacimiento)
        {
            var hoy = DateOnly.FromDateTime(DateTime.Today);
            var edad = hoy.Year - fechaNacimiento.Year;

            if (fechaNacimiento > hoy.AddYears(-edad))
                edad--;

            return edad;
        }

        // Botones        
        private void btnCargarEvolucion_Click(object sender, EventArgs e)
        {
            AuxCargarEvolucion cargarEvolucion = new AuxCargarEvolucion(_Paciente, _Profesional);
            cargarEvolucion.ShowDialog();
        }

        private void btnLLamar_Click(object sender, EventArgs e)
        {
            // Relacion con Consultorio
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Desea volver a la vista de Agenda?",
                "Confirmar",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );

            if (resultado == DialogResult.Cancel) return;

            ProfAgendaDiaria agendaDiaria = new ProfAgendaDiaria(_Profesional);
            this.Hide();
            agendaDiaria.FormClosed += (s, args) => this.Close();
            agendaDiaria.Show();
        }

    }
}

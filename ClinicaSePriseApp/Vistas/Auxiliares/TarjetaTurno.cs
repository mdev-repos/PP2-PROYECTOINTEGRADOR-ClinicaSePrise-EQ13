using ClinicaSePriseApp.Entidades;
using ClinicaSePriseApp.Servicios;
using ClinicaSePriseApp.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaSePriseApp.Vistas.Auxiliares
{
    public partial class TarjetaTurno : UserControl
    {
        private E_Turno _Turno;
        private bool _estaSeleccionado = false;

        // EVENTO PÚBLICO para notificar clicks
        public event EventHandler TarjetaClickeada;

        public TarjetaTurno(E_Turno turno)
        {
            InitializeComponent();
            _Turno = turno;
            Turno = turno; // ← ESTA LÍNEA FALTABA

            // Hacer TODO el UserControl clickable
            HacerControlesClickables(this);
        }

        // Método recursivo para hacer clickables todos los controles
        private void HacerControlesClickables(Control control)
        {
            control.MouseDown += Control_MouseDown;

            // Aplicar a todos los controles hijos
            foreach (Control child in control.Controls)
            {
                HacerControlesClickables(child);
            }
        }

        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Disparar el evento público
                TarjetaClickeada?.Invoke(this, EventArgs.Empty);
            }
        }

        private void TarjetaTurno_Load(object sender, EventArgs e)
        {
            CargarDatos();
            AplicarEstilos();
        }

        public bool EstaSeleccionado
        {
            get => _estaSeleccionado;
            set
            {
                _estaSeleccionado = value;
                AplicarEstiloSeleccion();
                this.Invalidate();
                this.Refresh();
            }
        }

        public E_Turno Turno { get; private set; } // ← ESTA PROPIEDAD ESTABA VACÍA

        private void CargarDatos()
        {
            // ID Turno
            lblID.Text = _Turno.IdTurno.ToString();

            // Hora Turno
            TimeOnly hora = TimeOnly.FromDateTime(_Turno.FechaTurno);
            lblHora.Text = hora.ToString("HH:mm");

            // Nombre Paciente
            var paciente = PacienteService.ObtenerPacientePorID(_Turno.IdPaciente);
            if (paciente != null)
            {
                lblPaciente.Text = paciente.NombreCompleto;
            }
            else
            {
                lblPaciente.Text = "Turno Disponible";
            }

            // Estado Turno
            lblEstado.Text = EnumHelper.GetDescription(_Turno.Estado);
        }

        private void AplicarEstilos()
        {
            lblHora.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);
            lblPaciente.Font = new Font(Fuente.TIPOGRAFIA, Fuente.Title, FontStyle.Italic);
            lblEstado.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);

            switch (_Turno.Estado)
            {
                case Entidades.Enums.EstadoTurno.DISPONIBLE:
                    mainTLP.BackColor = PaletaColores.Grey;
                    foreach (Control label in mainTLP.Controls)
                    {
                        if (label is Label) label.ForeColor = Color.Black;
                    }
                    break;

                case Entidades.Enums.EstadoTurno.ASIGNADO:
                    mainTLP.BackColor = PaletaColores.LightGreen;
                    foreach (Control label in mainTLP.Controls)
                    {
                        if (label is Label) label.ForeColor = Color.Black;
                    }
                    lblEstado.Text = "Reservado";
                    break;

                case Entidades.Enums.EstadoTurno.ABONADO:
                    mainTLP.BackColor = PaletaColores.GreenishBlue;
                    foreach (Control label in mainTLP.Controls)
                    {
                        if (label is Label) label.ForeColor = Color.Black;
                    }
                    lblEstado.Text = "Presente";
                    break;

                case Entidades.Enums.EstadoTurno.FINALIZADO:
                    mainTLP.BackColor = PaletaColores.LightBlue;
                    foreach (Control label in mainTLP.Controls)
                    {
                        if (label is Label) label.ForeColor = Color.Black;
                    }
                    lblEstado.Text = "Atendido";
                    break;

                default:
                    break;
            }
        }

        private void AplicarEstiloSeleccion()
        {
            if (_estaSeleccionado)
            {
                this.BorderStyle = BorderStyle.FixedSingle;
                this.BackColor = Color.Yellow;
                this.Padding = new Padding(3);
            }
            else
            {
                this.BorderStyle = BorderStyle.None;
                this.Padding = new Padding(0);
                AplicarEstilos(); // Volver al estilo original
            }
        }
    }
}
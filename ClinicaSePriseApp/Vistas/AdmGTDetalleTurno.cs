using ClinicaSePriseApp.Entidades;
using ClinicaSePriseApp.Servicios;
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
    public partial class AdmGTDetalleTurno : Form
    {

        private E_Turno? _turnoSeleccionado;


        public AdmGTDetalleTurno()
        {
            InitializeComponent();
            _turnoSeleccionado = null;
            
            this.Resize += AdmGestionTurnos_Resize;

            this.Size = new Size(1024, 768);
            this.MinimumSize = new Size(1024, 768);
            this.WindowState = FormWindowState.Maximized;
        }

        public AdmGTDetalleTurno(E_Turno turno)
        {
            InitializeComponent();
                        
            _turnoSeleccionado = turno;

            if (_turnoSeleccionado == null)
            {
                MessageBox.Show("Error al cargar los datos del turno seleccionado.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            else
            {
                CargarDatosTurno(_turnoSeleccionado);
            }            
        }

        private void CargarDatosTurno(E_Turno turno)
        {          
            // Fecha y Hora
            string fechaMostrar = FormatearFechaEspanol(turno.FechaTurno);
            lblTurnoDia.Text = $"FECHA: {fechaMostrar}";

            // Profesional
            var profesional = ProfesionalService.ObtenerProfesionalPorID(turno.IdProfesional);
            string profesionalMostrar = profesional?.NombreCompleto ?? "No encontrado";
            lblTurnoProf.Text = $"MEDICO: DR. {profesionalMostrar}";

            // Especialidad 
            string especialidadMostrar = profesional != null ?
                ClinicaSePriseApp.Utilidades.EnumHelper.GetDescription(profesional.Especialidad) :
                "No encontrada";
            lblTurnoEsp.Text = $"ESPECIALIDAD: {especialidadMostrar}";

            // Estado Turno
            string estadoMostrar = ClinicaSePriseApp.Utilidades.EnumHelper.GetDescription(turno.Estado);
            lblTurnoEstado.Text = $"ESTADO: {estadoMostrar}";

            // Monto
            string montoMostrar = turno.Monto.ToString("C2");
            lblTurnoValor.Text = $"VALOR A ABONAR: {montoMostrar}";

            // Si el turno ya esta asignado, cargar datos del paciente
            if (turno.IdPaciente != null)
            {
                btnAsignar.Enabled = false;
                pacienteDniTxt.ReadOnly = true;
                dniSearchBtn.Enabled = false;

                // Buscar paciente en BBDD
                var paciente = PacienteService.ObtenerPacientePorID(turno.IdPaciente.Value);

                if (paciente != null)
                {
                    CargarDatosDelPaciente(paciente);
                }
            }
            else
            {
                VaciarDatosDelPaciente();
                btnAsignar.Enabled = true;
                btnCancelar.Enabled = false;
                btnAbonar.Enabled = false;
            }
        }

        private void CargarDatosDelPaciente(E_Paciente paciente)
        {
            // DNI
            pacienteDniTxt.Text = $"DNI: {paciente.Dni}";

            // Nombre Completo
            lblPacienteNombre.Text = $"NOMBRE: {paciente.NombreCompleto}";

            // Obra Social con descripción
            lblObraSocial.Text = $"OS: {ClinicaSePriseApp.Utilidades.EnumHelper.GetDescription(paciente.ObraSocial)}";

            // Numero Afiliado
            lblNumAfiliado.Text = $"N° {paciente.NumeroAfiliado}";

            // Genero con descripción
            lblGenero.Text = $"GENERO {ClinicaSePriseApp.Utilidades.EnumHelper.GetDescription(paciente.Genero)}";

            // Edad calculada correctamente
            int edad = CalcularEdad(paciente.FechaNacimiento);
            lblEdad.Text = $"EDAD: {edad} años";

            // Telefono
            lblTelefono.Text = $"TEL: {paciente.Telefono}";

            // Email
            lblEmail.Text = $"EMAIL: {paciente.Email}";

            // Direccion
            lblDireccion.Text = $"DIRECCION: {paciente.Direccion}";
        }

        private void VaciarDatosDelPaciente()
        {
            pacienteDniTxt.Text = string.Empty;
            lblPacienteNombre.Text = "TURNO NO ASIGNADO";
            lblObraSocial.Text = string.Empty;
            lblNumAfiliado.Text = string.Empty;
            lblGenero.Text = string.Empty;
            lblEdad.Text = string.Empty;
            lblTelefono.Text = string.Empty;
            lblEmail.Text = string.Empty;
            lblDireccion.Text = string.Empty;
        }

        private string FormatearFechaEspanol(DateTime fecha)
        {
            var cultureEs = new System.Globalization.CultureInfo("es-ES");

            string diaSemana = cultureEs.DateTimeFormat.GetDayName(fecha.DayOfWeek);
            diaSemana = char.ToUpper(diaSemana[0]) + diaSemana.Substring(1);

            string fechaCorta = fecha.ToString("dd/MM/yyyy");
            string hora = fecha.ToString("HH:mm");

            return $"{diaSemana} {fechaCorta} - {hora} Hs";
        }

        private int CalcularEdad(DateOnly fechaNacimiento)
        {
            var hoy = DateOnly.FromDateTime(DateTime.Today);
            var edad = hoy.Year - fechaNacimiento.Year;

            if (fechaNacimiento > hoy.AddYears(-edad))
                edad--;

            return edad;
        }


        private void AdmGTDetalleTurno_Load(object sender, EventArgs e)
        {
            ajustarPaneles();

            pacienteDniTxt.ImeMode = ImeMode.Off;
            pacienteDniTxt.MaxLength = 8;
            pacienteDniTxt.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            };
        }

        private void AdmGestionTurnos_Resize(object sender, EventArgs e)
        {
            ajustarPaneles();
        }

        private void ajustarPaneles()
        {
            mainTLP.BackColor = Utilidades.PaletaColores.bgCeleste;
            menuTLP.BackColor = Utilidades.PaletaColores.bgGris;

            contentLbl.BackColor = Utilidades.PaletaColores.bgGris;

            foreach (Control boton in menuTLP.Controls)
            {
                boton.Dock = DockStyle.Fill;

                if (boton == btnVolver)
                {
                    boton.BackColor = Utilidades.PaletaColores.btnRosa;
                }
                else if (boton == picLogo)
                {
                    boton.BackColor = Color.Transparent;
                }
                else
                {
                    boton.BackColor = Utilidades.PaletaColores.btnAzul;
                }

                boton.Font = new Font("LEMON MILK", 10, FontStyle.Bold);
                boton.ForeColor = Color.Transparent;
            }

            foreach (Control label in dataTLP.Controls)
            {
                if (label is Label)
                {
                    label.Font = new Font("LEMON MILK", 10, FontStyle.Bold);
                }
            }

            foreach (Control label in osTLP.Controls)
            {
                if (label is Label)
                {
                    label.Font = new Font("LEMON MILK", 10, FontStyle.Bold);
                }
            }

            foreach (Control label in telMailTLP.Controls)
            {
                if (label is Label)
                {
                    label.Font = new Font("LEMON MILK", 10, FontStyle.Bold);
                }
            }

            foreach (Control label in sexoEdadTLP.Controls)
            {
                if (label is Label)
                {
                    label.Font = new Font("LEMON MILK", 10, FontStyle.Bold);
                }
            }                       

            pacienteDniTxt.Font = new Font("LEMON MILK", 10, FontStyle.Bold);
        }




        // BOTONES
        private void btnAsignar_Click(object sender, EventArgs e)
        {
            string dniTexto = pacienteDniTxt.Text;
            string dniLimpio = new string(dniTexto.Where(char.IsDigit).ToArray());
            var paciente = PacienteService.ObtenerPacientePorDNI(dniLimpio);
            var turno = _turnoSeleccionado;

            if (turno != null && paciente != null)
            {
                DialogResult resultado = MessageBox.Show(
                    "Si continúa, se asignará el turno al paciente indicado",
                    "Confirmar Asignación",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                );
                                
                if (resultado == DialogResult.Cancel)
                {
                    return;
                }
                                
                TurnoService.AsignarTurno(turno, paciente);

                btnAsignar.Enabled = false;
                btnCancelar.Enabled = true;
                btnAbonar.Enabled = true;

                string estadoMostrar = ClinicaSePriseApp.Utilidades.EnumHelper.GetDescription(turno.Estado);
                lblTurnoEstado.Text = $"ESTADO: {estadoMostrar}";

                MessageBox.Show($"Turno asignado exitosamente al paciente: {paciente.NombreCompleto}",
                              "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al asignar el turno. Verifique los datos ingresados.",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var turno = _turnoSeleccionado;

            if (turno != null)
            {
                DialogResult resultado = MessageBox.Show(
                    "Si continúa, se cancelara la reserva de este turno",
                    "Confirmar Asignación",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                );

                if (resultado == DialogResult.Cancel)
                {
                    return;
                }
                
                TurnoService.CancelarTurno(turno);

                VaciarDatosDelPaciente();

                btnAsignar.Enabled = true;
                btnCancelar.Enabled = false;
                btnAbonar.Enabled = false;

                string estadoMostrar = ClinicaSePriseApp.Utilidades.EnumHelper.GetDescription(turno.Estado);
                lblTurnoEstado.Text = $"ESTADO: {estadoMostrar}";

                MessageBox.Show($"Reserva de Turno cancelada exitosamente",
                              "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al cancelar el turno. Verifique los datos ingresados.",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAbonar_Click(object sender, EventArgs e)
        {
            AdmGTPagoTurno admGTPagoTurno = new AdmGTPagoTurno(_turnoSeleccionado);
            this.Hide();
            admGTPagoTurno.FormClosed += (s, args) => this.Close();
            admGTPagoTurno.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            AdmGestionTurnos admGestionTurnos = new AdmGestionTurnos();
            this.Hide();
            admGestionTurnos.FormClosed += (s, args) => this.Close();
            admGestionTurnos.Show();
        }

        private void dniSearchBtn_Click(object sender, EventArgs e)
        {
            var dniInput = pacienteDniTxt.Text.Trim();

            if (string.IsNullOrEmpty(dniInput))
            {
                VaciarDatosDelPaciente();
                btnAsignar.Enabled = false;
                MessageBox.Show("Por favor, ingrese el DNI del paciente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var paciente = PacienteService.ObtenerPacientePorDNI(dniInput);

            if (paciente == null)
            {
                VaciarDatosDelPaciente();
                btnAsignar.Enabled = false;
                MessageBox.Show("No se encontró ningún paciente con el DNI ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                CargarDatosDelPaciente(paciente);
                btnAsignar.Enabled = true;
            }
        }
    }
}
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

        // Form
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


        // Estilos Visuales
        private void ajustarPaneles()
        {
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
                else
                {
                    boton.BackColor = PaletaColores.azulOscuro;
                }

                boton.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);
                boton.ForeColor = Color.White;
            }

            lblTurno.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);
            lblTurno.ForeColor = PaletaColores.azulOscuro;

            lblPaciente.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);
            lblPaciente.ForeColor = PaletaColores.azulOscuro;

            pacienteDniTxt.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);
            pacienteDniTxt.ForeColor = PaletaColores.azulOscuro;
        }
        private void ActualizarInterfazDespuesDePago()
        {
            _turnoSeleccionado = TurnoService.ObtenerTurnoPorID(_turnoSeleccionado.IdTurno);

            string estadoMostrar = EnumHelper.GetDescription(_turnoSeleccionado.Estado);
            lblTurnoEstado.Text = $"ESTADO: {estadoMostrar}";

            btnAbonar.Enabled = false;
            btnCancelar.Enabled = false;
            btnAsignar.Enabled = false;
        }


        // Carga de Datos
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
                    EnumHelper.GetDescription(profesional.Especialidad) :
                "No encontrada";
            lblTurnoEsp.Text = $"ESPECIALIDAD: {especialidadMostrar}";

            // Estado Turno
            string estadoMostrar = EnumHelper.GetDescription(turno.Estado);
            lblTurnoEstado.Text = $"ESTADO: {estadoMostrar}";

            // Monto
            string montoMostrar = turno.Monto.ToString("C2");
            lblTurnoValor.Text = $"VALOR A ABONAR: {montoMostrar}";

            btnAsignar.Enabled = (turno.Estado == Entidades.Enums.EstadoTurno.DISPONIBLE);
            btnCancelar.Enabled = (turno.Estado == Entidades.Enums.EstadoTurno.ASIGNADO);
            btnAbonar.Enabled = (turno.Estado == Entidades.Enums.EstadoTurno.ASIGNADO);
                        
            if (turno.IdPaciente != null &&
                (turno.Estado == Entidades.Enums.EstadoTurno.ASIGNADO ||
                 turno.Estado == Entidades.Enums.EstadoTurno.ABONADO ||
                 turno.Estado == Entidades.Enums.EstadoTurno.EN_ATENCION ||
                 turno.Estado == Entidades.Enums.EstadoTurno.FINALIZADO))
            {
                pacienteDniTxt.ReadOnly = true;
                dniSearchBtn.Enabled = false;

                var paciente = PacienteService.ObtenerPacientePorID(turno.IdPaciente.Value);

                if (paciente != null)
                {
                    CargarDatosDelPaciente(paciente);
                }
                else
                {
                    VaciarDatosDelPaciente();
                    lblPacienteNombre.Text = "PACIENTE NO ENCONTRADO";
                }
            }
            else
            {
                VaciarDatosDelPaciente();
                pacienteDniTxt.ReadOnly = false;
                dniSearchBtn.Enabled = true;

                if (turno.Estado == Entidades.Enums.EstadoTurno.DISPONIBLE)
                {
                    pacienteDniTxt.Text = "";
                    pacienteDniTxt.PlaceholderText = "Ingrese DNI del paciente";
                }
            }
        }

        private void CargarDatosDelPaciente(E_Paciente paciente)
        {
            // DNI
            pacienteDniTxt.Text = $"DNI: {paciente.Dni}";
            pacienteDniTxt.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);
            pacienteDniTxt.ForeColor = PaletaColores.azulOscuro;

            // Nombre Completo
            lblPacienteNombre.Text = $"NOMBRE: {paciente.NombreCompleto}";
            lblPacienteNombre.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);
            lblPacienteNombre.ForeColor = Color.White;

            // Obra Social con descripción
            lblObraSocial.Text = $"OS: {EnumHelper.GetDescription(paciente.ObraSocial)}";
            lblObraSocial.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);
            lblObraSocial.ForeColor = Color.White;

            // Numero Afiliado
            lblNumAfiliado.Text = $"N° {paciente.NumeroAfiliado}";
            lblNumAfiliado.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);
            lblNumAfiliado.ForeColor = Color.White;

            // Genero con descripción
            lblGenero.Text = $"GENERO {EnumHelper.GetDescription(paciente.Genero)}";
            lblGenero.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);
            lblGenero.ForeColor = Color.White;

            // Edad calculada correctamente
            int edad = CalcularEdad(paciente.FechaNacimiento);
            lblEdad.Text = $"EDAD: {edad} años";
            lblEdad.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);
            lblEdad.ForeColor = Color.White;

            // Telefono
            lblTelefono.Text = $"TEL: {paciente.Telefono}";
            lblTelefono.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);
            lblTelefono.ForeColor = Color.White;

            // Email
            lblEmail.Text = $"EMAIL: {paciente.Email}";
            lblEmail.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);
            lblEmail.ForeColor = Color.White;

            // Direccion
            lblDireccion.Text = $"DIRECCION: {paciente.Direccion}";
            lblDireccion.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);
            lblDireccion.ForeColor = Color.White;
        }

        private void VaciarDatosDelPaciente()
        {
            pacienteDniTxt.Text = string.Empty;
            lblPacienteNombre.Text = "TURNO NO ASIGNADO";
            lblPacienteNombre.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);
            lblPacienteNombre.ForeColor = Color.White;
            lblObraSocial.Text = string.Empty;
            lblNumAfiliado.Text = string.Empty;
            lblGenero.Text = string.Empty;
            lblEdad.Text = string.Empty;
            lblTelefono.Text = string.Empty;
            lblEmail.Text = string.Empty;
            lblDireccion.Text = string.Empty;
        }


        // Metodos Auxiliares
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


        // Botones
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
                pacienteDniTxt.ReadOnly = true;

                string estadoMostrar = EnumHelper.GetDescription(turno.Estado);
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

            if (turno.Estado != Entidades.Enums.EstadoTurno.ASIGNADO)
            {
                MessageBox.Show("Para cancelar, debe ser un turno Asignado y no Abonado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
                pacienteDniTxt.ReadOnly = false;

                string estadoMostrar = EnumHelper.GetDescription(turno.Estado);
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
            var turno = TurnoService.ObtenerTurnoPorID(_turnoSeleccionado.IdTurno);

            if (turno.Estado != Entidades.Enums.EstadoTurno.ASIGNADO)
            {
                MessageBox.Show("El Turno ya fue abonado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (turno.IdPaciente != null && turno.Estado == Entidades.Enums.EstadoTurno.ASIGNADO)
            {
                DialogResult resultado = MessageBox.Show(
                    "Si continúa, se procederá al pago del turno indicado",
                    "Confirmar",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                );

                if (resultado == DialogResult.Cancel) return;

                var paciente = PacienteService.ObtenerPacientePorID(turno.IdPaciente);

                E_Pago pago = new E_Pago(
                    paciente.IdPaciente,
                    turno.IdTurno,
                    turno.Monto);

                using (AuxPagoTurno pagoTurno = new AuxPagoTurno(pago))
                {
                    if (pagoTurno.ShowDialog() == DialogResult.OK)
                    {
                        ActualizarInterfazDespuesDePago();
                        MessageBox.Show("✅ Pago realizado exitosamente. El turno ha sido abonado.",
                                      "Pago Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El pago no se realizó. El turno permanece en estado 'Asignado'.",
                                      "Pago Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                    "Desea salir de la Pantalla y volver a Turnos?",
                    "Confirmar Asignación",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                );

            if (resultado == DialogResult.Cancel)
            {
                return;
            }

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
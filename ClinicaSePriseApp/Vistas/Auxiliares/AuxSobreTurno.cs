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
    public partial class AuxSobreTurno : Form
    {
        private E_Profesional _Profesional;
        private E_Paciente _PacienteSeleccionado;
        private DateTime _HorarioSeleccionado;

        public AuxSobreTurno(E_Profesional profesional)
        {
            InitializeComponent();
            _Profesional = profesional;
            AplicarEstilos();
            CargarHorarios();
        }

        // Estilo Visual
        private void AplicarEstilos()
        {
            containerTLP.BackColor = PaletaColores.azulClaro;

            foreach (Control boton in buttonsTLP.Controls)
            {
                boton.Dock = DockStyle.Fill;

                if (boton == btnCancelar)
                {
                    boton.BackColor = PaletaColores.rosa;
                }

                if (boton == btnConfirmar)
                {
                    boton.BackColor = PaletaColores.azulOscuro;
                }

                boton.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);
                boton.ForeColor = Color.White;
            }

            pacienteDniTxt.ImeMode = ImeMode.Off;
            pacienteDniTxt.MaxLength = 8;
            pacienteDniTxt.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            };

            cboxHorarios.Enabled = false;
            btnConfirmar.Enabled = false;
        }
        private class HorarioDisplay
        {
            public DateTime Horario { get; set; }
            public string Display => Horario.ToString("HH:mm") + " hs";
        }

        // Carga de Datos
        private void CargarHorarios()
        {
            var horarios = CalcularHorarios();

            var horariosDisplay = horarios
                .Select(h => new HorarioDisplay { Horario = h })
                .ToList();

            cboxHorarios.DataSource = horariosDisplay;
            cboxHorarios.DisplayMember = "Display";
            cboxHorarios.ValueMember = "Horario";
        }

        // Metodos Auxiliares
        private List<DateTime> CalcularHorarios()
        {
            List<DateTime> horariosDisponibles = new List<DateTime>();
            var hoy = DateTime.Today;

            var dispo = _Profesional.Disponibilidades
                .FirstOrDefault(d => d.Dia == hoy.DayOfWeek);

            if (dispo == null)
                return horariosDisponibles;

            int horaInicio = dispo.HoraInicio.Hours;
            int minutoInicio = dispo.HoraInicio.Minutes;
            int horaFin = dispo.HoraFin.Hours;

            DateTime horarioCreado = new DateTime(hoy.Year, hoy.Month, hoy.Day, horaInicio, minutoInicio, 0);
            DateTime horaFinal = new DateTime(hoy.Year, hoy.Month, hoy.Day, horaFin, 0, 0);

            // Corregido: usar while con incremento correcto
            while (horarioCreado <= horaFinal)
            {
                // Verificar si el horario está disponible (no existe en la agenda)
                bool horarioOcupado = _Profesional.AgendaMedica
                    .Any(t => t.FechaTurno == horarioCreado);

                if (!horarioOcupado)
                {
                    horariosDisponibles.Add(horarioCreado);
                }

                // Incrementar en 1 hora
                horarioCreado = horarioCreado.AddHours(1);
            }

            return horariosDisponibles;
        }

        // Botones
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea cancelar la generación de un sobreturno?",
                "Cancelar Sobreturno",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );

            if (resultado == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cboxHorarios.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un horario.", "Atención",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_PacienteSeleccionado == null)
            {
                MessageBox.Show("Por favor, busque y seleccione un paciente primero.", "Atención",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _HorarioSeleccionado = (DateTime)cboxHorarios.SelectedValue;

            var turno = TurnoService.CrearTurno(
                _HorarioSeleccionado,
                _Profesional,
                _PacienteSeleccionado
            );

            _Profesional.AgendaMedica.Add(turno);
            _PacienteSeleccionado.Reservas.Add(turno);

            E_Pago pago = new E_Pago(
                DDBB_Simulation.PagosDB.Count + 1,
                _PacienteSeleccionado.IdPaciente,
                turno.IdTurno,
                turno.Monto);

            using (AuxPagoTurno pagoTurno = new AuxPagoTurno(pago))
            {
                if (pagoTurno.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("✅ Sobreturno creado y pagado exitosamente.",
                                  "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    _Profesional.AgendaMedica.Remove(turno);
                    _PacienteSeleccionado.Reservas.Remove(turno);

                    MessageBox.Show("El pago no se realizó. El sobreturno ha sido cancelado.",
                                  "Pago Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dniSearchBtn_Click(object sender, EventArgs e)
        {
            string dni = pacienteDniTxt.Text.Trim();

            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Por favor, ingrese un DNI.", "Atención",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _PacienteSeleccionado = PacienteService.ObtenerPacientePorDNI(dni);

            if (_PacienteSeleccionado == null)
            {
                MessageBox.Show("No se encontró ningún paciente con ese DNI.", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblNombre.Text = $"{_PacienteSeleccionado.NombreCompleto}";
            cboxHorarios.Enabled = true;
            pacienteDniTxt.ReadOnly = true;
            dniSearchBtn.Enabled = false;
            btnConfirmar.Enabled = true;

            MessageBox.Show($"Paciente encontrado: {_PacienteSeleccionado.NombreCompleto}",
                           "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
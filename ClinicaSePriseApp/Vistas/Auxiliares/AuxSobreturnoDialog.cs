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

namespace ClinicaSePriseApp.Vistas.Auxiliares
{
    public partial class AuxSobreturnoDialog : Form
    {
        public E_Paciente PacienteEncontrado { get; private set; }
        public TimeSpan HoraSobreturno { get; private set; }

        private TextBox txtDni;
        private Button btnBuscar;
        private Panel panelDatos;
        private DateTimePicker timePickerHora;
        private Button btnCancelar;
        private Button btnCrear;

        public AuxSobreturnoDialog()
        {
            InicializarControles();
        }        

        private void InicializarControles()
        {
            this.Text = "Crear Sobreturno";
            this.Size = new Size(400, 250);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Label DNI
            Label lblDni = new Label();
            lblDni.Text = "DNI Paciente:";
            lblDni.Location = new Point(20, 25);
            lblDni.Size = new Size(100, 30);

            // TextBox DNI
            txtDni = new TextBox();
            txtDni.Location = new Point(125, 20);
            txtDni.Size = new Size(200, 30);

            txtDni.ImeMode = ImeMode.Off;
            txtDni.MaxLength = 8;
            txtDni.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            };

            // Botón Buscar
            btnBuscar = new Button();
            btnBuscar.Text = "🔍";
            btnBuscar.Location = new Point(330, 20);
            btnBuscar.Size = new Size(40, 30);
            btnBuscar.Click += BtnBuscar_Click;

            // Panel oculto inicialmente
            panelDatos = new Panel();
            panelDatos.Location = new Point(20, 60);
            panelDatos.Size = new Size(300, 70);
            panelDatos.Visible = false;

            // TimePicker para hora
            Label lblHora = new Label();
            lblHora.Text = "Horario:";
            lblHora.Location = new Point(0, 10);
            lblHora.Size = new Size(80, 20);

            timePickerHora = new DateTimePicker();
            timePickerHora.Format = DateTimePickerFormat.Custom;
            timePickerHora.CustomFormat = "HH:mm";
            timePickerHora.ShowUpDown = true;
            timePickerHora.Location = new Point(80, 10);
            timePickerHora.Size = new Size(100, 20);

            timePickerHora.MinDate = DateTime.Today;
            timePickerHora.Value = DateTime.Now;

            // Botones
            btnCancelar = new Button();
            btnCancelar.Text = "Cancelar";
            btnCancelar.Location = new Point(130, 150);
            btnCancelar.Size = new Size(80, 30);
            btnCancelar.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };

            btnCrear = new Button();
            btnCrear.Text = "Crear Sobreturno";
            btnCrear.Location = new Point(220, 150);
            btnCrear.Size = new Size(120, 30);
            btnCrear.Enabled = false;
            btnCrear.Click += BtnCrear_Click;

            // Agregar controles al panel
            panelDatos.Controls.Add(lblHora);
            panelDatos.Controls.Add(timePickerHora);

            // Agregar controles al form
            this.Controls.Add(lblDni);
            this.Controls.Add(txtDni);
            this.Controls.Add(btnBuscar);
            this.Controls.Add(panelDatos);
            this.Controls.Add(btnCancelar);
            this.Controls.Add(btnCrear);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text.Trim();

            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Por favor, ingrese un DNI.", "Atención",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buscar paciente por DNI
            PacienteEncontrado = PacienteService.ObtenerPacientePorDNI(dni);

            if (PacienteEncontrado == null)
            {
                MessageBox.Show("No se encontró ningún paciente con ese DNI.", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Si encontró paciente, mostrar panel de datos y habilitar crear
            panelDatos.Visible = true;
            btnCrear.Enabled = true;
            txtDni.Enabled = false;
            btnBuscar.Enabled = false;

            MessageBox.Show($"Paciente encontrado: {PacienteEncontrado.NombreCompleto}",
                           "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            HoraSobreturno = timePickerHora.Value.TimeOfDay;
            DateTime fechaHoraSeleccionada = DateTime.Today.Add(HoraSobreturno);

            if (fechaHoraSeleccionada < DateTime.Now)
            {
                MessageBox.Show("El turno no puede ser generado para un horario anterior al actual.", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

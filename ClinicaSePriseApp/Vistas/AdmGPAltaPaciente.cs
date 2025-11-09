using ClinicaSePriseApp.Entidades;
using ClinicaSePriseApp.Entidades.Enums;
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

namespace ClinicaSePriseApp.Vistas
{
    public partial class AdmGPAltaPaciente : Form
    {
        public AdmGPAltaPaciente()
        {
            InitializeComponent();
            this.Load += AdmGPAltaPaciente_Load;

            ajustarPaneles();
        }

        private void AdmGPAltaPaciente_Load(object sender, EventArgs e)
        {
            txtDni.KeyPress += txtDni_KeyPress;
            txtNombre.KeyPress += txtNombre_KeyPress;
            cboxGenero.DataSource = EnumHelper.GetEnumValuesWithDescriptions<Genero>();
            cboxGenero.DisplayMember = "Value"; 
            cboxGenero.ValueMember = "Key"; 
            cboxObraSocial.DataSource = EnumHelper.GetEnumValuesWithDescriptions<ObraSocial>();
            cboxObraSocial.DisplayMember = "Value";
            cboxObraSocial.ValueMember = "Key";
        }

        private void ajustarPaneles()
        {
            mainTLP.BackColor = PaletaColores.Skyblue;
            menuTLP.BackColor = PaletaColores.Grey;

            contentLbl.BackColor = PaletaColores.Grey;
            contentLbl.Font = new Font(Fuente.TIPOGRAFIA, Fuente.Title, FontStyle.Regular);


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

            lblTurno.ForeColor = Color.White;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
            "¿Está seguro de que desea volver a la pantalla de gestión de pacientes?\nSe perderán los datos no guardados.",
            "Confirmar regreso",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

            if (resultado == DialogResult.Yes)
            {
                AdmGestionPacientes admGestionPacientes = new AdmGestionPacientes();
                this.Hide();
                admGestionPacientes.FormClosed += (s, args) => this.Close();
                admGestionPacientes.Show();
            }

        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            RegistrarPaciente();
        }

        private void RegistrarPaciente()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtDni.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtNroAfiliado.Text) ||
                cboxGenero.SelectedValue == null ||
                cboxObraSocial.SelectedValue == null)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string dniIngresado = txtDni.Text.Trim();
            if (!dniIngresado.All(char.IsDigit) || dniIngresado.Length > 8)
            {
                MessageBox.Show("El DNI debe contener solo números y tener un máximo de 8 dígitos.", "DNI inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime fechaNacimiento = dateFechaNacimiento.Value;
            if (fechaNacimiento > DateTime.Today)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser futura.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool dniDuplicado = DDBB_Simulation.PacientesDB.Any(p => p.Dni == dniIngresado);
            if (dniDuplicado)
            {
                MessageBox.Show("Ya existe un paciente registrado con ese DNI.", "Paciente duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string emailFinal = string.IsNullOrWhiteSpace(txtMail.Text) ? "No posee" : txtMail.Text.Trim();

            var generoSeleccionado = (Genero)cboxGenero.SelectedValue;
            var obraSocialSeleccionada = (ObraSocial)cboxObraSocial.SelectedValue;
            
            var nuevoPaciente = new E_Paciente(
                apellido: txtApellido.Text.Trim(),
                nombre: txtNombre.Text.Trim(),
                dni: dniIngresado,
                genero: generoSeleccionado,
                fechaNacimiento: DateOnly.FromDateTime(dateFechaNacimiento.Value),
                direccion: txtDireccion.Text.Trim(),
                telefono: txtTelefono.Text.Trim(),
                email: emailFinal,
                obraSocial: obraSocialSeleccionada,
                numeroAfiliado: txtNroAfiliado.Text.Trim()
            );

            DDBB_Simulation.PacientesDB.Add(nuevoPaciente);

            string nombreCompleto = $"{nuevoPaciente.Nombre} {nuevoPaciente.Apellido}";
            MessageBox.Show($"Paciente {nombreCompleto} registrado correctamente.", "Alta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarFormulario();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txtDni.Text.Length >= 8 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void LimpiarFormulario()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDni.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtNroAfiliado.Text = string.Empty;

            cboxGenero.SelectedIndex = -1;
            cboxObraSocial.SelectedIndex = -1;

            dateFechaNacimiento.Value = DateTime.Today;
        }
    }
}
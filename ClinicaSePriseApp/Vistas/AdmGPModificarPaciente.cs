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
    public partial class AdmGPModificarPaciente : Form
    {
        private Entidades.E_Paciente pacienteActual;
        public AdmGPModificarPaciente(Entidades.E_Paciente paciente)
        {
            InitializeComponent();
            pacienteActual = paciente;
            this.Load += AdmGPModificarPaciente_Load;
            ajustarPaneles();
        }

        private void ajustarPaneles()
        {
            mainTLP.BackColor = PaletaColores.celeste;
            menuTLP.BackColor = PaletaColores.bgGris;

            contentLbl.BackColor = PaletaColores.bgGris;
            contentLbl.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XXL, FontStyle.Bold);


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

        private void AdmGPModificarPaciente_Load(object sender, EventArgs e)
        {
            cboxGenero.DataSource = EnumHelper.GetEnumValuesWithDescriptions<Genero>();
            cboxGenero.DisplayMember = "Value";
            cboxGenero.ValueMember = "Key";

            cboxObraSocial.DataSource = EnumHelper.GetEnumValuesWithDescriptions<ObraSocial>();
            cboxObraSocial.DisplayMember = "Value";
            cboxObraSocial.ValueMember = "Key";

            txtNombre.Text = pacienteActual.Nombre;
            txtApellido.Text = pacienteActual.Apellido;
            txtDni.Text = pacienteActual.Dni;
            txtDireccion.Text = pacienteActual.Direccion;
            txtTelefono.Text = pacienteActual.Telefono;
            txtMail.Text = pacienteActual.Email;
            txtNroAfiliado.Text = pacienteActual.NumeroAfiliado;
            dateFechaNacimiento.Value = pacienteActual.FechaNacimiento.ToDateTime(new TimeOnly(0, 0));
            cboxGenero.SelectedValue = pacienteActual.Genero;
            cboxObraSocial.SelectedValue = pacienteActual.ObraSocial;


        }

        private void btnConfirmar_Click(object sender, EventArgs e)
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

            // Actualizar datos del paciente
            pacienteActual.Nombre = txtNombre.Text.Trim();
            pacienteActual.Apellido = txtApellido.Text.Trim();
            pacienteActual.Dni = txtDni.Text.Trim();
            pacienteActual.Direccion = txtDireccion.Text.Trim();
            pacienteActual.Telefono = txtTelefono.Text.Trim();
            pacienteActual.Email = string.IsNullOrWhiteSpace(txtMail.Text) ? "No posee" : txtMail.Text.Trim();
            pacienteActual.NumeroAfiliado = txtNroAfiliado.Text.Trim();
            pacienteActual.FechaNacimiento = DateOnly.FromDateTime(dateFechaNacimiento.Value);
            pacienteActual.Genero = (Genero)cboxGenero.SelectedValue;
            pacienteActual.ObraSocial = (ObraSocial)cboxObraSocial.SelectedValue;

            MessageBox.Show("Datos del paciente actualizados correctamente.", "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AdmGestionPacientes admGestionPacientes = new AdmGestionPacientes();
            this.Hide();
            admGestionPacientes.FormClosed += (s, args) => this.Close();
            admGestionPacientes.Show();
        }
    }
}

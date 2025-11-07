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
    public partial class DashAdmin : Form
    {
        public DashAdmin()
        {
            InitializeComponent();
            this.Resize += DashAdmin_Resize;

            this.Size = new Size(1024, 768);
            this.MinimumSize = new Size(1024, 768);
            this.WindowState = FormWindowState.Maximized;
        }

        private void DashAdmin_Load(object sender, EventArgs e)
        {
            AjustarPaneles();
        }

        private void DashAdmin_Resize(object sender, EventArgs e)
        {
            AjustarPaneles();
        }

        private void AjustarPaneles()
        {

            mainTLP.BackColor = PaletaColores.bgGris;
            menuTLP.BackColor = PaletaColores.bgGris;

            foreach (Control boton in menuTLP.Controls)
            {
                boton.Dock = DockStyle.Fill;

                if (boton == btnLogout)
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

                boton.Font = new Font("LEMON MILK", 10, FontStyle.Bold);
                boton.ForeColor = Color.Transparent;
            }
        }

        // Botones
        private void btnTurnos_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                    "Desea acceder al menú de Gestión de Turnos?",
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
        private void btnPacientes_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                    "Desea ingresar al menú de Gestión de Pacientes?",
                    "Confirmar Asignación",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                );

            if (resultado == DialogResult.Cancel)
            {
                return;
            }

            AdmGestionPacientes admGestionPacientes = new AdmGestionPacientes();
            this.Hide();
            admGestionPacientes.FormClosed += (s, args) => this.Close();
            admGestionPacientes.Show();
        }
        private void btnConsultorios_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                    "Desea ingresar al menú de Gestión de Consultorios?",
                    "Confirmar Asignación",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                );

            if (resultado == DialogResult.Cancel)
            {
                return;
            }
            AdmGestionConsultorios admGestionConsultorios = new AdmGestionConsultorios();
            this.Hide();
            admGestionConsultorios.FormClosed += (s, args) => this.Close();
            admGestionConsultorios.Show();
        }        
        private void btnInsumos_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                    "Desea ingresar al menú de Gestión de Insumos?",
                    "Confirmar Asignación",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                );

            if (resultado == DialogResult.Cancel)
            {
                return;
            }

            AdmGestionInsumos admGestionInsumos = new AdmGestionInsumos();
            this.Hide();
            admGestionInsumos.FormClosed += (s, args) => this.Close();
            admGestionInsumos.Show();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                    "Desea cerrar su sesión actual?",
                    "Confirmar Asignación",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                );

            if (resultado == DialogResult.Cancel)
            {
                return;
            }

            Login login = new Login();
            this.Hide();
            login.FormClosed += (s, args) => this.Close();
            login.Show();
        }

    }
}

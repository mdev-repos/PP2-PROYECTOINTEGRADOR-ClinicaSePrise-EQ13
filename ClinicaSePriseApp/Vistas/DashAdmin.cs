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

            mainTLP.BackColor = Utilidades.PaletaColores.bgGris;
            menuTLP.BackColor = Utilidades.PaletaColores.bgGris;

            foreach (Control boton in menuTLP.Controls)
            {
                boton.Dock = DockStyle.Fill;

                if (boton == btnLogout)
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

        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
            AdmGestionTurnos admGestionTurnos = new AdmGestionTurnos();
            this.Hide();
            admGestionTurnos.FormClosed += (s, args) => this.Close();
            admGestionTurnos.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            AdmGestionInsumos admGestionInsumos = new AdmGestionInsumos();
            this.Hide();
            admGestionInsumos.FormClosed += (s, args) => this.Close();
            admGestionInsumos.Show();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            AdmGestionPacientes admGestionPacientes = new AdmGestionPacientes();
            this.Hide();
            admGestionPacientes.FormClosed += (s, args) => this.Close();
            admGestionPacientes.Show();
        }
    }
}

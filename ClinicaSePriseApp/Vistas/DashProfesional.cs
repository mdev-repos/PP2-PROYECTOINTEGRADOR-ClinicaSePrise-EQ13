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
    public partial class DashProfesional : Form
    {
        public DashProfesional()
        {
            InitializeComponent();
            this.Resize += DashProfesional_Resize;

            this.Size = new Size(1024, 768);
            this.MinimumSize = new Size(1024, 768);
            this.WindowState = FormWindowState.Maximized;
        }

        private void DashProfesional_Load(object sender, EventArgs e)
        {
            ajustarPaneles();
        }

        private void DashProfesional_Resize(object sender, EventArgs e)
        {
            ajustarPaneles();
        }

        private void ajustarPaneles()
        {
            // Estilo de fondos
            mainTLP.BackColor = PaletaColores.bgGris;
            menuTLP.BackColor = PaletaColores.bgGris;

            // Estilo para menu
            foreach (Control boton in menuTLP.Controls)
            {
                boton.Dock = DockStyle.Fill;

                if (boton == btnLogout)
                {
                    boton.BackColor = PaletaColores.btnRosa;
                }
                else if (boton == btnLiquidaciones)
                {
                    boton.BackColor = PaletaColores.btnVerde;
                }
                else
                {
                    boton.BackColor = PaletaColores.btnAzul;
                }

                boton.Font = new Font("LEMON MILK", 10, FontStyle.Bold);
                boton.ForeColor = Color.Transparent;

                // Logo
                picLogo.BackColor = Color.Transparent;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

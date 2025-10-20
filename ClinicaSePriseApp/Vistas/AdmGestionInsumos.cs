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
    public partial class AdmGestionInsumos : Form
    {
        public AdmGestionInsumos()
        {
            InitializeComponent();

            this.Resize += AdmGestionInsumos_Resize;

            this.Size = new Size(1024, 768);
            this.MinimumSize = new Size(1024, 768);
            this.WindowState = FormWindowState.Maximized;
        }

        private void AdmGestionInsumos_Load(object sender, EventArgs e)
        {
            ajustarPaneles();
        }

        private void AdmGestionInsumos_Resize(object? sender, EventArgs e)
        {
            ajustarPaneles();
        }

        private void ajustarPaneles()
        {
            // Estilo de fondos
            mainTLP.BackColor = Utilidades.PaletaColores.bgCeleste;
            menuTLP.BackColor = Utilidades.PaletaColores.bgGris;
            contentLbl.BackColor = Utilidades.PaletaColores.bgGris;

            // Estilo para menu
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
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DashAdmin dashAdmin = new DashAdmin();
            this.Hide();
            dashAdmin.FormClosed += (s, args) => this.Close();
            dashAdmin.Show();
        }
    }
}

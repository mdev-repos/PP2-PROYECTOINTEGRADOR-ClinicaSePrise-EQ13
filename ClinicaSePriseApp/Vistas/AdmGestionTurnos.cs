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
    public partial class AdmGestionTurnos : Form
    {
        public AdmGestionTurnos()
        {
            InitializeComponent();
            this.Resize += AdmGestionTurnos_Resize;

            this.Size = new Size(1024, 768);
            this.MinimumSize = new Size(1024, 768);
            this.WindowState = FormWindowState.Maximized;
        //    this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DashAdmin dashAdmin = new DashAdmin();
            this.Hide();
            dashAdmin.Show();
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
                //boton.Margin = new Padding(15, 10, 15, 10);
                if (boton == btnVolver)
                {
                    boton.BackColor = Utilidades.PaletaColores.btnRosa;
                }
                else if(boton == picLogo)
                {
                    boton.BackColor = Color.Transparent;
                }
                else
                {
                    boton.BackColor = Utilidades.PaletaColores.btnAzul;
                }
            }
        }

        private void AdmGestionTurnos_Load(object sender, EventArgs e)
        {
            ajustarPaneles();
        }

        private void AdmGestionTurnos_Resize(object sender, EventArgs e)
        {
            ajustarPaneles();
        }
    }
}

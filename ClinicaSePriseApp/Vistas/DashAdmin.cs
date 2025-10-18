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
            leftPanel.Width = (int)(mainPanel.Width * 0.75);
            leftPanel.Height = mainPanel.Height;
            leftPanel.Location = new Point(0, 0);

            picBox.Width = leftPanel.Width;
            picBox.Height = leftPanel.Height;
            
            tlpRightPanel.BackColor = PaletaColores.bgGris;

            for (int i = 0; i < 5; i++)
            {
                tlpBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            }

            foreach (Control boton in tlpBotones.Controls)
            {
                boton.Dock = DockStyle.Fill;
                boton.Margin = new Padding(15, 10, 15, 10);
                
                if (boton == btnLogout)
                {
                    boton.BackColor = PaletaColores.btnRosa;
                }
                else
                {
                    boton.BackColor = PaletaColores.btnAzul;
                }

                boton.Font = new Font("LEMON MILK", 10, FontStyle.Bold);
                boton.ForeColor = Color.Transparent;
            }

        }
    }
}

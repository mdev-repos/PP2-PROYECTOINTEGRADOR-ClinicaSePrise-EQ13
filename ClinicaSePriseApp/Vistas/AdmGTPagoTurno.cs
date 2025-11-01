using ClinicaSePriseApp.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaSePriseApp.Vistas
{
    public partial class AdmGTPagoTurno : Form
    {
        private E_Turno? _turnoSeleccionado;

        public AdmGTPagoTurno()
        {
            InitializeComponent();
            _turnoSeleccionado = null;

            this.Resize += AdmGTPagoTurno_Resize;

            this.Size = new Size(1024, 768);
            this.MinimumSize = new Size(1024, 768);
            this.WindowState = FormWindowState.Maximized;
        }

        public AdmGTPagoTurno(E_Turno turno)
        {
            InitializeComponent();
            _turnoSeleccionado = turno;

            this.Resize += AdmGTPagoTurno_Resize;

            this.Size = new Size(1024, 768);
            this.MinimumSize = new Size(1024, 768);
            this.WindowState = FormWindowState.Maximized;
        }

        private void AdmGTPagoTurno_Load(object sender, EventArgs e)
        {
            ajustarPaneles();
        }

        private void AdmGTPagoTurno_Resize(object? sender, EventArgs e)
        {
            ajustarPaneles();
        }


        // BOTONES
        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            var turno = _turnoSeleccionado;

            if (turno != null)
            {
                AdmGTDetalleTurno admGTDetalleTurno = new AdmGTDetalleTurno(turno);
                this.Hide();
                admGTDetalleTurno.FormClosed += (s, args) => this.Close();
                admGTDetalleTurno.Show();
            }
        }


        // DISEÑO DE PANTALLA
        private void ajustarPaneles()
        {
            mainTLP.BackColor = Utilidades.PaletaColores.bgCeleste;
            menuTLP.BackColor = Utilidades.PaletaColores.bgGris;

            contentLbl.BackColor = Utilidades.PaletaColores.bgGris;

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
    }
}

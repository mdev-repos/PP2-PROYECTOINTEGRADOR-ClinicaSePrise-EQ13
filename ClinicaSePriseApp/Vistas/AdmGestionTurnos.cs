using ClinicaSePriseApp.Entidades.Enums;
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

            //Carga de Combos
            cargarCombos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DashAdmin dashAdmin = new DashAdmin();
            this.Hide();
            dashAdmin.FormClosed += (s, args) => this.Close();
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

                boton.Font = new Font("LEMON MILK", 10, FontStyle.Bold);
                boton.ForeColor = Color.Transparent;

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

        private void cargarCombos() {
            //Especialidad
            especialidadCbx.DataSource = Enum.GetValues(typeof(EspecialidadMedica));

            especialidadCbx.FormattingEnabled = true;
            especialidadCbx.Format += (sender, e) =>
            {
                if (e.ListItem != null)
                {
                    e.Value = e.ListItem.ToString();
                }
            };

            //Estado Turno
            estadoCbx.DataSource = Enum.GetValues(typeof(EstadoTurno));

            estadoCbx.FormattingEnabled = true;
            estadoCbx.Format += (sender, e) =>
            {
                if (e.ListItem != null)
                {
                    e.Value = e.ListItem.ToString();
                }
            };

        }
    }
}

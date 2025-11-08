using ClinicaSePriseApp.Entidades;
using ClinicaSePriseApp.Utilidades;
using ClinicaSePriseApp.Vistas.Auxiliares;
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

        private static E_Profesional _Profesional;

        public DashProfesional()
        {
            InitializeComponent();

            _Profesional = null;

            this.Resize += DashProfesional_Resize;

            this.Size = new Size(1024, 768);
            this.MinimumSize = new Size(1024, 768);
            this.WindowState = FormWindowState.Maximized;
        }

        public DashProfesional(E_Profesional profesional)
        {
            InitializeComponent();

            _Profesional = profesional;

            this.Resize += DashProfesional_Resize;

            this.Size = new Size(1024, 768);
            this.MinimumSize = new Size(1024, 768);
            this.WindowState = FormWindowState.Maximized;

            this.Text = $"Clinica SePrise  ||  Dashboard Dr. {profesional.Apellido}";
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
            mainTLP.BackColor = PaletaColores.celeste;
            menuTLP.BackColor = PaletaColores.bgGris;

            // Estilo para menu
            foreach (Control boton in menuTLP.Controls)
            {
                boton.Dock = DockStyle.Fill;

                if (boton == btnLogout)
                {
                    boton.BackColor = PaletaColores.rosa;
                }
                else if (boton == btnLiquidaciones)
                {
                    boton.BackColor = PaletaColores.azulVerde;
                }
                else
                {
                    boton.BackColor = PaletaColores.azulOscuro;
                }

                boton.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);
                boton.ForeColor = Color.Transparent;

                // Logo
                picLogo.BackColor = Color.Transparent;
            }
        }

        // Botones
        private void btnAgenda_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                    "Desea acceder a su agenda del dia?",
                    "Confirmar Ingreso a la Agenda Médica",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                );

            if (resultado == DialogResult.Cancel)
            {
                return;
            }

            ProfAgendaDiaria agendaDiaria = new ProfAgendaDiaria(_Profesional);
            this.Hide();
            agendaDiaria.FormClosed += (s, args) => this.Close();
            agendaDiaria.Show();
        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                    "Desea acceder al menú de insumos?",
                    "Confirmar Ingreso a Solicitud de Insumos",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                );

            if (resultado == DialogResult.Cancel)
            {
                return;
            }

            AuxSolicitarInsumos solicitarInsumos = new AuxSolicitarInsumos(_Profesional);
            solicitarInsumos.ShowDialog();
        }

        private void btnLiquidaciones_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                    "Desea consultar sus liquidaciones?",
                    "Confirmar Ingreso a Mis Liquidaciones",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                );

            if (resultado == DialogResult.Cancel)
            {
                return;
            }

            AuxCargaGenerica liquidaciones = new AuxCargaGenerica(_Profesional);
            liquidaciones.ShowDialog();
        }
    
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                    "Desea cerrar su sesión actual?",
                    "Confirmar Cierre de Sesión",
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

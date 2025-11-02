using ClinicaSePriseApp.Servicios;
using ClinicaSePriseApp.Utilidades;
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
    public partial class AdmGTGestionAgendas : Form
    {
        public AdmGTGestionAgendas()
        {
            InitializeComponent();

            this.Resize += AdmGTGestionAgendas_Resize;

            this.Size = new Size(1024, 768);
            this.MinimumSize = new Size(1024, 768);
            this.WindowState = FormWindowState.Maximized;

            CargarProfesionales();

            DisponibilidadBotones();
        }

        private void AdmGTGestionAgendas_Load(object sender, EventArgs e)
        {
            ajustarPaneles();
        }

        private void AdmGTGestionAgendas_Resize(object? sender, EventArgs e)
        {
            ajustarPaneles();
        }

        private void DisponibilidadBotones()
        {
            if (btnGenerar.Enabled == true)
            {
                btnGenerar.Enabled = false;
                btnEliminar.Enabled = false;
                btnSobreturno.Enabled = false;
                btnMesSiguiente.Enabled = false;
                btnMesAnterior.Enabled = false;
            }
            else
            {
                btnGenerar.Enabled = true;
                btnEliminar.Enabled = true;
                btnSobreturno.Enabled = true;
                btnMesSiguiente.Enabled = true;
                btnMesAnterior.Enabled = true;
            }
        }

        private void ajustarPaneles()
        {
            mainTLP.BackColor = Utilidades.PaletaColores.bgCeleste;
            menuTLP.BackColor = Utilidades.PaletaColores.bgGris;

            contentLbl.BackColor = Utilidades.PaletaColores.bgGris;
            dataViewTLP.BackColor = Utilidades.PaletaColores.bgCeleste;
            agendaDGV.BackgroundColor = Utilidades.PaletaColores.bgCeleste;
            agendaDGV.BorderStyle = BorderStyle.None;

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

            // Calendario

            calendarMonthTLP.BackColor = Utilidades.PaletaColores.btnAzul;
            calendarMonthTLP.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            calendarWeekTLP.BackColor = Utilidades.PaletaColores.btnAzul;
            calendarWeekTLP.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            calendarDaysTLP.BackColor = Color.White;
            calendarDaysTLP.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            foreach (Control label in calendarMonthTLP.Controls)
            {
                if (label is Button)
                {
                    label.BackColor = Utilidades.PaletaColores.btnAzul;
                    label.Font = new Font("LEMON MILK", 10, FontStyle.Bold);
                    label.ForeColor = Color.White;
                }
                else
                {
                    label.Font = new Font("LEMON MILK", 10, FontStyle.Bold);
                    label.ForeColor = Color.White;
                }

            }

            foreach (Control label in calendarWeekTLP.Controls)
            {
                label.Font = new Font("LEMON MILK", 10, FontStyle.Bold);
                label.ForeColor = Color.White;
            }

            foreach (Control label in calendarDaysTLP.Controls)
            {
                label.Font = new Font("LEMON MILK", 10, FontStyle.Bold);
                label.ForeColor = Color.White;
            }
        }


        // CARGA DE PROFESIONALES
        private void CargarProfesionales()
        {
            var listaProfesionales = new List<string>();

            listaProfesionales.Add(String.Empty);

            foreach (var prof in DDBB_Simulation.ProfesionalesDB)
            {
                listaProfesionales.Add(prof.NombreCompleto);
            }

            profesionalCbx.DataSource = listaProfesionales;
        }


        // BOTONES
        private void btnGenerar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnSobreturno_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            AdmGestionTurnos admGestionTurnos = new AdmGestionTurnos();
            this.Hide();
            admGestionTurnos.FormClosed += (s, args) => this.Close();
            admGestionTurnos.Show();
        }

        private void btnMesSiguiente_Click(object sender, EventArgs e)
        {

        }

        private void btnMesAnterior_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarProf_Click(object sender, EventArgs e)
        {

            if (profesionalCbx.SelectedItem == null || profesionalCbx.SelectedItem.ToString() == String.Empty)
            {
                MessageBox.Show("Por favor, seleccione un profesional.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                // Traer prof desde combo box
                var nombreProf = profesionalCbx.SelectedItem.ToString();

                // Buscar profesional en BBDD
                var profesional = ProfesionalService.ObtenerProfesionalPorNombreCompleto(nombreProf);

                if (profesional != null)
                {
                    // Cargar la agenda del profesional
                    MessageBox.Show($"Cargando agenda del profesional: {profesional.NombreCompleto}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Mostrar el Mes en curso en el Calendario, con los dias del profesional (Su disponibilidad, aquellos que ya tengan agendas en amarillo y los "libres en verde")


                    // Habilitar botones
                    DisponibilidadBotones();
                }
                else
                {
                    MessageBox.Show("Profesional no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                
        }
    }
}
using ClinicaSePriseApp.Entidades.Enums;
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

        private void cargarCombos()
        {
            // Especialidad
            var listaEspecialidades = new List<string> { "Todas las especialidades" };

            foreach (EspecialidadMedica esp in Enum.GetValues(typeof(EspecialidadMedica)))
            {
                listaEspecialidades.Add(EnumHelper.GetDescription(esp));
            }

            especialidadCbx.DataSource = listaEspecialidades;


            // Estado Turno
            var listaEstados = new List<string> { "Todos los estados" };

            foreach (EstadoTurno est in Enum.GetValues(typeof(EstadoTurno)))
            {
                listaEstados.Add(EnumHelper.GetDescription(est));
            }

            estadoCbx.DataSource = listaEstados;


            // Profesionales
            var listaProfesionales = new List<string> { "Todos los profesionales" };

            foreach (var prof in DDBB_Simulation.ProfesionalesDB)
            {
                listaProfesionales.Add($"{prof.Apellido}, {prof.Nombre}");
            }

            profesionalCbx.DataSource = listaProfesionales;
        }

        private EspecialidadMedica? StringAEspecialidad(string descripcion)
        {
            if (string.IsNullOrEmpty(descripcion) || descripcion == "Todas las especialidades")
                return null;

            foreach (EspecialidadMedica esp in Enum.GetValues(typeof(EspecialidadMedica)))
            {
                if (EnumHelper.GetDescription(esp) == descripcion)
                    return esp;
            }
            return null;
        }

        private EstadoTurno? StringAEstado(string descripcion)
        {
            if (string.IsNullOrEmpty(descripcion) || descripcion == "Todos los estados")
                return null;

            foreach (EstadoTurno est in Enum.GetValues(typeof(EstadoTurno)))
            {
                if (EnumHelper.GetDescription(est) == descripcion)
                    return est;
            }
            return null;
        }

        private int? StringAIdProfesional(string nombreCompleto)
        {
            if (string.IsNullOrEmpty(nombreCompleto) || nombreCompleto == "Todos los profesionales")
                return null;

            var profesional = DDBB_Simulation.ProfesionalesDB
                .FirstOrDefault(p => $"{p.Apellido}, {p.Nombre}" == nombreCompleto);

            return profesional?.IdProfesional;
        }
    }
}

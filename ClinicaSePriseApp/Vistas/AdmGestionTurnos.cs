using ClinicaSePriseApp.Entidades.Enums;
using ClinicaSePriseApp.Servicios;
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

            cargarCombos();

            btnFiltros.Click += btnFiltros_Click;
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
            mainTLP.BackColor = Utilidades.PaletaColores.bgCeleste;
            menuTLP.BackColor = Utilidades.PaletaColores.bgGris;
            turnosDgv.BackgroundColor = Utilidades.PaletaColores.bgCeleste;

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

        private void AdmGestionTurnos_Load(object sender, EventArgs e)
        {
            ajustarPaneles();
            
            AjustarControlesFiltro();
            
            CargarTurnosEnDGV();
        }

        private void AdmGestionTurnos_Resize(object sender, EventArgs e)
        {
            ajustarPaneles();

            AjustarControlesFiltro();
            
            if (turnosDgv.DataSource != null)
            {
                AjustarColumnasDGV();
            }
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

        private void AjustarControlesFiltro()
        {
            int fontSize = CalcularTamanoFuente();

            Font fontControles = new Font("LEMON MILK", fontSize);

            dtpTurnos.Font = fontControles;

            especialidadCbx.Font = fontControles;
            profesionalCbx.Font = fontControles;
            estadoCbx.Font = fontControles;

            int alturaCombo = 25 + (fontSize - 8) * 2;
            especialidadCbx.Height = alturaCombo;
            profesionalCbx.Height = alturaCombo;
            estadoCbx.Height = alturaCombo;
            dtpTurnos.Height = alturaCombo;
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

        private void CargarTurnosEnDGV()
        {
            var turnos = TurnoService.ObtenerTodosLosTurnos();

            var turnosOrdenados = turnos.OrderByDescending(t => t.FechaTurno.Date)
                                        .ThenBy(t => TimeOnly.FromDateTime(t.FechaTurno))
                                        .ToList();

            var turnosParaMostrar = turnosOrdenados.Select(t => new
            {
                Fecha = DateOnly.FromDateTime(t.FechaTurno),
                Hora = TimeOnly.FromDateTime(t.FechaTurno).ToString("HH:mm"),
                Especialidad = ObtenerEspecialidadProfesional(t.IdProfesional),
                Profesional = ObtenerNombreProfesional(t.IdProfesional),
                Estado = EnumHelper.GetDescription(t.Estado)
            }).ToList();

            ConfigurarDataGridView();

            turnosDgv.DataSource = turnosParaMostrar;

            AjustarColumnasDGV();
        }

        private string ObtenerEspecialidadProfesional(int idProfesional)
        {
            var profesional = ProfesionalService.ObtenerProfesionalPorID(idProfesional);
            if (profesional != null)
            {
                return EnumHelper.GetDescription(profesional.Especialidad);
            }
            return "No encontrado";
        }

        private string ObtenerNombreProfesional(int idProfesional)
        {
            var profesional = ProfesionalService.ObtenerProfesionalPorID(idProfesional);
            if (profesional != null)
            {
                return $"{profesional.Apellido}, {profesional.Nombre}";
            }
            return "No encontrado";
        }

        private void ConfigurarDataGridView()
        {
            turnosDgv.ScrollBars = ScrollBars.Both;
            turnosDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            turnosDgv.ReadOnly = true;
            turnosDgv.AllowUserToAddRows = false;
            turnosDgv.AllowUserToDeleteRows = false;
            turnosDgv.AllowUserToOrderColumns = false;
            turnosDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            turnosDgv.MultiSelect = false;
            turnosDgv.AutoGenerateColumns = true;
        }

        private void AjustarColumnasDGV()
        {
            if (turnosDgv.Columns.Count > 0)
            {
                int fontSize = CalcularTamanoFuente();

                turnosDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (turnosDgv.Columns.Contains("Fecha"))
                {
                    turnosDgv.Columns["Fecha"].FillWeight = 15;
                    turnosDgv.Columns["Fecha"].HeaderText = "FECHA";
                }

                if (turnosDgv.Columns.Contains("Hora"))
                {
                    turnosDgv.Columns["Hora"].FillWeight = 10;
                    turnosDgv.Columns["Hora"].HeaderText = "HORA";
                }

                if (turnosDgv.Columns.Contains("Especialidad"))
                {
                    turnosDgv.Columns["Especialidad"].FillWeight = 25;
                    turnosDgv.Columns["Especialidad"].HeaderText = "ESPECIALIDAD";
                }

                if (turnosDgv.Columns.Contains("Profesional"))
                {
                    turnosDgv.Columns["Profesional"].FillWeight = 30;
                    turnosDgv.Columns["Profesional"].HeaderText = "PROFESIONAL";
                }

                if (turnosDgv.Columns.Contains("Estado"))
                {
                    turnosDgv.Columns["Estado"].FillWeight = 20;
                    turnosDgv.Columns["Estado"].HeaderText = "ESTADO";
                }

                turnosDgv.EnableHeadersVisualStyles = false;

                turnosDgv.ColumnHeadersDefaultCellStyle.BackColor = Utilidades.PaletaColores.btnAzul;
                turnosDgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                turnosDgv.ColumnHeadersDefaultCellStyle.Font = new Font("LEMON MILK", fontSize, FontStyle.Bold);

                turnosDgv.DefaultCellStyle.SelectionBackColor = Utilidades.PaletaColores.btnVerde;

                turnosDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                turnosDgv.ColumnHeadersHeight = 35 + (fontSize - 8);

                foreach (DataGridViewColumn col in turnosDgv.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.DefaultCellStyle.Font = new Font("LEMON MILK", fontSize - 0.5f);
                }

                turnosDgv.RowTemplate.Height = 25 + (fontSize - 8);

                turnosDgv.RowHeadersVisible = false;
                turnosDgv.BorderStyle = BorderStyle.None;
                turnosDgv.GridColor = Color.LightGray;

                turnosDgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            }
        }

        private int CalcularTamanoFuente()
        {
            int anchoPantalla = this.Width;

            if (anchoPantalla <= 800)
                return 6;
            else if (anchoPantalla <= 1024)
                return 7;
            else if (anchoPantalla <= 1280)
                return 8;
            else if (anchoPantalla <= 1366)
                return 9;
            else 
                return 10;            
        }

        private void btnFiltros_Click(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void AplicarFiltros()
        {
            try
            {
                var turnos = TurnoService.ObtenerTodosLosTurnos();

                var turnosFiltrados = AplicarFiltrosATurnos(turnos);

                if (!turnosFiltrados.Any())
                {
                    MessageBox.Show("No se encontraron turnos con los filtros aplicados.", "Información",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarTurnosEnDGV();

                    return;
                }

                var turnosOrdenados = turnosFiltrados.OrderByDescending(t => t.FechaTurno.Date)
                                                    .ThenBy(t => TimeOnly.FromDateTime(t.FechaTurno))
                                                    .ToList();
                
                var turnosParaMostrar = turnosOrdenados.Select(t => new
                {
                    Fecha = DateOnly.FromDateTime(t.FechaTurno),
                    Hora = TimeOnly.FromDateTime(t.FechaTurno).ToString("HH:mm"),
                    Especialidad = ObtenerEspecialidadProfesional(t.IdProfesional),
                    Profesional = ObtenerNombreProfesional(t.IdProfesional),
                    Estado = EnumHelper.GetDescription(t.Estado)
                }).ToList();

                turnosDgv.DataSource = turnosParaMostrar;

                AjustarColumnasDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al aplicar filtros: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<Entidades.E_Turno> AplicarFiltrosATurnos(List<Entidades.E_Turno> turnos)
        {
            var turnosFiltrados = turnos;

            if (dtpTurnos.Value != DateTime.Today)
            {
                DateOnly fechaSeleccionada = DateOnly.FromDateTime(dtpTurnos.Value);
                turnosFiltrados = turnosFiltrados.Where(t =>
                    DateOnly.FromDateTime(t.FechaTurno) == fechaSeleccionada).ToList();
            }

            var especialidadFiltro = StringAEspecialidad(especialidadCbx.SelectedItem?.ToString());
            if (especialidadFiltro.HasValue)
            {
                turnosFiltrados = turnosFiltrados.Where(t =>
                {
                    var profesional = ProfesionalService.ObtenerProfesionalPorID(t.IdProfesional);
                    return profesional?.Especialidad == especialidadFiltro.Value;
                }).ToList();
            }

            var profesionalFiltro = StringAIdProfesional(profesionalCbx.SelectedItem?.ToString());
            if (profesionalFiltro.HasValue)
            {
                turnosFiltrados = turnosFiltrados.Where(t =>
                    t.IdProfesional == profesionalFiltro.Value).ToList();
            }

            var estadoFiltro = StringAEstado(estadoCbx.SelectedItem?.ToString());
            if (estadoFiltro.HasValue)
            {
                turnosFiltrados = turnosFiltrados.Where(t =>
                    t.Estado == estadoFiltro.Value).ToList();
            }

            return turnosFiltrados;
        }
    }
}
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

            //Carga de Combos
            cargarCombos();

            // Configurar el botón de filtros (si no está en el designer)
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

            // Aplicar el mismo tamaño de fuente a todos los controles de filtro
            Font fontControles = new Font("LEMON MILK", fontSize);

            // DatePicker
            dtpTurnos.Font = fontControles;

            // ComboBoxes
            especialidadCbx.Font = fontControles;
            profesionalCbx.Font = fontControles;
            estadoCbx.Font = fontControles;

            // Ajustar altura de los combos basado en el tamaño de fuente
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
            // Obtener todos los turnos        
            var turnos = TurnoService.ObtenerTodosLosTurnos();

            // Ordenar por fecha (más recientes primero) y luego por hora
            var turnosOrdenados = turnos.OrderByDescending(t => t.FechaTurno.Date)
                                        .ThenBy(t => TimeOnly.FromDateTime(t.FechaTurno))
                                        .ToList();

            // Crear lista con datos formateados para mostrar (sin ID)
            var turnosParaMostrar = turnosOrdenados.Select(t => new
            {
                Fecha = DateOnly.FromDateTime(t.FechaTurno),
                Hora = TimeOnly.FromDateTime(t.FechaTurno).ToString("HH:mm"),
                Especialidad = ObtenerEspecialidadProfesional(t.IdProfesional),
                Profesional = ObtenerNombreProfesional(t.IdProfesional),
                Estado = EnumHelper.GetDescription(t.Estado)
            }).ToList();

            // Configurar el DataGridView
            ConfigurarDataGridView();

            // Asignar los datos
            turnosDgv.DataSource = turnosParaMostrar;

            // Ajustar columnas después de cargar los datos
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
            // Habilitar scroll
            turnosDgv.ScrollBars = ScrollBars.Both;
            turnosDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Configurar para mejor experiencia de usuario
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
                // Calcular tamaño de fuente basado en el ancho de la pantalla
                int fontSize = CalcularTamanoFuente();

                // Usar Fill con pesos personalizados
                turnosDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Asignar FillWeight (pesos relativos)
                if (turnosDgv.Columns.Contains("Fecha"))
                {
                    turnosDgv.Columns["Fecha"].FillWeight = 15; // 15%
                    turnosDgv.Columns["Fecha"].HeaderText = "FECHA";
                }

                if (turnosDgv.Columns.Contains("Hora"))
                {
                    turnosDgv.Columns["Hora"].FillWeight = 10; // 10%
                    turnosDgv.Columns["Hora"].HeaderText = "HORA";
                }

                if (turnosDgv.Columns.Contains("Especialidad"))
                {
                    turnosDgv.Columns["Especialidad"].FillWeight = 25; // 25%
                    turnosDgv.Columns["Especialidad"].HeaderText = "ESPECIALIDAD";
                }

                if (turnosDgv.Columns.Contains("Profesional"))
                {
                    turnosDgv.Columns["Profesional"].FillWeight = 30; // 30%
                    turnosDgv.Columns["Profesional"].HeaderText = "PROFESIONAL";
                }

                if (turnosDgv.Columns.Contains("Estado"))
                {
                    turnosDgv.Columns["Estado"].FillWeight = 20; // 20%
                    turnosDgv.Columns["Estado"].HeaderText = "ESTADO";
                }

                // Configurar estilo de la cabecera
                turnosDgv.EnableHeadersVisualStyles = false;

                // Color de fondo celeste y texto blanco para los headers
                turnosDgv.ColumnHeadersDefaultCellStyle.BackColor = Utilidades.PaletaColores.bgCeleste;
                turnosDgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                turnosDgv.ColumnHeadersDefaultCellStyle.Font = new Font("LEMON MILK", fontSize, FontStyle.Bold);

                // Altura de la cabecera (también ajustable)
                turnosDgv.ColumnHeadersHeight = 35 + (fontSize - 8); // Ajusta según el tamaño de fuente

                // Centrar TODO el contenido y aplicar fuente a las celdas
                foreach (DataGridViewColumn col in turnosDgv.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.DefaultCellStyle.Font = new Font("LEMON MILK", fontSize - 0.5f); // Un poco más pequeña que el header
                }

                // Ajustar altura de filas según el tamaño de fuente
                turnosDgv.RowTemplate.Height = 25 + (fontSize - 8);

                // Opcional: mejorar el aspecto de las filas
                turnosDgv.RowHeadersVisible = false;
                turnosDgv.BorderStyle = BorderStyle.None;
                turnosDgv.GridColor = Color.LightGray;

                // Alternar colores para mejor legibilidad
                turnosDgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            }
        }

        private int CalcularTamanoFuente()
        {
            int anchoPantalla = this.Width;

            if (anchoPantalla <= 800)
                return 6;   // Pantallas muy pequeñas
            else if (anchoPantalla <= 1024)
                return 7;   // Pantallas pequeñas
            else if (anchoPantalla <= 1280)
                return 8;   // Pantallas medianas-pequeñas
            else if (anchoPantalla <= 1366)
                return 9;   // Pantallas medianas
            else 
                return 10;  // Pantallas grandes
            
        }

        private void btnFiltros_Click(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void AplicarFiltros()
        {
            try
            {
                // Obtener todos los turnos        
                var turnos = TurnoService.ObtenerTodosLosTurnos();

                // Aplicar filtros
                var turnosFiltrados = AplicarFiltrosATurnos(turnos);

                // Verificar si hay resultados ANTES de procesar
                if (!turnosFiltrados.Any())
                {
                    // Limpiar el DataGridView
                    turnosDgv.DataSource = null;

                    MessageBox.Show("No se encontraron turnos con los filtros aplicados.", "Información",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // Salir del método aquí
                }

                // Ordenar por fecha (más recientes primero) y luego por hora
                var turnosOrdenados = turnosFiltrados.OrderByDescending(t => t.FechaTurno.Date)
                                                    .ThenBy(t => TimeOnly.FromDateTime(t.FechaTurno))
                                                    .ToList();

                // Crear lista con datos formateados para mostrar (sin ID)
                var turnosParaMostrar = turnosOrdenados.Select(t => new
                {
                    Fecha = DateOnly.FromDateTime(t.FechaTurno),
                    Hora = TimeOnly.FromDateTime(t.FechaTurno).ToString("HH:mm"),
                    Especialidad = ObtenerEspecialidadProfesional(t.IdProfesional),
                    Profesional = ObtenerNombreProfesional(t.IdProfesional),
                    Estado = EnumHelper.GetDescription(t.Estado)
                }).ToList();

                // Asignar los datos filtrados
                turnosDgv.DataSource = turnosParaMostrar;

                // Ajustar las columnas después de cargar los datos
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

            // Filtro por fecha (si no es la fecha por defecto)
            if (dtpTurnos.Value != DateTime.Today)
            {
                DateOnly fechaSeleccionada = DateOnly.FromDateTime(dtpTurnos.Value);
                turnosFiltrados = turnosFiltrados.Where(t =>
                    DateOnly.FromDateTime(t.FechaTurno) == fechaSeleccionada).ToList();
            }

            // Filtro por especialidad
            var especialidadFiltro = StringAEspecialidad(especialidadCbx.SelectedItem?.ToString());
            if (especialidadFiltro.HasValue)
            {
                turnosFiltrados = turnosFiltrados.Where(t =>
                {
                    var profesional = ProfesionalService.ObtenerProfesionalPorID(t.IdProfesional);
                    return profesional?.Especialidad == especialidadFiltro.Value;
                }).ToList();
            }

            // Filtro por profesional
            var profesionalFiltro = StringAIdProfesional(profesionalCbx.SelectedItem?.ToString());
            if (profesionalFiltro.HasValue)
            {
                turnosFiltrados = turnosFiltrados.Where(t =>
                    t.IdProfesional == profesionalFiltro.Value).ToList();
            }

            // Filtro por estado
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
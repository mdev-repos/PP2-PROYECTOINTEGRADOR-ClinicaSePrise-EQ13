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

            cbFecha.CheckedChanged += (s, e) => HabilitarDeshabilitarControl(dtpTurnos, cbFecha.Checked);
            cbEspecialidad.CheckedChanged += (s, e) => HabilitarDeshabilitarControl(especialidadCbx, cbEspecialidad.Checked);
            cbProfesional.CheckedChanged += (s, e) => HabilitarDeshabilitarControl(profesionalCbx, cbProfesional.Checked);
            cbEstado.CheckedChanged += (s, e) => HabilitarDeshabilitarControl(estadoCbx, cbEstado.Checked);

            HabilitarDeshabilitarControl(dtpTurnos, false);
            HabilitarDeshabilitarControl(especialidadCbx, false);
            HabilitarDeshabilitarControl(profesionalCbx, false);
            HabilitarDeshabilitarControl(estadoCbx, false);

            cargarCombos();

            btnFiltros.Click += btnFiltros_Click;
        }

        // Form
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


        // Estilos Visuales
        private void ajustarPaneles()
        {
            mainTLP.BackColor = PaletaColores.celeste;
            menuTLP.BackColor = PaletaColores.bgGris;
            turnosDgv.BackgroundColor = PaletaColores.celeste;

            contentLbl.BackColor = PaletaColores.bgGris;

            foreach (Control boton in menuTLP.Controls)
            {
                boton.Dock = DockStyle.Fill;

                if (boton == btnVolver)
                {
                    boton.BackColor = PaletaColores.rosa;
                }
                else if (boton == picLogo)
                {
                    boton.BackColor = Color.Transparent;
                }
                else
                {
                    boton.BackColor = PaletaColores.azulOscuro;
                }

                boton.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);
                boton.ForeColor = Color.White;

                profesionalCbx.BackColor = Color.White;
                estadoCbx.BackColor = Color.White;
                especialidadCbx.BackColor = Color.White;
            }
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

                if (turnosDgv.Columns.Contains("IdTurno"))
                {
                    turnosDgv.Columns["IdTurno"].Visible = false;
                }

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

                turnosDgv.ColumnHeadersDefaultCellStyle.BackColor = PaletaColores.azulClaro;
                turnosDgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                turnosDgv.ColumnHeadersDefaultCellStyle.Font = new Font(Fuente.TIPOGRAFIA, fontSize, FontStyle.Bold);

                turnosDgv.DefaultCellStyle.SelectionBackColor = PaletaColores.verdeOscuro;

                turnosDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                turnosDgv.ColumnHeadersHeight = 35 + (fontSize - 8);

                foreach (DataGridViewColumn col in turnosDgv.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.DefaultCellStyle.Font = new Font(Fuente.TIPOGRAFIA, fontSize - 0.5f);
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


        // Carga de Datos
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
        private void CargarTurnosEnDGV()
        {
            var turnos = TurnoService.ObtenerTodosLosTurnos();

            var turnosOrdenados = turnos.OrderBy(t => t.FechaTurno)
                                        .ToList();

            var turnosParaMostrar = turnosOrdenados.Select(t => new
            {
                IdTurno = t.IdTurno,
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


        // Filtrado
        private void HabilitarDeshabilitarControl(Control control, bool habilitado)
        {
            control.Enabled = habilitado;
            control.BackColor = habilitado ? Color.White : SystemColors.Control;
        }
        private void AjustarControlesFiltro()
        {
            int fontSize = CalcularTamanoFuente();

            Font fontControles = new Font(Fuente.TIPOGRAFIA, fontSize);

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
        private void AplicarFiltros()
        {
            try
            {
                if (!cbFecha.Checked && !cbEspecialidad.Checked && !cbProfesional.Checked && !cbEstado.Checked)
                {
                    MessageBox.Show("Por favor, seleccione al menos un filtro para aplicar.", "Información",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTurnosEnDGV();
                    return;
                }

                var turnos = TurnoService.ObtenerTodosLosTurnos();

                var turnosFiltrados = AplicarFiltrosATurnos(turnos);

                if (!turnosFiltrados.Any())
                {
                    MessageBox.Show("No se encontraron turnos con los filtros aplicados.", "Información",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarTurnosEnDGV();
                    return;
                }

                var turnosOrdenados = turnosFiltrados.OrderBy(t => t.FechaTurno)
                                                    .ToList();

                var turnosParaMostrar = turnosOrdenados.Select(t => new
                {
                    IdTurno = t.IdTurno,
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

            if (cbFecha.Checked && dtpTurnos.Value != DateTime.Today)
            {
                DateOnly fechaSeleccionada = DateOnly.FromDateTime(dtpTurnos.Value);
                turnosFiltrados = turnosFiltrados.Where(t =>
                    DateOnly.FromDateTime(t.FechaTurno) == fechaSeleccionada).ToList();
            }

            if (cbEspecialidad.Checked)
            {
                var especialidadFiltro = StringAEspecialidad(especialidadCbx.SelectedItem?.ToString());
                if (especialidadFiltro.HasValue)
                {
                    turnosFiltrados = turnosFiltrados.Where(t =>
                    {
                        var profesional = ProfesionalService.ObtenerProfesionalPorID(t.IdProfesional);
                        return profesional?.Especialidad == especialidadFiltro.Value;
                    }).ToList();
                }
            }

            if (cbProfesional.Checked)
            {
                var profesionalFiltro = StringAIdProfesional(profesionalCbx.SelectedItem?.ToString());
                if (profesionalFiltro.HasValue)
                {
                    turnosFiltrados = turnosFiltrados.Where(t =>
                        t.IdProfesional == profesionalFiltro.Value).ToList();
                }
            }

            if (cbEstado.Checked)
            {
                var estadoFiltro = StringAEstado(estadoCbx.SelectedItem?.ToString());
                if (estadoFiltro.HasValue)
                {
                    turnosFiltrados = turnosFiltrados.Where(t =>
                        t.Estado == estadoFiltro.Value).ToList();
                }
            }

            return turnosFiltrados;
        }


        // Métodos Auxiliares
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
        private int? ObtenerIdTurnoSeleccionado()
        {
            if (turnosDgv.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = turnosDgv.SelectedRows[0];
                if (fila.Cells["IdTurno"].Value != null)
                {
                    return Convert.ToInt32(fila.Cells["IdTurno"].Value);
                }
            }
            else if (turnosDgv.CurrentRow != null && turnosDgv.CurrentRow.Cells["IdTurno"].Value != null)
            {
                return Convert.ToInt32(turnosDgv.CurrentRow.Cells["IdTurno"].Value);
            }

            return null;
        }
        private void IrAlTurnoSeleccionado()
        {
            try
            {
                var idTurno = ObtenerIdTurnoSeleccionado();

                if (!idTurno.HasValue)
                {
                    MessageBox.Show("Por favor, seleccione un turno de la lista.", "Información",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var turno = TurnoService.ObtenerTurnoPorID(idTurno.Value);

                if (turno != null)
                {
                    AdmGTDetalleTurno admGTDetalleTurno = new AdmGTDetalleTurno(turno);
                    this.Hide();
                    admGTDetalleTurno.FormClosed += (s, args) => this.Close();
                    admGTDetalleTurno.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el turno: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Botones
        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                    "Desea salir de la Pantalla y volver al Dashboard?",
                    "Confirmar Asignación",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                );

            if (resultado == DialogResult.Cancel)
            {
                return;
            }

            DashAdmin dashAdmin = new DashAdmin();
            this.Hide();
            dashAdmin.FormClosed += (s, args) => this.Close();
            dashAdmin.Show();
        }
        private void btnFiltros_Click(object sender, EventArgs e)
        {
            AplicarFiltros();
        }    
        private void btnAgenda_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                    "Desea ir al menú de gestión de las Agendas Médicas?",
                    "Confirmar Asignación",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                );

            if (resultado == DialogResult.Cancel)
            {
                return;
            }

            AdmGTGestionAgendas admGTGestionAgendas = new AdmGTGestionAgendas();
            this.Hide();
            admGTGestionAgendas.FormClosed += (s, args) => this.Close();
            admGTGestionAgendas.Show();
        }
        private void btnTurno_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                    "Desea ver el Detalle del Turno seleccionado?",
                    "Confirmar Asignación",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                );

            if (resultado == DialogResult.Cancel)
            {
                return;
            }

            IrAlTurnoSeleccionado();
        }
    }
}
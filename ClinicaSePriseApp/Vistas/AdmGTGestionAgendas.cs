using ClinicaSePriseApp.Entidades;
using ClinicaSePriseApp.Entidades.Enums;
using ClinicaSePriseApp.Servicios;
using ClinicaSePriseApp.Utilidades;
using ClinicaSePriseApp.Vistas.Auxiliares;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaSePriseApp.Vistas
{
    public partial class AdmGTGestionAgendas : Form
    {
        // Variables Globales
        private E_Profesional _profesionalSeleccionado;
        private DateTime _fechaActual;
        private DateTime _fechaSeleccionada;
        private Panel _loadingPanel;
        private Label _loadingLabel;
        private bool _calendarioCargado = false;

        public AdmGTGestionAgendas()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            calendarDaysTLP.DoubleBuffered(true);
            AgendaDataTLP.DoubleBuffered(true);

            InitializeLoadingPanel();

            AgendaContainerTLP.Visible = false;

            this.Resize += AdmGTGestionAgendas_Resize;

            this.Size = new Size(1024, 768);
            this.MinimumSize = new Size(1024, 768);
            this.WindowState = FormWindowState.Maximized;

            CargarProfesionales();
        }

        private void InitializeLoadingPanel()
        {
            _loadingPanel = new Panel();
            _loadingPanel.Size = new Size(300, 80);
            _loadingPanel.BackColor = PaletaColores.azulClaro;
            _loadingPanel.BorderStyle = BorderStyle.FixedSingle;
            _loadingPanel.Visible = false;
            _loadingPanel.BringToFront();

            _loadingLabel = new Label();
            _loadingLabel.Text = "CARGANDO CALENDARIO...";
            _loadingLabel.TextAlign = ContentAlignment.MiddleCenter;
            _loadingLabel.Dock = DockStyle.Fill;
            _loadingLabel.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XXL, FontStyle.Bold);
            _loadingLabel.ForeColor = PaletaColores.blanco;
            _loadingLabel.BackColor = PaletaColores.azulClaro;

            _loadingPanel.Controls.Add(_loadingLabel);
            this.Controls.Add(_loadingPanel);
            _loadingPanel.BringToFront();
        }

        private void AdmGTGestionAgendas_Load(object sender, EventArgs e)
        {
            ajustarPaneles();

            AjustarAlturaAgenda();
        }

        private void AdmGTGestionAgendas_Resize(object? sender, EventArgs e)
        {
            if (!_calendarioCargado)
            {
                ajustarPaneles();
            }

            if (_loadingPanel != null && _loadingPanel.Visible)
            {
                _loadingPanel.Location = new Point(
                    (this.ClientSize.Width - _loadingPanel.Width) / 2,
                    (this.ClientSize.Height - _loadingPanel.Height) / 2
                );
            }

            AjustarTipografiaResponsive();
            AjustarAlturaAgenda();

            if (AgendaContainerTLP.Visible && _profesionalSeleccionado != null)
            {
                CargarTurnosEnTLP(_fechaSeleccionada);
            }

            if (AgendaContainerTLP.Visible && _profesionalSeleccionado != null)
            {
                bool scrollActivo = AgendaScroll.VerticalScroll.Visible;
                AgendaHeadersTLP.Margin = new Padding(0, 0, scrollActivo ? 20 : 0, 0);
            }
        }

        private void ajustarPaneles()
        {
            AgendaScroll.AutoSize = false;
            AgendaScroll.AutoScroll = true;
            AgendaScroll.Dock = DockStyle.Fill;

            AgendaDataTLP.Dock = DockStyle.Top;
            AgendaDataTLP.AutoSize = true;

            mainTLP.BackColor = PaletaColores.celeste;
            menuTLP.BackColor = PaletaColores.bgGris;
            contentLbl.BackColor = PaletaColores.bgGris;
            dataViewTLP.BackColor = PaletaColores.celeste;

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
            }

            calendarMonthTLP.BackColor = PaletaColores.azulClaro;
            calendarMonthTLP.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            calendarWeekTLP.BackColor = PaletaColores.azulClaro;
            calendarWeekTLP.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            calendarDaysTLP.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            AgendaContainerTLP.BackColor = PaletaColores.celeste;
            AgendaHeadersTLP.BackColor = PaletaColores.azulClaro;
            AgendaHeadersTLP.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            AgendaDataTLP.BackColor = PaletaColores.celeste;
            AgendaDataTLP.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            foreach (Control label in calendarMonthTLP.Controls)
            {
                if (label is Button)
                {
                    label.BackColor = PaletaColores.azulClaro;
                    label.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);
                    label.ForeColor = Color.White;
                }
                else if (label is Label)
                {
                    label.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);
                    label.ForeColor = Color.White;
                }
            }

            foreach (Control label in calendarWeekTLP.Controls)
            {
                if (label is Label)
                {
                    label.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);
                    label.ForeColor = Color.White;
                }
            }

            foreach (Control control in AgendaHeadersTLP.Controls)
            {
                if (control is Label label)
                {
                    label.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);
                    label.ForeColor = Color.White;
                    label.BackColor = PaletaColores.azulClaro;
                }
            }
        }

        private void AjustarTipografiaResponsive()
        {
            int anchoTotal = AgendaContainerTLP.Width;

            float tamanoFuente = Fuente.XL;

            if (anchoTotal < 300)
                tamanoFuente = Fuente.M;
            else if (anchoTotal < 400)
                tamanoFuente = Fuente.L;
            else if (anchoTotal > 600)
                tamanoFuente = Fuente.XXL;

            foreach (Control control in AgendaHeadersTLP.Controls)
            {
                if (control is Label label)
                {
                    label.Font = new Font(Fuente.TIPOGRAFIA, tamanoFuente, FontStyle.Bold);
                }
            }

            if (AgendaDataTLP.Controls.Count > 0)
            {
                foreach (Control control in AgendaDataTLP.Controls)
                {
                    if (control is Label label)
                    {
                        label.Font = new Font(Fuente.TIPOGRAFIA, tamanoFuente, FontStyle.Regular);
                    }
                }
            }
        }

        private void ShowLoading(bool show)
        {
            if (_loadingPanel != null)
            {
                if (show)
                {
                    _loadingPanel.Location = new Point(
                        (this.ClientSize.Width - _loadingPanel.Width) / 2,
                        (this.ClientSize.Height - _loadingPanel.Height) / 2
                    );
                }

                _loadingPanel.Visible = show;
                _loadingPanel.BringToFront();

                profesionalCbx.Enabled = !show;
                btnBuscarProf.Enabled = !show;
                btnGenerar.Enabled = !show;
                btnEliminar.Enabled = !show;
                btnSobreturno.Enabled = !show;
            }
        }


        // CARGA DE PROFESIONALES
        private void CargarProfesionales()
        {
            var listaProfesionales = new List<string>() { String.Empty };

            foreach (var prof in DDBB_Simulation.ProfesionalesDB)
            {
                listaProfesionales.Add(prof.NombreCompleto);
            }

            profesionalCbx.DataSource = listaProfesionales;
        }

                

        // CALENDARIO
        private void CargarCalendarioCompleto(E_Profesional profesional)
        {
            if (profesional == null) return;

            _profesionalSeleccionado = profesional;
            _fechaActual = DateTime.Now;

            lblMes.Text = _fechaActual.ToString("MMMM yyyy").ToUpper();

            PoblarEstructuraBasicaCalendario(_fechaActual.Year, _fechaActual.Month);
            ColorearCalendarioSegunProfesional(profesional, _fechaActual.Year, _fechaActual.Month);

            _calendarioCargado = true;
        }

        private void PoblarEstructuraBasicaCalendario(int año, int mes)
        {
            DateTime primerDiaMes = new DateTime(año, mes, 1);
            DateTime ultimoDiaMes = primerDiaMes.AddMonths(1).AddDays(-1);

            int diasEnMes = ultimoDiaMes.Day;
            int diaInicioSemana = (int)primerDiaMes.DayOfWeek;

            calendarDaysTLP.Controls.Clear();

            for (int i = 0; i < diaInicioSemana; i++)
            {
                AddCeldaCalendario("", Color.FromArgb(0xBC, 0xBC, 0xBC), false);
            }

            for (int dia = 1; dia <= diasEnMes; dia++)
            {
                AddCeldaCalendario(dia.ToString(), Color.White, true);
            }

            int celdasUsadas = diaInicioSemana + diasEnMes;
            int celdasRestantes = 42 - celdasUsadas;
            for (int i = 0; i < celdasRestantes; i++)
            {
                AddCeldaCalendario("", Color.FromArgb(0xBC, 0xBC, 0xBC), false);
            }
        }

        private void AddCeldaCalendario(string texto, Color colorFondo, bool esDiaValido)
        {
            Label lblDia = new Label();
            lblDia.Text = texto;
            lblDia.BackColor = colorFondo;
            lblDia.Dock = DockStyle.Fill;
            lblDia.TextAlign = ContentAlignment.MiddleCenter;
            lblDia.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);
            lblDia.Margin = new Padding(0);

            if (esDiaValido && !string.IsNullOrEmpty(texto))
            {
                lblDia.Cursor = Cursors.Hand;
                lblDia.Click += LabelDia_Click;
            }

            calendarDaysTLP.Controls.Add(lblDia);
        }

        private void ColorearCalendarioSegunProfesional(E_Profesional profesional, int año, int mes)
        {
            if (profesional == null) return;

            List<DayOfWeek> diasDisponibles = ProfesionalService.ObtenerDiasDisponibles(profesional);

            List<DateTime> fechasConTurnos = profesional.AgendaMedica
                .Where(t => t.FechaTurno.Year == año && t.FechaTurno.Month == mes)
                .Select(t => t.FechaTurno.Date)
                .Distinct()
                .ToList();

            for (int i = 0; i < calendarDaysTLP.Controls.Count; i++)
            {
                var control = calendarDaysTLP.Controls[i];
                if (control is Label lbl && !string.IsNullOrEmpty(lbl.Text))
                {
                    int dia = int.Parse(lbl.Text);
                    DateTime fecha = new DateTime(año, mes, dia);

                    if (diasDisponibles.Contains(fecha.DayOfWeek))
                    {
                        if (fechasConTurnos.Contains(fecha))
                        {
                            lbl.BackColor = PaletaColores.celeste;
                            lbl.Cursor = Cursors.Hand;
                        }
                        else
                        {
                            if (fecha < DateTime.Today)
                            {
                                lbl.BackColor = PaletaColores.rosa;
                                lbl.Cursor = Cursors.Default;
                                lbl.Click -= LabelDia_Click;
                            }
                            else
                            {
                                lbl.BackColor = PaletaColores.verdeClaro;
                                lbl.Cursor = Cursors.Hand;
                            }
                        }
                    }
                    else
                    {
                        lbl.BackColor = Color.White;
                        lbl.Cursor = Cursors.Default;
                        lbl.Click -= LabelDia_Click;
                    }
                }
            }
        }

        private void LabelDia_Click(object sender, EventArgs e)
        {
            if (_profesionalSeleccionado == null) return;

            Label lblDia = (Label)sender;
            int dia = int.Parse(lblDia.Text);
            _fechaSeleccionada = new DateTime(_fechaActual.Year, _fechaActual.Month, dia);

            AgendaContainerTLP.Visible = true;
            CargarTurnosEnTLP(_fechaSeleccionada);
        }

        // AGENDA
        private void CargarTurnosEnTLP(DateTime fecha)
        {

            // Configurar el Panel de scroll correctamente
            AgendaScroll.AutoSize = false;
            AgendaScroll.AutoScroll = true;
            AgendaScroll.Dock = DockStyle.Fill;

            // Configurar el TableLayoutPanel de datos
            AgendaDataTLP.Dock = DockStyle.Top;
            AgendaDataTLP.AutoSize = true;

            AgendaDataTLP.Controls.Clear();
            AgendaDataTLP.RowStyles.Clear();
            AgendaDataTLP.RowCount = 0;

            AgendaDataTLP.ColumnCount = AgendaHeadersTLP.ColumnCount;
            for (int i = 0; i < AgendaDataTLP.ColumnCount; i++)
            {
                AgendaDataTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / AgendaDataTLP.ColumnCount));
            }

            var turnosDelDia = _profesionalSeleccionado.AgendaMedica
                .Where(t => t.FechaTurno.Date == fecha.Date)
                .OrderBy(t => t.FechaTurno)
                .ToList();

            if (turnosDelDia.Count == 0)
            {
                AgendaDataTLP.RowCount = 1;
                AgendaDataTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 35));

                Label lblMensaje = new Label();
                lblMensaje.Text = "No hay turnos para este día";
                lblMensaje.Dock = DockStyle.Fill;
                lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
                lblMensaje.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Italic);
                lblMensaje.ForeColor = Color.White;
                lblMensaje.BackColor = PaletaColores.celeste;

                AgendaDataTLP.Controls.Add(lblMensaje, 0, 0);
                AgendaDataTLP.SetColumnSpan(lblMensaje, 5);
            }
            else
            {
                AgendaDataTLP.RowCount = turnosDelDia.Count;

                int anchoTotal = AgendaDataTLP.Width;
                int anchoPorColumna = anchoTotal / AgendaDataTLP.ColumnCount;

                for (int i = 0; i < turnosDelDia.Count; i++)
                {
                    AgendaDataTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 35));

                    var turno = turnosDelDia[i];

                    Label lblFecha = CrearLabelDato(turno.FechaTurno.ToString("dd/MM"), anchoPorColumna);
                    Label lblHora = CrearLabelDato(turno.FechaTurno.ToString("HH:mm"), anchoPorColumna);
                    Label lblEstado = CrearLabelDato(EnumHelper.GetDescription(turno.Estado), anchoPorColumna);

                    Button btnVer = CrearBotonVer(turno);
                    Button btnEliminar = CrearBotonEliminar(turno);

                    AgendaDataTLP.Controls.Add(lblFecha, 0, i);
                    AgendaDataTLP.Controls.Add(lblHora, 1, i);
                    AgendaDataTLP.Controls.Add(lblEstado, 2, i);
                    AgendaDataTLP.Controls.Add(btnVer, 3, i);
                    AgendaDataTLP.Controls.Add(btnEliminar, 4, i);
                }
            }

            bool scrollActivo = AgendaScroll.VerticalScroll.Visible;

            if (scrollActivo)
            {
                AgendaHeadersTLP.Margin = new Padding(0, 0, 20, 0);
            }
            else
            {
                AgendaHeadersTLP.Margin = new Padding(0, 0, 0, 0);
            }

            AgendaContainerTLP.Height = calendarDaysTLP.Height;
            AgendaDataTLP.Dock = DockStyle.Top;

            AgendaScroll.AutoScroll = true;

            AjustarAlturaAgenda();
        }

        private void AjustarAlturaAgenda()
        {
            AgendaContainerTLP.Height = calendarDaysTLP.Height;
        }

        private Label CrearLabelDato(string texto, int anchoDisponible = 0)
        {
            Label label = new Label();
            label.Text = texto;
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Regular);
            label.BackColor = Color.White;
            label.ForeColor = Color.Black;
            label.Margin = new Padding(0);

            if (anchoDisponible == 0)
                anchoDisponible = 80;

            bool textoCabe = TextoCabeEnEspacio(texto, Fuente.L, anchoDisponible);

            if (!textoCabe)
            {
                label.Text = AbreviarEstado(texto);
                label.Font = new Font(Fuente.TIPOGRAFIA, Fuente.M, FontStyle.Regular);

                bool abreviadoCabe = TextoCabeEnEspacio(label.Text, Fuente.M, anchoDisponible);
                if (!abreviadoCabe)
                {
                    label.Font = new Font(Fuente.TIPOGRAFIA, Fuente.S, FontStyle.Regular);
                }
            }

            return label;
        }

        private bool TextoCabeEnEspacio(string texto, float tamanoFuente, int anchoDisponible)
        {
            using (var font = new Font(Fuente.TIPOGRAFIA, tamanoFuente, FontStyle.Regular))
            using (var graphics = CreateGraphics())
            {
                SizeF tamañoTexto = graphics.MeasureString(texto, font);
                return tamañoTexto.Width <= (anchoDisponible - 10);
            }
        }

        private string AbreviarEstado(string estado)
        {
            switch (estado.ToUpper())
            {
                case "DISPONIBLE": return "Disp.";
                case "ASIGNADO": return "Asig.";
                case "ABONADO": return "Abon.";
                case "EN ATENCION": return "Atenc.";
                case "FINALIZADO": return "Final.";
                default: return estado.Length > 8 ? estado.Substring(0, 7) + "." : estado;
            }
        }

        private Button CrearBotonVer(E_Turno turno)
        {
            Button btn = new Button();
            btn.Dock = DockStyle.Fill;
            btn.BackgroundImage = Properties.Resources.icon_editar;
            btn.BackgroundImageLayout = ImageLayout.Zoom;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.White;
            btn.Margin = new Padding(0);
            btn.Padding = new Padding(0);
            btn.Tag = turno;
            btn.Click += (sender, e) => VerDetalleTurno(turno);
            return btn;
        }

        private Button CrearBotonEliminar(E_Turno turno)
        {
            Button btn = new Button();
            btn.Dock = DockStyle.Fill;
            btn.BackgroundImage = Properties.Resources.icon_borrar;
            btn.BackgroundImageLayout = ImageLayout.Zoom;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.White;
            btn.Margin = new Padding(0);
            btn.Padding = new Padding(0);
            btn.Tag = turno;
            btn.Click += (sender, e) => EliminarTurno(turno);
            return btn;
        }

        private void VerDetalleTurno(E_Turno turno)
        {
            try
            {
                var turnoActualizado = TurnoService.ObtenerTurnoPorID(turno.IdTurno);

                if (turnoActualizado != null)
                {
                    AdmGTDetalleTurno admGTDetalleTurno = new AdmGTDetalleTurno(turnoActualizado);
                    this.Hide();
                    admGTDetalleTurno.FormClosed += (s, args) => this.Close();
                    admGTDetalleTurno.Show();
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el turno seleccionado.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el turno: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarTurno(E_Turno turno)
        {
            switch (turno.Estado)
            {
                case EstadoTurno.DISPONIBLE:
                    var result = MessageBox.Show(
                        "¿Está seguro que desea eliminar este turno disponible?",
                        "Confirmar Eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        EliminarTurnoDeSistema(turno);
                    }
                    break;

                case EstadoTurno.ASIGNADO:
                    MessageBox.Show(
                        "No se puede eliminar un turno asignado.\nDebe reprogramar el turno primero.",
                        "No se puede eliminar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    break;

                case EstadoTurno.ABONADO:
                    MessageBox.Show(
                        "No se puede eliminar un turno abonado.",
                        "No se puede eliminar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    break;

                case EstadoTurno.EN_ATENCION:
                    MessageBox.Show(
                        "No se puede eliminar un turno en atención.",
                        "No se puede eliminar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    break;

                case EstadoTurno.FINALIZADO:
                    MessageBox.Show(
                        "No se puede eliminar un turno finalizado.",
                        "No se puede eliminar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    break;
            }
        }

        private void EliminarTurnoDeSistema(E_Turno turno)
        {
            ProfesionalService.EliminarTurnoDeAgenda(_profesionalSeleccionado, turno);

            MessageBox.Show("Turno eliminado correctamente", "Éxito",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Recargar los turnos
            if (_profesionalSeleccionado != null)
            {
                CargarTurnosEnTLP(DateTime.Now.Date);
            }
        }


        // BOTONES

        // Generar Agenda
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (_profesionalSeleccionado == null)
            {
                MessageBox.Show("Por favor, seleccione un profesional primero.", "Atención",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!AgendaContainerTLP.Visible)
            {
                MessageBox.Show("Por favor, seleccione un día del calendario primero.", "Atención",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_fechaSeleccionada == DateTime.MinValue)
            {
                MessageBox.Show("No hay una fecha válida seleccionada.", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var turnosExistentes = _profesionalSeleccionado.AgendaMedica
                .Where(t => t.FechaTurno.Date == _fechaSeleccionada.Date)
                .ToList();

            if (turnosExistentes.Count > 0)
            {
                MessageBox.Show($"Ya existe una agenda generada para el día {_fechaSeleccionada:dd/MM/yyyy}.\n" +
                               $"Cantidad de turnos existentes: {turnosExistentes.Count}",
                               "Agenda ya generada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DayOfWeek diaSemana = _fechaSeleccionada.DayOfWeek;
            bool tieneDisponibilidad = _profesionalSeleccionado.Disponibilidades
                .Any(d => d.Dia == diaSemana);

            if (!tieneDisponibilidad)
            {
                MessageBox.Show($"El profesional no tiene disponibilidad para el dia seleccionado.",
                               "Sin disponibilidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro que desea generar la agenda para el día {_fechaSeleccionada:dd/MM/yyyy}?\n" +
                $"Profesional: {_profesionalSeleccionado.NombreCompleto}\n",
                "Confirmar Generación de Agenda",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                GenerarAgendaParaDiaSeleccionado();
            }
        }

            private void GenerarAgendaParaDiaSeleccionado()
        {
            try
            {
                ShowLoading(true);

                DateOnly diaDateOnly = DateOnly.FromDateTime(_fechaSeleccionada);

                TurnoService.CrearAgendaMedica(_profesionalSeleccionado, diaDateOnly);

                MessageBox.Show($"Agenda generada exitosamente para el día {_fechaSeleccionada:dd/MM/yyyy}",
                               "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarTurnosEnTLP(_fechaSeleccionada);
                ColorearCalendarioSegunProfesional(_profesionalSeleccionado, _fechaSeleccionada.Year, _fechaSeleccionada.Month);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar la agenda: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ShowLoading(false);
            }
        }

        // Eliminar Agenda

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_profesionalSeleccionado == null)
            {
                MessageBox.Show("Por favor, seleccione un profesional primero.", "Atención",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!AgendaContainerTLP.Visible || _fechaSeleccionada == DateTime.MinValue)
            {
                MessageBox.Show("Por favor, seleccione un día del calendario primero.", "Atención",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var turnosDelDia = _profesionalSeleccionado.AgendaMedica
                .Where(t => t.FechaTurno.Date == _fechaSeleccionada.Date)
                .ToList();

            if (turnosDelDia.Count == 0)
            {
                MessageBox.Show($"No existen turnos para eliminar en el día {_fechaSeleccionada:dd/MM/yyyy}.",
                               "Sin turnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var turnosNoDisponibles = turnosDelDia
                .Where(t => t.Estado != EstadoTurno.DISPONIBLE)
                .ToList();

            if (turnosNoDisponibles.Count > 0)
            {
                string mensaje = $"No se puede eliminar la agenda del día {_fechaSeleccionada:dd/MM/yyyy} porque hay turnos que no están disponibles:\n\n";

                foreach (var turno in turnosNoDisponibles)
                {
                    mensaje += $"• Turno {turno.FechaTurno:HH:mm} - Estado: {EnumHelper.GetDescription(turno.Estado)}\n";
                }

                mensaje += $"\nTotal de turnos no disponibles: {turnosNoDisponibles.Count}";

                MessageBox.Show(mensaje, "No se puede eliminar agenda",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro que desea ELIMINAR TODOS los turnos del día {_fechaSeleccionada:dd/MM/yyyy}?\n" +
                $"Profesional: {_profesionalSeleccionado.NombreCompleto}\n" +
                $"Cantidad de turnos a eliminar: {turnosDelDia.Count}\n\n" +
                $"⚠️  Esta acción no se puede deshacer.",
                "Confirmar Eliminación de Agenda",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                EliminarAgendaDelDiaSeleccionado(turnosDelDia);
            }
        }

            private void EliminarAgendaDelDiaSeleccionado(List<E_Turno> turnosAEliminar)
        {
            try
            {
                ShowLoading(true);

                foreach (var turno in turnosAEliminar)
                {
                    ProfesionalService.EliminarTurnoDeAgenda(_profesionalSeleccionado, turno);

                    TurnoService.EliminarTurno(turno);
                }

                MessageBox.Show($"Agenda eliminada exitosamente para el día {_fechaSeleccionada:dd/MM/yyyy}\n" +
                               $"Turnos eliminados: {turnosAEliminar.Count}",
                               "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarTurnosEnTLP(_fechaSeleccionada);
                ColorearCalendarioSegunProfesional(_profesionalSeleccionado, _fechaSeleccionada.Year, _fechaSeleccionada.Month);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la agenda: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ShowLoading(false);
            }
        }

        // Generar Sobre Turno
        private void btnSobreturno_Click(object sender, EventArgs e)
        {
            if (_profesionalSeleccionado == null)
            {
                MessageBox.Show("Por favor, seleccione un profesional primero.", "Atención",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!AgendaContainerTLP.Visible || _fechaSeleccionada == DateTime.MinValue)
            {
                MessageBox.Show("Por favor, seleccione un día del calendario primero.", "Atención",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var turnosDelDia = _profesionalSeleccionado.AgendaMedica
                .Where(t => t.FechaTurno.Date == _fechaSeleccionada.Date)
                .ToList();

            if (turnosDelDia.Count == 0)
            {
                MessageBox.Show("No existe agenda médica para el día seleccionado.", "Sin agenda",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MostrarDialogoSobreturno();
        }

            // Dialog y Creacion del Sobreturno
            private void MostrarDialogoSobreturno()
            {
                using (var dialog = new AuxSobreturnoDialog())
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        CrearSobreturno(dialog.PacienteEncontrado, dialog.HoraSobreturno);
                    }
                }
            }

            private void CrearSobreturno(E_Paciente paciente, TimeSpan hora)
            {
                try
                {
                    TimeSpan duracion;
                    decimal valorConsulta;

                    switch (_profesionalSeleccionado.Especialidad)
                    {
                        case EspecialidadMedica.NEUROLOGIA:
                            duracion = new TimeSpan(0, 45, 0);
                            valorConsulta = 5000m;
                            break;
                        case EspecialidadMedica.UROLOGIA:
                            duracion = new TimeSpan(0, 30, 0);
                            valorConsulta = 4000m;
                            break;
                        default:
                            duracion = new TimeSpan(0, 15, 0);
                            valorConsulta = 3000m;
                            break;
                    }

                    DateTime fechaTurno = _fechaSeleccionada.Date.Add(hora);

                    E_Turno sobreturno = new E_Turno(
                        DDBB_Simulation.TurnosDB.Count + 1,
                        fechaTurno,
                        _profesionalSeleccionado.IdProfesional,
                        valorConsulta
                    );

                    sobreturno.IdPaciente = paciente.IdPaciente;
                    sobreturno.Estado = EstadoTurno.ASIGNADO;

                    TurnoService.GuardarTurno(sobreturno);

                    ProfesionalService.AgregarTurnoEnAgenda(_profesionalSeleccionado, sobreturno);

                    paciente.Reservas.Add(sobreturno);

                    MessageBox.Show($"Sobreturno creado exitosamente para:\n" +
                                   $"Paciente: {paciente.NombreCompleto}\n" +
                                   $"Fecha: {fechaTurno:dd/MM/yyyy HH:mm}\n" +
                                   $"Profesional: {_profesionalSeleccionado.NombreCompleto}",
                                   "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarTurnosEnTLP(_fechaSeleccionada);
                    ColorearCalendarioSegunProfesional(_profesionalSeleccionado, _fechaSeleccionada.Year, _fechaSeleccionada.Month);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear el sobreturno: {ex.Message}", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                    "Desea salir de la Pantalla y volver a Turnos?",
                    "Confirmar Asignación",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                );

            if (resultado == DialogResult.Cancel)
            {
                return;
            }

            AdmGestionTurnos admGestionTurnos = new AdmGestionTurnos();
            this.Hide();
            admGestionTurnos.FormClosed += (s, args) => this.Close();
            admGestionTurnos.Show();
        }



        private async void btnBuscarProf_Click(object sender, EventArgs e)
        {
            if (profesionalCbx.SelectedItem == null || profesionalCbx.SelectedItem.ToString() == String.Empty)
            {
                MessageBox.Show("Por favor, seleccione un profesional.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ShowLoading(true);

            AgendaContainerTLP.Visible = false;

            try
            {
                var nombreProf = profesionalCbx.SelectedItem.ToString();

                await Task.Run(() =>
                {
                    var profesional = ProfesionalService.ObtenerProfesionalPorNombreCompleto(nombreProf);

                    this.Invoke(new Action(() =>
                    {
                        if (profesional != null)
                        {
                            CargarCalendarioCompleto(profesional);
                        }
                        else
                        {
                            MessageBox.Show("Profesional no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }));
                });
            }
            finally
            {
                ShowLoading(false);
            }
        }

        private void btnMesAnterior_Click(object sender, EventArgs e)
        {
            if (_profesionalSeleccionado == null) return;

            _fechaActual = _fechaActual.AddMonths(-1);
            ActualizarVistaCalendario();
        }

        private void btnMesSiguiente_Click(object sender, EventArgs e)
        {
            if (_profesionalSeleccionado == null) return;

            _fechaActual = _fechaActual.AddMonths(1);
            ActualizarVistaCalendario();
        }

            private void ActualizarVistaCalendario()
            {
                lblMes.Text = _fechaActual.ToString("MMMM yyyy").ToUpper();
                PoblarEstructuraBasicaCalendario(_fechaActual.Year, _fechaActual.Month);
                ColorearCalendarioSegunProfesional(_profesionalSeleccionado, _fechaActual.Year, _fechaActual.Month);

                AgendaContainerTLP.Visible = false;
            }

    }
}
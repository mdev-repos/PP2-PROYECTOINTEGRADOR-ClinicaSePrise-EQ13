using ClinicaSePriseApp.Datos;
using ClinicaSePriseApp.Entidades;
using ClinicaSePriseApp.Servicios;
using ClinicaSePriseApp.Utilidades;
using ClinicaSePriseApp.Vistas.Auxiliares;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ClinicaSePriseApp.Vistas
{
    public partial class AdmGestionConsultorios : Form
    {
        private DataGridView dgvConsultorios;
        private List<E_Consultorio> consultorios;
        private List<E_Profesional> profesionales;
        private Panel _loadingPanel;
        private Label _loadingLabel;

        public AdmGestionConsultorios()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            this.Size = new Size(1024, 768);
            this.MinimumSize = new Size(1024, 768);
            this.WindowState = FormWindowState.Maximized;

            this.Load += AdmGestionConsultorios_Load;
            this.Resize += AdmGestionConsultorios_Resize;

            btnAsignarLiberar.Click += btnAsignarLiberar_Click;
            btnVolver.Click += btnVolver_Click;

            InitializeLoadingPanel();
        }

        private void AdmGestionConsultorios_Load(object sender, EventArgs e)
        {
            ShowLoading(true);

            try
            {
                ajustarPaneles();
                InicializarControles();
                ConfigurarGrid();
                InicializarConsultorios();
                CargarConsultorios();
                AjustarColumnasDGV();
            }
            finally
            {
                ShowLoading(false);
            }

            AjustarLayout();
        }

        private void AdmGestionConsultorios_Resize(object sender, EventArgs e)
        {
            ajustarPaneles();
            AjustarLayout();

            if (_loadingPanel?.Visible == true)
            {
                _loadingPanel.Location = new Point(
                    (this.ClientSize.Width - _loadingPanel.Width) / 2,
                    (this.ClientSize.Height - _loadingPanel.Height) / 2
                );
            }

            if (dgvConsultorios.Rows.Count > 0)
            {
                AjustarColumnasDGV();
            }
        }

        private void ajustarPaneles()
        {
            mainTLP.BackColor = PaletaColores.celeste;
            menuTLP.BackColor = PaletaColores.bgGris;
            contentLbl.BackColor = PaletaColores.bgGris;
            contentLbl.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XXL, FontStyle.Bold);
            dgvConsultorios.BackgroundColor = PaletaColores.celeste;

            foreach (Control boton in menuTLP.Controls)
            {
                boton.Dock = DockStyle.Fill;

                if (boton == btnVolver)
                    boton.BackColor = PaletaColores.rosa;
                else if (boton == picLogo)
                    boton.BackColor = Color.Transparent;
                else
                    boton.BackColor = PaletaColores.azulOscuro;

                boton.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);
                boton.ForeColor = Color.White;
            }

            btnAsignarLiberar.BackColor = PaletaColores.azulOscuro;
            btnAsignarLiberar.ForeColor = Color.White;
            btnAsignarLiberar.FlatStyle = FlatStyle.Flat;
            btnAsignarLiberar.FlatAppearance.BorderSize = 0;
            btnAsignarLiberar.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);
        }

        private void AjustarLayout()
        {
            if (dgvConsultorios != null)
            {
                dgvConsultorios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                dgvConsultorios.Location = new Point(20, 20);
                dgvConsultorios.Size = new Size(this.ClientSize.Width - 40, this.ClientSize.Height - 150);
            }

            btnAsignarLiberar.Location = new Point(
                this.ClientSize.Width - btnAsignarLiberar.Width - 40,
                this.ClientSize.Height - btnAsignarLiberar.Height - 40
            );

            btnVolver.Location = new Point(
                40,
                this.ClientSize.Height - btnVolver.Height - 40
            );
        }

        private void InitializeLoadingPanel()
        {
            _loadingPanel = new Panel
            {
                Size = new Size(300, 80),
                BackColor = PaletaColores.azulClaro,
                BorderStyle = BorderStyle.FixedSingle,
                Visible = false
            };

            _loadingLabel = new Label
            {
                Text = "CARGANDO CONSULTORIOS...",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                Font = new Font(Fuente.TIPOGRAFIA, Fuente.XXL, FontStyle.Bold),
                ForeColor = Color.White
            };

            _loadingPanel.Controls.Add(_loadingLabel);
            this.Controls.Add(_loadingPanel);
            _loadingPanel.BringToFront();
        }

        private void ShowLoading(bool show)
        {
            if (_loadingPanel == null) return;

            if (show)
            {
                _loadingPanel.Location = new Point(
                    (this.ClientSize.Width - _loadingPanel.Width) / 2,
                    (this.ClientSize.Height - _loadingPanel.Height) / 2
                );
            }

            _loadingPanel.Visible = show;
            _loadingPanel.BringToFront();

            dgvConsultorios.Enabled = !show;
            btnAsignarLiberar.Enabled = !show;
            btnVolver.Enabled = !show;
        }

        private void InicializarControles()
        {
            dgvConsultorios.ReadOnly = false;
            dgvConsultorios.AllowUserToAddRows = false;
            dgvConsultorios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultorios.MultiSelect = false;

            dgvConsultorios.EditingControlShowing += dgvConsultorios_EditingControlShowing;
            dgvConsultorios.CellFormatting += dgvConsultorios_CellFormatting;
            dgvConsultorios.CellContentClick += dgvConsultorios_CellContentClick;

            dgvConsultorios.CurrentCellDirtyStateChanged += (s, e) =>
            {
                if (dgvConsultorios.IsCurrentCellDirty)
                    dgvConsultorios.CommitEdit(DataGridViewDataErrorContexts.Commit);
            };
        }

        private void ConfigurarGrid()
        {
            dgvConsultorios.AutoGenerateColumns = false;
            dgvConsultorios.Columns.Clear();

            // ID Consultorio
            dgvConsultorios.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                Name = "colId",
                ReadOnly = true
            });

            // Profesional
            var colProfesional = new DataGridViewComboBoxColumn
            {
                HeaderText = "PROFESIONAL",
                DataPropertyName = "IdProfesional",
                Name = "colProfesional",
                DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton
            };
            dgvConsultorios.Columns.Add(colProfesional);

            // Especialidad
            dgvConsultorios.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ESPECIALIDAD",
                Name = "colEspecialidad",
                ReadOnly = true
            });

            // Estado
            dgvConsultorios.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ESTADO",
                Name = "colEstado",
                ReadOnly = true
            });

            // Insumos
            dgvConsultorios.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = "INSUMOS",
                Name = "colInsumos",
                Text = "VER",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat
            });
        }

        private void AjustarColumnasDGV()
        {
            if (dgvConsultorios.Columns.Count > 0)
            {
                int fontSize = CalcularTamanoFuente();

                dgvConsultorios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dgvConsultorios.Columns.Contains("colId"))
                {
                    dgvConsultorios.Columns["colId"].FillWeight = 10;
                    dgvConsultorios.Columns["colId"].HeaderText = "ID";
                }

                if (dgvConsultorios.Columns.Contains("colProfesional"))
                {
                    dgvConsultorios.Columns["colProfesional"].FillWeight = 35;
                    dgvConsultorios.Columns["colProfesional"].HeaderText = "PROFESIONAL";
                }

                if (dgvConsultorios.Columns.Contains("colEspecialidad"))
                {
                    dgvConsultorios.Columns["colEspecialidad"].FillWeight = 25;
                    dgvConsultorios.Columns["colEspecialidad"].HeaderText = "ESPECIALIDAD";
                }

                if (dgvConsultorios.Columns.Contains("colEstado"))
                {
                    dgvConsultorios.Columns["colEstado"].FillWeight = 15;
                    dgvConsultorios.Columns["colEstado"].HeaderText = "ESTADO";
                }

                if (dgvConsultorios.Columns.Contains("colInsumos"))
                {
                    dgvConsultorios.Columns["colInsumos"].FillWeight = 15;
                    dgvConsultorios.Columns["colInsumos"].HeaderText = "INSUMOS";
                }

                dgvConsultorios.EnableHeadersVisualStyles = false;

                dgvConsultorios.ColumnHeadersDefaultCellStyle.BackColor = PaletaColores.azulClaro;
                dgvConsultorios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvConsultorios.ColumnHeadersDefaultCellStyle.Font = new Font(Fuente.TIPOGRAFIA, fontSize, FontStyle.Bold);

                dgvConsultorios.DefaultCellStyle.SelectionBackColor = PaletaColores.verdeOscuro;

                dgvConsultorios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                dgvConsultorios.ColumnHeadersHeight = 35 + (fontSize - 8);

                foreach (DataGridViewColumn col in dgvConsultorios.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.DefaultCellStyle.Font = new Font(Fuente.TIPOGRAFIA, fontSize - 0.5f);
                }

                dgvConsultorios.RowTemplate.Height = 25 + (fontSize - 8);

                dgvConsultorios.RowHeadersVisible = false;
                dgvConsultorios.BorderStyle = BorderStyle.None;
                dgvConsultorios.GridColor = Color.LightGray;

                dgvConsultorios.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
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

        private void InicializarConsultorios()
        {
            try
            {
                profesionales = ProfesionalService.ObtenerTodosLosProfesionales() ?? new List<E_Profesional>();
            }
            catch
            {
                MessageBox.Show("Error al cargar profesionales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                profesionales = new List<E_Profesional>();
            }

            consultorios = Enumerable.Range(1, 10)
                .Select(i => new E_Consultorio
                {
                    IdConsultorio = i,
                    IdProfesional = 0,
                    Insumos = new List<E_Insumo>()
                })
                .ToList();
        }

        private void CargarConsultorios()
        {
            var comboCol = (DataGridViewComboBoxColumn)dgvConsultorios.Columns["colProfesional"];
            comboCol.DataSource = profesionales;
            comboCol.DisplayMember = "NombreCompleto";
            comboCol.ValueMember = "IdProfesional";

            dgvConsultorios.Rows.Clear();

            foreach (var c in consultorios)
            {
                int index = dgvConsultorios.Rows.Add();
                var row = dgvConsultorios.Rows[index];
                row.Cells["colId"].Value = c.IdConsultorio;

                if (c.IdProfesional > 0)
                {
                    var prof = profesionales.FirstOrDefault(p => p.IdProfesional == c.IdProfesional);
                    row.Cells["colProfesional"].Value = prof?.IdProfesional;
                    row.Cells["colEspecialidad"].Value = prof != null ? EnumHelper.GetDescription(prof.Especialidad) : "";
                    row.Cells["colEstado"].Value = "OCUPADO";
                }
                else
                {
                    row.Cells["colProfesional"].Value = null;
                    row.Cells["colEspecialidad"].Value = "";
                    row.Cells["colEstado"].Value = "DISPONIBLE";
                }
            }
        }

        private void dgvConsultorios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvConsultorios.Rows.Count) return;

            var row = dgvConsultorios.Rows[e.RowIndex];

            // Formatear columna de estado
            if (dgvConsultorios.Columns[e.ColumnIndex].Name == "colEstado")
            {
                string estado = row.Cells["colEstado"].Value?.ToString() ?? "";
                if (estado == "OCUPADO")
                {
                    row.Cells["colEstado"].Style.ForeColor = Color.Red;
                    row.Cells["colEstado"].Style.Font = new Font(Fuente.TIPOGRAFIA, CalcularTamanoFuente() - 0.5f, FontStyle.Bold);
                }
                else
                {
                    row.Cells["colEstado"].Style.ForeColor = PaletaColores.verdeClaro;
                    row.Cells["colEstado"].Style.Font = new Font(Fuente.TIPOGRAFIA, CalcularTamanoFuente() - 0.5f, FontStyle.Bold);
                }
            }

            // Formatear botón de insumos
            if (dgvConsultorios.Columns[e.ColumnIndex].Name == "colInsumos")
            {
                string estado = row.Cells["colEstado"].Value?.ToString() ?? "";
                var cell = (DataGridViewButtonCell)row.Cells["colInsumos"];

                if (estado == "OCUPADO")
                {
                    cell.Style.BackColor = PaletaColores.azulClaro;
                    cell.Style.ForeColor = Color.White;
                    cell.Style.SelectionBackColor = PaletaColores.azulOscuro;
                    cell.Style.Font = new Font(Fuente.TIPOGRAFIA, CalcularTamanoFuente() - 1, FontStyle.Bold);
                }
                else
                {
                    cell.Style.BackColor = Color.LightGray;
                    cell.Style.ForeColor = Color.DarkGray;
                    cell.Style.Font = new Font(Fuente.TIPOGRAFIA, CalcularTamanoFuente() - 1, FontStyle.Regular);
                }
            }
        }

        private void dgvConsultorios_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvConsultorios.CurrentCell.OwningColumn.Name == "colProfesional" && e.Control is ComboBox combo)
            {
                combo.SelectedIndexChanged -= ProfesionalCombo_SelectedIndexChanged;
                combo.SelectedIndexChanged += ProfesionalCombo_SelectedIndexChanged;
            }
        }

        private void ProfesionalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is not ComboBox combo || combo.SelectedValue is not int idProfesional)
                return;

            var profesional = profesionales.FirstOrDefault(p => p.IdProfesional == idProfesional);
            if (profesional == null || dgvConsultorios.CurrentCell == null)
                return;

            int rowIndex = dgvConsultorios.CurrentCell.RowIndex;
            dgvConsultorios.Rows[rowIndex].Cells["colEspecialidad"].Value =
                EnumHelper.GetDescription(profesional.Especialidad);
        }

        private void dgvConsultorios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvConsultorios.Columns[e.ColumnIndex].Name != "colInsumos")
                return;

            var row = dgvConsultorios.Rows[e.RowIndex];
            string estado = row.Cells["colEstado"].Value?.ToString() ?? "";

            if (estado != "OCUPADO")
            {
                MessageBox.Show("Solo se pueden gestionar insumos en consultorios ocupados.", "Información",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int idConsultorio = Convert.ToInt32(row.Cells["colId"].Value);
            var consultorio = consultorios.First(c => c.IdConsultorio == idConsultorio);

            // Abrir pantalla de gestión de insumos del consultorio
            using (var formInsumos = new AuxCargaGenerica(consultorio))
            {
                formInsumos.ShowDialog();
            }
        }

        private void btnAsignarLiberar_Click(object sender, EventArgs e)
        {
            if (dgvConsultorios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un consultorio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dgvConsultorios.CurrentRow;
            int idConsultorio = Convert.ToInt32(row.Cells["colId"].Value);
            var consultorio = consultorios.First(c => c.IdConsultorio == idConsultorio);

            if (consultorio.IdProfesional == 0)
            {
                if (row.Cells["colProfesional"].Value == null)
                {
                    MessageBox.Show("Seleccione un profesional antes de asignar.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idProfesionalSeleccionado = Convert.ToInt32(row.Cells["colProfesional"].Value);

                bool yaAsignado = consultorios.Any(c => c.IdProfesional == idProfesionalSeleccionado);
                if (yaAsignado)
                {
                    MessageBox.Show("Este profesional ya está asignado a otro consultorio.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                consultorio.IdProfesional = idProfesionalSeleccionado;
                row.Cells["colEstado"].Value = "OCUPADO";
                MessageBox.Show($"Consultorio {idConsultorio} asignado correctamente.", "Asignación exitosa");
            }
            else
            {
                consultorio.IdProfesional = 0;
                row.Cells["colProfesional"].Value = null;
                row.Cells["colEspecialidad"].Value = "";
                row.Cells["colEstado"].Value = "DISPONIBLE";
                MessageBox.Show($"Consultorio {idConsultorio} liberado.", "Liberación exitosa");
            }

            dgvConsultorios.Refresh();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DashAdmin dashAdmin = new DashAdmin();
            this.Hide();
            dashAdmin.FormClosed += (s, args) => this.Close();
            dashAdmin.Show();
        }
    }
}
using ClinicaSePriseApp.Datos;
using ClinicaSePriseApp.Entidades;
using ClinicaSePriseApp.Servicios;
using ClinicaSePriseApp.Utilidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ClinicaSePriseApp.Vistas
{
    public partial class AdmGestionConsultorios : Form
    {
        private DataGridView dgvConsultorios; // ⚠️ Declaración mantenida, pero no inicializada manualmente (viene del diseñador)
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

            btnAsignarLiberar.Click -= btnAsignarLiberar_Click;
            btnAsignarLiberar.Click += btnAsignarLiberar_Click;

            btnVolver.Click -= btnVolver_Click;
            btnVolver.Click += btnVolver_Click;

            InitializeLoadingPanel();
            ConfigurarBotonesPrincipales();
        }

        private void AdmGestionConsultorios_Load(object sender, EventArgs e)
        {
            ShowLoading(true);

            try
            {
                InicializarControles();
                ConfigurarGrid();
                InicializarConsultorios();
                CargarConsultorios();
                ConfigurarComportamientoVisualGrilla();
            }
            finally
            {
                ShowLoading(false);
            }

            AjustarLayout();
        }

        private void AdmGestionConsultorios_Resize(object sender, EventArgs e)
        {
            AjustarLayout();

            if (_loadingPanel?.Visible == true)
            {
                _loadingPanel.Location = new Point(
                    (this.ClientSize.Width - _loadingPanel.Width) / 2,
                    (this.ClientSize.Height - _loadingPanel.Height) / 2
                );
            }
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
                Size = new Size(280, 80),
                BackColor = Color.FromArgb(0, 123, 255),
                BorderStyle = BorderStyle.FixedSingle,
                Visible = false
            };

            _loadingLabel = new Label
            {
                Text = "CARGANDO CONSULTORIOS...",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
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

        private void ConfigurarBotonesPrincipales()
        {
            // Botón Asignar/Liberar
            btnAsignarLiberar.BackColor = Color.FromArgb(0, 123, 255);
            btnAsignarLiberar.ForeColor = Color.White;
            btnAsignarLiberar.FlatStyle = FlatStyle.Flat;
            btnAsignarLiberar.FlatAppearance.BorderSize = 0;
            btnAsignarLiberar.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            // Botón Volver
            btnVolver.BackColor = Color.FromArgb(220, 53, 69);
            btnVolver.ForeColor = Color.White;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        }

        private void ConfigurarComportamientoVisualGrilla()
        {
            dgvConsultorios.AllowUserToResizeRows = false;
            dgvConsultorios.AllowUserToResizeColumns = false;
            dgvConsultorios.RowHeadersVisible = false;
            dgvConsultorios.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvConsultorios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvConsultorios.ScrollBars = ScrollBars.Vertical;
            dgvConsultorios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultorios.BorderStyle = BorderStyle.FixedSingle;
            dgvConsultorios.BackgroundColor = Color.White;
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

            // Profesional
            var colProfesional = new DataGridViewComboBoxColumn
            {
                HeaderText = "Profesional",
                DataPropertyName = "IdProfesional",
                Name = "colProfesional",
                DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton
            };
            dgvConsultorios.Columns.Add(colProfesional);

            // Especialidad
            dgvConsultorios.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Especialidad",
                Name = "colEspecialidad"
            });

            // ID Consultorio
            dgvConsultorios.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID Consultorio",
                Name = "colId"
            });

            // Estado
            dgvConsultorios.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Estado",
                Name = "colEstado"
            });

            // Insumos
            dgvConsultorios.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = "Insumos",
                Name = "colInsumos",
                Text = "Ver",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat
            });
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
                    row.Cells["colEstado"].Value = "Ocupado";
                }
                else
                {
                    row.Cells["colProfesional"].Value = null;
                    row.Cells["colEspecialidad"].Value = "";
                    row.Cells["colEstado"].Value = "Disponible";
                }
            }
        }

        private void dgvConsultorios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvConsultorios.Columns[e.ColumnIndex].Name == "colInsumos")
            {
                var row = dgvConsultorios.Rows[e.RowIndex];
                var cell = (DataGridViewButtonCell)row.Cells["colInsumos"];
                string estado = row.Cells["colEstado"].Value?.ToString() ?? "";

                if (estado == "Ocupado")
                {
                    cell.Style.BackColor = Color.FromArgb(0, 123, 255);
                    cell.Style.ForeColor = Color.White;
                    cell.Style.SelectionBackColor = Color.FromArgb(0, 105, 217);
                }
                else
                {
                    cell.Style.BackColor = Color.LightGray;
                    cell.Style.ForeColor = Color.DarkGray;
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

            var idConsultorio = dgvConsultorios.Rows[e.RowIndex].Cells["colId"].Value;
            MessageBox.Show($"Abrir gestión de insumos del consultorio {idConsultorio}.", "Insumos");
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
                row.Cells["colEstado"].Value = "Ocupado";
                MessageBox.Show($"Consultorio {idConsultorio} asignado correctamente.", "Asignación exitosa");
            }
            else
            {
                consultorio.IdProfesional = 0;
                row.Cells["colProfesional"].Value = null;
                row.Cells["colEspecialidad"].Value = "";
                row.Cells["colEstado"].Value = "Disponible";
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

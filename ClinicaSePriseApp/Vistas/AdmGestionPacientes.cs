using ClinicaSePriseApp.Datos;
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
    public partial class AdmGestionPacientes : Form
    {
        public AdmGestionPacientes()
        {
            InitializeComponent();
        }

        private void AdmGestionPacientes_Load(object sender, EventArgs e)
        {
            MostrarPlaceholderDni();
            ConfigurarGrillaPacientes();
            CargarTodosLosPacientes();
            pacientesDgv.CellPainting += pacientesDgv_CellPainting;
        }

        private void MostrarPlaceholderDni()
        {
            if (string.IsNullOrWhiteSpace(txtDni.Text))
            {
                txtDni.Text = "DNI";
                txtDni.ForeColor = Color.Gray;
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            DashAdmin dashAdmin = new DashAdmin();
            this.Hide();
            dashAdmin.FormClosed += (s, args) => this.Close();
            dashAdmin.Show();
        }

        private void AjustarFondoGrilla()
        {
            if (pacientesDgv.Rows.Count <= 2)
            {
                pacientesDgv.BackgroundColor = Color.CornflowerBlue;
            }
            else
            {
                pacientesDgv.BackgroundColor = SystemColors.Window;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String dniIngresado = txtDni.Text.Trim();

            // Lógica para buscar el paciente por DNI
            if (string.IsNullOrEmpty(dniIngresado))
            {
                MessageBox.Show("Debe ingresar un DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDni.Focus();
                return;
            }
            txtDni.BackColor = SystemColors.Window;

            // Lógica para buscar el paciente en la base de datos
            var repo = new PacienteRepository();
            var paciente = repo.ObtenerPacientePorDNI(dniIngresado);

            if (paciente != null)
            {
                pacientesDgv.DataSource = new List<Entidades.E_Paciente> { paciente };
                AjustarFondoGrilla();
            }
            else
            {
                // Paciente no encontrado, mostrar mensaje de error
                MessageBox.Show("No se encontró ningún paciente con el DNI ingresado.", "Paciente no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarTodosLosPacientes();
                txtDni.Focus();
            }

        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            if (txtDni.Text == "DNI" || string.IsNullOrWhiteSpace(txtDni.Text))
            {
                txtDni.ForeColor = Color.Gray;
            }
            else
            {
                txtDni.ForeColor = Color.Black;
            }

        }

        private void txtDni_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtDni.Text == "DNI")
            {
                txtDni.Text = "";
                txtDni.ForeColor = Color.Black;
            }
        }

        private void txtDni_Leave(object sender, EventArgs e)
        {
            MostrarPlaceholderDni();
        }

        private void txtDni_Enter(object sender, EventArgs e)
        {
            if (txtDni.Text == "DNI")
            {
                txtDni.Text = "";
                txtDni.ForeColor = Color.Black;
            }
        }

        private void CargarTodosLosPacientes()
        {
            var repo = new PacienteRepository();
            var listaPacientes = repo.ObtenerTodosLosPacientes();
            pacientesDgv.DataSource = listaPacientes;
            AjustarFondoGrilla();
        }


        private void ConfigurarGrillaPacientes()
        {
            pacientesDgv.AutoGenerateColumns = false;
            pacientesDgv.Columns.Clear();
            pacientesDgv.Dock = DockStyle.Fill;

            AplicarEstiloGrilla(pacientesDgv);

            // Columnas de datos
            pacientesDgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Dni",
                HeaderText = "DNI",
                DataPropertyName = "Dni",
                SortMode = DataGridViewColumnSortMode.NotSortable
            });

            pacientesDgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NombreApellido",
                HeaderText = "NOMBRE y APELLIDO",
                DataPropertyName = "NombreCompleto",
                SortMode = DataGridViewColumnSortMode.NotSortable
            });

            pacientesDgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ObraSocial",
                HeaderText = "OBRA SOCIAL",
                DataPropertyName = "ObraSocial",
                SortMode = DataGridViewColumnSortMode.NotSortable
            });

            pacientesDgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NroAfiliado",
                HeaderText = "Nro AFILIADO",
                DataPropertyName = "numeroAfiliado",
                SortMode = DataGridViewColumnSortMode.NotSortable
            });

            pacientesDgv.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "btnVerTurnos",
                HeaderText = "TURNOS",
                Text = "Ver",
                UseColumnTextForButtonValue = true,
                SortMode = DataGridViewColumnSortMode.NotSortable
            });

            pacientesDgv.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "btnVerPagos",
                HeaderText = "PAGOS",
                Text = "Ver",
                UseColumnTextForButtonValue = true,
                SortMode = DataGridViewColumnSortMode.NotSortable
            });


        }

        private void AplicarEstiloGrilla(DataGridView dgv)
        {
            dgv.RowHeadersVisible = false;
            dgv.BackgroundColor = PaletaColores.bgCeleste;
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void pacientesDgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 &&
        (pacientesDgv.Columns[e.ColumnIndex].Name == "btnVerTurnos" || pacientesDgv.Columns[e.ColumnIndex].Name == "btnVerPagos"))
            {
                e.PaintBackground(e.CellBounds, true);

                Color botonColor = pacientesDgv.Columns[e.ColumnIndex].Name == "btnVerTurnos"
                    ? PaletaColores.btnAzul
                    : PaletaColores.btnVerde;

                using (Brush brush = new SolidBrush(botonColor))
                {
                    Rectangle rect = new Rectangle(e.CellBounds.Left + 6, e.CellBounds.Top + 4, e.CellBounds.Width - 12, e.CellBounds.Height - 8);
                    e.Graphics.FillRectangle(brush, rect);
                }

                const string textoBoton = "Ver";
                TextRenderer.DrawText(
                    e.Graphics,
                    textoBoton,
                    new Font(pacientesDgv.Font, FontStyle.Bold),
                    e.CellBounds,
                    Color.White,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );

                e.Handled = true;
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            AdmGPAltaPaciente altaPaciente = new AdmGPAltaPaciente();
            this.Hide();
            altaPaciente.FormClosed += (s, args) => this.Close();
            altaPaciente.Show();
        }

        private void btnModificarPaciente_Click(object sender, EventArgs e)
        {
            if (pacientesDgv.CurrentRow == null || pacientesDgv.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Debe seleccionar un paciente para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var pacienteSeleccionado = (Entidades.E_Paciente)pacientesDgv.CurrentRow.DataBoundItem;

            AdmGPModificarPaciente modificarPaciente = new AdmGPModificarPaciente(pacienteSeleccionado);
            modificarPaciente.FormClosed += (s, args) => this.Close();
            modificarPaciente.Show();
        }
    }
}

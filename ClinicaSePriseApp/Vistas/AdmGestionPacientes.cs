using ClinicaSePriseApp.Datos;
using ClinicaSePriseApp.Entidades;
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
    public partial class AdmGestionPacientes : Form
    {
        public AdmGestionPacientes()
        {
            InitializeComponent();

            ajustarPaneles();
        }

        private void AdmGestionPacientes_Load(object sender, EventArgs e)
        {
            MostrarPlaceholderDni();
            ConfigurarGrillaPacientes();
            CargarTodosLosPacientes();
            pacientesDgv.CellPainting += pacientesDgv_CellPainting;
        }

        private void ajustarPaneles()
        {
            mainTLP.BackColor = PaletaColores.celeste;
            menuTLP.BackColor = PaletaColores.bgGris;

            contentLbl.BackColor = PaletaColores.bgGris;
            contentLbl.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XXL, FontStyle.Bold);

            pacientesDgv.BorderStyle = BorderStyle.None;

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


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String dniIngresado = txtDni.Text.Trim();

            if (string.IsNullOrEmpty(dniIngresado))
            {
                MessageBox.Show("Debe ingresar un DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDni.Focus();
                return;
            }
            txtDni.BackColor = SystemColors.Window;

            var pacienteEncontrado = PacienteService.ObtenerPacientePorDNI(dniIngresado);

            if (pacienteEncontrado != null)
            {                
                var listaTransformada = new List<object>
                {
                    new
                    {
                        Dni = pacienteEncontrado.Dni,
                        NombreApellido = pacienteEncontrado.NombreCompleto,
                        ObraSocial = EnumHelper.GetDescription(pacienteEncontrado.ObraSocial),
                        NumeroAfiliado = pacienteEncontrado.NumeroAfiliado,
                        Turnos = "Ver",
                        Pagos = "Ver",
                        PacienteOriginal = pacienteEncontrado
                    }
                };

                pacientesDgv.DataSource = listaTransformada;                
            }
            else
            {
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
            var listaPacientes = PacienteService.ObtenerTodosLosPacientes();
            
            var listaTransformada = listaPacientes.Select(p => new
            {
                Dni = p.Dni,
                NombreApellido = p.NombreCompleto,
                ObraSocial = EnumHelper.GetDescription(p.ObraSocial),
                NumeroAfiliado = p.NumeroAfiliado,
                Turnos = "Ver",
                Pagos = "Ver",
                PacienteOriginal = p
            }).ToList();

            pacientesDgv.DataSource = listaTransformada;
        }


        private void ConfigurarGrillaPacientes()
        {
            pacientesDgv.AutoGenerateColumns = false;
            pacientesDgv.Columns.Clear();
            pacientesDgv.Dock = DockStyle.Fill;

            AplicarEstiloGrilla(pacientesDgv);

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
                DataPropertyName = "NombreApellido",
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
                Name = "NumeroAfiliado",
                HeaderText = "Nro AFILIADO",
                DataPropertyName = "NumeroAfiliado",
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
            dgv.BackgroundColor = PaletaColores.celeste;
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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

            dynamic filaSeleccionada = pacientesDgv.CurrentRow.DataBoundItem;
            var pacienteSeleccionado = filaSeleccionada.PacienteOriginal;

            AdmGPModificarPaciente modificarPaciente = new AdmGPModificarPaciente(pacienteSeleccionado);
            modificarPaciente.FormClosed += (s, args) => this.Close();
            modificarPaciente.Show();
        }
    }
}

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
    public partial class AdmGestionInsumos : Form
    {
        private List<E_Insumo> insumos;
        private Dictionary<string, int> stockMaximoPorInsumo = new Dictionary<string, int>();

        private enum EstadoIngreso { Modificar, Editando }
        private EstadoIngreso estadoIngreso = EstadoIngreso.Modificar;

        private readonly Color colorModificar = PaletaColores.DarkBlue;
        private readonly Color colorCancelar = Color.Red;
        private readonly Color colorAceptar = Color.Green;

        public AdmGestionInsumos()
        {
            InitializeComponent();
            this.Resize += AdmGestionInsumos_Resize;
            this.Size = new Size(1024, 768);
            this.MinimumSize = new Size(1024, 768);
            this.WindowState = FormWindowState.Maximized;
        }

        private void AdmGestionInsumos_Load(object sender, EventArgs e)
        {
            ajustarPaneles();
            InicializarControles();
            ConfigurarGrilla();
            CargarInsumos();
        }

        private void AdmGestionInsumos_Resize(object sender, EventArgs e)
        {
            ajustarPaneles();
            if (dgvInsumos.Rows.Count > 0)
            {
                AjustarColumnasDGV();
            }
        }

        private void ajustarPaneles()
        {
            mainTLP.BackColor = PaletaColores.Skyblue;
            menuTLP.BackColor = PaletaColores.Grey;
            contentLbl.BackColor = PaletaColores.Grey;
            contentLbl.Font = new Font(Fuente.TIPOGRAFIA, Fuente.Title, FontStyle.Regular);
            dgvInsumos.BackgroundColor = PaletaColores.Skyblue;

            foreach (Control boton in menuTLP.Controls)
            {
                boton.Dock = DockStyle.Fill;

                if (boton == btnVolver)
                    boton.BackColor = PaletaColores.Pink;
                else if (boton == picLogo)
                    boton.BackColor = Color.Transparent;
                else
                    boton.BackColor = PaletaColores.DarkBlue;

                boton.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);
                boton.ForeColor = Color.White;
            }
        }

        private void InicializarControles()
        {
            dgvInsumos.Dock = DockStyle.Fill;
            dgvInsumos.ReadOnly = true;
            dgvInsumos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInsumos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvInsumos.AllowUserToAddRows = false;

            dgvInsumos.CellFormatting += dgvInsumos_CellFormatting;
            dgvInsumos.CellClick += DgvInsumos_CellClick;

            btnAñadirInsumo.Click += btnAñadirInsumo_Click;
            btnActualizarInsumo.Click += btnActualizarInsumo_Click;
            btnVolver.Click += btnVolver_Click;
        }

        private void ConfigurarGrilla()
        {
            dgvInsumos.Columns.Clear();
            dgvInsumos.Columns.Add(new DataGridViewTextBoxColumn { Name = "colId", HeaderText = "Id" });
            dgvInsumos.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCodigo", HeaderText = "Código" });
            dgvInsumos.Columns.Add(new DataGridViewTextBoxColumn { Name = "colNombre", HeaderText = "Nombre" });
            dgvInsumos.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDetalle", HeaderText = "Descripción" });
            dgvInsumos.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCantidad", HeaderText = "Cantidad" });

            // Agregar columnas de botones
            var colEditar = new DataGridViewButtonColumn
            {
                Name = "colEditar",
                HeaderText = "EDITAR",
                Text = "✏️",
                UseColumnTextForButtonValue = true
            };

            var colEliminar = new DataGridViewButtonColumn
            {
                Name = "colEliminar",
                HeaderText = "ELIMINAR",
                Text = "🗑️",
                UseColumnTextForButtonValue = true
            };

            dgvInsumos.Columns.Add(colEditar);
            dgvInsumos.Columns.Add(colEliminar);

            dgvInsumos.Columns["colId"].Visible = false;
        }

        private void AjustarColumnasDGV()
        {
            if (dgvInsumos.Columns.Count > 0)
            {
                int fontSize = CalcularTamanoFuente();

                dgvInsumos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dgvInsumos.Columns.Contains("colCodigo"))
                {
                    dgvInsumos.Columns["colCodigo"].FillWeight = 10;
                    dgvInsumos.Columns["colCodigo"].HeaderText = "CÓDIGO";
                }

                if (dgvInsumos.Columns.Contains("colNombre"))
                {
                    dgvInsumos.Columns["colNombre"].FillWeight = 15;
                    dgvInsumos.Columns["colNombre"].HeaderText = "NOMBRE";
                }

                if (dgvInsumos.Columns.Contains("colDetalle"))
                {
                    dgvInsumos.Columns["colDetalle"].FillWeight = 49;
                    dgvInsumos.Columns["colDetalle"].HeaderText = "DESCRIPCIÓN";
                }

                if (dgvInsumos.Columns.Contains("colCantidad"))
                {
                    dgvInsumos.Columns["colCantidad"].FillWeight = 10;
                    dgvInsumos.Columns["colCantidad"].HeaderText = "CANTIDAD";
                }

                if (dgvInsumos.Columns.Contains("colEditar"))
                {
                    dgvInsumos.Columns["colEditar"].FillWeight = 8;
                    dgvInsumos.Columns["colEditar"].HeaderText = "EDITAR";
                }

                if (dgvInsumos.Columns.Contains("colEliminar"))
                {
                    dgvInsumos.Columns["colEliminar"].FillWeight = 8;
                    dgvInsumos.Columns["colEliminar"].HeaderText = "ELIMINAR";
                }

                dgvInsumos.EnableHeadersVisualStyles = false;

                dgvInsumos.ColumnHeadersDefaultCellStyle.BackColor = PaletaColores.LightBlue;
                dgvInsumos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvInsumos.ColumnHeadersDefaultCellStyle.Font = new Font(Fuente.TIPOGRAFIA, fontSize, FontStyle.Bold);

                dgvInsumos.DefaultCellStyle.SelectionBackColor = PaletaColores.DarkGreen;

                dgvInsumos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                dgvInsumos.ColumnHeadersHeight = 35 + (fontSize - 8);

                foreach (DataGridViewColumn col in dgvInsumos.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.DefaultCellStyle.Font = new Font(Fuente.TIPOGRAFIA, fontSize - 0.5f);
                }

                dgvInsumos.RowTemplate.Height = 25 + (fontSize - 8);

                dgvInsumos.RowHeadersVisible = false;
                dgvInsumos.BorderStyle = BorderStyle.None;
                dgvInsumos.GridColor = Color.LightGray;

                dgvInsumos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
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

        private void CargarInsumos()
        {
            insumos = InsumoService.ObtenerInsumos();

            dgvInsumos.Rows.Clear();
            foreach (var insumo in insumos)
                dgvInsumos.Rows.Add(insumo.IdInsumo, insumo.Codigo, insumo.Nombre, insumo.Descripcion, insumo.Cantidad, "✏️", "🗑️");

            AjustarColumnasDGV();
        }

        private void DgvInsumos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvInsumos.Rows.Count) return;

            var row = dgvInsumos.Rows[e.RowIndex];
            int idInsumo = Convert.ToInt32(row.Cells["colId"].Value);

            if (e.ColumnIndex == dgvInsumos.Columns["colEditar"].Index)
            {
                EditarInsumo(idInsumo, row);
            }
            else if (e.ColumnIndex == dgvInsumos.Columns["colEliminar"].Index)
            {
                EliminarInsumo(idInsumo, row);
            }
        }

        private void EditarInsumo(int idInsumo, DataGridViewRow row)
        {
            if (estadoIngreso == EstadoIngreso.Editando)
            {
                MessageBox.Show("Complete o cancele la operación actual antes de editar otro insumo.",
                              "Operación en curso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var insumo = insumos.FirstOrDefault(i => i.IdInsumo == idInsumo);
            if (insumo != null)
            {
                dgvInsumos.ReadOnly = false;
                btnActualizarInsumo.Text = "ACEPTAR CAMBIOS";
                btnActualizarInsumo.BackColor = colorAceptar;
                estadoIngreso = EstadoIngreso.Editando;

                // Seleccionar la fila para edición
                dgvInsumos.CurrentCell = row.Cells["colCodigo"];
                dgvInsumos.BeginEdit(true);
            }
        }

        private void EliminarInsumo(int idInsumo, DataGridViewRow row)
        {
            var insumo = insumos.FirstOrDefault(i => i.IdInsumo == idInsumo);
            if (insumo != null)
            {
                if (MessageBox.Show($"¿Desea eliminar el insumo '{insumo.Nombre}'?", "Confirmar eliminación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        insumos.Remove(insumo);
                        dgvInsumos.Rows.Remove(row);
                        MessageBox.Show("Insumo eliminado correctamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar el insumo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAñadirInsumo_Click(object sender, EventArgs e)
        {
            if (estadoIngreso == EstadoIngreso.Modificar)
            {
                dgvInsumos.ReadOnly = false;
                dgvInsumos.Rows.Add(0, "", "", "", 0, "✏️", "🗑️");
                dgvInsumos.CurrentCell = dgvInsumos.Rows[dgvInsumos.Rows.Count - 1].Cells["colCodigo"];
                dgvInsumos.BeginEdit(true);

                btnAñadirInsumo.Text = "ACEPTAR INGRESO";
                btnAñadirInsumo.BackColor = colorAceptar;
                estadoIngreso = EstadoIngreso.Editando;
            }
            else if (estadoIngreso == EstadoIngreso.Editando)
            {
                var fila = dgvInsumos.Rows[dgvInsumos.Rows.Count - 1];
                string codigo = $"COD/{fila.Cells["colCodigo"].Value?.ToString()}";
                string nombre = fila.Cells["colNombre"].Value?.ToString();
                string detalle = fila.Cells["colDetalle"].Value?.ToString();
                string cantidadStr = fila.Cells["colCantidad"].Value?.ToString();

                if (string.IsNullOrWhiteSpace(codigo) || string.IsNullOrWhiteSpace(nombre) ||
                    string.IsNullOrWhiteSpace(detalle) || !float.TryParse(cantidadStr, out float cantidad) || cantidad < 0)
                {
                    MessageBox.Show("Complete todos los campos correctamente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (ExisteCodigo(codigo))
                {
                    MessageBox.Show("El código de insumo ya existe.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (ExisteNombre(nombre))
                {
                    MessageBox.Show("El nombre de insumo ya existe.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    var insumo = new E_Insumo(codigo, nombre, detalle, cantidad);
                    InsumoService.CrearInsumo(insumo);

                    stockMaximoPorInsumo[nombre] = 200;

                    dgvInsumos.ReadOnly = true;
                    btnAñadirInsumo.Text = "AÑADIR INSUMO";
                    btnAñadirInsumo.BackColor = colorModificar;
                    estadoIngreso = EstadoIngreso.Modificar;

                    // Recargar para mostrar el ID generado
                    CargarInsumos();

                    MessageBox.Show("INSUMO AÑADIDO CORRECTAMENTE.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear el insumo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnActualizarInsumo_Click(object sender, EventArgs e)
        {
            if (dgvInsumos.CurrentRow == null && estadoIngreso == EstadoIngreso.Modificar)
            {
                MessageBox.Show("Seleccione una fila para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (estadoIngreso == EstadoIngreso.Modificar)
            {
                // Iniciar edición desde botón externo
                if (dgvInsumos.CurrentRow != null)
                {
                    int idInsumo = Convert.ToInt32(dgvInsumos.CurrentRow.Cells["colId"].Value);
                    EditarInsumo(idInsumo, dgvInsumos.CurrentRow);
                }
            }
            else if (estadoIngreso == EstadoIngreso.Editando)
            {
                // Aceptar cambios
                DataGridViewRow fila;
                if (btnAñadirInsumo.Text == "ACEPTAR INGRESO")
                {
                    fila = dgvInsumos.Rows[dgvInsumos.Rows.Count - 1];
                }
                else
                {
                    fila = dgvInsumos.CurrentRow;
                }

                if (fila == null) return;

                int id = Convert.ToInt32(fila.Cells["colId"].Value);
                string codigo = fila.Cells["colCodigo"].Value?.ToString();
                string nombre = fila.Cells["colNombre"].Value?.ToString();
                string detalle = fila.Cells["colDetalle"].Value?.ToString();
                string cantidadStr = fila.Cells["colCantidad"].Value?.ToString();

                if (string.IsNullOrWhiteSpace(codigo) || string.IsNullOrWhiteSpace(nombre) ||
                    string.IsNullOrWhiteSpace(detalle) || !float.TryParse(cantidadStr, out float cantidad))
                {
                    MessageBox.Show("Complete todos los campos correctamente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var insumo = insumos.FirstOrDefault(i => i.IdInsumo == id);
                if (insumo != null)
                {
                    // Verificar si el código o nombre ya existen en otros insumos
                    if (insumos.Any(i => i.IdInsumo != id && i.Codigo == codigo))
                    {
                        MessageBox.Show("El código de insumo ya existe en otro registro.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (insumos.Any(i => i.IdInsumo != id && i.Nombre == nombre))
                    {
                        MessageBox.Show("El nombre de insumo ya existe en otro registro.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    insumo.Codigo = codigo;
                    insumo.Nombre = nombre;
                    insumo.Descripcion = detalle;
                    insumo.Cantidad = cantidad;
                    stockMaximoPorInsumo[nombre] = 200;

                    MessageBox.Show("INSUMO ACTUALIZADO CORRECTAMENTE.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvInsumos.ReadOnly = true;
                btnActualizarInsumo.Text = "ACTUALIZAR INSUMO";
                btnActualizarInsumo.BackColor = colorModificar;
                btnAñadirInsumo.Text = "AÑADIR INSUMO";
                btnAñadirInsumo.BackColor = colorModificar;
                estadoIngreso = EstadoIngreso.Modificar;

                // Recargar para aplicar cambios visuales
                CargarInsumos();
            }
        }

        private void dgvInsumos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvInsumos.Columns[e.ColumnIndex].Name == "colCantidad" && e.RowIndex >= 0 && e.RowIndex < dgvInsumos.Rows.Count)
            {
                var fila = dgvInsumos.Rows[e.RowIndex];
                if (!fila.IsNewRow)
                {
                    string nombre = fila.Cells["colNombre"].Value?.ToString();
                    float cantidad = 0;
                    float.TryParse(fila.Cells["colCantidad"].Value?.ToString(), out cantidad);
                    fila.DefaultCellStyle.BackColor = ObtenerColorPorCantidad(nombre, cantidad);

                    // También aplicar color al texto para mejor contraste
                    if (cantidad == 0)
                    {
                        fila.Cells["colCantidad"].Style.ForeColor = Color.White;
                    }
                    else if (cantidad < 30) // Stock bajo
                    {
                        fila.Cells["colCantidad"].Style.ForeColor = Color.DarkRed;
                    }
                    else
                    {
                        fila.Cells["colCantidad"].Style.ForeColor = Color.Black;
                    }
                }
            }
        }

        private Color ObtenerColorPorCantidad(string nombre, float cantidad)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                return Color.Gray;

            int stockMaximo = stockMaximoPorInsumo.ContainsKey(nombre) ? stockMaximoPorInsumo[nombre] : 200;
            double porcentaje = (double)cantidad / stockMaximo;

            if (cantidad == 0) return Color.Red;
            if (porcentaje < 0.15) return Color.LightCoral;
            if (porcentaje < 0.5) return Color.LightYellow;
            return Color.White;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                    "Desea salir de la Pantalla y volver al Dashboard?",
                    "Confirmar Regreso",
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

        private bool ExisteCodigo(string codigo)
        {
            return insumos.Any(i => i.Codigo.Trim().Equals(codigo.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        private bool ExisteNombre(string nombre)
        {
            return insumos.Any(i => i.Nombre.Trim().Equals(nombre.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        private void btnVerSolicitudes_Click(object sender, EventArgs e)
        {
            AuxCargaGenerica auxCargaGenerica = new AuxCargaGenerica(DDBB_Simulation.PedidosInsumos);
            auxCargaGenerica.ShowDialog();
        }
    }
}
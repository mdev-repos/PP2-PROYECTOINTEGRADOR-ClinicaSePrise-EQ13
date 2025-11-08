using ClinicaSePriseApp.Entidades;
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

        private readonly Color colorModificar = Utilidades.PaletaColores.btnAzul;
        private readonly Color colorCancelar = Color.Red;
        private readonly Color colorAceptar = Color.Green;

        private Button btnCancelar;

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
        }

        private void ajustarPaneles()
        {
            mainTLP.BackColor = Utilidades.PaletaColores.bgCeleste;
            menuTLP.BackColor = Utilidades.PaletaColores.bgGris;
            contentLbl.BackColor = Utilidades.PaletaColores.bgGris;

            foreach (Control boton in menuTLP.Controls)
            {
                boton.Dock = DockStyle.Fill;

                if (boton == btnVolver)
                    boton.BackColor = Utilidades.PaletaColores.btnRosa;
                else if (boton == picLogo)
                    boton.BackColor = Color.Transparent;
                else
                    boton.BackColor = Utilidades.PaletaColores.btnAzul;

                boton.Font = new Font("LEMON MILK", 10, FontStyle.Bold);
                boton.ForeColor = Color.Transparent;
            }
        }

        private void InicializarControles()
        {
            dgvInsumos.Dock = DockStyle.Fill;
            dgvInsumos.ReadOnly = true;
            dgvInsumos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInsumos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInsumos.AllowUserToAddRows = false;

            dgvInsumos.CellFormatting += dgvInsumos_CellFormatting;
            dgvInsumos.CurrentCellChanged += dgvInsumos_CurrentCellChanged;

            btnAñadirInsumo.Click += btnAñadirInsumo_Click;
            btnActualizarInsumo.Click += btnActualizarInsumo_Click;
            btnVolver.Click += btnVolver_Click;

            btnCancelar = new Button
            {
                Text = "ELIMINAR INSUMO",
                BackColor = Color.DarkRed,
                ForeColor = Color.White,
                Font = new Font("LEMON MILK", 10, FontStyle.Bold),
                Visible = false,
                FlatStyle = FlatStyle.Flat
            };
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.Click += BtnCancelar_Click;

            if (menuTLP != null && menuTLP.Controls.Contains(btnActualizarInsumo) && menuTLP.Controls.Contains(btnAñadirInsumo))
            {
                int indexAdd = menuTLP.Controls.GetChildIndex(btnAñadirInsumo);
                menuTLP.Controls.Add(btnCancelar);
                menuTLP.Controls.SetChildIndex(btnCancelar, indexAdd);
                btnCancelar.Dock = DockStyle.Fill;
            }

            dgvInsumos.SelectionChanged += DgvInsumos_SelectionChanged;
        }

        private void ConfigurarGrilla()
        {
            dgvInsumos.Columns.Clear();
            dgvInsumos.Columns.Add(new DataGridViewTextBoxColumn { Name = "colId", HeaderText = "ID", ReadOnly = true });
            dgvInsumos.Columns.Add(new DataGridViewTextBoxColumn { Name = "colNombre", HeaderText = "Nombre" });
            dgvInsumos.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDetalle", HeaderText = "Descripción" });
            dgvInsumos.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCantidad", HeaderText = "Cantidad" });
        }

        private void CargarInsumos()
        {
            insumos = new List<E_Insumo>
            {
                new E_Insumo { IdInsumo = "INS001", Nombre = "Guantes", Detalle = "Guantes de látex", Cantidad = 400 },
                new E_Insumo { IdInsumo = "INS002", Nombre = "Alcohol", Detalle = "Alcohol al 70%", Cantidad = 50 },
                new E_Insumo { IdInsumo = "INS003", Nombre = "Jeringas", Detalle = "Jeringas descartables", Cantidad = 5 }
            };

            dgvInsumos.Rows.Clear();
            foreach (var insumo in insumos)
                dgvInsumos.Rows.Add(insumo.IdInsumo, insumo.Nombre, insumo.Detalle, insumo.Cantidad);
        }

        private void DgvInsumos_SelectionChanged(object sender, EventArgs e)
        {
            if (estadoIngreso == EstadoIngreso.Modificar && dgvInsumos.SelectedRows.Count > 0)
            {
                btnCancelar.Visible = true;
                btnCancelar.Text = "ELIMINAR INSUMO";
                btnCancelar.BackColor = Color.DarkRed;
            }
            else if (estadoIngreso == EstadoIngreso.Editando)
            {
                btnCancelar.Visible = true;
                btnCancelar.Text = "CANCELAR";
                btnCancelar.BackColor = colorCancelar;
            }
            else
            {
                btnCancelar.Visible = false;
            }
        }

        private void btnAñadirInsumo_Click(object sender, EventArgs e)
        {
            if (estadoIngreso == EstadoIngreso.Modificar)
            {
                string nuevoId = GenerarIdUnico("INS");
                dgvInsumos.ReadOnly = false;
                dgvInsumos.Rows.Add(nuevoId, "", "", 0);
                dgvInsumos.CurrentCell = dgvInsumos.Rows[dgvInsumos.Rows.Count - 1].Cells["colNombre"];
                dgvInsumos.BeginEdit(true);

                btnAñadirInsumo.Text = "ACEPTAR INGRESO";
                btnAñadirInsumo.BackColor = colorAceptar;
                estadoIngreso = EstadoIngreso.Editando;
                btnCancelar.Visible = false;
            }
            else if (estadoIngreso == EstadoIngreso.Editando)
            {
                var fila = dgvInsumos.Rows[dgvInsumos.Rows.Count - 1];
                string id = fila.Cells["colId"].Value?.ToString();
                string nombre = fila.Cells["colNombre"].Value?.ToString();
                string detalle = fila.Cells["colDetalle"].Value?.ToString();
                string cantidadStr = fila.Cells["colCantidad"].Value?.ToString();

                if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(detalle) ||
                    !int.TryParse(cantidadStr, out int cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("Complete todos los campos correctamente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (ExisteNombre(nombre))
                {
                    MessageBox.Show("El insumo ya existe.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                insumos.Add(new E_Insumo { IdInsumo = id, Nombre = nombre, Detalle = detalle, Cantidad = cantidad });
                stockMaximoPorInsumo[nombre] = 200;

                dgvInsumos.ReadOnly = true;
                btnAñadirInsumo.Text = "AÑADIR INSUMO";
                btnAñadirInsumo.BackColor = colorModificar;
                estadoIngreso = EstadoIngreso.Modificar;
                dgvInsumos.Refresh();

                MessageBox.Show("INSUMO AÑADIDO CORRECTAMENTE.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnActualizarInsumo_Click(object sender, EventArgs e)
        {
            if (dgvInsumos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una fila para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvInsumos.ReadOnly)
            {
                dgvInsumos.ReadOnly = false;
                btnActualizarInsumo.Text = "ACEPTAR CAMBIOS";
                btnActualizarInsumo.BackColor = colorAceptar;
                btnCancelar.Visible = true;
                btnCancelar.Text = "CANCELAR";
                estadoIngreso = EstadoIngreso.Editando;
            }
            else
            {
                var fila = dgvInsumos.CurrentRow;
                string id = fila.Cells["colId"].Value?.ToString();
                string nombre = fila.Cells["colNombre"].Value?.ToString();
                string detalle = fila.Cells["colDetalle"].Value?.ToString();
                string cantidadStr = fila.Cells["colCantidad"].Value?.ToString();

                if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(detalle) || !int.TryParse(cantidadStr, out int cantidad))
                {
                    MessageBox.Show("Complete todos los campos correctamente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var insumo = insumos.FirstOrDefault(i => i.IdInsumo == id);
                if (insumo != null)
                {
                    insumo.Nombre = nombre;
                    insumo.Detalle = detalle;
                    insumo.Cantidad = cantidad;
                    stockMaximoPorInsumo[nombre] = 200;
                    MessageBox.Show("INSUMO ACTUALIZADO CORRECTAMENTE.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvInsumos.ReadOnly = true;
                btnActualizarInsumo.Text = "ACTUALIZAR INSUMO";
                btnActualizarInsumo.BackColor = colorModificar;
                btnCancelar.Visible = false;
                estadoIngreso = EstadoIngreso.Modificar;
                dgvInsumos.Refresh();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (estadoIngreso == EstadoIngreso.Editando)
            {
                dgvInsumos.ReadOnly = true;
                btnActualizarInsumo.Text = "ACTUALIZAR INSUMO";
                btnActualizarInsumo.BackColor = colorModificar;
                estadoIngreso = EstadoIngreso.Modificar;
                btnCancelar.Visible = false;
                dgvInsumos.Refresh();
                return;
            }

            if (estadoIngreso == EstadoIngreso.Modificar && dgvInsumos.SelectedRows.Count > 0)
            {
                var fila = dgvInsumos.SelectedRows[0];
                string id = fila.Cells["colId"].Value?.ToString();
                var insumo = insumos.FirstOrDefault(i => i.IdInsumo == id);
                if (insumo != null)
                {
                    if (MessageBox.Show($"¿Desea eliminar el insumo '{insumo.Nombre}'?", "Confirmar eliminación",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        insumos.Remove(insumo);
                        dgvInsumos.Rows.Remove(fila);
                        MessageBox.Show("Insumo eliminado correctamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void dgvInsumos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvInsumos.Columns[e.ColumnIndex].Name == "colCantidad" && e.RowIndex >= 0)
            {
                var fila = dgvInsumos.Rows[e.RowIndex];
                string nombre = fila.Cells["colNombre"].Value?.ToString();
                int cantidad = 0;
                int.TryParse(fila.Cells["colCantidad"].Value?.ToString(), out cantidad);
                fila.DefaultCellStyle.BackColor = ObtenerColorPorCantidad(nombre, cantidad);
            }
        }

        private Color ObtenerColorPorCantidad(string nombre, int cantidad)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                return Color.Gray;

            int stockMaximo = stockMaximoPorInsumo.ContainsKey(nombre) ? stockMaximoPorInsumo[nombre] : 200;
            double porcentaje = (double)cantidad / stockMaximo;

            if (porcentaje < 0.15) return Color.Red;
            if (porcentaje < 0.5) return Color.Orange;
            return Color.White;
        }

        private void dgvInsumos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (estadoIngreso == EstadoIngreso.Editando && dgvInsumos.CurrentCell != null)
            {
                int ultimaFila = dgvInsumos.Rows.Count - 1;
                if (dgvInsumos.CurrentCell.RowIndex != ultimaFila)
                {
                    MessageBox.Show("Complete o cancele el ingreso actual antes de cambiar de fila.",
                        "Ingreso en curso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        dgvInsumos.CurrentCell = dgvInsumos.Rows[ultimaFila].Cells["colNombre"];
                        dgvInsumos.BeginEdit(true);
                    });
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DashAdmin dashAdmin = new DashAdmin();
            this.Hide();
            dashAdmin.FormClosed += (s, args) => this.Close();
            dashAdmin.Show();
        }

        private string GenerarIdUnico(string prefijo)
        {
            int max = insumos
                .Where(i => i.IdInsumo.StartsWith(prefijo))
                .Select(i => ExtraerNumero(i.IdInsumo, prefijo))
                .DefaultIfEmpty(0)
                .Max();
            return $"{prefijo}{(max + 1):000}";
        }

        private int ExtraerNumero(string id, string prefijo)
        {
            string numStr = id.Substring(prefijo.Length);
            return int.TryParse(numStr, out int num) ? num : 0;
        }

        private bool ExisteNombre(string nombre)
        {
            return insumos.Any(i => i.Nombre.Trim().Equals(nombre.Trim(), StringComparison.OrdinalIgnoreCase));
        }
    }
}

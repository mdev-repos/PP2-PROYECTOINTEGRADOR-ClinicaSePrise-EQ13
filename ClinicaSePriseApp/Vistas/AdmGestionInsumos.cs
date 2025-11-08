/*
MATIIIIIIIIII SI LEES ESTO LE FALTA VALIDAR EL TEMA DEL COLOR CUANDO SE AGREGA UN INSUMO NUEVO Y AGREGAR EL BOTON DE ELIMINAR INSUMO O CANCELAR EL INGRESO- LO SUBO PARA QUE LO VEAASSSS
*/

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

        private enum EstadoIngreso { Modificar, Editando, Aceptar }
        private EstadoIngreso estadoIngreso = EstadoIngreso.Modificar;

        private readonly Color colorModificar = Utilidades.PaletaColores.btnAzul;
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
            dgvInsumos.AllowUserToAddRows = false;
            dgvInsumos.AllowUserToResizeRows = false;
            dgvInsumos.AllowUserToResizeColumns = false;
            dgvInsumos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInsumos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInsumos.BackgroundColor = Color.White;
            dgvInsumos.BorderStyle = BorderStyle.FixedSingle;

            dgvInsumos.CellFormatting += dgvInsumos_CellFormatting;
            dgvInsumos.CellValueChanged += dgvInsumos_CellValueChanged;
            dgvInsumos.CellEndEdit += dgvInsumos_CellEndEdit;
            dgvInsumos.CurrentCellChanged += dgvInsumos_CurrentCellChanged;

            btnAñadirInsumo.Click += btnAñadirInsumo_Click;
            btnActualizarInsumo.Click += btnActualizarInsumo_Click;
            dgvInsumos.EditingControlShowing += dgvInsumos_EditingControlShowing;
            btnVolver.Click += btnVolver_Click;

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

        private void dgvInsumos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvInsumos.Columns[e.ColumnIndex].Name == "colCantidad" && e.RowIndex >= 0)
            {
                var fila = dgvInsumos.Rows[e.RowIndex];
                string nombre = fila.Cells["colNombre"].Value?.ToString();
                int cantidad = 0;

                if (!int.TryParse(fila.Cells["colCantidad"].Value?.ToString(), out cantidad))
                    return;

                string clave = string.IsNullOrWhiteSpace(nombre)
                    ? fila.Cells["colId"].Value?.ToString()
                    : nombre;

                if (string.IsNullOrWhiteSpace(clave))
                    return;

                fila.DefaultCellStyle.BackColor = ObtenerColorPorCantidad(clave, cantidad);
            }
        }

        private Color ObtenerColorPorCantidad(string nombre, int cantidad)
        {
            int stockMaximo = stockMaximoPorInsumo.ContainsKey(nombre) ? stockMaximoPorInsumo[nombre] : 200;
            if (stockMaximo <= 0) return Color.Gray; // ✅ Fallback seguro

            double porcentaje = (double)cantidad / stockMaximo;

            if (porcentaje < 0.15) return Color.Red;
            if (porcentaje < 0.5) return Color.Orange;
            return Color.White;
        }

        private void dgvInsumos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvInsumos.CurrentCell.OwningColumn.Name == "colCantidad")
            {
                TextBox txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.KeyPress -= SoloNumeros_KeyPress; // Evita duplicación
                    txt.KeyPress += SoloNumeros_KeyPress;
                }
            }
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos y teclas de control (como Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvInsumos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ValidarFilaEnEdicion();
        }

        private void btnAñadirInsumo_Click(object sender, EventArgs e)
        {
            switch (estadoIngreso)
            {
                case EstadoIngreso.Modificar:
                    // ✅ Validación previa: evitar múltiples ingresos simultáneos
                    if (estadoIngreso == EstadoIngreso.Editando)
                    {
                        MessageBox.Show("Complete o cancele el ingreso actual antes de añadir otro.", "Ingreso en curso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string nuevoId = GenerarIdUnico("INS");
                    dgvInsumos.ReadOnly = false;

                    dgvInsumos.Rows.Add(nuevoId, "", "", 0);
                    int nuevaFilaIndex = dgvInsumos.Rows.Count - 1;

                    dgvInsumos.CurrentCell = dgvInsumos.Rows[nuevaFilaIndex].Cells["colNombre"];
                    dgvInsumos.BeginEdit(true);
                    dgvInsumos.Focus();

                    btnAñadirInsumo.Text = "CANCELAR INGRESO";
                    btnAñadirInsumo.BackColor = colorCancelar;
                    estadoIngreso = EstadoIngreso.Editando;
                    break;

                case EstadoIngreso.Editando:
                    dgvInsumos.Rows.RemoveAt(dgvInsumos.Rows.Count - 1);
                    dgvInsumos.ReadOnly = true;

                    btnAñadirInsumo.Text = "AÑADIR INSUMO";
                    btnAñadirInsumo.BackColor = colorModificar;
                    estadoIngreso = EstadoIngreso.Modificar;
                    break;

                case EstadoIngreso.Aceptar:
                    var fila = dgvInsumos.Rows[^1];
                    string id = fila.Cells["colId"].Value?.ToString();
                    string nombre = fila.Cells["colNombre"].Value?.ToString();
                    string detalle = fila.Cells["colDetalle"].Value?.ToString();
                    string cantidadStr = fila.Cells["colCantidad"].Value?.ToString();

                    if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(detalle) || !int.TryParse(cantidadStr, out int cantidad) || cantidad <= 0)
                    {
                        MessageBox.Show("Complete todos los campos correctamente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (ExisteNombre(nombre) || ExisteId(id))
                    {
                        MessageBox.Show("El insumo ya existe por nombre o ID.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    insumos.Add(new E_Insumo
                    {
                        IdInsumo = id,
                        Nombre = nombre,
                        Detalle = detalle,
                        Cantidad = cantidad
                    });

                    stockMaximoPorInsumo[nombre] = 200;

                    dgvInsumos.ReadOnly = true;
                    btnAñadirInsumo.Text = "AÑADIR INSUMO";
                    btnAñadirInsumo.BackColor = colorModificar;
                    estadoIngreso = EstadoIngreso.Modificar;
                    dgvInsumos.InvalidateRow(dgvInsumos.Rows.Count - 1); // ✅ Redibuja la última fila

                    dgvInsumos.Refresh(); // ✅ Forzar redibujado para aplicar color

                    MessageBox.Show("INSUMO AÑADIDO CORRECTAMENTE.", "Ingreso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void dgvInsumos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (estadoIngreso == EstadoIngreso.Editando)
            {
                int ultimaFila = dgvInsumos.Rows.Count - 1;
                if (dgvInsumos.CurrentCell != null && dgvInsumos.CurrentCell.RowIndex != ultimaFila)
                {
                    MessageBox.Show("Complete o cancele el ingreso actual antes de cambiar de fila.", "Ingreso en curso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgvInsumos.CurrentCell = dgvInsumos.Rows[ultimaFila].Cells["colNombre"];
                    dgvInsumos.BeginEdit(true);
                }
            }
        }

        private void btnActualizarInsumo_Click(object sender, EventArgs e)
        {
            if (dgvInsumos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una fila para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool activarEdicion = dgvInsumos.ReadOnly;
            dgvInsumos.ReadOnly = !activarEdicion;

            if (activarEdicion)
            {
                btnActualizarInsumo.Text = "ACEPTAR CAMBIOS";
                btnActualizarInsumo.BackColor = colorAceptar;
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
                    dgvInsumos.ReadOnly = true;
                    btnActualizarInsumo.Text = "ACTUALIZAR INSUMO";
                    btnActualizarInsumo.BackColor = colorModificar;
                    return;
                }

                var insumo = insumos.FirstOrDefault(i => i.IdInsumo == id);
                if (insumo != null)
                {
                    insumo.Nombre = nombre;
                    insumo.Detalle = detalle;
                    insumo.Cantidad = cantidad;

                    if (!string.IsNullOrWhiteSpace(nombre))
                        stockMaximoPorInsumo[nombre] = 200;

                    MessageBox.Show("INSUMO ACTUALIZADO CORRECTAMENTE.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                btnActualizarInsumo.Text = "ACTUALIZAR INSUMO";
                btnActualizarInsumo.BackColor = colorModificar;
                dgvInsumos.Refresh(); // ✅ Forzar redibujado para aplicar color
            }
        }

        private void dgvInsumos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ValidarFilaEnEdicion();
        }

        private void ValidarFilaEnEdicion()
        {
            if (estadoIngreso != EstadoIngreso.Editando || dgvInsumos.Rows.Count == 0)
                return;

            var fila = dgvInsumos.Rows[^1];

            foreach (DataGridViewCell celda in fila.Cells)
            {
                celda.Style.BackColor = Color.White;

                if (celda.OwningColumn.Name != "colId" && string.IsNullOrWhiteSpace(celda.Value?.ToString()))
                    celda.Style.BackColor = Color.LightPink;
            }

            string nombre = fila.Cells["colNombre"].Value?.ToString();
            string detalle = fila.Cells["colDetalle"].Value?.ToString();
            string cantidadStr = fila.Cells["colCantidad"].Value?.ToString();

            bool nombreOk = !string.IsNullOrWhiteSpace(nombre);
            bool detalleOk = !string.IsNullOrWhiteSpace(detalle);
            bool cantidadOk = int.TryParse(cantidadStr, out int cantidad) && cantidad > 0;

            if (nombreOk && !stockMaximoPorInsumo.ContainsKey(nombre))
                stockMaximoPorInsumo[nombre] = 200;

            if (nombreOk && detalleOk && cantidadOk)
            {
                btnAñadirInsumo.Text = "ACEPTAR INGRESO";
                btnAñadirInsumo.BackColor = colorAceptar;
                estadoIngreso = EstadoIngreso.Aceptar;
            }
            else
            {
                btnAñadirInsumo.Text = "CANCELAR INGRESO";
                btnAñadirInsumo.BackColor = colorCancelar;
                estadoIngreso = EstadoIngreso.Editando;
            }

            dgvInsumos.InvalidateRow(dgvInsumos.Rows.Count - 1);
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

        private bool ExisteId(string id)
        {
            return insumos.Any(i => i.IdInsumo == id);
        }

    }
}

        
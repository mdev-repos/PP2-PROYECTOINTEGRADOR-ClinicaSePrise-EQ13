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

namespace ClinicaSePriseApp.Vistas.Auxiliares
{
    public partial class AuxSolicitarInsumos : Form
    {
        private E_Profesional _profesional;
        private List<E_Insumo> _insumosDisponibles;
        private List<E_InsumoSolicitado> _insumosSeleccionados;

        public AuxSolicitarInsumos(E_Profesional profesional)
        {
            InitializeComponent();
            _profesional = profesional;
            _insumosSeleccionados = new List<E_InsumoSolicitado>();

            // Configurar columnas
            insumosTLP.ColumnStyles.Clear();
            insumosTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            insumosTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            insumosTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            insumosTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));

            listaTLP.ColumnStyles.Clear();
            listaTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            listaTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            listaTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));

            AplicarEstilos();
            CargarInsumosDisponibles();
        }

        // Estilos Visuales
        private void AplicarEstilos()
        {
            containerTLP.BackColor = PaletaColores.LightBlue;

            foreach (Control boton in buttonsTLP.Controls)
            {
                boton.Dock = DockStyle.Fill;

                if (boton == btnCancelar)
                {
                    boton.BackColor = PaletaColores.Pink;
                }
                else if (boton == btnConfirmar)
                {
                    boton.BackColor = PaletaColores.DarkBlue;
                }

                boton.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);
                boton.ForeColor = Color.White;
            }

            lblTitulo.ForeColor = Color.White;
            btnCancelar.Click += BtnCancelar_Click;
            btnConfirmar.Click += BtnConfirmar_Click;
        }

        // Carga de datos
        private void CargarInsumosDisponibles()
        {
            _insumosDisponibles = InsumoService.ObtenerInsumos()
                .Where(i => i.Cantidad > 0)
                .ToList();

            CargarListaInsumosDisponibles();
            CargarListaInsumosSeleccionados();
        }

        private void CargarListaInsumosDisponibles()
        {
            insumosTLP.Controls.Clear();
            insumosTLP.RowStyles.Clear();
            insumosTLP.RowCount = 0;

            insumosTLP.RowCount = _insumosDisponibles.Count + 1;
            AgregarHeadersInsumosDisponibles();

            if (_insumosDisponibles.Count == 0)
            {
                insumosTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));

                Label lblMensaje = new Label();
                lblMensaje.Text = "No hay insumos disponibles en stock";
                lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
                lblMensaje.Dock = DockStyle.Fill;
                lblMensaje.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Italic);
                lblMensaje.ForeColor = Color.White;
                lblMensaje.BackColor = PaletaColores.Skyblue;

                insumosTLP.Controls.Add(lblMensaje, 0, 0);
                insumosTLP.SetColumnSpan(lblMensaje, 4);
                return;
            }

            for (int i = 0; i < _insumosDisponibles.Count; i++)
            {
                insumosTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
                AgregarFilaInsumoDisponible(_insumosDisponibles[i], i + 1);
            }
        }

        private void AgregarHeadersInsumosDisponibles()
        {
            insumosTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));

            string[] headers = { "NOMBRE", "STOCK", "CANTIDAD", "AGREGAR" };

            for (int i = 0; i < headers.Length; i++)
            {
                Label lblHeader = new Label();
                lblHeader.Text = headers[i];
                lblHeader.TextAlign = ContentAlignment.MiddleCenter;
                lblHeader.Dock = DockStyle.Fill;
                lblHeader.Font = new Font(Fuente.TIPOGRAFIA, Fuente.M, FontStyle.Bold);
                lblHeader.ForeColor = Color.White;
                lblHeader.BackColor = PaletaColores.DarkBlue;

                insumosTLP.Controls.Add(lblHeader, i, 0);
            }
        }

        private void AgregarFilaInsumoDisponible(E_Insumo insumo, int fila)
        {
            Label lblNombre = new Label();
            lblNombre.Text = insumo.Nombre;
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            lblNombre.Dock = DockStyle.Fill;
            lblNombre.Font = new Font(Fuente.TIPOGRAFIA, Fuente.M, FontStyle.Regular);
            lblNombre.ForeColor = Color.Black;
            lblNombre.BackColor = Color.White;

            Label lblStock = new Label();
            lblStock.Text = insumo.Cantidad.ToString();
            lblStock.TextAlign = ContentAlignment.MiddleCenter;
            lblStock.Dock = DockStyle.Fill;
            lblStock.Font = new Font(Fuente.TIPOGRAFIA, Fuente.M, FontStyle.Regular);
            lblStock.ForeColor = Color.Black;
            lblStock.BackColor = Color.White;

            NumericUpDown numCantidad = new NumericUpDown();
            numCantidad.Minimum = 1;
            numCantidad.Maximum = (decimal)insumo.Cantidad;
            numCantidad.Value = 1;
            numCantidad.Dock = DockStyle.Fill;
            numCantidad.Font = new Font(Fuente.TIPOGRAFIA, Fuente.M, FontStyle.Regular);
            numCantidad.TextAlign = HorizontalAlignment.Center;

            Button btnAgregar = new Button();
            btnAgregar.Text = "+";
            btnAgregar.Dock = DockStyle.Fill;
            btnAgregar.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);
            btnAgregar.BackColor = PaletaColores.LightGreen;
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Tag = new object[] { insumo, numCantidad };
            btnAgregar.Click += BtnAgregar_Click;

            insumosTLP.Controls.Add(lblNombre, 0, fila);
            insumosTLP.Controls.Add(lblStock, 1, fila);
            insumosTLP.Controls.Add(numCantidad, 2, fila);
            insumosTLP.Controls.Add(btnAgregar, 3, fila);
        }

        private void CargarListaInsumosSeleccionados()
        {
            listaTLP.Controls.Clear();
            listaTLP.RowStyles.Clear();
            listaTLP.RowCount = 0;

            listaTLP.RowCount = _insumosSeleccionados.Count + 1;
            AgregarHeadersInsumosSeleccionados();

            if (_insumosSeleccionados.Count == 0)
            {
                listaTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));

                Label lblMensaje = new Label();
                lblMensaje.Text = "No hay insumos seleccionados";
                lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
                lblMensaje.Dock = DockStyle.Fill;
                lblMensaje.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Italic);
                lblMensaje.ForeColor = Color.White;
                lblMensaje.BackColor = PaletaColores.Skyblue;

                listaTLP.Controls.Add(lblMensaje, 0, 0);
                listaTLP.SetColumnSpan(lblMensaje, 3);
                return;
            }

            for (int i = 0; i < _insumosSeleccionados.Count; i++)
            {
                listaTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
                AgregarFilaInsumoSeleccionado(_insumosSeleccionados[i], i + 1);
            }
        }

        private void AgregarHeadersInsumosSeleccionados()
        {
            listaTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));

            string[] headers = { "NOMBRE", "CANTIDAD", "QUITAR" };

            for (int i = 0; i < headers.Length; i++)
            {
                Label lblHeader = new Label();
                lblHeader.Text = headers[i];
                lblHeader.TextAlign = ContentAlignment.MiddleCenter;
                lblHeader.Dock = DockStyle.Fill;
                lblHeader.Font = new Font(Fuente.TIPOGRAFIA, Fuente.M, FontStyle.Bold);
                lblHeader.ForeColor = Color.White;
                lblHeader.BackColor = PaletaColores.DarkBlue;

                listaTLP.Controls.Add(lblHeader, i, 0);
            }
        }

        private void AgregarFilaInsumoSeleccionado(E_InsumoSolicitado insumoSolicitado, int fila)
        {
            Label lblNombre = new Label();
            lblNombre.Text = insumoSolicitado.Insumo.Nombre;
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            lblNombre.Dock = DockStyle.Fill;
            lblNombre.Font = new Font(Fuente.TIPOGRAFIA, Fuente.M, FontStyle.Regular);
            lblNombre.ForeColor = Color.Black;
            lblNombre.BackColor = Color.White;

            Label lblCantidad = new Label();
            lblCantidad.Text = insumoSolicitado.CantidadSolicitada.ToString();
            lblCantidad.TextAlign = ContentAlignment.MiddleCenter;
            lblCantidad.Dock = DockStyle.Fill;
            lblCantidad.Font = new Font(Fuente.TIPOGRAFIA, Fuente.M, FontStyle.Regular);
            lblCantidad.ForeColor = Color.Black;
            lblCantidad.BackColor = Color.White;

            Button btnQuitar = new Button();
            btnQuitar.Text = "×";
            btnQuitar.Dock = DockStyle.Fill;
            btnQuitar.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);
            btnQuitar.BackColor = PaletaColores.Pink;
            btnQuitar.ForeColor = Color.White;
            btnQuitar.Margin = new Padding(2);
            btnQuitar.Tag = insumoSolicitado;
            btnQuitar.Click += BtnQuitar_Click;

            listaTLP.Controls.Add(lblNombre, 0, fila);
            listaTLP.Controls.Add(lblCantidad, 1, fila);
            listaTLP.Controls.Add(btnQuitar, 2, fila);
        }

        // Botones
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            object[] tagData = (object[])btn.Tag;
            E_Insumo insumo = (E_Insumo)tagData[0];
            NumericUpDown numCantidad = (NumericUpDown)tagData[1];

            float cantidad = (float)numCantidad.Value;

            if (cantidad > insumo.Cantidad)
            {
                MessageBox.Show($"No hay suficiente stock disponible. Stock actual: {insumo.Cantidad}",
                              "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var existente = _insumosSeleccionados.FirstOrDefault(i => i.Insumo.IdInsumo == insumo.IdInsumo);

            if (existente != null)
            {
                if (existente.CantidadSolicitada + cantidad > insumo.Cantidad)
                {
                    MessageBox.Show($"La cantidad total solicitada supera el stock disponible. Stock actual: {insumo.Cantidad}",
                                  "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                existente.CantidadSolicitada += cantidad;
            }
            else
            {
                _insumosSeleccionados.Add(new E_InsumoSolicitado(insumo, cantidad));
            }

            CargarListaInsumosDisponibles();
            CargarListaInsumosSeleccionados();
        }

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            E_InsumoSolicitado insumoSolicitado = (E_InsumoSolicitado)btn.Tag;

            _insumosSeleccionados.Remove(insumoSolicitado);

            CargarListaInsumosDisponibles();
            CargarListaInsumosSeleccionados();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea cancelar la solicitud de insumos?",
                "Cancelar Solicitud",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );

            if (resultado == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (_insumosSeleccionados.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione al menos un insumo para solicitar.", "Atención",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var insumoSolicitado in _insumosSeleccionados)
            {
                var insumoActual = _insumosDisponibles.FirstOrDefault(i => i.IdInsumo == insumoSolicitado.Insumo.IdInsumo);
                if (insumoActual == null || insumoSolicitado.CantidadSolicitada > insumoActual.Cantidad)
                {
                    MessageBox.Show($"El stock del insumo '{insumoSolicitado.Insumo.Nombre}' ha cambiado. Por favor, actualice la solicitud.",
                                  "Stock modificado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CargarInsumosDisponibles();
                    return;
                }
            }

            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro que desea enviar la solicitud de insumos?\n\n" +
                $"Cantidad de insumos: {_insumosSeleccionados.Count}\n" +
                $"Profesional: {_profesional.NombreCompleto}\n\n" +
                $"📋 La solicitud será revisada por un administrativo antes de ser procesada.",
                "Confirmar Solicitud",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    var insumosParaPedido = _insumosSeleccionados
                        .Select(ip => new E_InsumoSolicitado(ip.Insumo, ip.CantidadSolicitada))
                        .ToList();

                    var nuevoPedido = new E_PedidoInsumo(
                        _profesional.IdProfesional,
                        insumosParaPedido
                    );

                    PedidoInsumoService.CrearPedidoInsumo(nuevoPedido);

                    MessageBox.Show("Solicitud de insumos enviada exitosamente.\n\n" +
                                  "Un administrativo revisará su solicitud y la procesará próximamente.",
                                  "Solicitud Enviada",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al enviar la solicitud: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
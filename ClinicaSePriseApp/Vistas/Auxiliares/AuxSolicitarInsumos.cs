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
        private static E_Profesional _Profesional;
        private static List<E_Insumo> _InsumosDisponibles;
        private static List<InsumoPedido> _InsumosSeleccionados;

        private class InsumoPedido
        {
            public E_Insumo Insumo { get; set; }
            public float CantidadSolicitada { get; set; }
        }

        public AuxSolicitarInsumos(E_Profesional profesional)
        {
            InitializeComponent();
            _Profesional = profesional;
            _InsumosSeleccionados = new List<InsumoPedido>();


            insumosTLP.ColumnStyles.Clear();
            insumosTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            insumosTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23F));
            insumosTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23F));
            insumosTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));

            listaTLP.ColumnStyles.Clear();
            listaTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43F));
            listaTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            listaTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27F));

            AplicarEstilos();
            CargarInsumosDisponibles();
        }


        // Estilos Visuales
        private void AplicarEstilos()
        {
            containerTLP.BackColor = PaletaColores.azulClaro;            

            foreach (Control boton in buttonsTLP.Controls)
            {
                boton.Dock = DockStyle.Fill;

                if (boton == btnCancelar)
                {
                    boton.BackColor = PaletaColores.rosa;
                }
                else if (boton == btnConfirmar)
                {
                    boton.BackColor = PaletaColores.azulOscuro;
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
            _InsumosDisponibles = InsumoService.ObtenerInsumos()
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

            insumosTLP.RowCount = _InsumosDisponibles.Count + 1;
            AgregarHeadersInsumosDisponibles();

            if (_InsumosDisponibles.Count == 0)
            {
                insumosTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));

                Label lblMensaje = new Label();
                lblMensaje.Text = "No hay insumos disponibles en stock";
                lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
                lblMensaje.Dock = DockStyle.Fill;
                lblMensaje.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Italic);
                lblMensaje.ForeColor = Color.White;
                lblMensaje.BackColor = PaletaColores.celeste;

                insumosTLP.Controls.Add(lblMensaje, 0, 0);
                insumosTLP.SetColumnSpan(lblMensaje, 5);
                return;
            }

            for (int i = 0; i < _InsumosDisponibles.Count; i++)
            {
                insumosTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
                AgregarFilaInsumoDisponible(_InsumosDisponibles[i], i + 1);
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
                lblHeader.BackColor = PaletaColores.azulOscuro;

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
            numCantidad.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Regular);
            numCantidad.TextAlign = HorizontalAlignment.Center;
            numCantidad.Margin = new Padding(3, 5, 3, 3);

            Button btnAgregar = new Button();
            btnAgregar.Text = "+";
            btnAgregar.Dock = DockStyle.Fill;
            btnAgregar.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);
            btnAgregar.BackColor = PaletaColores.verdeClaro;
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

            listaTLP.RowCount = _InsumosSeleccionados.Count + 1;
            AgregarHeadersInsumosSeleccionados();

            if (_InsumosSeleccionados.Count == 0)
            {
                listaTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));

                Label lblMensaje = new Label();
                lblMensaje.Text = "No hay insumos seleccionados";
                lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
                lblMensaje.Dock = DockStyle.Fill;
                lblMensaje.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Italic);
                lblMensaje.ForeColor = Color.White;
                lblMensaje.BackColor = PaletaColores.celeste;

                listaTLP.Controls.Add(lblMensaje, 0, 1);
                listaTLP.SetColumnSpan(lblMensaje, 3);
                return;
            }

            for (int i = 0; i < _InsumosSeleccionados.Count; i++)
            {
                listaTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
                AgregarFilaInsumoSeleccionado(_InsumosSeleccionados[i], i + 1);
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
                lblHeader.BackColor = PaletaColores.azulOscuro;

                listaTLP.Controls.Add(lblHeader, i, 0);
            }
        }

        private void AgregarFilaInsumoSeleccionado(InsumoPedido insumoPedido, int fila)
        {
            Label lblNombre = new Label();
            lblNombre.Text = insumoPedido.Insumo.Nombre;
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            lblNombre.Dock = DockStyle.Fill;
            lblNombre.Font = new Font(Fuente.TIPOGRAFIA, Fuente.M, FontStyle.Regular);
            lblNombre.ForeColor = Color.Black;
            lblNombre.BackColor = Color.White;

            Label lblCantidad = new Label();
            lblCantidad.Text = insumoPedido.CantidadSolicitada.ToString();
            lblCantidad.TextAlign = ContentAlignment.MiddleCenter;
            lblCantidad.Dock = DockStyle.Fill;
            lblCantidad.Font = new Font(Fuente.TIPOGRAFIA, Fuente.M, FontStyle.Regular);
            lblCantidad.ForeColor = Color.Black;
            lblCantidad.BackColor = Color.White;

            Button btnQuitar = new Button();
            btnQuitar.Text = "×";
            btnQuitar.Dock = DockStyle.Fill;
            btnQuitar.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);
            btnQuitar.BackColor = PaletaColores.rosa;
            btnQuitar.ForeColor = Color.White;
            btnQuitar.Margin = new Padding(2);
            btnQuitar.Tag = insumoPedido;
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

            var existente = _InsumosSeleccionados.FirstOrDefault(i => i.Insumo.IdInsumo == insumo.IdInsumo);

            if (existente != null)
            {
                existente.CantidadSolicitada += cantidad;
            }
            else
            {
                _InsumosSeleccionados.Add(new InsumoPedido
                {
                    Insumo = insumo,
                    CantidadSolicitada = cantidad
                });
            }

            insumo.Cantidad -= cantidad;

            CargarListaInsumosDisponibles();
            CargarListaInsumosSeleccionados();
        }

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            InsumoPedido insumoPedido = (InsumoPedido)btn.Tag;

            var insumoOriginal = _InsumosDisponibles.FirstOrDefault(i => i.IdInsumo == insumoPedido.Insumo.IdInsumo);
            if (insumoOriginal != null)
            {
                insumoOriginal.Cantidad += insumoPedido.CantidadSolicitada;
            }

            _InsumosSeleccionados.Remove(insumoPedido);

            CargarListaInsumosDisponibles();
            CargarListaInsumosSeleccionados();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea cancelar la solicitud de insumos?\n\n" +
                "Todos los insumos seleccionados serán devueltos al stock.",
                "Cancelar Solicitud",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );

            if (resultado == DialogResult.Yes)
            {
                foreach (var insumoPedido in _InsumosSeleccionados)
                {
                    var insumoOriginal = _InsumosDisponibles.FirstOrDefault(i => i.IdInsumo == insumoPedido.Insumo.IdInsumo);
                    if (insumoOriginal != null)
                    {
                        insumoOriginal.Cantidad += insumoPedido.CantidadSolicitada;
                    }
                }

                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (_InsumosSeleccionados.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione al menos un insumo para solicitar.", "Atención",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro que desea confirmar la solicitud de insumos?\n\n" +
                $"Cantidad de insumos: {_InsumosSeleccionados.Count}\n" +
                $"Profesional: {_Profesional.NombreCompleto}\n\n" +
                $"⚠️ Esta acción no se puede deshacer",
                "Confirmar Solicitud",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );

            if (confirmacion == DialogResult.Yes)
            {
                List<E_Insumo> insumosFinales = _InsumosSeleccionados
                    .Select(ip => new E_Insumo(
                        ip.Insumo.Codigo,
                        ip.Insumo.Nombre,
                        ip.Insumo.Descripcion,
                        ip.CantidadSolicitada
                    ))
                    .ToList();

                var nuevoPedido = new E_PedidoInsumo(
                    _Profesional.IdProfesional,
                    insumosFinales);

                PedidoInsumoService.CrearPedidoInsumo(nuevoPedido);

                MessageBox.Show($"Se ha cargado correctamente su solicitud de insumos.\n  CÓDIGO de Solicitud n°{nuevoPedido.IdPedido}.", "Información",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
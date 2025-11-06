using ClinicaSePriseApp.Entidades;
using ClinicaSePriseApp.Servicios;
using ClinicaSePriseApp.Utilidades;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
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
    public partial class AuxCargaGenerica : Form
    {
        public AuxCargaGenerica()
        {
            InitializeComponent();

            this.Size = new System.Drawing.Size(700, 500);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.MaximumSize = new System.Drawing.Size(700, 500);
        }

        private void AjustarMargenScroll()
        {
            bool scrollVisible = containerPanel.VerticalScroll.Visible;

            if (scrollVisible)
            {
                int anchoScroll = SystemInformation.VerticalScrollBarWidth;
                containerPanel.Padding = new Padding(0, 0, anchoScroll, 0);
            }
            else
            {
                containerPanel.Padding = new Padding(0);
            }
        }

        // PARA CARGA DE LIQUIDACIONES (PROFESIONAL)
        private E_Profesional _Profesional;

        public AuxCargaGenerica(E_Profesional profesional)
        {
            InitializeComponent();
            _Profesional = profesional;

            dataTLP.ColumnStyles.Clear();
            dataTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            dataTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            dataTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            dataTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));

            this.Text = "Clinica SePrise  ||  Consulta de Liquidaciones";

            AplicarEstilosLiquidaciones();
            CargarLiquidaciones();
            AjustarMargenScroll();
        }

        private void AplicarEstilosLiquidaciones()
        {
            mainTLP.BackColor = PaletaColores.azulClaro;
            lblTitulo.Text = "MIS LIQUIDACIONES";

            foreach (Control tlp in mainTLP.Controls)
            {
                foreach (Control label in tlp.Controls)
                {
                    label.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);
                    label.ForeColor = System.Drawing.Color.White;
                }

                tlp.ForeColor = System.Drawing.Color.White;
                btnCerrar.BackColor = PaletaColores.rosa;
                btnCerrar.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);
            }
        }

        private void CargarLiquidaciones()
        {
            if (_Profesional == null)
            {
                DialogResult resultado = MessageBox.Show(
                    "Error al buscar Profesional.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                this.Close();
                return;
            }

            lblNombre.Text = $"Profesional: {_Profesional.NombreCompleto}";
            CargarRecibos();
        }

        private void CargarRecibos()
        {
            if (_Profesional == null) return;

            var recibos = _Profesional.Liquidaciones
                .OrderByDescending(e => e.FechaLiquidacion)
                .ToList();

            dataTLP.Controls.Clear();
            dataTLP.RowStyles.Clear();

            dataTLP.RowCount = recibos.Count + 1;
            AgregarHeaderLiquidaciones(0);

            if (recibos.Count == 0)
            {
                dataTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
                dataTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));

                Label lblMensaje = new Label();
                lblMensaje.Text = "No hay liquidaciones registradas";
                lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
                lblMensaje.Dock = DockStyle.Fill;
                lblMensaje.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Italic);
                lblMensaje.ForeColor = System.Drawing.Color.White;

                dataTLP.Controls.Add(lblMensaje, 0, 1);
                dataTLP.SetColumnSpan(lblMensaje, 4);
                return;
            }

            dataTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));

            for (int i = 0; i < recibos.Count; i++)
            {
                dataTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
                AgregarFilaLiquidacion(recibos[i], i + 1);
            }

            AjustarMargenScroll();
        }

        private void AgregarHeaderLiquidaciones(int fila)
        {
            Label lblHeaderFecha = new Label();
            lblHeaderFecha.Text = "FECHA";
            lblHeaderFecha.TextAlign = ContentAlignment.MiddleCenter;
            lblHeaderFecha.Dock = DockStyle.Fill;
            lblHeaderFecha.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);
            lblHeaderFecha.ForeColor = System.Drawing.Color.White;
            lblHeaderFecha.BackColor = PaletaColores.azulOscuro;

            Label lblHeaderPeriodo = new Label();
            lblHeaderPeriodo.Text = "PERIODO";
            lblHeaderPeriodo.TextAlign = ContentAlignment.MiddleCenter;
            lblHeaderPeriodo.Dock = DockStyle.Fill;
            lblHeaderPeriodo.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);
            lblHeaderPeriodo.ForeColor = System.Drawing.Color.White;
            lblHeaderPeriodo.BackColor = PaletaColores.azulOscuro;

            Label lblHeaderMonto = new Label();
            lblHeaderMonto.Text = "MONTO";
            lblHeaderMonto.TextAlign = ContentAlignment.MiddleCenter;
            lblHeaderMonto.Dock = DockStyle.Fill;
            lblHeaderMonto.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);
            lblHeaderMonto.ForeColor = System.Drawing.Color.White;
            lblHeaderMonto.BackColor = PaletaColores.azulOscuro;

            Label lblHeaderDescargar = new Label();
            lblHeaderDescargar.Text = "COMPROBANTE";
            lblHeaderDescargar.TextAlign = ContentAlignment.MiddleCenter;
            lblHeaderDescargar.Dock = DockStyle.Fill;
            lblHeaderDescargar.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);
            lblHeaderDescargar.ForeColor = System.Drawing.Color.White;
            lblHeaderDescargar.BackColor = PaletaColores.azulOscuro;

            dataTLP.Controls.Add(lblHeaderFecha, 0, fila);
            dataTLP.Controls.Add(lblHeaderPeriodo, 1, fila);
            dataTLP.Controls.Add(lblHeaderMonto, 2, fila);
            dataTLP.Controls.Add(lblHeaderDescargar, 3, fila);
        }

        private void AgregarFilaLiquidacion(E_Liquidacion liquidacion, int fila)
        {
            System.Drawing.Color colorFondo = fila % 2 == 0 ? PaletaColores.azulClaro : PaletaColores.celeste;

            Label lblFecha = new Label();
            lblFecha.Text = liquidacion.FechaLiquidacion.ToString("MM/yyyy");
            lblFecha.TextAlign = ContentAlignment.MiddleCenter;
            lblFecha.Dock = DockStyle.Fill;
            lblFecha.Font = new Font(Fuente.TIPOGRAFIA, Fuente.M, FontStyle.Regular);
            lblFecha.ForeColor = System.Drawing.Color.White;
            lblFecha.BackColor = colorFondo;

            Label lblPeriodo = new Label();
            lblPeriodo.Text = liquidacion.PeriodoLiquidado.ToUpper();
            lblPeriodo.TextAlign = ContentAlignment.MiddleCenter;
            lblPeriodo.Dock = DockStyle.Fill;
            lblPeriodo.Font = new Font(Fuente.TIPOGRAFIA, Fuente.M, FontStyle.Regular);
            lblPeriodo.ForeColor = System.Drawing.Color.White;
            lblPeriodo.BackColor = colorFondo;

            Label lblMonto = new Label();
            lblMonto.Text = $"${liquidacion.Monto}";
            lblMonto.TextAlign = ContentAlignment.MiddleCenter;
            lblMonto.Dock = DockStyle.Fill;
            lblMonto.Font = new Font(Fuente.TIPOGRAFIA, Fuente.M, FontStyle.Bold);
            lblMonto.ForeColor = PaletaColores.verdeClaro;
            lblMonto.BackColor = colorFondo;

            Button btnDescargar = new Button();
            btnDescargar.BackgroundImage = Properties.Resources.icon_descargar;
            btnDescargar.BackgroundImageLayout = ImageLayout.Zoom;
            btnDescargar.Dock = DockStyle.Fill;
            btnDescargar.FlatStyle = FlatStyle.Flat;
            btnDescargar.FlatAppearance.BorderSize = 0;
            btnDescargar.BackColor = colorFondo;
            //btnDescargar.Margin = new Padding(10, 5, 10, 5);
            btnDescargar.Margin = new Padding(0);
            btnDescargar.Tag = liquidacion;

            btnDescargar.Click += (s, e) => DescargarComprobanteLiquidacion(liquidacion);

            dataTLP.Controls.Add(lblFecha, 0, fila);
            dataTLP.Controls.Add(lblPeriodo, 1, fila);
            dataTLP.Controls.Add(lblMonto, 2, fila);
            dataTLP.Controls.Add(btnDescargar, 3, fila);
        }

        private void DescargarComprobanteLiquidacion(E_Liquidacion liquidacion)
        {
            try
            {
                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "PDF files (*.pdf)|*.pdf";
                    saveDialog.FileName = $"{_Profesional.NombreCompleto}_Liquidacion_{liquidacion.PeriodoLiquidado}_{liquidacion.FechaLiquidacion:yyyyMMdd}.pdf";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        GenerarComprobanteLiquidacion(liquidacion, saveDialog.FileName);

                        MessageBox.Show($"Comprobante generado exitosamente:\n{saveDialog.FileName}",
                                      "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el comprobante: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerarComprobanteLiquidacion(E_Liquidacion liquidacion, string filePath)
        {
            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A5);
                    page.Margin(1.5f, Unit.Centimetre);

                    page.Header().AlignCenter().Text("RECIBO DE HONORARIOS").Bold().FontSize(14);

                    page.Content().PaddingTop(20).Column(column =>
                    {
                        column.Spacing(10);

                        column.Item().Background(Colors.Grey.Lighten3).Padding(10).Column(profColumn =>
                        {
                            profColumn.Spacing(5);
                            profColumn.Item().PaddingBottom(5).Text("DATOS DEL PROFESIONAL").Bold().FontSize(10);
                            profColumn.Item().PaddingLeft(15).Text($"Nombre: Dr. {_Profesional.NombreCompleto}");
                            profColumn.Item().PaddingLeft(15).Text($"Especialidad: {EnumHelper.GetDescription(_Profesional.Especialidad)}");
                            profColumn.Item().PaddingLeft(15).Text($"Matrícula: {_Profesional.Matricula}");
                        });

                        column.Item().Background(Colors.Grey.Lighten3).Padding(10).Column(liqColumn =>
                        {
                            liqColumn.Spacing(5);
                            liqColumn.Item().PaddingBottom(5).Text("DETALLE DE LIQUIDACIÓN").Bold().FontSize(10);
                            liqColumn.Item().PaddingLeft(15).Text($"N° Liquidación: {liquidacion.IdLiquidacion}");
                            liqColumn.Item().PaddingLeft(15).Text($"Fecha: {liquidacion.FechaLiquidacion:dd/MM/yyyy}");
                            liqColumn.Item().PaddingLeft(15).Text($"Periodo: {liquidacion.PeriodoLiquidado}");
                            liqColumn.Item().PaddingLeft(15).Text($"Monto: ${liquidacion.Monto}");
                        });
                         
                        column.Item().Background(Colors.Grey.Lighten3).Padding(10).Column(obsColumn =>
                        {
                            obsColumn.Spacing(5);
                            obsColumn.Item().PaddingBottom(5).Text("OBSERVACIONES").Bold().FontSize(10);
                            obsColumn.Item().PaddingLeft(15).Text("Pago correspondiente a honorarios profesionales por");
                            obsColumn.Item().PaddingLeft(15).Text("servicios médicos prestados en el periodo indicado.");
                        });

                    });

                    page.Footer().AlignCenter().Column(footerColumn =>
                    {
                        byte[] logoBytes;
                        using (var stream = new System.IO.MemoryStream())
                        {
                            Properties.Resources.SePrise_logoApp.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                            logoBytes = stream.ToArray();
                        }

                        footerColumn.Item().AlignCenter().Height(100).Image(logoBytes);
                        footerColumn.Item().AlignCenter().PaddingTop(5).Text("Clínica SePrise - Sistema de Gestión").FontSize(8);
                        footerColumn.Item().PaddingTop(10).LineHorizontal(0.5f);
                        footerColumn.Item().AlignCenter().PaddingTop(10).Text("Documento generado automáticamente").FontSize(7).Italic();
                    });
                });
            }).GeneratePdf(filePath);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // PARA CARGA DE TURNOS (PACIENTE)
        private E_Paciente _Paciente;

        public AuxCargaGenerica(E_Paciente paciente)
        {
            InitializeComponent();
            _Paciente = paciente;

            dataTLP.ColumnStyles.Clear();
            dataTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            dataTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            dataTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));

            AplicarEstilosTurnos();
        }

        private void AplicarEstilosTurnos()
        {
            mainTLP.BackColor = PaletaColores.azulClaro;
            lblTitulo.Text = "MIS TURNOS RESERVADOS";

            foreach (Control tlp in mainTLP.Controls)
            {
                foreach (Control label in tlp.Controls)
                {
                    label.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);
                    label.ForeColor = System.Drawing.Color.White;
                }

                tlp.ForeColor = System.Drawing.Color.White;
                btnCerrar.BackColor = PaletaColores.rosa;
                btnCerrar.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);
            }
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
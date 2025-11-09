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
        private TableLayoutPanel dataTLP;

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

        private void CrearDataTLP(int columnCount, float[] columnWidths)
        {
            if (dataTLP != null)
            {
                containerPanel.Controls.Remove(dataTLP);
                dataTLP.Dispose();
            }

            dataTLP = new TableLayoutPanel
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                ColumnCount = columnCount,
                Dock = DockStyle.Top,
                Location = new Point(0, 0),
                Margin = new Padding(0),
                Name = "dataTLP",
                RowCount = 1,
                TabIndex = 0
            };

            for (int i = 0; i < columnCount; i++)
            {
                dataTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, columnWidths[i]));
            }

            containerPanel.Controls.Add(dataTLP);
        }

        // PARA CARGA DE LIQUIDACIONES (PROFESIONAL)
        private E_Profesional _Profesional;

        public AuxCargaGenerica(E_Profesional profesional) : this()
        {
            _Profesional = profesional;

            CrearDataTLP(4, new float[] { 25F, 25F, 25F, 25F });

            this.Text = "Clinica SePrise  ||  Consulta de Liquidaciones";

            AplicarEstilosLiquidaciones();
            CargarLiquidaciones();
            AjustarMargenScroll();
        }

        // Estilos Visuales
        private void AplicarEstilosLiquidaciones()
        {
            mainTLP.BackColor = PaletaColores.LightBlue;
            lblTitulo.Text = "MIS LIQUIDACIONES";

            foreach (Control tlp in mainTLP.Controls)
            {
                foreach (Control label in tlp.Controls)
                {
                    label.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);
                    label.ForeColor = System.Drawing.Color.White;
                }

                tlp.ForeColor = System.Drawing.Color.White;
                btnCerrar.BackColor = PaletaColores.Pink;
                btnCerrar.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);
            }
        }

        // Carga de Datos
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
            lblHeaderFecha.BackColor = PaletaColores.DarkBlue;

            Label lblHeaderPeriodo = new Label();
            lblHeaderPeriodo.Text = "PERIODO";
            lblHeaderPeriodo.TextAlign = ContentAlignment.MiddleCenter;
            lblHeaderPeriodo.Dock = DockStyle.Fill;
            lblHeaderPeriodo.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);
            lblHeaderPeriodo.ForeColor = System.Drawing.Color.White;
            lblHeaderPeriodo.BackColor = PaletaColores.DarkBlue;

            Label lblHeaderMonto = new Label();
            lblHeaderMonto.Text = "MONTO";
            lblHeaderMonto.TextAlign = ContentAlignment.MiddleCenter;
            lblHeaderMonto.Dock = DockStyle.Fill;
            lblHeaderMonto.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);
            lblHeaderMonto.ForeColor = System.Drawing.Color.White;
            lblHeaderMonto.BackColor = PaletaColores.DarkBlue;

            Label lblHeaderDescargar = new Label();
            lblHeaderDescargar.Text = "COMPROBANTE";
            lblHeaderDescargar.TextAlign = ContentAlignment.MiddleCenter;
            lblHeaderDescargar.Dock = DockStyle.Fill;
            lblHeaderDescargar.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);
            lblHeaderDescargar.ForeColor = System.Drawing.Color.White;
            lblHeaderDescargar.BackColor = PaletaColores.DarkBlue;

            dataTLP.Controls.Add(lblHeaderFecha, 0, fila);
            dataTLP.Controls.Add(lblHeaderPeriodo, 1, fila);
            dataTLP.Controls.Add(lblHeaderMonto, 2, fila);
            dataTLP.Controls.Add(lblHeaderDescargar, 3, fila);
        }

        private void AgregarFilaLiquidacion(E_Liquidacion liquidacion, int fila)
        {
            System.Drawing.Color colorFondo = fila % 2 == 0 ? PaletaColores.LightBlue : PaletaColores.Skyblue;

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
            lblMonto.ForeColor = PaletaColores.LightGreen;
            lblMonto.BackColor = colorFondo;

            Button btnDescargar = new Button();
            btnDescargar.BackgroundImage = Properties.Resources.icon_descargar;
            btnDescargar.BackgroundImageLayout = ImageLayout.Zoom;
            btnDescargar.Dock = DockStyle.Fill;
            btnDescargar.FlatStyle = FlatStyle.Flat;
            btnDescargar.FlatAppearance.BorderSize = 0;
            btnDescargar.BackColor = colorFondo;
            btnDescargar.Margin = new Padding(0);
            btnDescargar.Tag = liquidacion;

            btnDescargar.Click += (s, e) => DescargarComprobanteLiquidacion(liquidacion);

            dataTLP.Controls.Add(lblFecha, 0, fila);
            dataTLP.Controls.Add(lblPeriodo, 1, fila);
            dataTLP.Controls.Add(lblMonto, 2, fila);
            dataTLP.Controls.Add(btnDescargar, 3, fila);
        }

        // Metodos Auxiliares
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

        // Botones        
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        // PARA CARGA DE TURNOS (PACIENTE)
        private E_Paciente _Paciente;
        public AuxCargaGenerica(E_Paciente paciente, List<E_Turno> turnos) : this()
        {
            _Paciente = paciente;

            CrearDataTLP(3, new float[] { 30F, 50F, 20F });

            this.Text = "Clínica SePrise  ||  Consulta de Turnos del Paciente";

            AplicarEstilosTurnos();
            CargarTurnosPaciente(turnos);
            AjustarMargenScroll();
        }

        // Estilos Visuales para Turnos
        private void AplicarEstilosTurnos()
        {
            mainTLP.BackColor = PaletaColores.LightBlue;
            lblTitulo.Text = "MIS TURNOS RESERVADOS";
            lblNombre.Text = $"Paciente: {_Paciente.NombreCompleto}";

            foreach (Control tlp in mainTLP.Controls)
            {
                foreach (Control label in tlp.Controls)
                {
                    label.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);
                    label.ForeColor = System.Drawing.Color.White;
                }

                tlp.ForeColor = System.Drawing.Color.White;
                btnCerrar.BackColor = PaletaColores.Pink;
                btnCerrar.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);
            }
        }

        // Carga de Datos
        private void CargarTurnosPaciente(List<E_Turno> turnos)
        {
            if (_Paciente == null || turnos == null)
            {
                DialogResult resultado = MessageBox.Show(
                    "Error al cargar los turnos del paciente.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                this.Close();
                return;
            }

            CargarListaTurnos(turnos);
        }

        private void CargarListaTurnos(List<E_Turno> turnos)
        {
            dataTLP.Controls.Clear();
            dataTLP.RowStyles.Clear();

            dataTLP.RowCount = turnos.Count + 1;
            AgregarHeaderTurnos(0);

            if (turnos.Count == 0)
            {
                dataTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
                dataTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));

                Label lblMensaje = new Label();
                lblMensaje.Text = "No hay turnos registrados para este paciente";
                lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
                lblMensaje.Dock = DockStyle.Fill;
                lblMensaje.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Italic);
                lblMensaje.ForeColor = System.Drawing.Color.White;

                dataTLP.Controls.Add(lblMensaje, 0, 1);
                dataTLP.SetColumnSpan(lblMensaje, 3);
                return;
            }

            dataTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));

            for (int i = 0; i < turnos.Count; i++)
            {
                dataTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
                AgregarFilaTurno(turnos[i], i + 1);
            }

            AjustarMargenScroll();
        }

        private void AgregarHeaderTurnos(int fila)
        {
            string[] headers = { "FECHA", "MÉDICO", "ESTADO" };

            for (int i = 0; i < headers.Length; i++)
            {
                Label lblHeader = new Label();
                lblHeader.Text = headers[i];
                lblHeader.TextAlign = ContentAlignment.MiddleCenter;
                lblHeader.Dock = DockStyle.Fill;
                lblHeader.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);
                lblHeader.ForeColor = System.Drawing.Color.White;
                lblHeader.BackColor = PaletaColores.DarkBlue;

                dataTLP.Controls.Add(lblHeader, i, fila);
            }
        }

        private void AgregarFilaTurno(E_Turno turno, int fila)
        {
            System.Drawing.Color colorFondo = fila % 2 == 0 ? PaletaColores.LightBlue : PaletaColores.Skyblue;

            Label lblFecha = new Label();
            lblFecha.Text = turno.FechaTurno.ToString("dd/MM/yyyy");
            lblFecha.TextAlign = ContentAlignment.MiddleCenter;
            lblFecha.Dock = DockStyle.Fill;
            lblFecha.Font = new Font(Fuente.TIPOGRAFIA, Fuente.M, FontStyle.Regular);
            lblFecha.ForeColor = System.Drawing.Color.White;
            lblFecha.BackColor = colorFondo;

            Label lblMedico = new Label();
            var profesional = ProfesionalService.ObtenerProfesionalPorID(turno.IdProfesional);
            lblMedico.Text = profesional?.NombreCompleto ?? "No encontrado";
            lblMedico.TextAlign = ContentAlignment.MiddleCenter;
            lblMedico.Dock = DockStyle.Fill;
            lblMedico.Font = new Font(Fuente.TIPOGRAFIA, Fuente.M, FontStyle.Regular);
            lblMedico.ForeColor = System.Drawing.Color.White;
            lblMedico.BackColor = colorFondo;

            Label lblEstado = new Label();
            lblEstado.Text = EnumHelper.GetDescription(turno.Estado);
            lblEstado.TextAlign = ContentAlignment.MiddleCenter;
            lblEstado.Dock = DockStyle.Fill;
            lblEstado.Font = new Font(Fuente.TIPOGRAFIA, Fuente.M, FontStyle.Bold);
            lblEstado.ForeColor = ObtenerColorEstadoTurno(turno.Estado);
            lblEstado.BackColor = colorFondo;

            dataTLP.Controls.Add(lblFecha, 0, fila);
            dataTLP.Controls.Add(lblMedico, 1, fila);
            dataTLP.Controls.Add(lblEstado, 2, fila);
        }

        private System.Drawing.Color ObtenerColorEstadoTurno(Entidades.Enums.EstadoTurno estado)
        {
            switch (estado)
            {
                case Entidades.Enums.EstadoTurno.ASIGNADO:
                    return System.Drawing.Color.Orange;
                case Entidades.Enums.EstadoTurno.ABONADO:
                    return PaletaColores.LightGreen;                
                case Entidades.Enums.EstadoTurno.FINALIZADO:
                    return System.Drawing.Color.LightBlue;
                default:
                    return System.Drawing.Color.White;
            }
        }


        // PARA CARGA DE PAGOS (PACIENTE)
        public AuxCargaGenerica(E_Paciente paciente, List<E_Pago> pagos) : this()
        {
            _Paciente = paciente;

            CrearDataTLP(4, new float[] { 25F, 20F, 25F, 30F });

            this.Text = "Clínica SePrise  ||  Consulta de Pagos del Paciente";

            AplicarEstilosPagos();
            CargarPagosPaciente(pagos);
            AjustarMargenScroll();
        }

        // Estilos Visuales
        private void AplicarEstilosPagos()
        {
            mainTLP.BackColor = PaletaColores.LightBlue;
            lblTitulo.Text = "MIS PAGOS REALIZADOS";
            lblNombre.Text = $"Paciente: {_Paciente.NombreCompleto}";

            foreach (Control tlp in mainTLP.Controls)
            {
                foreach (Control label in tlp.Controls)
                {
                    label.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);
                    label.ForeColor = System.Drawing.Color.White;
                }

                tlp.ForeColor = System.Drawing.Color.White;
                btnCerrar.BackColor = PaletaColores.Pink;
                btnCerrar.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);
            }
        }

        // Carga de Datos
        private void CargarPagosPaciente(List<E_Pago> pagos)
        {
            if (_Paciente == null || pagos == null)
            {
                DialogResult resultado = MessageBox.Show(
                    "Error al cargar los pagos del paciente.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                this.Close();
                return;
            }

            CargarListaPagos(pagos);
        }

        private void CargarListaPagos(List<E_Pago> pagos)
        {
            dataTLP.Controls.Clear();
            dataTLP.RowStyles.Clear();

            dataTLP.RowCount = pagos.Count + 1;
            AgregarHeaderPagos(0);

            if (pagos.Count == 0)
            {
                dataTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
                dataTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));

                Label lblMensaje = new Label();
                lblMensaje.Text = "No hay pagos registrados para este paciente";
                lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
                lblMensaje.Dock = DockStyle.Fill;
                lblMensaje.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Italic);
                lblMensaje.ForeColor = System.Drawing.Color.White;

                dataTLP.Controls.Add(lblMensaje, 0, 1);
                dataTLP.SetColumnSpan(lblMensaje, 4);
                return;
            }

            dataTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));

            for (int i = 0; i < pagos.Count; i++)
            {
                dataTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
                AgregarFilaPago(pagos[i], i + 1);
            }

            AjustarMargenScroll();
        }

        private void AgregarHeaderPagos(int fila)
        {
            string[] headers = { "FECHA", "MONTO", "ESTADO", "MÉTODO DE PAGO" };

            for (int i = 0; i < headers.Length; i++)
            {
                Label lblHeader = new Label();
                lblHeader.Text = headers[i];
                lblHeader.TextAlign = ContentAlignment.MiddleCenter;
                lblHeader.Dock = DockStyle.Fill;
                lblHeader.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);
                lblHeader.ForeColor = System.Drawing.Color.White;
                lblHeader.BackColor = PaletaColores.DarkBlue;

                dataTLP.Controls.Add(lblHeader, i, fila);
            }
        }

        private void AgregarFilaPago(E_Pago pago, int fila)
        {
            System.Drawing.Color colorFondo = fila % 2 == 0 ? PaletaColores.LightBlue : PaletaColores.Skyblue;

            Label lblFecha = new Label();
            lblFecha.Text = pago.FechaPago?.ToString("dd/MM/yyyy") ?? "PENDIENTE";
            lblFecha.TextAlign = ContentAlignment.MiddleCenter;
            lblFecha.Dock = DockStyle.Fill;
            lblFecha.Font = new Font(Fuente.TIPOGRAFIA, Fuente.M, FontStyle.Regular);
            lblFecha.ForeColor = System.Drawing.Color.White;
            lblFecha.BackColor = colorFondo;

            Label lblMonto = new Label();
            lblMonto.Text = $"${pago.Monto}";
            lblMonto.TextAlign = ContentAlignment.MiddleCenter;
            lblMonto.Dock = DockStyle.Fill;
            lblMonto.Font = new Font(Fuente.TIPOGRAFIA, Fuente.M, FontStyle.Bold);
            lblMonto.ForeColor = PaletaColores.LightGreen;
            lblMonto.BackColor = colorFondo;

            Label lblEstado = new Label();
            lblEstado.Text = EnumHelper.GetDescription(pago.Estado);
            lblEstado.TextAlign = ContentAlignment.MiddleCenter;
            lblEstado.Dock = DockStyle.Fill;
            lblEstado.Font = new Font(Fuente.TIPOGRAFIA, Fuente.M, FontStyle.Bold);
            lblEstado.ForeColor = ObtenerColorEstadoPago(pago.Estado);
            lblEstado.BackColor = colorFondo;

            Label lblMetodo = new Label();
            lblMetodo.Text = pago.MetodoPago.HasValue
                ? EnumHelper.GetDescription(pago.MetodoPago.Value)
                : "NO ESPECIFICADO";
            lblMetodo.TextAlign = ContentAlignment.MiddleCenter;
            lblMetodo.Dock = DockStyle.Fill;
            lblMetodo.Font = new Font(Fuente.TIPOGRAFIA, Fuente.M, FontStyle.Regular);
            lblMetodo.ForeColor = System.Drawing.Color.White;
            lblMetodo.BackColor = colorFondo;

            dataTLP.Controls.Add(lblFecha, 0, fila);
            dataTLP.Controls.Add(lblMonto, 1, fila);
            dataTLP.Controls.Add(lblEstado, 2, fila);
            dataTLP.Controls.Add(lblMetodo, 3, fila);
        }

        private System.Drawing.Color ObtenerColorEstadoPago(Entidades.Enums.EstadoPago estado)
        {
            switch (estado)
            {
                case Entidades.Enums.EstadoPago.PENDIENTE:
                    return System.Drawing.Color.Orange;
                case Entidades.Enums.EstadoPago.REALIZADO:
                    return PaletaColores.LightGreen;
                case Entidades.Enums.EstadoPago.RECHAZADO:
                    return System.Drawing.Color.Red;
                default:
                    return System.Drawing.Color.White;
            }
        }



        // PARA CARGA DE INSUMOS (CONSULTORIO)
        private E_Consultorio _Consultorio;
        public AuxCargaGenerica(E_Consultorio consultorio) : this()
        {
            _Consultorio = consultorio;

            CrearDataTLP(3, new float[] { 20F, 50F, 30F });

            this.Text = "Clínica SePrise  ||  Gestión de Insumos del Consultorio";

            AplicarEstilosInsumosConsultorio();
            CargarInsumosConsultorio();
            AjustarMargenScroll();
        }

        // Estilos Visuales
        private void AplicarEstilosInsumosConsultorio()
        {
            mainTLP.BackColor = PaletaColores.LightBlue;
            lblTitulo.Text = $"INSUMOS - CONSULTORIO {_Consultorio.IdConsultorio}";
            lblNombre.Text = $"Profesional: {ObtenerNombreProfesional()} - Especialidad: {ObtenerEspecialidadProfesional()}";

            foreach (Control tlp in mainTLP.Controls)
            {
                foreach (Control label in tlp.Controls)
                {
                    label.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);
                    label.ForeColor = System.Drawing.Color.White;
                }

                tlp.ForeColor = System.Drawing.Color.White;
                btnCerrar.BackColor = PaletaColores.Pink;
                btnCerrar.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);
            }
        }

        // Metodos Auxiliares
        private string ObtenerNombreProfesional()
        {
            if (_Consultorio.IdProfesional == 0)
                return "Sin asignar";

            var profesional = ProfesionalService.ObtenerProfesionalPorID(_Consultorio.IdProfesional);
            return profesional?.NombreCompleto ?? "No encontrado";
        }

        private string ObtenerEspecialidadProfesional()
        {
            if (_Consultorio.IdProfesional == 0)
                return "Sin especialidad";

            var profesional = ProfesionalService.ObtenerProfesionalPorID(_Consultorio.IdProfesional);
            return profesional != null ? EnumHelper.GetDescription(profesional.Especialidad) : "No encontrada";
        }
        private List<E_Insumo> ObtenerInsumosPorEspecialidad()
        {
            if (_Consultorio.IdProfesional == 0)
                return new List<E_Insumo>();

            var profesional = ProfesionalService.ObtenerProfesionalPorID(_Consultorio.IdProfesional);
            if (profesional == null)
                return new List<E_Insumo>();

            switch (profesional.Especialidad)
            {
                case Entidades.Enums.EspecialidadMedica.CARDIOLOGIA:
                    return new List<E_Insumo>
            {
                new E_Insumo("CAR-001", "Electrocardiógrafo", "Equipo para ECG", 2),
                new E_Insumo("CAR-002", "Monitor Cardiaco", "Monitor de signos vitales", 3),
                new E_Insumo("CAR-003", "Estetoscopio Cardiológico", "Estetoscopio especializado", 5),
                new E_Insumo("CAR-004", "Tensiómetro Digital", "Medidor de presión arterial", 4),
                new E_Insumo("CAR-005", "Desfibrilador", "Equipo de emergencia cardíaca", 1),
                new E_Insumo("CAR-006", "Jeringas Cardiacas", "Jeringas especiales", 15),
                new E_Insumo("CAR-007", "Catéteres", "Catéteres diversos", 8),
                new E_Insumo("CAR-008", "Guantes Estériles", "Guantes quirúrgicos", 25)
            };

                case Entidades.Enums.EspecialidadMedica.CLINICA_MEDICA:
                    return new List<E_Insumo>
            {
                new E_Insumo("CLI-001", "Estetoscopio", "Estetoscopio profesional", 6),
                new E_Insumo("CLI-002", "Otoscopio", "Equipo para examen auditivo", 3),
                new E_Insumo("CLI-003", "Oftalmoscopio", "Equipo para examen ocular", 2),
                new E_Insumo("CLI-004", "Termómetro Digital", "Medidor de temperatura", 5),
                new E_Insumo("CLI-005", "Balanza", "Báscula médica", 2),
                new E_Insumo("CLI-006", "Talla Metro", "Medidor de altura", 3),
                new E_Insumo("CLI-007", "Martillo Reflejo", "Probador de reflejos", 4),
                new E_Insumo("CLI-008", "Guantes de Latex", "Guantes de examen", 30),
                new E_Insumo("CLI-009", "Jeringas Descartables", "Jeringas 5-10ml", 20),
                new E_Insumo("CLI-010", "Agujas Estériles", "Agujas diversas", 25)
            };

                case Entidades.Enums.EspecialidadMedica.NEUROLOGIA:
                    return new List<E_Insumo>
            {
                new E_Insumo("NEU-001", "Martillo Reflejo Neurológico", "Martillo especializado", 3),
                new E_Insumo("NEU-002", "Agujas para EMG", "Agujas para electromiografía", 12),
                new E_Insumo("NEU-003", "Electrodos EEG", "Electrodos para electroencefalograma", 20),
                new E_Insumo("NEU-004", "Linterna Neurológica", "Linterna para pupilas", 4),
                new E_Insumo("NEU-005", "Diapasón", "Probador de vibración", 3),
                new E_Insumo("NEU-006", "Pinzas de Babinski", "Pinzas para reflejos", 2),
                new E_Insumo("NEU-007", "Monitor EEG", "Monitor de actividad cerebral", 1),
                new E_Insumo("NEU-008", "Guantes Sin Talco", "Guantes para procedimientos", 18),
                new E_Insumo("NEU-009", "Jeringas Tuberculina", "Jeringas para pruebas", 15)
            };

                default:
                    return new List<E_Insumo>
            {
                new E_Insumo("GEN-001", "Guantes Estériles", "Guantes de uso general", 10),
                new E_Insumo("GEN-002", "Mascarillas", "Barbijos quirúrgicos", 20),
                new E_Insumo("GEN-003", "Jeringas", "Jeringas descartables", 15),
                new E_Insumo("GEN-004", "Algodón", "Algodón estéril", 8),
                new E_Insumo("GEN-005", "Alcohol", "Alcohol en gel", 5)
            };
            }
        }

        // Carga de Datos
        private void CargarInsumosConsultorio()
        {
            if (_Consultorio == null)
            {
                DialogResult resultado = MessageBox.Show(
                    "Error al cargar el consultorio.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                this.Close();
                return;
            }

            CargarListaInsumos();
        }

        private void CargarListaInsumos()
        {
            var insumos = ObtenerInsumosPorEspecialidad();

            dataTLP.Controls.Clear();
            dataTLP.RowStyles.Clear();

            dataTLP.RowCount = insumos.Count + 1;
            AgregarHeaderInsumos(0);

            if (insumos.Count == 0)
            {
                dataTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
                dataTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));

                Label lblMensaje = new Label();
                lblMensaje.Text = "No hay insumos asignados a este consultorio";
                lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
                lblMensaje.Dock = DockStyle.Fill;
                lblMensaje.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Italic);
                lblMensaje.ForeColor = System.Drawing.Color.White;

                dataTLP.Controls.Add(lblMensaje, 0, 1);
                dataTLP.SetColumnSpan(lblMensaje, 3);
                return;
            }

            dataTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));

            for (int i = 0; i < insumos.Count; i++)
            {
                dataTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
                AgregarFilaInsumo(insumos[i], i + 1);
            }

            AjustarMargenScroll();
        }


        private void AgregarHeaderInsumos(int fila)
        {
            string[] headers = { "COD", "NOMBRE", "CANTIDAD" };

            for (int i = 0; i < headers.Length; i++)
            {
                Label lblHeader = new Label();
                lblHeader.Text = headers[i];
                lblHeader.TextAlign = ContentAlignment.MiddleCenter;
                lblHeader.Dock = DockStyle.Fill;
                lblHeader.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);
                lblHeader.ForeColor = System.Drawing.Color.White;
                lblHeader.BackColor = PaletaColores.DarkBlue;

                dataTLP.Controls.Add(lblHeader, i, fila);
            }
        }

        private void AgregarFilaInsumo(E_Insumo insumo, int fila)
        {
            System.Drawing.Color colorFondo = fila % 2 == 0 ? PaletaColores.LightBlue : PaletaColores.Skyblue;

            Label lblCodigo = new Label();
            lblCodigo.Text = insumo.Codigo;
            lblCodigo.TextAlign = ContentAlignment.MiddleCenter;
            lblCodigo.Dock = DockStyle.Fill;
            lblCodigo.Font = new Font(Fuente.TIPOGRAFIA, Fuente.M, FontStyle.Regular);
            lblCodigo.ForeColor = System.Drawing.Color.White;
            lblCodigo.BackColor = colorFondo;

            Label lblNombre = new Label();
            lblNombre.Text = insumo.Nombre;
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            lblNombre.Dock = DockStyle.Fill;
            lblNombre.Font = new Font(Fuente.TIPOGRAFIA, Fuente.M, FontStyle.Regular);
            lblNombre.ForeColor = System.Drawing.Color.White;
            lblNombre.BackColor = colorFondo;

            Label lblCantidad = new Label();
            lblCantidad.Text = insumo.Cantidad.ToString();
            lblCantidad.TextAlign = ContentAlignment.MiddleCenter;
            lblCantidad.Dock = DockStyle.Fill;
            lblCantidad.Font = new Font(Fuente.TIPOGRAFIA, Fuente.M, FontStyle.Bold);
            lblCantidad.ForeColor = ObtenerColorCantidad(insumo.Cantidad);
            lblCantidad.BackColor = colorFondo;

            dataTLP.Controls.Add(lblCodigo, 0, fila);
            dataTLP.Controls.Add(lblNombre, 1, fila);
            dataTLP.Controls.Add(lblCantidad, 2, fila);
        }

        private System.Drawing.Color ObtenerColorCantidad(float cantidad)
        {
            if (cantidad == 0) return System.Drawing.Color.Red;
            if (cantidad < 3) return System.Drawing.Color.Orange;
            if (cantidad < 6) return System.Drawing.Color.Yellow;
            return PaletaColores.LightGreen;
        }



        // PARA VISUALIZACION DE SOLICITUDES DE INSUMO
        private List<E_PedidoInsumo> _Solicitudes;
        public AuxCargaGenerica(List<E_PedidoInsumo> solicitudes) : this()
        {
            _Solicitudes = solicitudes;

            CrearDataTLP(6, new float[] { 20F, 12F, 26F, 14F, 14F, 14F });

            this.Text = "Clínica SePrise  ||  Gestión de Solicitudes de Insumos";

            AplicarEstilosSolicitudes();
            CargarSolicitudes();
            AjustarMargenScroll();
        }

        // Estilos Visuales
        private void AplicarEstilosSolicitudes()
        {
            mainTLP.BackColor = PaletaColores.LightBlue;
            lblTitulo.Text = "SOLICITUDES DE INSUMOS PENDIENTES";
            lblNombre.Text = $"Total de solicitudes: {_Solicitudes?.Count ?? 0}";

            foreach (Control tlp in mainTLP.Controls)
            {
                foreach (Control label in tlp.Controls)
                {
                    label.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);
                    label.ForeColor = System.Drawing.Color.White;
                }

                tlp.ForeColor = System.Drawing.Color.White;
                btnCerrar.BackColor = PaletaColores.Pink;
                btnCerrar.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);
            }
        }

        // Carga de Datos
        private void CargarSolicitudes()
        {
            if (_Solicitudes == null || _Solicitudes.Count == 0)
            {
                DialogResult resultado = MessageBox.Show(
                    "No hay solicitudes de insumos para mostrar.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                this.Close();
                return;
            }

            CargarListaSolicitudes();
        }

        private void CargarListaSolicitudes()
        {
            dataTLP.Controls.Clear();
            dataTLP.RowStyles.Clear();

            dataTLP.RowCount = _Solicitudes.Count + 1;
            AgregarHeaderSolicitudes(0);

            if (_Solicitudes.Count == 0)
            {
                dataTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
                dataTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));

                Label lblMensaje = new Label();
                lblMensaje.Text = "No hay solicitudes de insumos pendientes";
                lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
                lblMensaje.Dock = DockStyle.Fill;
                lblMensaje.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Italic);
                lblMensaje.ForeColor = System.Drawing.Color.White;

                dataTLP.Controls.Add(lblMensaje, 0, 1);
                dataTLP.SetColumnSpan(lblMensaje, 6);
                return;
            }

            dataTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));

            for (int i = 0; i < _Solicitudes.Count; i++)
            {
                dataTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
                AgregarFilaSolicitud(_Solicitudes[i], i + 1);
            }

            AjustarMargenScroll();
        }

        private void AgregarHeaderSolicitudes(int fila)
        {
            string[] headers = { "FECHA", "CONS.", "PROFESIONAL", "VER", "✅", "❌" };

            for (int i = 0; i < headers.Length; i++)
            {
                Label lblHeader = new Label();
                lblHeader.Text = headers[i];
                lblHeader.TextAlign = ContentAlignment.MiddleCenter;
                lblHeader.Dock = DockStyle.Fill;
                lblHeader.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);
                lblHeader.ForeColor = System.Drawing.Color.White;
                lblHeader.BackColor = PaletaColores.DarkBlue;

                dataTLP.Controls.Add(lblHeader, i, fila);
            }
        }

        private void AgregarFilaSolicitud(E_PedidoInsumo solicitud, int fila)
        {
            System.Drawing.Color colorFondo = fila % 2 == 0 ? PaletaColores.LightBlue : PaletaColores.Skyblue;

            Label lblFecha = new Label();
            lblFecha.Text = solicitud.FechaPedido.ToString("dd/MM/yyyy");
            lblFecha.TextAlign = ContentAlignment.MiddleCenter;
            lblFecha.Dock = DockStyle.Fill;
            lblFecha.Font = new Font(Fuente.TIPOGRAFIA, Fuente.M, FontStyle.Regular);
            lblFecha.ForeColor = System.Drawing.Color.White;
            lblFecha.BackColor = colorFondo;

            Label lblConsultorio = new Label();
            int idConsultorio = ConsultorioService.ObtenerConsultorioPorProfesional(solicitud.IdProfesional);
            lblConsultorio.Text = idConsultorio > 0 ? $"N° {idConsultorio}" : "Sin asignar";
            lblConsultorio.TextAlign = ContentAlignment.MiddleCenter;
            lblConsultorio.Dock = DockStyle.Fill;
            lblConsultorio.Font = new Font(Fuente.TIPOGRAFIA, Fuente.M, FontStyle.Regular);
            lblConsultorio.ForeColor = System.Drawing.Color.White;
            lblConsultorio.BackColor = colorFondo;

            Label lblProfesional = new Label();
            var profesional = ProfesionalService.ObtenerProfesionalPorID(solicitud.IdProfesional);
            lblProfesional.Text = profesional?.NombreCompleto ?? "No encontrado";
            lblProfesional.TextAlign = ContentAlignment.MiddleCenter;
            lblProfesional.Dock = DockStyle.Fill;
            lblProfesional.Font = new Font(Fuente.TIPOGRAFIA, Fuente.M, FontStyle.Regular);
            lblProfesional.ForeColor = System.Drawing.Color.White;
            lblProfesional.BackColor = colorFondo;

            Button btnVer = new Button();
            btnVer.Text = "👁️";
            btnVer.Dock = DockStyle.Fill;
            btnVer.FlatStyle = FlatStyle.Flat;
            btnVer.FlatAppearance.BorderSize = 0;
            btnVer.BackColor = PaletaColores.LightBlue;
            btnVer.ForeColor = System.Drawing.Color.White;
            btnVer.Font = new Font(Fuente.TIPOGRAFIA, Fuente.M, FontStyle.Bold);
            btnVer.Margin = new Padding(2);
            btnVer.Tag = solicitud;
            btnVer.Click += (s, e) => VerDetalleSolicitud(solicitud);

            Button btnAceptar = new Button();
            btnAceptar.Text = "✅";
            btnAceptar.Dock = DockStyle.Fill;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.BackColor = PaletaColores.LightGreen;
            btnAceptar.ForeColor = System.Drawing.Color.White;
            btnAceptar.Font = new Font(Fuente.TIPOGRAFIA, Fuente.M, FontStyle.Bold);
            btnAceptar.Margin = new Padding(2);
            btnAceptar.Tag = solicitud;
            btnAceptar.Click += (s, e) => AceptarSolicitud(solicitud);

            Button btnRechazar = new Button();
            btnRechazar.Text = "❌";
            btnRechazar.Dock = DockStyle.Fill;
            btnRechazar.FlatStyle = FlatStyle.Flat;
            btnRechazar.FlatAppearance.BorderSize = 0;
            btnRechazar.BackColor = PaletaColores.Pink;
            btnRechazar.ForeColor = System.Drawing.Color.White;
            btnRechazar.Font = new Font(Fuente.TIPOGRAFIA, Fuente.M, FontStyle.Bold);
            btnRechazar.Margin = new Padding(2);
            btnRechazar.Tag = solicitud;
            btnRechazar.Click += (s, e) => RechazarSolicitud(solicitud);

            dataTLP.Controls.Add(lblFecha, 0, fila);
            dataTLP.Controls.Add(lblConsultorio, 1, fila);
            dataTLP.Controls.Add(lblProfesional, 2, fila);
            dataTLP.Controls.Add(btnVer, 3, fila);
            dataTLP.Controls.Add(btnAceptar, 4, fila);
            dataTLP.Controls.Add(btnRechazar, 5, fila);
        }

        private void VerDetalleSolicitud(E_PedidoInsumo solicitud)
        {
            try
            {
                var profesional = ProfesionalService.ObtenerProfesionalPorID(solicitud.IdProfesional);
                int idConsultorio = ConsultorioService.ObtenerConsultorioPorProfesional(solicitud.IdProfesional);

                StringBuilder detalle = new StringBuilder();
                detalle.AppendLine($"📋 DETALLE DE SOLICITUD #{solicitud.IdPedido}");
                detalle.AppendLine();
                detalle.AppendLine($"📅 Fecha: {solicitud.FechaPedido:dd/MM/yyyy}");
                detalle.AppendLine($"👨‍⚕️ Profesional: {profesional?.NombreCompleto ?? "No encontrado"}");
                detalle.AppendLine($"🏥 Consultorio: {(idConsultorio > 0 ? $"Consultorio {idConsultorio}" : "Sin asignar")}");
                detalle.AppendLine($"📦 Estado: {solicitud.EstadoPedidoInsumo}");
                detalle.AppendLine();
                detalle.AppendLine("📦 INSUMOS SOLICITADOS:");
                detalle.AppendLine();

                if (solicitud.InsumosSolicitados != null && solicitud.InsumosSolicitados.Count > 0)
                {
                    foreach (var insumoSolicitado in solicitud.InsumosSolicitados)
                    {
                        detalle.AppendLine($"• {insumoSolicitado.Insumo.Nombre} - Cantidad: {insumoSolicitado.CantidadSolicitada}");
                    }
                }
                else
                {
                    detalle.AppendLine("No hay insumos en esta solicitud");
                }

                MessageBox.Show(detalle.ToString(), "Detalle de Solicitud",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar el detalle: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AceptarSolicitud(E_PedidoInsumo solicitud)
        {
            try
            {
                DialogResult confirmacion = MessageBox.Show(
                    $"¿Está seguro que desea ACEPTAR la solicitud #{solicitud.IdPedido}?\n\n" +
                    $"Profesional: {ProfesionalService.ObtenerProfesionalPorID(solicitud.IdProfesional)?.NombreCompleto}\n" +
                    $"Cantidad de insumos: {solicitud.InsumosSolicitados?.Count ?? 0}",
                    "Confirmar Aceptación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    // Lógica para aceptar la solicitud

                    MessageBox.Show($"Solicitud #{solicitud.IdPedido} aceptada correctamente.",
                                  "Solicitud Aceptada",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarListaSolicitudes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al aceptar la solicitud: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RechazarSolicitud(E_PedidoInsumo solicitud)
        {
            try
            {
                DialogResult confirmacion = MessageBox.Show(
                    $"¿Está seguro que desea RECHAZAR la solicitud #{solicitud.IdPedido}?\n\n" +
                    $"Profesional: {ProfesionalService.ObtenerProfesionalPorID(solicitud.IdProfesional)?.NombreCompleto}\n\n" +
                    $"⚠️ Esta acción no se puede deshacer",
                    "Confirmar Rechazo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmacion == DialogResult.Yes)
                {
                    PedidoInsumoService.EliminarPedidoInsumo(solicitud);

                    _Solicitudes.Remove(solicitud);

                    MessageBox.Show($"Solicitud #{solicitud.IdPedido} rechazada y eliminada correctamente.",
                                  "Solicitud Rechazada",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarListaSolicitudes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al rechazar la solicitud: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
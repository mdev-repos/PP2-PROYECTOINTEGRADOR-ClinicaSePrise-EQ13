using ClinicaSePriseApp.Entidades;
using ClinicaSePriseApp.Entidades.Enums;
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
    public partial class AuxPagoTurno : Form
    {
        private E_Pago _Pago;

        public AuxPagoTurno()
        {
            InitializeComponent();

            _Pago = null;

            this.Size = new System.Drawing.Size(700, 500);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public AuxPagoTurno(E_Pago pago)
        {
            InitializeComponent();

            _Pago = pago;

            AplicarEstilos();

            CargarMedios();

            btnImprimir.Enabled = false;
        }

        // Estilo
        private void AplicarEstilos() 
        {
            containerTLP.BackColor = PaletaColores.bgGris;


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
                else
                {
                    boton.BackColor = PaletaColores.azulVerde;
                }

                boton.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);
                boton.ForeColor = System.Drawing.Color.White;
            }
        }


        // Metodos
        private void CargarMedios()
        {
            var mediosPago = new List<string> { string.Empty };

            foreach (MetodoPago med in Enum.GetValues(typeof(MetodoPago)))
            {
                mediosPago.Add(EnumHelper.GetDescription(med));
            }

            cboxMedioPago.DataSource = mediosPago;
        }

        private MetodoPago? StringAMetodo(string descripcion)
        {
            if (string.IsNullOrEmpty(descripcion) || descripcion == "")
                return null;

            foreach (MetodoPago med in Enum.GetValues(typeof(MetodoPago)))
            { 
                if(EnumHelper.GetDescription(med) == descripcion) return med;            
            }

            return null;
        }

        private void GenerarComprobantePDF(E_Pago pago, string filePath)
        {
            var turno = TurnoService.ObtenerTurnoPorID(pago.IdTurno);
            var profesional = ProfesionalService.ObtenerProfesionalPorID(turno.IdProfesional);

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A5);
                    page.Margin(1.5f, Unit.Centimetre);

                    page.Header().AlignCenter().Text("CLÍNICA SEPRISE").Bold().FontSize(14);

                    page.Content().PaddingTop(20).Column(column =>
                    {
                        column.Spacing(10);

                        column.Item().Background(Colors.Grey.Lighten3).Padding(10).Column(turnoColumn =>
                        {
                            turnoColumn.Spacing(5);
                            turnoColumn.Item().PaddingBottom(10).Text("DETALLE DEL TURNO").Bold().FontSize(10);
                            turnoColumn.Item().PaddingLeft(20).Text($"Fecha de Turno: {turno.FechaTurno:dd/MM/yyyy}");
                            turnoColumn.Item().PaddingLeft(20).Text($"Hora: {turno.FechaTurno:HH:mm}");
                            turnoColumn.Item().PaddingLeft(20).Text($"Profesional: Dr. {profesional.NombreCompleto}");
                            turnoColumn.Item().PaddingLeft(20).Text($"Especialidad: {EnumHelper.GetDescription(profesional.Especialidad)}");
                        });

                        column.Item().PaddingVertical(5).LineHorizontal(1);

                        column.Item().Background(Colors.Grey.Lighten3).Padding(10).Column(pagoColumn =>
                        {
                            pagoColumn.Spacing(5);
                            pagoColumn.Item().PaddingBottom(10).Text("COMPROBANTE DE PAGO").Bold().FontSize(10);
                            pagoColumn.Item().PaddingLeft(20).Text($"Código de Pago: {pago.IdPago}");
                            pagoColumn.Item().PaddingLeft(20).Text($"Fecha de Pago: {pago.FechaPago:dd/MM/yyyy}");
                            pagoColumn.Item().PaddingLeft(20).Text($"Monto: ${pago.Monto}");
                            pagoColumn.Item().PaddingLeft(20).Text($"Método de Pago: {EnumHelper.GetDescription(pago.MetodoPago)}");
                            pagoColumn.Item().PaddingLeft(20).Text($"Estado: {EnumHelper.GetDescription(pago.Estado)}");
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
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea cancelar el pago?\n\n" +
                "El turno no será abonado y se mantendrá en estado 'Asignado'.",
                "Cancelar Pago",
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var seleccion = cboxMedioPago.Text;
            var medioSeleccionado = StringAMetodo(seleccion);

            if (medioSeleccionado == null)
            {
                MessageBox.Show("Por favor, seleccione un método de pago de la lista.", "Información",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro que desea confirmar el pago?\n\n" +
                $"Método: {seleccion}\n" +
                $"Monto: ${_Pago.Monto}\n\n" +
                $"⚠️ Esta acción no se puede deshacer",
                "Confirmar Pago",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );

            if (confirmacion == DialogResult.No) return;

            try
            {
                DateOnly diaPago = DateOnly.FromDateTime(DateTime.Now);

                PagoService.RealizarPago(_Pago, diaPago, medioSeleccionado.Value);

                var paciente = PacienteService.ObtenerPacientePorID(_Pago.IdPaciente);
                var turno = TurnoService.ObtenerTurnoPorID(_Pago.IdTurno);

                if (paciente != null)
                {
                    PacienteService.AgregarPago(paciente, _Pago);
                    turno.Estado = EstadoTurno.ABONADO;

                    MessageBox.Show("¡Pago registrado correctamente!", "Éxito",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnImprimir.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnConfirmar.Enabled = false;
                    cboxMedioPago.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error: No se encontró el paciente asociado al pago.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar el pago: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "PDF files (*.pdf)|*.pdf";
                    var paciente = PacienteService.ObtenerPacientePorID(_Pago.IdPaciente);

                    saveDialog.FileName = $"Comprobante_Pago_ID{_Pago.IdPago}_{paciente.NombreCompleto}_{DateTime.Now:yyyyMMdd}.pdf";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        GenerarComprobantePDF(_Pago, saveDialog.FileName);

                        MessageBox.Show($"Comprobante generado exitosamente:\n{saveDialog.FileName}",
                                      "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el comprobante: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

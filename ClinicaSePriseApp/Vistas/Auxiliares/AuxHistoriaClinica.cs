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
    public partial class AuxHistoriaClinica : Form
    {
        private E_Paciente _Paciente;

        public AuxHistoriaClinica()
        {
            InitializeComponent();

            this.Size = new Size(700, 500);
            this.MinimumSize = new Size(700, 500);
            this.MaximumSize = new Size(700, 500);

            _Paciente = null;
        }

        public AuxHistoriaClinica(E_Paciente paciente)
        {
            InitializeComponent();
            _Paciente = paciente;

            entradasTLP.ColumnStyles.Clear();
            entradasTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            entradasTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            entradasTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));

            AplicarEstilos();
            CargarDatos();
        }

        private void AplicarEstilos()
        {
            mainTLP.BackColor = PaletaColores.LightBlue;

            foreach (Control tlp in mainTLP.Controls)
            {
                foreach (Control label in tlp.Controls)
                {
                    label.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);
                    label.ForeColor = Color.White;
                }

                tlp.ForeColor = Color.White;
                btnCerrar.BackColor = PaletaColores.Pink;
                btnCerrar.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);
            }
        }

        private void CargarDatos()
        {
            if (_Paciente == null)
            {
                DialogResult resultado = MessageBox.Show(
                    "Error al buscar Paciente.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                this.Close();
                return;
            }

            lblNombre.Text = $"Paciente: {_Paciente.NombreCompleto}";
            CargarEntradas();
        }

        private void CargarEntradas()
        {
            if (_Paciente == null || string.IsNullOrEmpty(_Paciente.HistoriaClinica.IdHistoriaClinica.ToString())) return;

            var entradas = _Paciente.HistoriaClinica.Entradas
                .OrderByDescending(e => e.FechaEntrada)
                .ToList();

            entradasTLP.Controls.Clear();
            entradasTLP.RowStyles.Clear();

            entradasTLP.RowCount = entradas.Count + 1;
            AgregarHeader(0);

            if (entradas.Count == 0)
            {
                entradasTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
                entradasTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));

                Label lblMensaje = new Label();
                lblMensaje.Text = "No hay entradas registradas en la historia clínica";
                lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
                lblMensaje.Dock = DockStyle.Fill;
                lblMensaje.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Italic);
                lblMensaje.ForeColor = Color.White;

                entradasTLP.Controls.Add(lblMensaje, 0, 1);
                entradasTLP.SetColumnSpan(lblMensaje, 3);
                return;
            }

            entradasTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));

            for (int i = 0; i < entradas.Count; i++)
            {
                entradasTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
                AgregarFilaEntrada(entradas[i], i + 1);
            }
        }

        private void AgregarHeader(int fila)
        {
            Label lblHeaderFecha = new Label();
            lblHeaderFecha.Text = "FECHA";
            lblHeaderFecha.TextAlign = ContentAlignment.MiddleCenter;
            lblHeaderFecha.Dock = DockStyle.Fill;
            lblHeaderFecha.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);
            lblHeaderFecha.ForeColor = Color.White;
            lblHeaderFecha.BackColor = PaletaColores.DarkBlue;

            Label lblHeaderProfesional = new Label();
            lblHeaderProfesional.Text = "PROFESIONAL";
            lblHeaderProfesional.TextAlign = ContentAlignment.MiddleCenter;
            lblHeaderProfesional.Dock = DockStyle.Fill;
            lblHeaderProfesional.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);
            lblHeaderProfesional.ForeColor = Color.White;
            lblHeaderProfesional.BackColor = PaletaColores.DarkBlue;

            Label lblHeaderObservaciones = new Label();
            lblHeaderObservaciones.Text = "OBSERVACIONES";
            lblHeaderObservaciones.TextAlign = ContentAlignment.MiddleCenter;
            lblHeaderObservaciones.Dock = DockStyle.Fill;
            lblHeaderObservaciones.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);
            lblHeaderObservaciones.ForeColor = Color.White;
            lblHeaderObservaciones.BackColor = PaletaColores.DarkBlue;

            entradasTLP.Controls.Add(lblHeaderFecha, 0, fila);
            entradasTLP.Controls.Add(lblHeaderProfesional, 1, fila);
            entradasTLP.Controls.Add(lblHeaderObservaciones, 2, fila);
        }

        private void AgregarFilaEntrada(E_Entrada entrada, int fila)
        {
            Label lblFecha = new Label();
            lblFecha.Text = entrada.FechaEntrada.ToString("dd/MM/yyyy");
            lblFecha.TextAlign = ContentAlignment.MiddleCenter;
            lblFecha.Dock = DockStyle.Fill;
            lblFecha.Font = new Font(Fuente.TIPOGRAFIA, Fuente.M, FontStyle.Bold);
            lblFecha.ForeColor = PaletaColores.DarkBlue;
            lblFecha.BackColor = Color.White;
            lblFecha.Padding = new Padding(5, 0, 0, 0);

            Label lblMedico = new Label();
            var profesional = ProfesionalService.ObtenerProfesionalPorID(entrada.IdProfesional);
            lblMedico.Text = profesional != null ? $"Dr. {profesional.NombreCompleto}" : "Médico no encontrado";
            lblMedico.TextAlign = ContentAlignment.MiddleCenter;
            lblMedico.Dock = DockStyle.Fill;
            lblMedico.Font = new Font(Fuente.TIPOGRAFIA, Fuente.M, FontStyle.Bold);
            lblMedico.ForeColor = PaletaColores.DarkBlue;
            lblMedico.BackColor = Color.White;
            lblMedico.Padding = new Padding(5, 0, 0, 0);

            Button btnVer = new Button();
            btnVer.Text = string.IsNullOrEmpty(entrada.Observaciones) ? "Sin observaciones" : "VER";
            btnVer.Enabled = !string.IsNullOrEmpty(entrada.Observaciones);
            btnVer.Dock = DockStyle.Fill;
            btnVer.Font = new Font(Fuente.TIPOGRAFIA, Fuente.S, FontStyle.Bold);
            btnVer.BackColor = btnVer.Enabled ? PaletaColores.LightBlue : Color.Gray;
            btnVer.ForeColor = Color.White;
            btnVer.Margin = new Padding(0);

            if (btnVer.Enabled)
            {
                btnVer.Click += (s, e) => MostrarObservaciones(entrada);
            }

            entradasTLP.Controls.Add(lblFecha, 0, fila);
            entradasTLP.Controls.Add(lblMedico, 1, fila);
            entradasTLP.Controls.Add(btnVer, 2, fila);
        }

        private void MostrarObservaciones(E_Entrada entrada)
        {
            MessageBox.Show(
                entrada.Observaciones,
                $"{entrada.FechaEntrada:dd/MM/yyyy}  |  {ProfesionalService.ObtenerProfesionalPorID(entrada.IdProfesional).NombreCompleto}",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
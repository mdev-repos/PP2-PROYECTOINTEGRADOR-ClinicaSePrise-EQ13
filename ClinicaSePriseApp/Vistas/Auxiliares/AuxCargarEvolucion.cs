using ClinicaSePriseApp.Entidades;
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
    public partial class AuxCargarEvolucion : Form
    {
        private E_Paciente _Paciente;
        private E_Profesional _Profesional;

        public AuxCargarEvolucion()
        {
            InitializeComponent();

            this.Size = new Size(700, 500);
            this.MinimumSize = new Size(700, 500);
            this.MaximumSize = new Size(700, 500);

            _Paciente = null;
        }

        public AuxCargarEvolucion(E_Paciente paciente, E_Profesional profesional)
        {
            InitializeComponent();
            _Paciente = paciente;
            _Profesional = profesional;

            AplicarEstilos();
            CargarDatos();
        }

        private void AplicarEstilos()
        {
            mainTLP.BackColor = PaletaColores.azulClaro;

            foreach (Control tlp in mainTLP.Controls)
            {
                foreach (Control label in tlp.Controls)
                {
                    label.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);
                    label.ForeColor = Color.White;
                }

                tlp.ForeColor = Color.White;
                btnCancelar.BackColor = PaletaColores.rosa;
                btnCancelar.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);

                btnConfirmar.BackColor = PaletaColores.azulOscuro;
                btnConfirmar.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);
            }

            txtMotivo.ForeColor = PaletaColores.azulOscuro;
            txtDiagnostico.ForeColor = PaletaColores.azulOscuro;
            txtObservaciones.ForeColor = PaletaColores.azulOscuro;
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

            var fecha = DateOnly.FromDateTime(DateTime.Now);
            lblFechaNombre.Text = $"{fecha} | {_Paciente.NombreCompleto}";

            txtMotivo.PlaceholderText = "Ingrese el motivo de la consulta aquí...";
            txtDiagnostico.PlaceholderText = "Ingrese su diagnóstico aquí...";
            txtObservaciones.PlaceholderText = "Ingrese sus observaciones aquí...";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (_Paciente == null)
            {
                MessageBox.Show("Error: No se encontró el paciente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                return;
            }

            // Validar que haya datos
            if (string.IsNullOrWhiteSpace(txtMotivo.Text) &&
                string.IsNullOrWhiteSpace(txtDiagnostico.Text) &&
                string.IsNullOrWhiteSpace(txtObservaciones.Text))
            {
                MessageBox.Show("Debe completar al menos un campo para cargar la evolución.", "Advertencia",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro que desea cargar la evolución del Paciente {_Paciente.NombreCompleto}?\n\n" +
                "✅ Se guardará en la historia clínica\n" +
                "✅ El turno se marcará como finalizado\n" +
                "✅ Esta acción no puede deshacerse",
                "Confirmar Evolución",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );

            if (confirmacion == DialogResult.No) return;

            try
            {
                var motivo = txtMotivo.Text.Trim();
                var diagnostico = txtDiagnostico.Text.Trim();
                var observaciones = txtObservaciones.Text.Trim();

                var entradaNueva = $"Paciente: {_Paciente.NombreCompleto}\n\n" +
                    $"Motivo de la Consulta: {motivo}\n\n" +
                    $"Diagnóstico: {diagnostico}\n\n" +
                    $"Observaciones: {observaciones}";

                E_Entrada evolucion = new E_Entrada(
                    DDBB_Simulation.EntradasDB.Count + 1,
                    idHistoria: _Paciente.HistoriaClinica.IdHistoriaClinica,
                    idProfesional: _Profesional.IdProfesional,
                    observaciones: entradaNueva,
                    fecha: DateTime.Now
                );

                _Paciente.HistoriaClinica.Entradas.Add(evolucion);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la evolución: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
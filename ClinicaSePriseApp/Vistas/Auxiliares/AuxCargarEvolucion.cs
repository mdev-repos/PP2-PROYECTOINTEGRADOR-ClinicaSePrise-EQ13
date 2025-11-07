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

            txtboxObservaciones.PlaceholderText = "Ingrese las observaciones de la evolución aquí...";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (_Paciente == null)
            {
                DialogResult confirmacion = MessageBox.Show(
                    "Esta seguro que desea cargar la evolución de esta consulta?" +
                    "Esta acción no puede deshacerse.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                this.Close();
                return;
            }

            var entradaNueva = txtboxObservaciones.Text.Trim();

            E_Entrada evolucion = new E_Entrada(
                DDBB_Simulation.EntradasDB.Count + 1,
                idHistoria: _Paciente.HistoriaClinica.IdHistoriaClinica,
                idProfesional: _Profesional.IdProfesional,
                observaciones: entradaNueva,
                fecha: DateTime.Now
            );

            _Paciente.HistoriaClinica.Entradas.Add(evolucion);

            DialogResult resultado = MessageBox.Show(
                    "Evolución cargada con exito.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

            this.Close();
        }
    }
}

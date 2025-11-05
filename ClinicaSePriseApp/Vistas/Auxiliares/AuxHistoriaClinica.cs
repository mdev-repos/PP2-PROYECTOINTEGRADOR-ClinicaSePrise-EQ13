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

            _Paciente = null;
        }

        public AuxHistoriaClinica(E_Paciente paciente)
        {
            InitializeComponent();
            _Paciente = paciente;
            AplicarEstilos();
            CargarDatos();
        }

        private void AplicarEstilos()
        {
            mainTLP.BackColor = PaletaColores.azulOscuro;

            foreach (Control tlp in mainTLP.Controls)
            {
                foreach (Control label in tlp.Controls)
                {
                    label.Font = new Font(Fuente.TIPOGRAFIA, Fuente.L, FontStyle.Bold);
                    label.ForeColor = Color.White;
                }

                tlp.ForeColor = Color.White;
                btnCerrar.BackColor = PaletaColores.rosa;
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

            if (_Paciente == null || string.IsNullOrEmpty(_Paciente.HistoriaClinica.IdHistoriaClinica)) return;

            E_HistoriaClinica historia = HistoriaClinicaService.ObtenerHistoriaClinica(_Paciente.HistoriaClinica.IdHistoriaClinica);
            
            var entradas = historia.Entradas;
        }
    }
}

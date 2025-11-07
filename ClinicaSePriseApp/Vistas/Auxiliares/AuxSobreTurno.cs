using ClinicaSePriseApp.Entidades;
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
    public partial class AuxSobreTurno : Form
    {
        private E_Profesional _Profesional;

        public AuxSobreTurno(E_Profesional profesional)
        {
            InitializeComponent();

            _Profesional = profesional;

            AplicarEstilos();
        }

        private void AplicarEstilos()
        {
            pacienteDniTxt.ImeMode = ImeMode.Off;
            pacienteDniTxt.MaxLength = 8;
            pacienteDniTxt.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            };
        }


        // Botones
        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }
    }
}
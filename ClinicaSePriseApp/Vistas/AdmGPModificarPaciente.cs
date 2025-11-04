using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaSePriseApp.Vistas
{
    public partial class AdmGPModificarPaciente : Form
    {
        private Entidades.E_Paciente pacienteActual;
        public AdmGPModificarPaciente(Entidades.E_Paciente paciente)
        {
            InitializeComponent();
            pacienteActual = paciente;
        }
    }
}

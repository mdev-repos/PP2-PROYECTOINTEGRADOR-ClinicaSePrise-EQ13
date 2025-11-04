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

namespace ClinicaSePriseApp.Vistas
{
    public partial class ProfAgendaDiaria : Form
    {
        private static E_Profesional _Profesional;
        public ProfAgendaDiaria()
        {
            InitializeComponent();

            _Profesional = null;
        }

        public ProfAgendaDiaria(E_Profesional profesional)
        {
            InitializeComponent();

            _Profesional = profesional;
        }

        private void ProfAgendaDiaria_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class ProfADAtencionMedica : Form
    {
        private static E_Profesional _Profesional;

        private static E_Turno _Turno;

        public ProfADAtencionMedica()
        {
            InitializeComponent();
        }

        public ProfADAtencionMedica(E_Profesional profesional, E_Turno turno)
        {
            InitializeComponent(); 

            _Profesional = profesional;

            _Turno = turno;
        }

        // Botones
        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Desea volver a la vista de Agenda?",
                "Confirmar",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );

            if (resultado == DialogResult.Cancel) return;

            ProfAgendaDiaria agendaDiaria = new ProfAgendaDiaria(_Profesional);
            this.Hide();
            agendaDiaria.FormClosed += (s, args) => this.Close();
            agendaDiaria.Show();
        }
    }
}

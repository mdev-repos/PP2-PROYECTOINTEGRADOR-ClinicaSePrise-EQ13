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
    public partial class AuxDetalleTurno : Form
    {
        private E_Turno _Turno;

        private E_Profesional _Profesional;

        public AuxDetalleTurno()
        {
            InitializeComponent();

            this.Size = new Size(700, 500);
            this.MinimumSize = new Size(700, 500);
            this.MaximumSize = new Size(700, 500);

            _Profesional = null;
            _Turno = null;
        }

        public AuxDetalleTurno(E_Turno turno, E_Profesional profesional)
        {
            InitializeComponent();

            _Turno = turno;
            _Profesional = profesional;

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

                btnVerHistoria.BackColor = PaletaColores.GreenishBlue;
                btnVerHistoria.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);

                btnCerrar.BackColor = PaletaColores.Pink;
                btnCerrar.Font = new Font(Fuente.TIPOGRAFIA, Fuente.XL, FontStyle.Bold);
            }
        }

        private void CargarDatos()
        {
            var paciente = PacienteService.ObtenerPacientePorID(_Turno.IdPaciente);

            if (paciente == null)
            {
                DialogResult resultado = MessageBox.Show(
                    "Error al buscar Paciente.",
                    "Confirmar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );

                return;
            }

            lblNombre.Text = $"Paciente: {paciente.NombreCompleto}";
            lblDNI.Text = $"DNI: {paciente.Dni}";
            lblGenero.Text = $"Género: {EnumHelper.GetDescription(paciente.Genero)}";
            lblFechaNac.Text = $"Fecha de Nacimiento: {paciente.FechaNacimiento.ToShortDateString()}";
            var edad = CalcularEdad(paciente.FechaNacimiento);
            lblEdad.Text = $"Edad: {edad} años";
            lblOS.Text = $"Obra Social: {EnumHelper.GetDescription(paciente.ObraSocial)}";
            lblNumAfiliado.Text = $"N° {paciente.NumeroAfiliado}";
            lblTel.Text = $"Teléfono: {paciente.Telefono}";
            lblMail.Text = $"Email: {paciente.Email}";

        }

        private int CalcularEdad(DateOnly fechaNacimiento)
        {
            var hoy = DateOnly.FromDateTime(DateTime.Today);
            var edad = hoy.Year - fechaNacimiento.Year;

            if (fechaNacimiento > hoy.AddYears(-edad))
                edad--;

            return edad;
        }

        // BOTONES
        private void btnVerHistoria_Click(object sender, EventArgs e)
        {
            var paciente = PacienteService.ObtenerPacientePorID(_Turno.IdPaciente);

            if (paciente == null)
            {
                DialogResult resultado = MessageBox.Show(
                    "Error al buscar Paciente.",
                    "Confirmar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            AuxHistoriaClinica historiaClinica = new AuxHistoriaClinica(paciente);
            historiaClinica.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

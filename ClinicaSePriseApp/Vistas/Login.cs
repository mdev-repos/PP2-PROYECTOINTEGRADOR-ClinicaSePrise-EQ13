using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using ClinicaSePriseApp.Utilidades;

namespace ClinicaSePriseApp.Vistas
{
    public partial class Login : Form
    {
        private List<Image> imagenes = new List<Image>();
        private int indiceActual = 0;
        private System.Windows.Forms.Timer timerCarrusel;
        private PictureBox picCarrusel;

        public Login()
        {
            InitializeComponent();
            this.Resize += Login_Resize;

            this.Size = new Size(1024, 768);
            this.MinimumSize = new Size(1024, 768);
            this.WindowState = FormWindowState.Maximized;

            InicializarCarrusel();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            AjustarPaneles();
            AjustarImagenHeight100();
            ForceRefreshImagen();
        }

        private void Login_Resize(object sender, EventArgs e)
        {
            AjustarPaneles();
            AjustarImagenHeight100();
            ForceRefreshImagen();
        }

        private void AjustarPaneles()
        {
            leftPanel.Width = (int)(mainPanel.Width * 0.65);
            leftPanel.Height = mainPanel.Height;
            leftPanel.Location = new Point(0, 0);

            rightPanel.Width = mainPanel.Width - leftPanel.Width;
            rightPanel.Height = mainPanel.Height;
            rightPanel.Location = new Point(leftPanel.Width, 0);
            rightPanel.BackColor = PaletaColores.bgGris;


            // Estilo de Botones y Textbox
            btnLogin.BackColor = PaletaColores.btnAzul;

        }

        private void CargarImagenes()
        {
            imagenes.Add(Properties.Resources.img_clinica);
            imagenes.Add(Properties.Resources.img_administrativo);
            imagenes.Add(Properties.Resources.img_profesional);
        }


        private void AjustarImagenHeight100()
        {
            if (picCarrusel?.Image == null) return;

            picCarrusel.Height = leftPanel.Height;

            float ratio = (float)picCarrusel.Image.Width / picCarrusel.Image.Height;
            picCarrusel.Width = (int)(leftPanel.Height * ratio);

            picCarrusel.Left = (leftPanel.Width - picCarrusel.Width) / 2;
            picCarrusel.Top = 0;
        }

        private void ForceRefreshImagen()
        {
            if (picCarrusel?.Image == null) return;

            Image temp = picCarrusel.Image;
            picCarrusel.Image = null;
            picCarrusel.Image = temp;

            picCarrusel.Refresh();
            leftPanel.Refresh();
            mainPanel.Refresh();
        }

        private void InicializarCarrusel()
        {
            CargarImagenes();

            picCarrusel = new PictureBox();
            picCarrusel.SizeMode = PictureBoxSizeMode.Zoom;
            picCarrusel.Image = imagenes[0];

            leftPanel.Controls.Add(picCarrusel);

            timerCarrusel = new System.Windows.Forms.Timer();
            timerCarrusel.Interval = 3500;
            timerCarrusel.Tick += TimerCarrusel_Tick;
            timerCarrusel.Start();

            AjustarImagenHeight100();
        }

        private void TimerCarrusel_Tick(object sender, EventArgs e)
        {
            indiceActual = (indiceActual + 1) % imagenes.Count;
            picCarrusel.Image = imagenes[indiceActual];
            AjustarImagenHeight100();
            ForceRefreshImagen();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var usuario = txtUsuario.Text.Trim();
            var password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Aquí iría la lógica de autenticación real por base de datos
            // EVALUA EXISTENCIA EN BBDD y ROL

            // Simulacion para desarrollo de interfaces
            if (usuario.ToLower() == "admin" && password.ToLower() == "admin")
            {
                Form dashboardAdmin = new DashAdmin();
                this.Hide();
                dashboardAdmin.FormClosed += (s, args) => this.Close(); 
                dashboardAdmin.Show();
            }
            else if (usuario.ToLower() == "medico" && password.ToLower() == "medico")
            {
                Form dashboardMedico = new DashProfesional();
                this.Hide();
                dashboardMedico.FormClosed += (s, args) => this.Close();
                dashboardMedico.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
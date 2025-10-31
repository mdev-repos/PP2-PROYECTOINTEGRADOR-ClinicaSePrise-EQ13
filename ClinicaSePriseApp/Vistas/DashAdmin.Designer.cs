namespace ClinicaSePriseApp.Vistas
{
    partial class DashAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashAdmin));
            btnInsumos = new Button();
            btnConsultorios = new Button();
            btnPacientes = new Button();
            btnTurnos = new Button();
            btnLogout = new Button();
            picBox = new PictureBox();
            menuTLP = new TableLayoutPanel();
            picLogo = new PictureBox();
            mainTLP = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            menuTLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            mainTLP.SuspendLayout();
            SuspendLayout();
            // 
            // btnInsumos
            // 
            btnInsumos.BackColor = Color.CornflowerBlue;
            btnInsumos.Dock = DockStyle.Fill;
            btnInsumos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnInsumos.ForeColor = Color.White;
            btnInsumos.Location = new Point(0, 727);
            btnInsumos.Margin = new Padding(0);
            btnInsumos.Name = "btnInsumos";
            btnInsumos.Size = new Size(470, 82);
            btnInsumos.TabIndex = 3;
            btnInsumos.Text = "GESTIONAR INSUMOS";
            btnInsumos.UseVisualStyleBackColor = false;
            btnInsumos.Click += btnInsumos_Click;
            // 
            // btnConsultorios
            // 
            btnConsultorios.BackColor = Color.CornflowerBlue;
            btnConsultorios.Dock = DockStyle.Fill;
            btnConsultorios.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnConsultorios.ForeColor = Color.White;
            btnConsultorios.Location = new Point(0, 594);
            btnConsultorios.Margin = new Padding(0);
            btnConsultorios.Name = "btnConsultorios";
            btnConsultorios.Size = new Size(470, 82);
            btnConsultorios.TabIndex = 2;
            btnConsultorios.Text = "GESTIONAR CONSULTORIOS";
            btnConsultorios.UseVisualStyleBackColor = false;
            // 
            // btnPacientes
            // 
            btnPacientes.BackColor = Color.CornflowerBlue;
            btnPacientes.Dock = DockStyle.Fill;
            btnPacientes.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnPacientes.ForeColor = Color.White;
            btnPacientes.Location = new Point(0, 461);
            btnPacientes.Margin = new Padding(0);
            btnPacientes.Name = "btnPacientes";
            btnPacientes.Size = new Size(470, 82);
            btnPacientes.TabIndex = 1;
            btnPacientes.Text = "GESTIONAR PACIENTES";
            btnPacientes.UseVisualStyleBackColor = false;
            btnPacientes.Click += btnPacientes_Click;
            // 
            // btnTurnos
            // 
            btnTurnos.BackColor = Color.CornflowerBlue;
            btnTurnos.Dock = DockStyle.Fill;
            btnTurnos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnTurnos.ForeColor = Color.White;
            btnTurnos.Location = new Point(0, 328);
            btnTurnos.Margin = new Padding(0);
            btnTurnos.Name = "btnTurnos";
            btnTurnos.Size = new Size(470, 82);
            btnTurnos.TabIndex = 0;
            btnTurnos.Text = "GESTIONAR TURNOS";
            btnTurnos.UseVisualStyleBackColor = false;
            btnTurnos.Click += btnTurnos_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Pink;
            btnLogout.Dock = DockStyle.Fill;
            btnLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 880);
            btnLogout.Margin = new Padding(0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(470, 82);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "LOG OUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // picBox
            // 
            picBox.BackColor = SystemColors.Control;
            picBox.BackgroundImageLayout = ImageLayout.None;
            picBox.Dock = DockStyle.Fill;
            picBox.Image = Properties.Resources.img_administrativo;
            picBox.Location = new Point(0, 0);
            picBox.Margin = new Padding(0);
            picBox.Name = "picBox";
            picBox.Size = new Size(1426, 1033);
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            picBox.TabIndex = 0;
            picBox.TabStop = false;
            // 
            // menuTLP
            // 
            menuTLP.ColumnCount = 1;
            menuTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            menuTLP.Controls.Add(btnLogout, 0, 10);
            menuTLP.Controls.Add(btnInsumos, 0, 8);
            menuTLP.Controls.Add(btnTurnos, 0, 2);
            menuTLP.Controls.Add(btnConsultorios, 0, 6);
            menuTLP.Controls.Add(btnPacientes, 0, 4);
            menuTLP.Controls.Add(picLogo, 0, 0);
            menuTLP.Dock = DockStyle.Fill;
            menuTLP.Location = new Point(1429, 3);
            menuTLP.Name = "menuTLP";
            menuTLP.RowCount = 12;
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 2F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            menuTLP.Size = new Size(470, 1027);
            menuTLP.TabIndex = 2;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = Properties.Resources.SePrise_logoApp;
            picLogo.Location = new Point(0, 0);
            picLogo.Margin = new Padding(0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(470, 308);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 5;
            picLogo.TabStop = false;
            // 
            // mainTLP
            // 
            mainTLP.ColumnCount = 2;
            mainTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            mainTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            mainTLP.Controls.Add(menuTLP, 1, 0);
            mainTLP.Controls.Add(picBox, 0, 0);
            mainTLP.Dock = DockStyle.Fill;
            mainTLP.Location = new Point(0, 0);
            mainTLP.Margin = new Padding(0);
            mainTLP.Name = "mainTLP";
            mainTLP.RowCount = 1;
            mainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTLP.Size = new Size(1902, 1033);
            mainTLP.TabIndex = 1;
            // 
            // DashAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(mainTLP);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1024, 768);
            Name = "DashAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clinica SePrise  ||  Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += DashAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            menuTLP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            mainTLP.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox picBox;
        private Button btnLogout;
        private Button btnInsumos;
        private Button btnConsultorios;
        private Button btnPacientes;
        private Button btnTurnos;
        private TableLayoutPanel menuTLP;
        private TableLayoutPanel mainTLP;
        private PictureBox picLogo;
    }
}
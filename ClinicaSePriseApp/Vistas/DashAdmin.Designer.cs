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
            mainPanel = new Panel();
            tlpRightPanel = new TableLayoutPanel();
            picLogo = new PictureBox();
            tlpBotones = new TableLayoutPanel();
            btnInsumos = new Button();
            btnConsultorios = new Button();
            btnPacientes = new Button();
            btnTurnos = new Button();
            btnLogout = new Button();
            leftPanel = new Panel();
            picBox = new PictureBox();
            mainPanel.SuspendLayout();
            tlpRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            tlpBotones.SuspendLayout();
            leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(tlpRightPanel);
            mainPanel.Controls.Add(leftPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1902, 1033);
            mainPanel.TabIndex = 0;
            // 
            // tlpRightPanel
            // 
            tlpRightPanel.ColumnCount = 1;
            tlpRightPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpRightPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpRightPanel.Controls.Add(picLogo, 0, 0);
            tlpRightPanel.Controls.Add(tlpBotones, 0, 1);
            tlpRightPanel.Dock = DockStyle.Right;
            tlpRightPanel.Location = new Point(1445, 0);
            tlpRightPanel.Name = "tlpRightPanel";
            tlpRightPanel.RowCount = 2;
            tlpRightPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 29.1384315F));
            tlpRightPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 70.8615646F));
            tlpRightPanel.Size = new Size(457, 1033);
            tlpRightPanel.TabIndex = 1;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = Properties.Resources.SePrise_logoApp;
            picLogo.Location = new Point(3, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(451, 295);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // tlpBotones
            // 
            tlpBotones.ColumnCount = 1;
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBotones.Controls.Add(btnInsumos, 0, 3);
            tlpBotones.Controls.Add(btnConsultorios, 0, 2);
            tlpBotones.Controls.Add(btnPacientes, 0, 1);
            tlpBotones.Controls.Add(btnTurnos, 0, 0);
            tlpBotones.Controls.Add(btnLogout, 0, 5);
            tlpBotones.Dock = DockStyle.Fill;
            tlpBotones.Location = new Point(0, 301);
            tlpBotones.Margin = new Padding(0);
            tlpBotones.Name = "tlpBotones";
            tlpBotones.RowCount = 6;
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 17F));
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 17F));
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 17F));
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 17F));
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 17F));
            tlpBotones.Size = new Size(457, 732);
            tlpBotones.TabIndex = 1;
            // 
            // btnInsumos
            // 
            btnInsumos.Location = new Point(3, 375);
            btnInsumos.Name = "btnInsumos";
            btnInsumos.Size = new Size(94, 29);
            btnInsumos.TabIndex = 3;
            btnInsumos.Text = "GESTIONAR INSUMOS";
            btnInsumos.UseVisualStyleBackColor = true;
            // 
            // btnConsultorios
            // 
            btnConsultorios.Location = new Point(3, 251);
            btnConsultorios.Name = "btnConsultorios";
            btnConsultorios.Size = new Size(94, 29);
            btnConsultorios.TabIndex = 2;
            btnConsultorios.Text = "GESTIONAR CONSULTORIOS";
            btnConsultorios.UseVisualStyleBackColor = true;
            // 
            // btnPacientes
            // 
            btnPacientes.Location = new Point(3, 127);
            btnPacientes.Name = "btnPacientes";
            btnPacientes.Size = new Size(94, 29);
            btnPacientes.TabIndex = 1;
            btnPacientes.Text = "GESTIONAR PACIENTES";
            btnPacientes.UseVisualStyleBackColor = true;
            // 
            // btnTurnos
            // 
            btnTurnos.Location = new Point(0, 0);
            btnTurnos.Margin = new Padding(0);
            btnTurnos.Name = "btnTurnos";
            btnTurnos.Size = new Size(94, 29);
            btnTurnos.TabIndex = 0;
            btnTurnos.Text = "GESTIONAR TURNOS";
            btnTurnos.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(3, 608);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "LOG OUT";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(picBox);
            leftPanel.Dock = DockStyle.Fill;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(1902, 1033);
            leftPanel.TabIndex = 0;
            // 
            // picBox
            // 
            picBox.BackColor = SystemColors.Control;
            picBox.BackgroundImageLayout = ImageLayout.None;
            picBox.Dock = DockStyle.Fill;
            picBox.Image = Properties.Resources.img_administrativo;
            picBox.Location = new Point(0, 0);
            picBox.Name = "picBox";
            picBox.Size = new Size(1902, 1033);
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            picBox.TabIndex = 0;
            picBox.TabStop = false;
            // 
            // DashAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(mainPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1024, 768);
            Name = "DashAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clinica SePrise  ||  Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += DashAdmin_Load;
            mainPanel.ResumeLayout(false);
            tlpRightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            tlpBotones.ResumeLayout(false);
            leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel leftPanel;
        private PictureBox picBox;
        private TableLayoutPanel tlpRightPanel;
        private PictureBox picLogo;
        private TableLayoutPanel tlpBotones;
        private Button btnLogout;
        private Button btnInsumos;
        private Button btnConsultorios;
        private Button btnPacientes;
        private Button btnTurnos;
    }
}
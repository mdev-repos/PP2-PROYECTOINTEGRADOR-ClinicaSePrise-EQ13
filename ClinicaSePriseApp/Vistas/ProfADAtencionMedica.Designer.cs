namespace ClinicaSePriseApp.Vistas
{
    partial class ProfADAtencionMedica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfADAtencionMedica));
            mainTLP = new TableLayoutPanel();
            menuTLP = new TableLayoutPanel();
            picLogo = new PictureBox();
            btnVolver = new Button();
            btnCargarEvolucion = new Button();
            btnLLamar = new Button();
            contentTLP = new TableLayoutPanel();
            contentLbl = new Label();
            dataTLP = new TableLayoutPanel();
            lblPacienteInfo = new Label();
            historiaContainerPanel = new Panel();
            entradasTLP = new TableLayoutPanel();
            lblHistoria = new Label();
            infoPacTLP = new TableLayoutPanel();
            lblOS = new Label();
            lblNumAfiliado = new Label();
            lblEdad = new Label();
            lblFechaNac = new Label();
            lblGenero = new Label();
            lblDNI = new Label();
            lblDireccion = new Label();
            lblEmail = new Label();
            lblTelefono = new Label();
            mainTLP.SuspendLayout();
            menuTLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            contentTLP.SuspendLayout();
            dataTLP.SuspendLayout();
            historiaContainerPanel.SuspendLayout();
            infoPacTLP.SuspendLayout();
            SuspendLayout();
            // 
            // mainTLP
            // 
            mainTLP.ColumnCount = 2;
            mainTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            mainTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            mainTLP.Controls.Add(menuTLP, 1, 0);
            mainTLP.Controls.Add(contentTLP, 0, 0);
            mainTLP.Dock = DockStyle.Fill;
            mainTLP.Location = new Point(0, 0);
            mainTLP.Margin = new Padding(0);
            mainTLP.Name = "mainTLP";
            mainTLP.RowCount = 1;
            mainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTLP.Size = new Size(1006, 721);
            mainTLP.TabIndex = 4;
            // 
            // menuTLP
            // 
            menuTLP.BackColor = SystemColors.GradientInactiveCaption;
            menuTLP.ColumnCount = 1;
            menuTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            menuTLP.Controls.Add(picLogo, 0, 0);
            menuTLP.Controls.Add(btnVolver, 0, 8);
            menuTLP.Controls.Add(btnCargarEvolucion, 0, 2);
            menuTLP.Controls.Add(btnLLamar, 0, 6);
            menuTLP.Dock = DockStyle.Fill;
            menuTLP.Location = new Point(754, 0);
            menuTLP.Margin = new Padding(0);
            menuTLP.Name = "menuTLP";
            menuTLP.RowCount = 10;
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            menuTLP.Size = new Size(252, 721);
            menuTLP.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BackColor = SystemColors.GradientInactiveCaption;
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = Properties.Resources.SePrise_logoApp;
            picLogo.Location = new Point(0, 0);
            picLogo.Margin = new Padding(0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(252, 216);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.MediumVioletRed;
            btnVolver.Dock = DockStyle.Fill;
            btnVolver.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(0, 602);
            btnVolver.Margin = new Padding(0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(252, 57);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "REGRESAR A LA AGENDA";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnCargarEvolucion
            // 
            btnCargarEvolucion.BackColor = Color.CornflowerBlue;
            btnCargarEvolucion.Dock = DockStyle.Fill;
            btnCargarEvolucion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargarEvolucion.ForeColor = Color.White;
            btnCargarEvolucion.Location = new Point(0, 259);
            btnCargarEvolucion.Margin = new Padding(0);
            btnCargarEvolucion.Name = "btnCargarEvolucion";
            btnCargarEvolucion.Size = new Size(252, 57);
            btnCargarEvolucion.TabIndex = 9;
            btnCargarEvolucion.Text = "CARGAR EVOLUCION";
            btnCargarEvolucion.UseVisualStyleBackColor = false;
            btnCargarEvolucion.Click += btnCargarEvolucion_Click;
            // 
            // btnLLamar
            // 
            btnLLamar.BackColor = Color.DarkTurquoise;
            btnLLamar.Dock = DockStyle.Fill;
            btnLLamar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLLamar.ForeColor = Color.White;
            btnLLamar.Location = new Point(0, 459);
            btnLLamar.Margin = new Padding(0);
            btnLLamar.Name = "btnLLamar";
            btnLLamar.Size = new Size(252, 57);
            btnLLamar.TabIndex = 10;
            btnLLamar.Text = "LLAMAR NUEVAMENTE";
            btnLLamar.UseVisualStyleBackColor = false;
            btnLLamar.Click += btnLLamar_Click;
            // 
            // contentTLP
            // 
            contentTLP.ColumnCount = 1;
            contentTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            contentTLP.Controls.Add(contentLbl, 0, 1);
            contentTLP.Controls.Add(dataTLP, 0, 3);
            contentTLP.Dock = DockStyle.Fill;
            contentTLP.Location = new Point(0, 0);
            contentTLP.Margin = new Padding(0);
            contentTLP.Name = "contentTLP";
            contentTLP.RowCount = 5;
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 77F));
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            contentTLP.Size = new Size(754, 721);
            contentTLP.TabIndex = 1;
            // 
            // contentLbl
            // 
            contentLbl.AutoSize = true;
            contentLbl.BackColor = SystemColors.GradientInactiveCaption;
            contentLbl.Dock = DockStyle.Fill;
            contentLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contentLbl.Location = new Point(0, 36);
            contentLbl.Margin = new Padding(0);
            contentLbl.Name = "contentLbl";
            contentLbl.Size = new Size(754, 72);
            contentLbl.TabIndex = 0;
            contentLbl.Text = "    FECHA  |  NOMBRE PACIENTE";
            contentLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataTLP
            // 
            dataTLP.ColumnCount = 5;
            dataTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2F));
            dataTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            dataTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            dataTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57F));
            dataTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2F));
            dataTLP.Controls.Add(lblPacienteInfo, 1, 0);
            dataTLP.Controls.Add(historiaContainerPanel, 3, 1);
            dataTLP.Controls.Add(lblHistoria, 3, 0);
            dataTLP.Controls.Add(infoPacTLP, 1, 1);
            dataTLP.Dock = DockStyle.Fill;
            dataTLP.Location = new Point(0, 136);
            dataTLP.Margin = new Padding(0);
            dataTLP.Name = "dataTLP";
            dataTLP.RowCount = 2;
            dataTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            dataTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            dataTLP.Size = new Size(754, 555);
            dataTLP.TabIndex = 1;
            // 
            // lblPacienteInfo
            // 
            lblPacienteInfo.AutoSize = true;
            lblPacienteInfo.Dock = DockStyle.Fill;
            lblPacienteInfo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblPacienteInfo.Location = new Point(15, 0);
            lblPacienteInfo.Margin = new Padding(0);
            lblPacienteInfo.Name = "lblPacienteInfo";
            lblPacienteInfo.Size = new Size(263, 55);
            lblPacienteInfo.TabIndex = 3;
            lblPacienteInfo.Text = "INFORMACION PERSONAL";
            lblPacienteInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // historiaContainerPanel
            // 
            historiaContainerPanel.AutoScroll = true;
            historiaContainerPanel.Controls.Add(entradasTLP);
            historiaContainerPanel.Dock = DockStyle.Fill;
            historiaContainerPanel.Location = new Point(308, 55);
            historiaContainerPanel.Margin = new Padding(0);
            historiaContainerPanel.Name = "historiaContainerPanel";
            historiaContainerPanel.Size = new Size(429, 500);
            historiaContainerPanel.TabIndex = 11;
            // 
            // entradasTLP
            // 
            entradasTLP.AutoSize = true;
            entradasTLP.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            entradasTLP.ColumnCount = 3;
            entradasTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            entradasTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            entradasTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            entradasTLP.Dock = DockStyle.Top;
            entradasTLP.Location = new Point(0, 0);
            entradasTLP.Margin = new Padding(0);
            entradasTLP.Name = "entradasTLP";
            entradasTLP.RowCount = 1;
            entradasTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            entradasTLP.Size = new Size(429, 0);
            entradasTLP.TabIndex = 2;
            // 
            // lblHistoria
            // 
            lblHistoria.AutoSize = true;
            lblHistoria.Dock = DockStyle.Fill;
            lblHistoria.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblHistoria.Location = new Point(308, 0);
            lblHistoria.Margin = new Padding(0);
            lblHistoria.Name = "lblHistoria";
            lblHistoria.Size = new Size(429, 55);
            lblHistoria.TabIndex = 12;
            lblHistoria.Text = "HISTORIA CLINICA";
            lblHistoria.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // infoPacTLP
            // 
            infoPacTLP.ColumnCount = 1;
            infoPacTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            infoPacTLP.Controls.Add(lblOS, 0, 4);
            infoPacTLP.Controls.Add(lblNumAfiliado, 0, 5);
            infoPacTLP.Controls.Add(lblEdad, 0, 3);
            infoPacTLP.Controls.Add(lblFechaNac, 0, 2);
            infoPacTLP.Controls.Add(lblGenero, 0, 1);
            infoPacTLP.Controls.Add(lblDNI, 0, 0);
            infoPacTLP.Controls.Add(lblDireccion, 0, 8);
            infoPacTLP.Controls.Add(lblEmail, 0, 7);
            infoPacTLP.Controls.Add(lblTelefono, 0, 6);
            infoPacTLP.Dock = DockStyle.Fill;
            infoPacTLP.Location = new Point(15, 55);
            infoPacTLP.Margin = new Padding(0);
            infoPacTLP.Name = "infoPacTLP";
            infoPacTLP.RowCount = 9;
            infoPacTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            infoPacTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            infoPacTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            infoPacTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            infoPacTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            infoPacTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            infoPacTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            infoPacTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            infoPacTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            infoPacTLP.Size = new Size(263, 500);
            infoPacTLP.TabIndex = 13;
            // 
            // lblOS
            // 
            lblOS.AutoSize = true;
            lblOS.Dock = DockStyle.Fill;
            lblOS.Location = new Point(0, 220);
            lblOS.Margin = new Padding(0);
            lblOS.Name = "lblOS";
            lblOS.Size = new Size(263, 55);
            lblOS.TabIndex = 9;
            lblOS.Text = "OBRA SOCIAL";
            lblOS.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNumAfiliado
            // 
            lblNumAfiliado.AutoSize = true;
            lblNumAfiliado.Dock = DockStyle.Fill;
            lblNumAfiliado.Location = new Point(0, 275);
            lblNumAfiliado.Margin = new Padding(0);
            lblNumAfiliado.Name = "lblNumAfiliado";
            lblNumAfiliado.Size = new Size(263, 55);
            lblNumAfiliado.TabIndex = 6;
            lblNumAfiliado.Text = "N° AFILIADO";
            lblNumAfiliado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Dock = DockStyle.Fill;
            lblEdad.Location = new Point(0, 165);
            lblEdad.Margin = new Padding(0);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(263, 55);
            lblEdad.TabIndex = 4;
            lblEdad.Text = "EDAD PACIENTE";
            lblEdad.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Dock = DockStyle.Fill;
            lblFechaNac.Location = new Point(0, 110);
            lblFechaNac.Margin = new Padding(0);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(263, 55);
            lblFechaNac.TabIndex = 3;
            lblFechaNac.Text = "FECHA DE NACIMIENTO";
            lblFechaNac.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Dock = DockStyle.Fill;
            lblGenero.Location = new Point(0, 55);
            lblGenero.Margin = new Padding(0);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(263, 55);
            lblGenero.TabIndex = 2;
            lblGenero.Text = "GENERO PACIENTE";
            lblGenero.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Dock = DockStyle.Fill;
            lblDNI.Location = new Point(0, 0);
            lblDNI.Margin = new Padding(0);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(263, 55);
            lblDNI.TabIndex = 1;
            lblDNI.Text = "DNI PACIENTE";
            lblDNI.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Dock = DockStyle.Fill;
            lblDireccion.Location = new Point(0, 440);
            lblDireccion.Margin = new Padding(0);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(263, 60);
            lblDireccion.TabIndex = 8;
            lblDireccion.Text = "DIRECCION";
            lblDireccion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Location = new Point(0, 385);
            lblEmail.Margin = new Padding(0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(263, 55);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "EMAIL";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Dock = DockStyle.Fill;
            lblTelefono.Location = new Point(0, 330);
            lblTelefono.Margin = new Padding(0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(263, 55);
            lblTelefono.TabIndex = 6;
            lblTelefono.Text = "TELEFONO";
            lblTelefono.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProfADAtencionMedica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(mainTLP);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProfADAtencionMedica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clinica SePrise  ||  Atención Médica";
            WindowState = FormWindowState.Maximized;
            mainTLP.ResumeLayout(false);
            menuTLP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            contentTLP.ResumeLayout(false);
            contentTLP.PerformLayout();
            dataTLP.ResumeLayout(false);
            dataTLP.PerformLayout();
            historiaContainerPanel.ResumeLayout(false);
            historiaContainerPanel.PerformLayout();
            infoPacTLP.ResumeLayout(false);
            infoPacTLP.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTLP;
        private TableLayoutPanel menuTLP;
        private PictureBox picLogo;
        private Button btnVolver;
        private Button btnCargarEvolucion;
        private TableLayoutPanel contentTLP;
        private Label contentLbl;
        private Button btnLLamar;
        private TableLayoutPanel dataTLP;
        private Label lblPacienteInfo;
        private Panel historiaContainerPanel;
        private TableLayoutPanel entradasTLP;
        private Label lblHistoria;
        private TableLayoutPanel infoPacTLP;
        private Label lblEdad;
        private Label lblFechaNac;
        private Label lblGenero;
        private Label lblDNI;
        private Label lblDireccion;
        private Label lblEmail;
        private Label lblTelefono;
        private Label lblNumAfiliado;
        private Label lblOS;
    }
}
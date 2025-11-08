namespace ClinicaSePriseApp.Vistas
{
    partial class AdmGPAltaPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmGPAltaPaciente));
            lblFechaNacimiento = new Label();
            lblDni = new Label();
            lblApellido = new Label();
            lblTurno = new Label();
            lblNombre = new Label();
            lblGenero = new Label();
            imgPicBox = new PictureBox();
            dataTLP = new TableLayoutPanel();
            txtNroAfiliado = new TextBox();
            lblNroAfiliado = new Label();
            cboxObraSocial = new ComboBox();
            txtMail = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtDni = new TextBox();
            txtApellido = new TextBox();
            lblObraSocial = new Label();
            lblEmail = new Label();
            lblTelefono = new Label();
            label7 = new Label();
            txtNombre = new TextBox();
            cboxGenero = new ComboBox();
            dateFechaNacimiento = new DateTimePicker();
            contentLbl = new Label();
            viewTLP = new TableLayoutPanel();
            contentTLP = new TableLayoutPanel();
            picLogo = new PictureBox();
            btnVolver = new Button();
            btnDarAlta = new Button();
            menuTLP = new TableLayoutPanel();
            mainTLP = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)imgPicBox).BeginInit();
            dataTLP.SuspendLayout();
            viewTLP.SuspendLayout();
            contentTLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            menuTLP.SuspendLayout();
            mainTLP.SuspendLayout();
            SuspendLayout();
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Dock = DockStyle.Fill;
            lblFechaNacimiento.Enabled = false;
            lblFechaNacimiento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFechaNacimiento.ForeColor = Color.Black;
            lblFechaNacimiento.Location = new Point(15, 403);
            lblFechaNacimiento.Margin = new Padding(15, 0, 0, 0);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(312, 79);
            lblFechaNacimiento.TabIndex = 12;
            lblFechaNacimiento.Text = "Fecha de nacimiento:";
            lblFechaNacimiento.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Dock = DockStyle.Fill;
            lblDni.Enabled = false;
            lblDni.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDni.ForeColor = Color.Black;
            lblDni.Location = new Point(15, 245);
            lblDni.Margin = new Padding(15, 0, 0, 0);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(312, 79);
            lblDni.TabIndex = 3;
            lblDni.Text = "DNI: ";
            lblDni.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Dock = DockStyle.Fill;
            lblApellido.Enabled = false;
            lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblApellido.ForeColor = Color.Black;
            lblApellido.Location = new Point(15, 166);
            lblApellido.Margin = new Padding(15, 0, 0, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(312, 79);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido: ";
            lblApellido.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            dataTLP.SetColumnSpan(lblTurno, 2);
            lblTurno.Dock = DockStyle.Fill;
            lblTurno.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTurno.Location = new Point(0, 0);
            lblTurno.Margin = new Padding(0);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(688, 87);
            lblTurno.TabIndex = 0;
            lblTurno.Text = "DATOS DEL PACIENTE";
            lblTurno.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Dock = DockStyle.Fill;
            lblNombre.Enabled = false;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(15, 87);
            lblNombre.Margin = new Padding(15, 0, 0, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(312, 79);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre: ";
            lblNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Dock = DockStyle.Fill;
            lblGenero.Enabled = false;
            lblGenero.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGenero.ForeColor = Color.Black;
            lblGenero.Location = new Point(15, 324);
            lblGenero.Margin = new Padding(15, 0, 0, 0);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(312, 79);
            lblGenero.TabIndex = 4;
            lblGenero.Text = "Género: ";
            lblGenero.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // imgPicBox
            // 
            imgPicBox.Dock = DockStyle.Fill;
            imgPicBox.Image = (Image)resources.GetObject("imgPicBox.Image");
            imgPicBox.Location = new Point(716, 3);
            imgPicBox.Name = "imgPicBox";
            imgPicBox.Size = new Size(707, 873);
            imgPicBox.SizeMode = PictureBoxSizeMode.Zoom;
            imgPicBox.TabIndex = 0;
            imgPicBox.TabStop = false;
            // 
            // dataTLP
            // 
            dataTLP.ColumnCount = 2;
            dataTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.63514F));
            dataTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.3648643F));
            dataTLP.Controls.Add(txtNroAfiliado, 1, 10);
            dataTLP.Controls.Add(lblNroAfiliado, 0, 10);
            dataTLP.Controls.Add(cboxObraSocial, 1, 9);
            dataTLP.Controls.Add(txtMail, 1, 8);
            dataTLP.Controls.Add(txtTelefono, 1, 7);
            dataTLP.Controls.Add(txtDireccion, 1, 6);
            dataTLP.Controls.Add(txtDni, 1, 3);
            dataTLP.Controls.Add(txtApellido, 1, 2);
            dataTLP.Controls.Add(lblObraSocial, 0, 9);
            dataTLP.Controls.Add(lblEmail, 0, 8);
            dataTLP.Controls.Add(lblTelefono, 0, 7);
            dataTLP.Controls.Add(label7, 0, 6);
            dataTLP.Controls.Add(lblFechaNacimiento, 0, 5);
            dataTLP.Controls.Add(lblGenero, 0, 4);
            dataTLP.Controls.Add(lblDni, 0, 3);
            dataTLP.Controls.Add(lblApellido, 0, 2);
            dataTLP.Controls.Add(lblTurno, 0, 0);
            dataTLP.Controls.Add(lblNombre, 0, 1);
            dataTLP.Controls.Add(txtNombre, 1, 1);
            dataTLP.Controls.Add(cboxGenero, 1, 4);
            dataTLP.Controls.Add(dateFechaNacimiento, 1, 5);
            dataTLP.Dock = DockStyle.Fill;
            dataTLP.Location = new Point(5, 0);
            dataTLP.Margin = new Padding(5, 0, 20, 0);
            dataTLP.Name = "dataTLP";
            dataTLP.RowCount = 11;
            dataTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            dataTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            dataTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            dataTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            dataTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            dataTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            dataTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            dataTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            dataTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            dataTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            dataTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            dataTLP.Size = new Size(688, 879);
            dataTLP.TabIndex = 2;
            // 
            // txtNroAfiliado
            // 
            txtNroAfiliado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNroAfiliado.Location = new Point(327, 825);
            txtNroAfiliado.Margin = new Padding(0);
            txtNroAfiliado.Name = "txtNroAfiliado";
            txtNroAfiliado.Size = new Size(361, 27);
            txtNroAfiliado.TabIndex = 39;
            // 
            // lblNroAfiliado
            // 
            lblNroAfiliado.AutoSize = true;
            lblNroAfiliado.Dock = DockStyle.Fill;
            lblNroAfiliado.Enabled = false;
            lblNroAfiliado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNroAfiliado.ForeColor = Color.Black;
            lblNroAfiliado.Location = new Point(15, 798);
            lblNroAfiliado.Margin = new Padding(15, 0, 0, 0);
            lblNroAfiliado.Name = "lblNroAfiliado";
            lblNroAfiliado.Size = new Size(312, 81);
            lblNroAfiliado.TabIndex = 38;
            lblNroAfiliado.Text = "Nro Afiliado: ";
            lblNroAfiliado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboxObraSocial
            // 
            cboxObraSocial.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboxObraSocial.FormattingEnabled = true;
            cboxObraSocial.Location = new Point(330, 744);
            cboxObraSocial.Margin = new Padding(3, 4, 3, 4);
            cboxObraSocial.Name = "cboxObraSocial";
            cboxObraSocial.Size = new Size(355, 28);
            cboxObraSocial.TabIndex = 36;
            // 
            // txtMail
            // 
            txtMail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMail.Location = new Point(327, 666);
            txtMail.Margin = new Padding(0);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(361, 27);
            txtMail.TabIndex = 33;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTelefono.Location = new Point(327, 587);
            txtTelefono.Margin = new Padding(0);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(361, 27);
            txtTelefono.TabIndex = 32;
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDireccion.Location = new Point(327, 508);
            txtDireccion.Margin = new Padding(0);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(361, 27);
            txtDireccion.TabIndex = 31;
            // 
            // txtDni
            // 
            txtDni.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDni.Location = new Point(327, 271);
            txtDni.Margin = new Padding(0);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(361, 27);
            txtDni.TabIndex = 28;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtApellido.Location = new Point(327, 192);
            txtApellido.Margin = new Padding(0);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(361, 27);
            txtApellido.TabIndex = 27;
            // 
            // lblObraSocial
            // 
            lblObraSocial.AutoSize = true;
            lblObraSocial.Dock = DockStyle.Fill;
            lblObraSocial.Enabled = false;
            lblObraSocial.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblObraSocial.ForeColor = Color.Black;
            lblObraSocial.Location = new Point(15, 719);
            lblObraSocial.Margin = new Padding(15, 0, 0, 0);
            lblObraSocial.Name = "lblObraSocial";
            lblObraSocial.Size = new Size(312, 79);
            lblObraSocial.TabIndex = 25;
            lblObraSocial.Text = "Obra Social: ";
            lblObraSocial.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Enabled = false;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(15, 640);
            lblEmail.Margin = new Padding(15, 0, 0, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(312, 79);
            lblEmail.TabIndex = 23;
            lblEmail.Text = "E-mail: ";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Dock = DockStyle.Fill;
            lblTelefono.Enabled = false;
            lblTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTelefono.ForeColor = Color.Black;
            lblTelefono.Location = new Point(15, 561);
            lblTelefono.Margin = new Padding(15, 0, 0, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(312, 79);
            lblTelefono.TabIndex = 21;
            lblTelefono.Text = "Teléfono: ";
            lblTelefono.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Enabled = false;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(15, 482);
            label7.Margin = new Padding(15, 0, 0, 0);
            label7.Name = "label7";
            label7.Size = new Size(312, 79);
            label7.TabIndex = 19;
            label7.Text = "Dirección: ";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Location = new Point(327, 113);
            txtNombre.Margin = new Padding(0);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(361, 27);
            txtNombre.TabIndex = 26;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // cboxGenero
            // 
            cboxGenero.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboxGenero.FormattingEnabled = true;
            cboxGenero.Location = new Point(330, 349);
            cboxGenero.Margin = new Padding(3, 4, 3, 4);
            cboxGenero.Name = "cboxGenero";
            cboxGenero.Size = new Size(355, 28);
            cboxGenero.TabIndex = 34;
            // 
            // dateFechaNacimiento
            // 
            dateFechaNacimiento.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dateFechaNacimiento.Location = new Point(330, 429);
            dateFechaNacimiento.Margin = new Padding(3, 4, 3, 4);
            dateFechaNacimiento.Name = "dateFechaNacimiento";
            dateFechaNacimiento.Size = new Size(355, 27);
            dateFechaNacimiento.TabIndex = 37;
            // 
            // contentLbl
            // 
            contentLbl.AutoSize = true;
            contentLbl.BackColor = SystemColors.GradientInactiveCaption;
            contentLbl.Dock = DockStyle.Fill;
            contentLbl.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contentLbl.Location = new Point(0, 51);
            contentLbl.Margin = new Padding(0);
            contentLbl.Name = "contentLbl";
            contentLbl.Size = new Size(1426, 103);
            contentLbl.TabIndex = 0;
            contentLbl.Text = "    ALTA PACIENTE";
            contentLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // viewTLP
            // 
            viewTLP.ColumnCount = 2;
            viewTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            viewTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            viewTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 21F));
            viewTLP.Controls.Add(imgPicBox, 1, 0);
            viewTLP.Controls.Add(dataTLP, 0, 0);
            viewTLP.Dock = DockStyle.Fill;
            viewTLP.Location = new Point(0, 154);
            viewTLP.Margin = new Padding(0);
            viewTLP.Name = "viewTLP";
            viewTLP.RowCount = 1;
            viewTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            viewTLP.Size = new Size(1426, 879);
            viewTLP.TabIndex = 1;
            // 
            // contentTLP
            // 
            contentTLP.ColumnCount = 1;
            contentTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            contentTLP.Controls.Add(contentLbl, 0, 1);
            contentTLP.Controls.Add(viewTLP, 0, 3);
            contentTLP.Dock = DockStyle.Fill;
            contentTLP.Location = new Point(0, 0);
            contentTLP.Margin = new Padding(0);
            contentTLP.Name = "contentTLP";
            contentTLP.RowCount = 4;
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 0F));
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            contentTLP.Size = new Size(1426, 1033);
            contentTLP.TabIndex = 1;
            // 
            // picLogo
            // 
            picLogo.BackColor = SystemColors.GradientInactiveCaption;
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = Properties.Resources.SePrise_logoApp;
            picLogo.Location = new Point(0, 0);
            picLogo.Margin = new Padding(0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(476, 309);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Pink;
            btnVolver.Dock = DockStyle.Fill;
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(0, 861);
            btnVolver.Margin = new Padding(0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(476, 82);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "VOLVER A PACIENTES";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnDarAlta
            // 
            btnDarAlta.BackColor = Color.CornflowerBlue;
            btnDarAlta.Dock = DockStyle.Fill;
            btnDarAlta.ForeColor = Color.White;
            btnDarAlta.Location = new Point(0, 370);
            btnDarAlta.Margin = new Padding(0);
            btnDarAlta.Name = "btnDarAlta";
            btnDarAlta.Size = new Size(476, 82);
            btnDarAlta.TabIndex = 9;
            btnDarAlta.Text = "DAR DE ALTA";
            btnDarAlta.UseVisualStyleBackColor = false;
            btnDarAlta.Click += btnAsignar_Click;
            // 
            // menuTLP
            // 
            menuTLP.BackColor = SystemColors.GradientInactiveCaption;
            menuTLP.ColumnCount = 1;
            menuTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            menuTLP.Controls.Add(picLogo, 0, 0);
            menuTLP.Controls.Add(btnVolver, 0, 8);
            menuTLP.Controls.Add(btnDarAlta, 0, 2);
            menuTLP.Dock = DockStyle.Fill;
            menuTLP.Location = new Point(1426, 0);
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
            menuTLP.Size = new Size(476, 1033);
            menuTLP.TabIndex = 0;
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
            mainTLP.Size = new Size(1902, 1033);
            mainTLP.TabIndex = 2;
            // 
            // AdmGPAltaPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(mainTLP);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1024, 766);
            Name = "AdmGPAltaPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clinica SePrise  ||  Alta Paciente";
            WindowState = FormWindowState.Maximized;
            Load += AdmGPAltaPaciente_Load;
            ((System.ComponentModel.ISupportInitialize)imgPicBox).EndInit();
            dataTLP.ResumeLayout(false);
            dataTLP.PerformLayout();
            viewTLP.ResumeLayout(false);
            contentTLP.ResumeLayout(false);
            contentTLP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            menuTLP.ResumeLayout(false);
            mainTLP.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblFechaNacimiento;
        private Label lblDni;
        private Label lblApellido;
        private Label lblTurno;
        private Label lblNombre;
        private Label lblGenero;
        private PictureBox imgPicBox;
        private TableLayoutPanel dataTLP;
        private Label contentLbl;
        private TableLayoutPanel viewTLP;
        private TableLayoutPanel contentTLP;
        private PictureBox picLogo;
        private Button btnVolver;
        private Button btnDarAlta;
        private TableLayoutPanel menuTLP;
        private TableLayoutPanel mainTLP;
        private Label label7;
        private Label lblObraSocial;
        private Label lblEmail;
        private Label lblTelefono;
        private TextBox txtNombre;
        private TextBox txtMail;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtDni;
        private TextBox txtApellido;
        private ComboBox cboxObraSocial;
        private ComboBox cboxGenero;
        private DateTimePicker dateFechaNacimiento;
        private TextBox txtNroAfiliado;
        private Label lblNroAfiliado;
    }
}
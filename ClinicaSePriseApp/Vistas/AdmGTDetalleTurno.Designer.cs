namespace ClinicaSePriseApp.Vistas
{
    partial class AdmGTDetalleTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmGTDetalleTurno));
            mainTLP = new TableLayoutPanel();
            menuTLP = new TableLayoutPanel();
            picLogo = new PictureBox();
            btnVolver = new Button();
            btnAbonar = new Button();
            btnCancelar = new Button();
            btnAsignar = new Button();
            contentTLP = new TableLayoutPanel();
            contentLbl = new Label();
            viewTLP = new TableLayoutPanel();
            imgPicBox = new PictureBox();
            dataTLP = new TableLayoutPanel();
            lblTurnoValor = new Label();
            telMailTLP = new TableLayoutPanel();
            lblEmail = new Label();
            lblTelefono = new Label();
            lblTurnoEstado = new Label();
            lblTurnoEsp = new Label();
            lblTurnoProf = new Label();
            lblTurno = new Label();
            lblTurnoDia = new Label();
            lblPaciente = new Label();
            dniTLP = new TableLayoutPanel();
            pacienteDniTxt = new TextBox();
            dniSearchBtn = new Button();
            osTLP = new TableLayoutPanel();
            lblNumAfiliado = new Label();
            lblObraSocial = new Label();
            sexoEdadTLP = new TableLayoutPanel();
            lblEdad = new Label();
            lblGenero = new Label();
            lblPacienteNombre = new Label();
            lblDireccion = new Label();
            mainTLP.SuspendLayout();
            menuTLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            contentTLP.SuspendLayout();
            viewTLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgPicBox).BeginInit();
            dataTLP.SuspendLayout();
            telMailTLP.SuspendLayout();
            dniTLP.SuspendLayout();
            osTLP.SuspendLayout();
            sexoEdadTLP.SuspendLayout();
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
            mainTLP.TabIndex = 1;
            // 
            // menuTLP
            // 
            menuTLP.BackColor = SystemColors.GradientInactiveCaption;
            menuTLP.ColumnCount = 1;
            menuTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            menuTLP.Controls.Add(picLogo, 0, 0);
            menuTLP.Controls.Add(btnVolver, 0, 8);
            menuTLP.Controls.Add(btnAbonar, 0, 6);
            menuTLP.Controls.Add(btnCancelar, 0, 4);
            menuTLP.Controls.Add(btnAsignar, 0, 2);
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
            btnVolver.BackColor = Color.Pink;
            btnVolver.Dock = DockStyle.Fill;
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(0, 602);
            btnVolver.Margin = new Padding(0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(252, 57);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "VOLVER A TURNOS";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnAbonar
            // 
            btnAbonar.BackColor = Color.CornflowerBlue;
            btnAbonar.Dock = DockStyle.Fill;
            btnAbonar.ForeColor = Color.White;
            btnAbonar.Location = new Point(0, 459);
            btnAbonar.Margin = new Padding(0);
            btnAbonar.Name = "btnAbonar";
            btnAbonar.Size = new Size(252, 57);
            btnAbonar.TabIndex = 2;
            btnAbonar.Text = "ABONAR TURNO";
            btnAbonar.UseVisualStyleBackColor = false;
            btnAbonar.Click += btnAbonar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.CornflowerBlue;
            btnCancelar.Dock = DockStyle.Fill;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(0, 359);
            btnCancelar.Margin = new Padding(0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(252, 57);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "CANCELAR TURNO";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAsignar
            // 
            btnAsignar.BackColor = Color.CornflowerBlue;
            btnAsignar.Dock = DockStyle.Fill;
            btnAsignar.ForeColor = Color.White;
            btnAsignar.Location = new Point(0, 259);
            btnAsignar.Margin = new Padding(0);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(252, 57);
            btnAsignar.TabIndex = 9;
            btnAsignar.Text = "ASIGNAR TURNO";
            btnAsignar.UseVisualStyleBackColor = false;
            btnAsignar.Click += btnAsignar_Click;
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
            contentTLP.Size = new Size(754, 721);
            contentTLP.TabIndex = 1;
            // 
            // contentLbl
            // 
            contentLbl.AutoSize = true;
            contentLbl.BackColor = SystemColors.GradientInactiveCaption;
            contentLbl.Dock = DockStyle.Fill;
            contentLbl.Font = new Font("LEMON MILK", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contentLbl.Location = new Point(0, 36);
            contentLbl.Margin = new Padding(0);
            contentLbl.Name = "contentLbl";
            contentLbl.Size = new Size(754, 72);
            contentLbl.TabIndex = 0;
            contentLbl.Text = "DETALLE DE TURNO";
            contentLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // viewTLP
            // 
            viewTLP.ColumnCount = 2;
            viewTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            viewTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            viewTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            viewTLP.Controls.Add(imgPicBox, 1, 0);
            viewTLP.Controls.Add(dataTLP, 0, 0);
            viewTLP.Dock = DockStyle.Fill;
            viewTLP.Location = new Point(0, 108);
            viewTLP.Margin = new Padding(0);
            viewTLP.Name = "viewTLP";
            viewTLP.RowCount = 1;
            viewTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            viewTLP.Size = new Size(754, 613);
            viewTLP.TabIndex = 1;
            // 
            // imgPicBox
            // 
            imgPicBox.Dock = DockStyle.Fill;
            imgPicBox.Image = Properties.Resources.img_detalleTurno;
            imgPicBox.Location = new Point(380, 3);
            imgPicBox.Name = "imgPicBox";
            imgPicBox.Size = new Size(371, 607);
            imgPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            imgPicBox.TabIndex = 0;
            imgPicBox.TabStop = false;
            // 
            // dataTLP
            // 
            dataTLP.ColumnCount = 1;
            dataTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            dataTLP.Controls.Add(lblTurnoValor, 0, 5);
            dataTLP.Controls.Add(telMailTLP, 0, 12);
            dataTLP.Controls.Add(lblTurnoEstado, 0, 4);
            dataTLP.Controls.Add(lblTurnoEsp, 0, 3);
            dataTLP.Controls.Add(lblTurnoProf, 0, 2);
            dataTLP.Controls.Add(lblTurno, 0, 0);
            dataTLP.Controls.Add(lblTurnoDia, 0, 1);
            dataTLP.Controls.Add(lblPaciente, 0, 7);
            dataTLP.Controls.Add(dniTLP, 0, 8);
            dataTLP.Controls.Add(osTLP, 0, 10);
            dataTLP.Controls.Add(sexoEdadTLP, 0, 11);
            dataTLP.Controls.Add(lblPacienteNombre, 0, 9);
            dataTLP.Controls.Add(lblDireccion, 0, 13);
            dataTLP.Dock = DockStyle.Fill;
            dataTLP.Location = new Point(5, 0);
            dataTLP.Margin = new Padding(5, 0, 0, 0);
            dataTLP.Name = "dataTLP";
            dataTLP.RowCount = 14;
            dataTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 7.46149254F));
            dataTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 7.46149254F));
            dataTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 7.46149254F));
            dataTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 7.46149254F));
            dataTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 7.46149254F));
            dataTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 7.46149254F));
            dataTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 3.00060034F));
            dataTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 7.46149254F));
            dataTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 7.46149254F));
            dataTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 7.46149254F));
            dataTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 7.46149254F));
            dataTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 7.46149254F));
            dataTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 7.46149254F));
            dataTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 7.46149254F));
            dataTLP.Size = new Size(372, 613);
            dataTLP.TabIndex = 2;
            // 
            // lblTurnoValor
            // 
            lblTurnoValor.AutoSize = true;
            lblTurnoValor.Dock = DockStyle.Fill;
            lblTurnoValor.Enabled = false;
            lblTurnoValor.Location = new Point(0, 225);
            lblTurnoValor.Margin = new Padding(0);
            lblTurnoValor.Name = "lblTurnoValor";
            lblTurnoValor.Size = new Size(372, 45);
            lblTurnoValor.TabIndex = 12;
            lblTurnoValor.Text = "Valor";
            lblTurnoValor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // telMailTLP
            // 
            telMailTLP.ColumnCount = 2;
            telMailTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            telMailTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            telMailTLP.Controls.Add(lblEmail, 1, 0);
            telMailTLP.Controls.Add(lblTelefono, 0, 0);
            telMailTLP.Dock = DockStyle.Fill;
            telMailTLP.Location = new Point(0, 513);
            telMailTLP.Margin = new Padding(0);
            telMailTLP.Name = "telMailTLP";
            telMailTLP.RowCount = 1;
            telMailTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            telMailTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            telMailTLP.Size = new Size(372, 45);
            telMailTLP.TabIndex = 9;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Location = new Point(189, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(180, 45);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Dock = DockStyle.Fill;
            lblTelefono.Location = new Point(3, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(180, 45);
            lblTelefono.TabIndex = 11;
            lblTelefono.Text = "Telefono";
            // 
            // lblTurnoEstado
            // 
            lblTurnoEstado.AutoSize = true;
            lblTurnoEstado.Dock = DockStyle.Fill;
            lblTurnoEstado.Enabled = false;
            lblTurnoEstado.Location = new Point(0, 180);
            lblTurnoEstado.Margin = new Padding(0);
            lblTurnoEstado.Name = "lblTurnoEstado";
            lblTurnoEstado.Size = new Size(372, 45);
            lblTurnoEstado.TabIndex = 4;
            lblTurnoEstado.Text = "Estado";
            lblTurnoEstado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTurnoEsp
            // 
            lblTurnoEsp.AutoSize = true;
            lblTurnoEsp.Dock = DockStyle.Fill;
            lblTurnoEsp.Enabled = false;
            lblTurnoEsp.Location = new Point(0, 135);
            lblTurnoEsp.Margin = new Padding(0);
            lblTurnoEsp.Name = "lblTurnoEsp";
            lblTurnoEsp.Size = new Size(372, 45);
            lblTurnoEsp.TabIndex = 3;
            lblTurnoEsp.Text = "Especialidad Medica";
            lblTurnoEsp.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTurnoProf
            // 
            lblTurnoProf.AutoSize = true;
            lblTurnoProf.Dock = DockStyle.Fill;
            lblTurnoProf.Enabled = false;
            lblTurnoProf.Location = new Point(0, 90);
            lblTurnoProf.Margin = new Padding(0);
            lblTurnoProf.Name = "lblTurnoProf";
            lblTurnoProf.Size = new Size(372, 45);
            lblTurnoProf.TabIndex = 2;
            lblTurnoProf.Text = "Profesional";
            lblTurnoProf.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Dock = DockStyle.Fill;
            lblTurno.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTurno.Location = new Point(0, 0);
            lblTurno.Margin = new Padding(0);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(372, 45);
            lblTurno.TabIndex = 0;
            lblTurno.Text = "DATOS DEL TURNO";
            lblTurno.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTurnoDia
            // 
            lblTurnoDia.AutoSize = true;
            lblTurnoDia.Dock = DockStyle.Fill;
            lblTurnoDia.Enabled = false;
            lblTurnoDia.Location = new Point(0, 45);
            lblTurnoDia.Margin = new Padding(0);
            lblTurnoDia.Name = "lblTurnoDia";
            lblTurnoDia.Size = new Size(372, 45);
            lblTurnoDia.TabIndex = 1;
            lblTurnoDia.Text = "Fecha Turno";
            lblTurnoDia.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Dock = DockStyle.Fill;
            lblPaciente.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaciente.Location = new Point(0, 288);
            lblPaciente.Margin = new Padding(0);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(372, 45);
            lblPaciente.TabIndex = 6;
            lblPaciente.Text = "DATOS DEL PACIENTE";
            lblPaciente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dniTLP
            // 
            dniTLP.ColumnCount = 2;
            dniTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            dniTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            dniTLP.Controls.Add(pacienteDniTxt, 0, 0);
            dniTLP.Controls.Add(dniSearchBtn, 1, 0);
            dniTLP.Dock = DockStyle.Fill;
            dniTLP.Location = new Point(3, 336);
            dniTLP.Name = "dniTLP";
            dniTLP.RowCount = 1;
            dniTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            dniTLP.Size = new Size(366, 39);
            dniTLP.TabIndex = 7;
            // 
            // pacienteDniTxt
            // 
            pacienteDniTxt.Dock = DockStyle.Fill;
            pacienteDniTxt.ImeMode = ImeMode.NoControl;
            pacienteDniTxt.Location = new Point(0, 5);
            pacienteDniTxt.Margin = new Padding(0, 5, 0, 0);
            pacienteDniTxt.MaxLength = 9;
            pacienteDniTxt.Name = "pacienteDniTxt";
            pacienteDniTxt.PlaceholderText = "DNI";
            pacienteDniTxt.Size = new Size(292, 27);
            pacienteDniTxt.TabIndex = 0;
            // 
            // dniSearchBtn
            // 
            dniSearchBtn.BackgroundImage = Properties.Resources.icon_lupa;
            dniSearchBtn.BackgroundImageLayout = ImageLayout.Zoom;
            dniSearchBtn.Dock = DockStyle.Fill;
            dniSearchBtn.ForeColor = SystemColors.ControlText;
            dniSearchBtn.Location = new Point(292, 0);
            dniSearchBtn.Margin = new Padding(0);
            dniSearchBtn.Name = "dniSearchBtn";
            dniSearchBtn.Padding = new Padding(6);
            dniSearchBtn.Size = new Size(74, 39);
            dniSearchBtn.TabIndex = 1;
            dniSearchBtn.UseVisualStyleBackColor = true;
            dniSearchBtn.Click += dniSearchBtn_Click;
            // 
            // osTLP
            // 
            osTLP.ColumnCount = 2;
            osTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            osTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            osTLP.Controls.Add(lblNumAfiliado, 1, 0);
            osTLP.Controls.Add(lblObraSocial, 0, 0);
            osTLP.Dock = DockStyle.Fill;
            osTLP.Location = new Point(3, 426);
            osTLP.Name = "osTLP";
            osTLP.RowCount = 1;
            osTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            osTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            osTLP.Size = new Size(366, 39);
            osTLP.TabIndex = 8;
            // 
            // lblNumAfiliado
            // 
            lblNumAfiliado.AutoSize = true;
            lblNumAfiliado.Dock = DockStyle.Fill;
            lblNumAfiliado.Location = new Point(183, 0);
            lblNumAfiliado.Margin = new Padding(0);
            lblNumAfiliado.Name = "lblNumAfiliado";
            lblNumAfiliado.Size = new Size(183, 39);
            lblNumAfiliado.TabIndex = 12;
            lblNumAfiliado.Text = "N°";
            // 
            // lblObraSocial
            // 
            lblObraSocial.AutoSize = true;
            lblObraSocial.Dock = DockStyle.Fill;
            lblObraSocial.Location = new Point(0, 0);
            lblObraSocial.Margin = new Padding(0);
            lblObraSocial.Name = "lblObraSocial";
            lblObraSocial.Size = new Size(183, 39);
            lblObraSocial.TabIndex = 11;
            lblObraSocial.Text = "OS";
            // 
            // sexoEdadTLP
            // 
            sexoEdadTLP.ColumnCount = 2;
            sexoEdadTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            sexoEdadTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            sexoEdadTLP.Controls.Add(lblEdad, 1, 0);
            sexoEdadTLP.Controls.Add(lblGenero, 0, 0);
            sexoEdadTLP.Dock = DockStyle.Fill;
            sexoEdadTLP.Location = new Point(0, 468);
            sexoEdadTLP.Margin = new Padding(0);
            sexoEdadTLP.Name = "sexoEdadTLP";
            sexoEdadTLP.RowCount = 1;
            sexoEdadTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            sexoEdadTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            sexoEdadTLP.Size = new Size(372, 45);
            sexoEdadTLP.TabIndex = 9;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Dock = DockStyle.Fill;
            lblEdad.Location = new Point(189, 0);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(180, 45);
            lblEdad.TabIndex = 12;
            lblEdad.Text = "Edad";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Dock = DockStyle.Fill;
            lblGenero.Location = new Point(3, 0);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(180, 45);
            lblGenero.TabIndex = 11;
            lblGenero.Text = "Genero";
            // 
            // lblPacienteNombre
            // 
            lblPacienteNombre.AutoSize = true;
            lblPacienteNombre.Dock = DockStyle.Fill;
            lblPacienteNombre.Location = new Point(0, 378);
            lblPacienteNombre.Margin = new Padding(0);
            lblPacienteNombre.Name = "lblPacienteNombre";
            lblPacienteNombre.Size = new Size(372, 45);
            lblPacienteNombre.TabIndex = 10;
            lblPacienteNombre.Text = "Nombre";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Dock = DockStyle.Fill;
            lblDireccion.Location = new Point(3, 558);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(366, 55);
            lblDireccion.TabIndex = 11;
            lblDireccion.Text = "Direccion";
            // 
            // AdmGTDetalleTurno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(mainTLP);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1024, 768);
            Name = "AdmGTDetalleTurno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle de Turno";
            WindowState = FormWindowState.Maximized;
            Load += AdmGTDetalleTurno_Load;
            mainTLP.ResumeLayout(false);
            menuTLP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            contentTLP.ResumeLayout(false);
            contentTLP.PerformLayout();
            viewTLP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgPicBox).EndInit();
            dataTLP.ResumeLayout(false);
            dataTLP.PerformLayout();
            telMailTLP.ResumeLayout(false);
            telMailTLP.PerformLayout();
            dniTLP.ResumeLayout(false);
            dniTLP.PerformLayout();
            osTLP.ResumeLayout(false);
            osTLP.PerformLayout();
            sexoEdadTLP.ResumeLayout(false);
            sexoEdadTLP.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTLP;
        private TableLayoutPanel menuTLP;
        private PictureBox picLogo;
        private Button btnVolver;
        private Button btnAbonar;
        private Button btnCancelar;
        private Button btnAsignar;
        private TableLayoutPanel contentTLP;
        private Label contentLbl;
        private TableLayoutPanel viewTLP;
        private PictureBox imgPicBox;
        private TextBox pacienteDniTxt;
        private Button dniSearchBtn;
        private TableLayoutPanel dataTLP;
        private Label lblTurno;
        private Label lblTurnoDia;
        private Label lblTurnoEstado;
        private Label lblTurnoEsp;
        private Label lblTurnoProf;
        private Label lblPaciente;
        private TableLayoutPanel dniTLP;
        private TableLayoutPanel telMailTLP;
        private Label lblEmail;
        private Label lblTelefono;
        private TableLayoutPanel osTLP;
        private Label lblNumAfiliado;
        private Label lblObraSocial;
        private TableLayoutPanel sexoEdadTLP;
        private Label lblEdad;
        private Label lblGenero;
        private Label lblPacienteNombre;
        private Label lblDireccion;
        private Label lblTurnoValor;
    }
}
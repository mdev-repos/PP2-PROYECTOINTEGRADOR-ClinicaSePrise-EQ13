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
            mainTLP.Size = new Size(1008, 729);
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
            menuTLP.Location = new Point(756, 0);
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
            menuTLP.Size = new Size(252, 729);
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
            picLogo.Size = new Size(252, 218);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Pink;
            btnVolver.Dock = DockStyle.Fill;
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(0, 608);
            btnVolver.Margin = new Padding(0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(252, 58);
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
            btnAbonar.Location = new Point(0, 463);
            btnAbonar.Margin = new Padding(0);
            btnAbonar.Name = "btnAbonar";
            btnAbonar.Size = new Size(252, 58);
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
            btnCancelar.Location = new Point(0, 362);
            btnCancelar.Margin = new Padding(0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(252, 58);
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
            btnAsignar.Location = new Point(0, 261);
            btnAsignar.Margin = new Padding(0);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(252, 58);
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
            contentTLP.Size = new Size(756, 729);
            contentTLP.TabIndex = 1;
            // 
            // contentLbl
            // 
            contentLbl.AutoSize = true;
            contentLbl.BackColor = SystemColors.GradientInactiveCaption;
            contentLbl.Dock = DockStyle.Fill;
            contentLbl.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contentLbl.Location = new Point(0, 36);
            contentLbl.Margin = new Padding(0);
            contentLbl.Name = "contentLbl";
            contentLbl.Size = new Size(756, 72);
            contentLbl.TabIndex = 0;
            contentLbl.Text = "DETALLE DE TURNO";
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
            viewTLP.Location = new Point(0, 108);
            viewTLP.Margin = new Padding(0);
            viewTLP.Name = "viewTLP";
            viewTLP.RowCount = 1;
            viewTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            viewTLP.Size = new Size(756, 621);
            viewTLP.TabIndex = 1;
            // 
            // imgPicBox
            // 
            imgPicBox.Dock = DockStyle.Fill;
            imgPicBox.Image = Properties.Resources.img_detalleTurno;
            imgPicBox.Location = new Point(381, 3);
            imgPicBox.Name = "imgPicBox";
            imgPicBox.Size = new Size(372, 615);
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
            dataTLP.Size = new Size(373, 621);
            dataTLP.TabIndex = 2;
            // 
            // lblTurnoValor
            // 
            lblTurnoValor.AutoSize = true;
            lblTurnoValor.Dock = DockStyle.Fill;
            lblTurnoValor.Enabled = false;
            lblTurnoValor.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblTurnoValor.Location = new Point(0, 230);
            lblTurnoValor.Margin = new Padding(0);
            lblTurnoValor.Name = "lblTurnoValor";
            lblTurnoValor.Size = new Size(373, 46);
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
            telMailTLP.Location = new Point(0, 524);
            telMailTLP.Margin = new Padding(0);
            telMailTLP.Name = "telMailTLP";
            telMailTLP.RowCount = 1;
            telMailTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            telMailTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            telMailTLP.Size = new Size(373, 46);
            telMailTLP.TabIndex = 9;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblEmail.Location = new Point(189, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(181, 46);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "EMAIL:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Dock = DockStyle.Fill;
            lblTelefono.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblTelefono.Location = new Point(3, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(180, 46);
            lblTelefono.TabIndex = 11;
            lblTelefono.Text = "TEL:";
            // 
            // lblTurnoEstado
            // 
            lblTurnoEstado.AutoSize = true;
            lblTurnoEstado.Dock = DockStyle.Fill;
            lblTurnoEstado.Enabled = false;
            lblTurnoEstado.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblTurnoEstado.Location = new Point(0, 184);
            lblTurnoEstado.Margin = new Padding(0);
            lblTurnoEstado.Name = "lblTurnoEstado";
            lblTurnoEstado.Size = new Size(373, 46);
            lblTurnoEstado.TabIndex = 4;
            lblTurnoEstado.Text = "Estado";
            lblTurnoEstado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTurnoEsp
            // 
            lblTurnoEsp.AutoSize = true;
            lblTurnoEsp.Dock = DockStyle.Fill;
            lblTurnoEsp.Enabled = false;
            lblTurnoEsp.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblTurnoEsp.Location = new Point(0, 138);
            lblTurnoEsp.Margin = new Padding(0);
            lblTurnoEsp.Name = "lblTurnoEsp";
            lblTurnoEsp.Size = new Size(373, 46);
            lblTurnoEsp.TabIndex = 3;
            lblTurnoEsp.Text = "Especialidad Medica";
            lblTurnoEsp.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTurnoProf
            // 
            lblTurnoProf.AutoSize = true;
            lblTurnoProf.Dock = DockStyle.Fill;
            lblTurnoProf.Enabled = false;
            lblTurnoProf.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblTurnoProf.Location = new Point(0, 92);
            lblTurnoProf.Margin = new Padding(0);
            lblTurnoProf.Name = "lblTurnoProf";
            lblTurnoProf.Size = new Size(373, 46);
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
            lblTurno.Size = new Size(373, 46);
            lblTurno.TabIndex = 0;
            lblTurno.Text = "DATOS DEL TURNO";
            lblTurno.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTurnoDia
            // 
            lblTurnoDia.AutoSize = true;
            lblTurnoDia.Dock = DockStyle.Fill;
            lblTurnoDia.Enabled = false;
            lblTurnoDia.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblTurnoDia.Location = new Point(0, 46);
            lblTurnoDia.Margin = new Padding(0);
            lblTurnoDia.Name = "lblTurnoDia";
            lblTurnoDia.Size = new Size(373, 46);
            lblTurnoDia.TabIndex = 1;
            lblTurnoDia.Text = "Fecha Turno";
            lblTurnoDia.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Dock = DockStyle.Fill;
            lblPaciente.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaciente.Location = new Point(0, 294);
            lblPaciente.Margin = new Padding(0);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(373, 46);
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
            dniTLP.Location = new Point(3, 343);
            dniTLP.Name = "dniTLP";
            dniTLP.RowCount = 1;
            dniTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            dniTLP.Size = new Size(367, 40);
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
            pacienteDniTxt.Size = new Size(293, 27);
            pacienteDniTxt.TabIndex = 0;
            // 
            // dniSearchBtn
            // 
            dniSearchBtn.BackgroundImage = Properties.Resources.icon_lupa;
            dniSearchBtn.BackgroundImageLayout = ImageLayout.Zoom;
            dniSearchBtn.Dock = DockStyle.Fill;
            dniSearchBtn.ForeColor = SystemColors.ControlText;
            dniSearchBtn.Location = new Point(293, 0);
            dniSearchBtn.Margin = new Padding(0);
            dniSearchBtn.Name = "dniSearchBtn";
            dniSearchBtn.Padding = new Padding(6, 5, 6, 5);
            dniSearchBtn.Size = new Size(74, 40);
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
            osTLP.Location = new Point(3, 435);
            osTLP.Name = "osTLP";
            osTLP.RowCount = 1;
            osTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            osTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            osTLP.Size = new Size(367, 40);
            osTLP.TabIndex = 8;
            // 
            // lblNumAfiliado
            // 
            lblNumAfiliado.AutoSize = true;
            lblNumAfiliado.Dock = DockStyle.Fill;
            lblNumAfiliado.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblNumAfiliado.Location = new Point(183, 0);
            lblNumAfiliado.Margin = new Padding(0);
            lblNumAfiliado.Name = "lblNumAfiliado";
            lblNumAfiliado.Size = new Size(184, 40);
            lblNumAfiliado.TabIndex = 12;
            lblNumAfiliado.Text = "N°";
            // 
            // lblObraSocial
            // 
            lblObraSocial.AutoSize = true;
            lblObraSocial.Dock = DockStyle.Fill;
            lblObraSocial.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblObraSocial.Location = new Point(0, 0);
            lblObraSocial.Margin = new Padding(0);
            lblObraSocial.Name = "lblObraSocial";
            lblObraSocial.Size = new Size(183, 40);
            lblObraSocial.TabIndex = 11;
            lblObraSocial.Text = "OS:";
            // 
            // sexoEdadTLP
            // 
            sexoEdadTLP.ColumnCount = 2;
            sexoEdadTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            sexoEdadTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            sexoEdadTLP.Controls.Add(lblEdad, 1, 0);
            sexoEdadTLP.Controls.Add(lblGenero, 0, 0);
            sexoEdadTLP.Dock = DockStyle.Fill;
            sexoEdadTLP.Location = new Point(0, 478);
            sexoEdadTLP.Margin = new Padding(0);
            sexoEdadTLP.Name = "sexoEdadTLP";
            sexoEdadTLP.RowCount = 1;
            sexoEdadTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            sexoEdadTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            sexoEdadTLP.Size = new Size(373, 46);
            sexoEdadTLP.TabIndex = 9;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Dock = DockStyle.Fill;
            lblEdad.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblEdad.Location = new Point(189, 0);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(181, 46);
            lblEdad.TabIndex = 12;
            lblEdad.Text = "EDAD:";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Dock = DockStyle.Fill;
            lblGenero.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblGenero.Location = new Point(3, 0);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(180, 46);
            lblGenero.TabIndex = 11;
            lblGenero.Text = "GENERO: ";
            // 
            // lblPacienteNombre
            // 
            lblPacienteNombre.AutoSize = true;
            lblPacienteNombre.Dock = DockStyle.Fill;
            lblPacienteNombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblPacienteNombre.Location = new Point(0, 386);
            lblPacienteNombre.Margin = new Padding(0);
            lblPacienteNombre.Name = "lblPacienteNombre";
            lblPacienteNombre.Size = new Size(373, 46);
            lblPacienteNombre.TabIndex = 10;
            lblPacienteNombre.Text = "NOMBRE:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Dock = DockStyle.Fill;
            lblDireccion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblDireccion.Location = new Point(3, 570);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(367, 51);
            lblDireccion.TabIndex = 11;
            lblDireccion.Text = "DIRECCION:";
            // 
            // AdmGTDetalleTurno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(mainTLP);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1024, 766);
            Name = "AdmGTDetalleTurno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clinica SePrise  ||  Detalle de Turno";
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
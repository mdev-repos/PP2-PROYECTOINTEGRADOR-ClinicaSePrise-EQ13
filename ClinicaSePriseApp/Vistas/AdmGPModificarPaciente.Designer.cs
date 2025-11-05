namespace ClinicaSePriseApp.Vistas
{
    partial class AdmGPModificarPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmGPModificarPaciente));
            mainTLP = new TableLayoutPanel();
            menuTLP = new TableLayoutPanel();
            picLogo = new PictureBox();
            btnVolver = new Button();
            btnConfirmar = new Button();
            contentTLP = new TableLayoutPanel();
            contentLbl = new Label();
            viewTLP = new TableLayoutPanel();
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
            lblFechaNacimiento = new Label();
            lblGenero = new Label();
            lblDni = new Label();
            lblApellido = new Label();
            lblTurno = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            cboxGenero = new ComboBox();
            dateFechaNacimiento = new DateTimePicker();
            mainTLP.SuspendLayout();
            menuTLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            contentTLP.SuspendLayout();
            viewTLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgPicBox).BeginInit();
            dataTLP.SuspendLayout();
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
            mainTLP.Size = new Size(1664, 775);
            mainTLP.TabIndex = 3;
            // 
            // menuTLP
            // 
            menuTLP.BackColor = SystemColors.GradientInactiveCaption;
            menuTLP.ColumnCount = 1;
            menuTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            menuTLP.Controls.Add(picLogo, 0, 0);
            menuTLP.Controls.Add(btnVolver, 0, 8);
            menuTLP.Controls.Add(btnConfirmar, 0, 2);
            menuTLP.Dock = DockStyle.Fill;
            menuTLP.Location = new Point(1248, 0);
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
            menuTLP.Size = new Size(416, 775);
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
            picLogo.Size = new Size(416, 232);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Pink;
            btnVolver.Dock = DockStyle.Fill;
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(0, 649);
            btnVolver.Margin = new Padding(0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(416, 62);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "VOLVER A PACIENTES";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.CornflowerBlue;
            btnConfirmar.Dock = DockStyle.Fill;
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(0, 278);
            btnConfirmar.Margin = new Padding(0);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(416, 62);
            btnConfirmar.TabIndex = 9;
            btnConfirmar.Text = "CONFIRMAR";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
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
            contentTLP.Size = new Size(1248, 775);
            contentTLP.TabIndex = 1;
            // 
            // contentLbl
            // 
            contentLbl.AutoSize = true;
            contentLbl.BackColor = SystemColors.GradientInactiveCaption;
            contentLbl.Dock = DockStyle.Fill;
            contentLbl.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contentLbl.Location = new Point(0, 38);
            contentLbl.Margin = new Padding(0);
            contentLbl.Name = "contentLbl";
            contentLbl.Size = new Size(1248, 77);
            contentLbl.TabIndex = 0;
            contentLbl.Text = "MODIFICAR PACIENTE";
            contentLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // viewTLP
            // 
            viewTLP.ColumnCount = 2;
            viewTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            viewTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            viewTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            viewTLP.Controls.Add(imgPicBox, 1, 0);
            viewTLP.Controls.Add(dataTLP, 0, 0);
            viewTLP.Dock = DockStyle.Fill;
            viewTLP.Location = new Point(0, 115);
            viewTLP.Margin = new Padding(0);
            viewTLP.Name = "viewTLP";
            viewTLP.RowCount = 1;
            viewTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            viewTLP.Size = new Size(1248, 660);
            viewTLP.TabIndex = 1;
            // 
            // imgPicBox
            // 
            imgPicBox.Dock = DockStyle.Fill;
            imgPicBox.Image = (Image)resources.GetObject("imgPicBox.Image");
            imgPicBox.Location = new Point(627, 2);
            imgPicBox.Margin = new Padding(3, 2, 3, 2);
            imgPicBox.Name = "imgPicBox";
            imgPicBox.Size = new Size(618, 656);
            imgPicBox.SizeMode = PictureBoxSizeMode.Zoom;
            imgPicBox.TabIndex = 0;
            imgPicBox.TabStop = false;
            // 
            // dataTLP
            // 
            dataTLP.ColumnCount = 2;
            dataTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.63514F));
            dataTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.3648643F));
            dataTLP.Controls.Add(dateFechaNacimiento, 1, 5);
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
            dataTLP.Dock = DockStyle.Fill;
            dataTLP.Location = new Point(4, 0);
            dataTLP.Margin = new Padding(4, 0, 0, 0);
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
            dataTLP.Size = new Size(620, 660);
            dataTLP.TabIndex = 2;
            // 
            // txtNroAfiliado
            // 
            txtNroAfiliado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNroAfiliado.Location = new Point(295, 617);
            txtNroAfiliado.Margin = new Padding(0);
            txtNroAfiliado.Name = "txtNroAfiliado";
            txtNroAfiliado.Size = new Size(325, 23);
            txtNroAfiliado.TabIndex = 40;
            txtNroAfiliado.Text = " ";
            // 
            // lblNroAfiliado
            // 
            lblNroAfiliado.AutoSize = true;
            lblNroAfiliado.Dock = DockStyle.Fill;
            lblNroAfiliado.Enabled = false;
            lblNroAfiliado.ForeColor = Color.Black;
            lblNroAfiliado.Location = new Point(0, 597);
            lblNroAfiliado.Margin = new Padding(0);
            lblNroAfiliado.Name = "lblNroAfiliado";
            lblNroAfiliado.Size = new Size(295, 63);
            lblNroAfiliado.TabIndex = 39;
            lblNroAfiliado.Text = "Nro Afiliado: ";
            lblNroAfiliado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboxObraSocial
            // 
            cboxObraSocial.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboxObraSocial.FormattingEnabled = true;
            cboxObraSocial.Location = new Point(298, 556);
            cboxObraSocial.Name = "cboxObraSocial";
            cboxObraSocial.Size = new Size(319, 23);
            cboxObraSocial.TabIndex = 36;
            // 
            // txtMail
            // 
            txtMail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMail.Location = new Point(295, 497);
            txtMail.Margin = new Padding(0);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(325, 23);
            txtMail.TabIndex = 33;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTelefono.Location = new Point(295, 438);
            txtTelefono.Margin = new Padding(0);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(325, 23);
            txtTelefono.TabIndex = 32;
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDireccion.Location = new Point(295, 379);
            txtDireccion.Margin = new Padding(0);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(325, 23);
            txtDireccion.TabIndex = 31;
            // 
            // txtDni
            // 
            txtDni.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDni.Location = new Point(295, 202);
            txtDni.Margin = new Padding(0);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(325, 23);
            txtDni.TabIndex = 28;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtApellido.Location = new Point(295, 143);
            txtApellido.Margin = new Padding(0);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(325, 23);
            txtApellido.TabIndex = 27;
            // 
            // lblObraSocial
            // 
            lblObraSocial.AutoSize = true;
            lblObraSocial.Dock = DockStyle.Fill;
            lblObraSocial.Enabled = false;
            lblObraSocial.Location = new Point(0, 538);
            lblObraSocial.Margin = new Padding(0);
            lblObraSocial.Name = "lblObraSocial";
            lblObraSocial.Size = new Size(295, 59);
            lblObraSocial.TabIndex = 25;
            lblObraSocial.Text = "Obra Social: ";
            lblObraSocial.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Enabled = false;
            lblEmail.Location = new Point(0, 479);
            lblEmail.Margin = new Padding(0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(295, 59);
            lblEmail.TabIndex = 23;
            lblEmail.Text = "E-mail: ";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Dock = DockStyle.Fill;
            lblTelefono.Enabled = false;
            lblTelefono.Location = new Point(0, 420);
            lblTelefono.Margin = new Padding(0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(295, 59);
            lblTelefono.TabIndex = 21;
            lblTelefono.Text = "Teléfono: ";
            lblTelefono.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Enabled = false;
            label7.Location = new Point(0, 361);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(295, 59);
            label7.TabIndex = 19;
            label7.Text = "Dirección: ";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Dock = DockStyle.Fill;
            lblFechaNacimiento.Enabled = false;
            lblFechaNacimiento.Location = new Point(0, 302);
            lblFechaNacimiento.Margin = new Padding(0);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(295, 59);
            lblFechaNacimiento.TabIndex = 12;
            lblFechaNacimiento.Text = "Fecha de nacimiento:";
            lblFechaNacimiento.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Dock = DockStyle.Fill;
            lblGenero.Enabled = false;
            lblGenero.Location = new Point(0, 243);
            lblGenero.Margin = new Padding(0);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(295, 59);
            lblGenero.TabIndex = 4;
            lblGenero.Text = "Género: ";
            lblGenero.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Dock = DockStyle.Fill;
            lblDni.Enabled = false;
            lblDni.Location = new Point(0, 184);
            lblDni.Margin = new Padding(0);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(295, 59);
            lblDni.TabIndex = 3;
            lblDni.Text = "DNI: ";
            lblDni.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Dock = DockStyle.Fill;
            lblApellido.Enabled = false;
            lblApellido.Location = new Point(0, 125);
            lblApellido.Margin = new Padding(0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(295, 59);
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
            lblTurno.Size = new Size(620, 66);
            lblTurno.TabIndex = 0;
            lblTurno.Text = "DATOS DEL PACIENTE";
            lblTurno.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Dock = DockStyle.Fill;
            lblNombre.Enabled = false;
            lblNombre.Location = new Point(0, 66);
            lblNombre.Margin = new Padding(0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(295, 59);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre: ";
            lblNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Location = new Point(295, 84);
            txtNombre.Margin = new Padding(0);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(325, 23);
            txtNombre.TabIndex = 26;
            // 
            // cboxGenero
            // 
            cboxGenero.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboxGenero.FormattingEnabled = true;
            cboxGenero.Location = new Point(298, 261);
            cboxGenero.Name = "cboxGenero";
            cboxGenero.Size = new Size(319, 23);
            cboxGenero.TabIndex = 34;
            // 
            // dateFechaNacimiento
            // 
            dateFechaNacimiento.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dateFechaNacimiento.Location = new Point(298, 320);
            dateFechaNacimiento.Name = "dateFechaNacimiento";
            dateFechaNacimiento.Size = new Size(319, 23);
            dateFechaNacimiento.TabIndex = 41;
            // 
            // AdmGPModificarPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1664, 775);
            Controls.Add(mainTLP);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(898, 586);
            Name = "AdmGPModificarPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clinica SePrise  ||  Modificar Paciente";
            WindowState = FormWindowState.Maximized;
            Load += AdmGPModificarPaciente_Load;
            mainTLP.ResumeLayout(false);
            menuTLP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            contentTLP.ResumeLayout(false);
            contentTLP.PerformLayout();
            viewTLP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgPicBox).EndInit();
            dataTLP.ResumeLayout(false);
            dataTLP.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTLP;
        private TableLayoutPanel menuTLP;
        private PictureBox picLogo;
        private Button btnVolver;
        private Button btnConfirmar;
        private TableLayoutPanel contentTLP;
        private Label contentLbl;
        private TableLayoutPanel viewTLP;
        private PictureBox imgPicBox;
        private TableLayoutPanel dataTLP;
        private ComboBox cboxObraSocial;
        private TextBox txtMail;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtDni;
        private TextBox txtApellido;
        private Label lblObraSocial;
        private Label lblEmail;
        private Label lblTelefono;
        private Label label7;
        private Label lblFechaNacimiento;
        private Label lblGenero;
        private Label lblDni;
        private Label lblApellido;
        private Label lblTurno;
        private Label lblNombre;
        private TextBox txtNombre;
        private ComboBox cboxGenero;
        private Label lblNroAfiliado;
        private TextBox txtNroAfiliado;
        private DateTimePicker dateFechaNacimiento;
    }
}
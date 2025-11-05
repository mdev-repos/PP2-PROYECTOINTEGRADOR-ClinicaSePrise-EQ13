namespace ClinicaSePriseApp.Vistas.Auxiliares
{
    partial class AuxDetalleTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuxDetalleTurno));
            mainTLP = new TableLayoutPanel();
            lblTurno = new Label();
            lblNombre = new Label();
            contactoTLP = new TableLayoutPanel();
            lblMail = new Label();
            lblTel = new Label();
            OSTLP = new TableLayoutPanel();
            lblNumAfiliado = new Label();
            lblOS = new Label();
            edadTLP = new TableLayoutPanel();
            lblEdad = new Label();
            lblFechaNac = new Label();
            identidadTLP = new TableLayoutPanel();
            lblGenero = new Label();
            lblDNI = new Label();
            botonesTLP = new TableLayoutPanel();
            btnVerHistoria = new Button();
            btnCerrar = new Button();
            mainTLP.SuspendLayout();
            contactoTLP.SuspendLayout();
            OSTLP.SuspendLayout();
            edadTLP.SuspendLayout();
            identidadTLP.SuspendLayout();
            botonesTLP.SuspendLayout();
            SuspendLayout();
            // 
            // mainTLP
            // 
            mainTLP.ColumnCount = 3;
            mainTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            mainTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            mainTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            mainTLP.Controls.Add(lblTurno, 1, 0);
            mainTLP.Controls.Add(lblNombre, 1, 1);
            mainTLP.Controls.Add(contactoTLP, 1, 6);
            mainTLP.Controls.Add(OSTLP, 1, 5);
            mainTLP.Controls.Add(edadTLP, 1, 4);
            mainTLP.Controls.Add(identidadTLP, 1, 3);
            mainTLP.Controls.Add(botonesTLP, 1, 8);
            mainTLP.Dock = DockStyle.Fill;
            mainTLP.Location = new Point(0, 0);
            mainTLP.Margin = new Padding(0);
            mainTLP.Name = "mainTLP";
            mainTLP.RowCount = 10;
            mainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 11.4942532F));
            mainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 11.4942532F));
            mainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 8.045977F));
            mainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 11.4942532F));
            mainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 11.4942532F));
            mainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 11.4942532F));
            mainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 11.4942532F));
            mainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 5.74712658F));
            mainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 11.4942532F));
            mainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 5.74712658F));
            mainTLP.Size = new Size(800, 600);
            mainTLP.TabIndex = 0;
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Dock = DockStyle.Fill;
            lblTurno.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTurno.Location = new Point(80, 0);
            lblTurno.Margin = new Padding(0);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(640, 68);
            lblTurno.TabIndex = 1;
            lblTurno.Text = "Detalle del Turno";
            lblTurno.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Dock = DockStyle.Fill;
            lblNombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(80, 68);
            lblNombre.Margin = new Padding(0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(640, 68);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Paciente: ";
            lblNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // contactoTLP
            // 
            contactoTLP.ColumnCount = 2;
            contactoTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            contactoTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            contactoTLP.Controls.Add(lblMail, 1, 0);
            contactoTLP.Controls.Add(lblTel, 0, 0);
            contactoTLP.Dock = DockStyle.Fill;
            contactoTLP.Location = new Point(80, 388);
            contactoTLP.Margin = new Padding(0);
            contactoTLP.Name = "contactoTLP";
            contactoTLP.RowCount = 1;
            contactoTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            contactoTLP.Size = new Size(640, 68);
            contactoTLP.TabIndex = 8;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Dock = DockStyle.Fill;
            lblMail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMail.Location = new Point(320, 0);
            lblMail.Margin = new Padding(0);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(320, 68);
            lblMail.TabIndex = 6;
            lblMail.Text = "EMail:";
            lblMail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Dock = DockStyle.Fill;
            lblTel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTel.Location = new Point(0, 0);
            lblTel.Margin = new Padding(0);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(320, 68);
            lblTel.TabIndex = 4;
            lblTel.Text = "Tel: ";
            lblTel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // OSTLP
            // 
            OSTLP.ColumnCount = 2;
            OSTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            OSTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            OSTLP.Controls.Add(lblNumAfiliado, 1, 0);
            OSTLP.Controls.Add(lblOS, 0, 0);
            OSTLP.Dock = DockStyle.Fill;
            OSTLP.Location = new Point(80, 320);
            OSTLP.Margin = new Padding(0);
            OSTLP.Name = "OSTLP";
            OSTLP.RowCount = 1;
            OSTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            OSTLP.Size = new Size(640, 68);
            OSTLP.TabIndex = 7;
            // 
            // lblNumAfiliado
            // 
            lblNumAfiliado.AutoSize = true;
            lblNumAfiliado.Dock = DockStyle.Fill;
            lblNumAfiliado.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumAfiliado.Location = new Point(320, 0);
            lblNumAfiliado.Margin = new Padding(0);
            lblNumAfiliado.Name = "lblNumAfiliado";
            lblNumAfiliado.Size = new Size(320, 68);
            lblNumAfiliado.TabIndex = 6;
            lblNumAfiliado.Text = "N° ";
            lblNumAfiliado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblOS
            // 
            lblOS.AutoSize = true;
            lblOS.Dock = DockStyle.Fill;
            lblOS.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOS.Location = new Point(0, 0);
            lblOS.Margin = new Padding(0);
            lblOS.Name = "lblOS";
            lblOS.Size = new Size(320, 68);
            lblOS.TabIndex = 4;
            lblOS.Text = "Obra Social: ";
            lblOS.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // edadTLP
            // 
            edadTLP.ColumnCount = 2;
            edadTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            edadTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            edadTLP.Controls.Add(lblEdad, 1, 0);
            edadTLP.Controls.Add(lblFechaNac, 0, 0);
            edadTLP.Dock = DockStyle.Fill;
            edadTLP.Location = new Point(80, 252);
            edadTLP.Margin = new Padding(0);
            edadTLP.Name = "edadTLP";
            edadTLP.RowCount = 1;
            edadTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            edadTLP.Size = new Size(640, 68);
            edadTLP.TabIndex = 5;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Dock = DockStyle.Fill;
            lblEdad.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEdad.Location = new Point(320, 0);
            lblEdad.Margin = new Padding(0);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(320, 68);
            lblEdad.TabIndex = 6;
            lblEdad.Text = "Edad: ";
            lblEdad.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Dock = DockStyle.Fill;
            lblFechaNac.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaNac.Location = new Point(0, 0);
            lblFechaNac.Margin = new Padding(0);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(320, 68);
            lblFechaNac.TabIndex = 4;
            lblFechaNac.Text = "Fecha de Nacimiento: ";
            lblFechaNac.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // identidadTLP
            // 
            identidadTLP.ColumnCount = 2;
            identidadTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            identidadTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            identidadTLP.Controls.Add(lblGenero, 1, 0);
            identidadTLP.Controls.Add(lblDNI, 0, 0);
            identidadTLP.Dock = DockStyle.Fill;
            identidadTLP.Location = new Point(80, 184);
            identidadTLP.Margin = new Padding(0);
            identidadTLP.Name = "identidadTLP";
            identidadTLP.RowCount = 1;
            identidadTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            identidadTLP.Size = new Size(640, 68);
            identidadTLP.TabIndex = 6;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Dock = DockStyle.Fill;
            lblGenero.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGenero.Location = new Point(320, 0);
            lblGenero.Margin = new Padding(0);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(320, 68);
            lblGenero.TabIndex = 7;
            lblGenero.Text = "Genero: ";
            lblGenero.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Dock = DockStyle.Fill;
            lblDNI.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDNI.Location = new Point(0, 0);
            lblDNI.Margin = new Padding(0);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(320, 68);
            lblDNI.TabIndex = 3;
            lblDNI.Text = "DNI: ";
            lblDNI.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // botonesTLP
            // 
            botonesTLP.ColumnCount = 5;
            botonesTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.4328356F));
            botonesTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.8507462F));
            botonesTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.4328356F));
            botonesTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.8507462F));
            botonesTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.4328356F));
            botonesTLP.Controls.Add(btnVerHistoria, 1, 0);
            botonesTLP.Controls.Add(btnCerrar, 3, 0);
            botonesTLP.Dock = DockStyle.Fill;
            botonesTLP.Location = new Point(80, 490);
            botonesTLP.Margin = new Padding(0);
            botonesTLP.Name = "botonesTLP";
            botonesTLP.RowCount = 1;
            botonesTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            botonesTLP.Size = new Size(640, 68);
            botonesTLP.TabIndex = 9;
            // 
            // btnVerHistoria
            // 
            btnVerHistoria.Dock = DockStyle.Fill;
            btnVerHistoria.Location = new Point(88, 3);
            btnVerHistoria.Name = "btnVerHistoria";
            btnVerHistoria.Size = new Size(185, 62);
            btnVerHistoria.TabIndex = 0;
            btnVerHistoria.Text = "HISTORIA CLINICA";
            btnVerHistoria.UseVisualStyleBackColor = true;
            btnVerHistoria.Click += btnVerHistoria_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Dock = DockStyle.Fill;
            btnCerrar.Location = new Point(364, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(185, 62);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "CERRAR";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // DetalleTurno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(mainTLP);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(800, 600);
            Name = "DetalleTurno";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Detalle de Turno";
            mainTLP.ResumeLayout(false);
            mainTLP.PerformLayout();
            contactoTLP.ResumeLayout(false);
            contactoTLP.PerformLayout();
            OSTLP.ResumeLayout(false);
            OSTLP.PerformLayout();
            edadTLP.ResumeLayout(false);
            edadTLP.PerformLayout();
            identidadTLP.ResumeLayout(false);
            identidadTLP.PerformLayout();
            botonesTLP.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTLP;
        private Label lblTurno;
        private Label lblNombre;
        private Label lblDNI;
        private Label lblFechaNac;
        private TableLayoutPanel edadTLP;
        private Label lblEdad;
        private TableLayoutPanel identidadTLP;
        private Label lblGenero;
        private TableLayoutPanel contactoTLP;
        private Label lblMail;
        private Label lblTel;
        private TableLayoutPanel OSTLP;
        private Label lblNumAfiliado;
        private Label lblOS;
        private TableLayoutPanel botonesTLP;
        private Button btnVerHistoria;
        private Button btnCerrar;
    }
}
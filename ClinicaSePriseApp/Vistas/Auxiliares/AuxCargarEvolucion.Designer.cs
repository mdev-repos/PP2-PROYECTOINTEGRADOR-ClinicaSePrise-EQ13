namespace ClinicaSePriseApp.Vistas.Auxiliares
{
    partial class AuxCargarEvolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuxCargarEvolucion));
            mainTLP = new TableLayoutPanel();
            lblHistoria = new Label();
            lblFechaNombre = new Label();
            botonesTLP = new TableLayoutPanel();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            txtboxObservaciones = new TextBox();
            mainTLP.SuspendLayout();
            botonesTLP.SuspendLayout();
            SuspendLayout();
            // 
            // mainTLP
            // 
            mainTLP.ColumnCount = 3;
            mainTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            mainTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            mainTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            mainTLP.Controls.Add(lblHistoria, 1, 0);
            mainTLP.Controls.Add(lblFechaNombre, 1, 1);
            mainTLP.Controls.Add(botonesTLP, 1, 4);
            mainTLP.Controls.Add(txtboxObservaciones, 1, 2);
            mainTLP.Dock = DockStyle.Fill;
            mainTLP.Location = new Point(0, 0);
            mainTLP.Margin = new Padding(0);
            mainTLP.Name = "mainTLP";
            mainTLP.RowCount = 6;
            mainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 13.06664F));
            mainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 13.06664F));
            mainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50.25631F));
            mainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 6.030757F));
            mainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 11.5489F));
            mainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 6.030757F));
            mainTLP.Size = new Size(700, 500);
            mainTLP.TabIndex = 2;
            // 
            // lblHistoria
            // 
            lblHistoria.AutoSize = true;
            lblHistoria.Dock = DockStyle.Fill;
            lblHistoria.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHistoria.Location = new Point(70, 0);
            lblHistoria.Margin = new Padding(0);
            lblHistoria.Name = "lblHistoria";
            lblHistoria.Size = new Size(560, 65);
            lblHistoria.TabIndex = 1;
            lblHistoria.Text = "Observaciones Médicas";
            lblHistoria.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFechaNombre
            // 
            lblFechaNombre.AllowDrop = true;
            lblFechaNombre.AutoSize = true;
            lblFechaNombre.Dock = DockStyle.Fill;
            lblFechaNombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaNombre.Location = new Point(70, 65);
            lblFechaNombre.Margin = new Padding(0);
            lblFechaNombre.Name = "lblFechaNombre";
            lblFechaNombre.Size = new Size(560, 65);
            lblFechaNombre.TabIndex = 2;
            lblFechaNombre.Text = "FECHA | PACIENTE ";
            lblFechaNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // botonesTLP
            // 
            botonesTLP.ColumnCount = 5;
            botonesTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.3133135F));
            botonesTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.03003F));
            botonesTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.3133135F));
            botonesTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.03003F));
            botonesTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.3133135F));
            botonesTLP.Controls.Add(btnCancelar, 3, 0);
            botonesTLP.Controls.Add(btnConfirmar, 1, 0);
            botonesTLP.Dock = DockStyle.Fill;
            botonesTLP.Location = new Point(70, 411);
            botonesTLP.Margin = new Padding(0);
            botonesTLP.Name = "botonesTLP";
            botonesTLP.RowCount = 1;
            botonesTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            botonesTLP.Size = new Size(560, 57);
            botonesTLP.TabIndex = 9;
            // 
            // btnCancelar
            // 
            btnCancelar.Dock = DockStyle.Fill;
            btnCancelar.Location = new Point(319, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(162, 51);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Dock = DockStyle.Fill;
            btnConfirmar.Location = new Point(77, 3);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(162, 51);
            btnConfirmar.TabIndex = 2;
            btnConfirmar.Text = "CONFIRMAR";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtboxObservaciones
            // 
            txtboxObservaciones.Dock = DockStyle.Fill;
            txtboxObservaciones.Location = new Point(71, 131);
            txtboxObservaciones.Margin = new Padding(1);
            txtboxObservaciones.Multiline = true;
            txtboxObservaciones.Name = "txtboxObservaciones";
            txtboxObservaciones.Size = new Size(558, 249);
            txtboxObservaciones.TabIndex = 10;
            // 
            // AuxCargarEvolucion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 500);
            Controls.Add(mainTLP);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(700, 500);
            MinimumSize = new Size(700, 500);
            Name = "AuxCargarEvolucion";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Clinica SePrise | Cargar Evolucion";
            mainTLP.ResumeLayout(false);
            mainTLP.PerformLayout();
            botonesTLP.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTLP;
        private Label lblHistoria;
        private Label lblFechaNombre;
        private TableLayoutPanel botonesTLP;
        private Button btnCancelar;
        private Button btnConfirmar;
        private TextBox txtboxObservaciones;
    }
}
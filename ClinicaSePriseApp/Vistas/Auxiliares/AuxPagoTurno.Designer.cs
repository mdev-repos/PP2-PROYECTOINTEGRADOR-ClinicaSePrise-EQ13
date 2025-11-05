namespace ClinicaSePriseApp.Vistas.Auxiliares
{
    partial class AuxPagoTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuxPagoTurno));
            containerTLP = new TableLayoutPanel();
            lblTitulo = new Label();
            lblSeleccion = new Label();
            cboxTLP = new TableLayoutPanel();
            cboxMedioPago = new ComboBox();
            buttonsTLP = new TableLayoutPanel();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            btnImprimir = new Button();
            containerTLP.SuspendLayout();
            cboxTLP.SuspendLayout();
            buttonsTLP.SuspendLayout();
            SuspendLayout();
            // 
            // containerTLP
            // 
            containerTLP.ColumnCount = 1;
            containerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            containerTLP.Controls.Add(lblTitulo, 0, 1);
            containerTLP.Controls.Add(lblSeleccion, 0, 3);
            containerTLP.Controls.Add(cboxTLP, 0, 5);
            containerTLP.Controls.Add(buttonsTLP, 0, 7);
            containerTLP.Dock = DockStyle.Fill;
            containerTLP.Location = new Point(0, 0);
            containerTLP.Margin = new Padding(0);
            containerTLP.Name = "containerTLP";
            containerTLP.RowCount = 9;
            containerTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            containerTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            containerTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 11F));
            containerTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            containerTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            containerTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            containerTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 21F));
            containerTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            containerTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            containerTLP.Size = new Size(600, 400);
            containerTLP.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(0, 16);
            lblTitulo.Margin = new Padding(0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(600, 48);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "PROCESAR PAGO";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSeleccion
            // 
            lblSeleccion.AutoSize = true;
            lblSeleccion.Dock = DockStyle.Fill;
            lblSeleccion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeleccion.Location = new Point(0, 108);
            lblSeleccion.Margin = new Padding(0);
            lblSeleccion.Name = "lblSeleccion";
            lblSeleccion.Size = new Size(600, 48);
            lblSeleccion.TabIndex = 1;
            lblSeleccion.Text = "SELECCIONAR MEDIO DE PAGO";
            lblSeleccion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cboxTLP
            // 
            cboxTLP.ColumnCount = 3;
            cboxTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            cboxTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            cboxTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            cboxTLP.Controls.Add(cboxMedioPago, 1, 0);
            cboxTLP.Dock = DockStyle.Fill;
            cboxTLP.Location = new Point(0, 184);
            cboxTLP.Margin = new Padding(0);
            cboxTLP.Name = "cboxTLP";
            cboxTLP.RowCount = 1;
            cboxTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            cboxTLP.Size = new Size(600, 48);
            cboxTLP.TabIndex = 2;
            // 
            // cboxMedioPago
            // 
            cboxMedioPago.Dock = DockStyle.Fill;
            cboxMedioPago.FormattingEnabled = true;
            cboxMedioPago.Location = new Point(200, 0);
            cboxMedioPago.Margin = new Padding(0);
            cboxMedioPago.Name = "cboxMedioPago";
            cboxMedioPago.Size = new Size(200, 28);
            cboxMedioPago.TabIndex = 3;
            // 
            // buttonsTLP
            // 
            buttonsTLP.ColumnCount = 7;
            buttonsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            buttonsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            buttonsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            buttonsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            buttonsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13F));
            buttonsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            buttonsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            buttonsTLP.Controls.Add(btnCancelar, 1, 0);
            buttonsTLP.Controls.Add(btnConfirmar, 3, 0);
            buttonsTLP.Controls.Add(btnImprimir, 5, 0);
            buttonsTLP.Dock = DockStyle.Fill;
            buttonsTLP.Location = new Point(0, 316);
            buttonsTLP.Margin = new Padding(0);
            buttonsTLP.Name = "buttonsTLP";
            buttonsTLP.RowCount = 1;
            buttonsTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            buttonsTLP.Size = new Size(600, 60);
            buttonsTLP.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.Dock = DockStyle.Fill;
            btnCancelar.Location = new Point(27, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(144, 54);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Dock = DockStyle.Fill;
            btnConfirmar.Location = new Point(201, 3);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(144, 54);
            btnConfirmar.TabIndex = 1;
            btnConfirmar.Text = "CONFIRMAR";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Dock = DockStyle.Fill;
            btnImprimir.Location = new Point(429, 3);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(144, 54);
            btnImprimir.TabIndex = 2;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // PagoTurno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 400);
            Controls.Add(containerTLP);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(600, 400);
            MinimumSize = new Size(600, 400);
            Name = "PagoTurno";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Pago de Turno";
            containerTLP.ResumeLayout(false);
            containerTLP.PerformLayout();
            cboxTLP.ResumeLayout(false);
            buttonsTLP.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel containerTLP;
        private Label lblTitulo;
        private Label lblSeleccion;
        private TableLayoutPanel cboxTLP;
        private ComboBox cboxMedioPago;
        private TableLayoutPanel buttonsTLP;
        private Button btnCancelar;
        private Button btnConfirmar;
        private Button btnImprimir;
    }
}
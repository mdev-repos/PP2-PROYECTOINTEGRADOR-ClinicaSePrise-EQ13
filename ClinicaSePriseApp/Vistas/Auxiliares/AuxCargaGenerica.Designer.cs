namespace ClinicaSePriseApp.Vistas.Auxiliares
{
    partial class AuxCargaGenerica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuxCargaGenerica));
            mainTLP = new TableLayoutPanel();
            lblTitulo = new Label();
            lblNombre = new Label();
            botonesTLP = new TableLayoutPanel();
            btnCerrar = new Button();
            containerPanel = new Panel();
            dataTLP = new TableLayoutPanel();
            mainTLP.SuspendLayout();
            botonesTLP.SuspendLayout();
            containerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainTLP
            // 
            mainTLP.ColumnCount = 3;
            mainTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            mainTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            mainTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            mainTLP.Controls.Add(lblTitulo, 1, 0);
            mainTLP.Controls.Add(lblNombre, 1, 1);
            mainTLP.Controls.Add(botonesTLP, 1, 4);
            mainTLP.Controls.Add(containerPanel, 1, 2);
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
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(70, 0);
            lblTitulo.Margin = new Padding(0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(560, 65);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "VAR TITULO";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            lblNombre.AllowDrop = true;
            lblNombre.AutoSize = true;
            lblNombre.Dock = DockStyle.Fill;
            lblNombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(70, 65);
            lblNombre.Margin = new Padding(0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(560, 65);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "VAR NOMBRE";
            lblNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // botonesTLP
            // 
            botonesTLP.ColumnCount = 2;
            botonesTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            botonesTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            botonesTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            botonesTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            botonesTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            botonesTLP.Controls.Add(btnCerrar, 1, 0);
            botonesTLP.Dock = DockStyle.Fill;
            botonesTLP.Location = new Point(70, 411);
            botonesTLP.Margin = new Padding(0);
            botonesTLP.Name = "botonesTLP";
            botonesTLP.RowCount = 1;
            botonesTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            botonesTLP.Size = new Size(560, 57);
            botonesTLP.TabIndex = 9;
            // 
            // btnCerrar
            // 
            btnCerrar.Dock = DockStyle.Fill;
            btnCerrar.Location = new Point(395, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(162, 51);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "CERRAR";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click_1;
            // 
            // containerPanel
            // 
            containerPanel.AutoScroll = true;
            containerPanel.Controls.Add(dataTLP);
            containerPanel.Dock = DockStyle.Fill;
            containerPanel.Location = new Point(70, 130);
            containerPanel.Margin = new Padding(0);
            containerPanel.Name = "containerPanel";
            containerPanel.Size = new Size(560, 251);
            containerPanel.TabIndex = 10;
            // 
            // dataTLP
            // 
            dataTLP.AutoSize = true;
            dataTLP.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            dataTLP.ColumnCount = 4;
            dataTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            dataTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            dataTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            dataTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            dataTLP.Dock = DockStyle.Top;
            dataTLP.Location = new Point(0, 0);
            dataTLP.Margin = new Padding(0);
            dataTLP.Name = "dataTLP";
            dataTLP.RowCount = 1;
            dataTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            dataTLP.Size = new Size(560, 0);
            dataTLP.TabIndex = 0;
            // 
            // AuxCargaGenerica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 500);
            Controls.Add(mainTLP);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(700, 500);
            MinimumSize = new Size(700, 500);
            Name = "AuxCargaGenerica";
            StartPosition = FormStartPosition.CenterParent;
            Text = "VAR NOMBRE PANTALLA";
            mainTLP.ResumeLayout(false);
            mainTLP.PerformLayout();
            botonesTLP.ResumeLayout(false);
            containerPanel.ResumeLayout(false);
            containerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTLP;
        private Label lblTitulo;
        private Label lblNombre;
        private TableLayoutPanel botonesTLP;
        private Button btnCerrar;
        private Panel containerPanel;
        private TableLayoutPanel dataTLP;
    }
}
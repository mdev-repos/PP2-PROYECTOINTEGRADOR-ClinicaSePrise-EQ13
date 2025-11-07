namespace ClinicaSePriseApp.Vistas.Auxiliares
{
    partial class AuxHistoriaClinica
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
            historiaContainerPanel = new Panel();
            entradasTLP = new TableLayoutPanel();
            botonesTLP = new TableLayoutPanel();
            btnCerrar = new Button();
            lblNombre = new Label();
            lblHistoria = new Label();
            mainTLP = new TableLayoutPanel();
            historiaContainerPanel.SuspendLayout();
            botonesTLP.SuspendLayout();
            mainTLP.SuspendLayout();
            SuspendLayout();
            // 
            // historiaContainerPanel
            // 
            historiaContainerPanel.AutoScroll = true;
            historiaContainerPanel.Controls.Add(entradasTLP);
            historiaContainerPanel.Dock = DockStyle.Fill;
            historiaContainerPanel.Location = new Point(70, 130);
            historiaContainerPanel.Margin = new Padding(0);
            historiaContainerPanel.Name = "historiaContainerPanel";
            historiaContainerPanel.Size = new Size(560, 251);
            historiaContainerPanel.TabIndex = 10;
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
            entradasTLP.Size = new Size(560, 0);
            entradasTLP.TabIndex = 0;
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
            btnCerrar.Click += btnCerrar_Click;
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
            lblNombre.Text = "Paciente: ";
            lblNombre.TextAlign = ContentAlignment.MiddleLeft;
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
            lblHistoria.Text = "Historia Clínica";
            lblHistoria.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainTLP
            // 
            mainTLP.ColumnCount = 3;
            mainTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            mainTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            mainTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            mainTLP.Controls.Add(lblHistoria, 1, 0);
            mainTLP.Controls.Add(lblNombre, 1, 1);
            mainTLP.Controls.Add(botonesTLP, 1, 4);
            mainTLP.Controls.Add(historiaContainerPanel, 1, 2);
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
            mainTLP.TabIndex = 1;
            // 
            // AuxHistoriaClinica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 500);
            Controls.Add(mainTLP);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(700, 500);
            MinimumSize = new Size(700, 500);
            Name = "AuxHistoriaClinica";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Consulta Historia Clinica";
            historiaContainerPanel.ResumeLayout(false);
            historiaContainerPanel.PerformLayout();
            botonesTLP.ResumeLayout(false);
            mainTLP.ResumeLayout(false);
            mainTLP.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel historiaContainerPanel;
        private TableLayoutPanel entradasTLP;
        private TableLayoutPanel botonesTLP;
        private Button btnCerrar;
        private Label lblNombre;
        private Label lblHistoria;
        private TableLayoutPanel mainTLP;
    }
}
namespace ClinicaSePriseApp.Vistas.Auxiliares
{
    partial class TarjetaTurno
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            mainTLP = new TableLayoutPanel();
            lblPaciente = new Label();
            lblEstado = new Label();
            lblHora = new Label();
            lblID = new Label();
            mainTLP.SuspendLayout();
            SuspendLayout();
            // 
            // mainTLP
            // 
            mainTLP.ColumnCount = 3;
            mainTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            mainTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            mainTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            mainTLP.Controls.Add(lblEstado, 1, 5);
            mainTLP.Controls.Add(lblPaciente, 1, 3);
            mainTLP.Controls.Add(lblHora, 1, 1);
            mainTLP.Controls.Add(lblID, 0, 0);
            mainTLP.Dock = DockStyle.Fill;
            mainTLP.Location = new Point(0, 0);
            mainTLP.Margin = new Padding(0);
            mainTLP.Name = "mainTLP";
            mainTLP.RowCount = 7;
            mainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 6.39386225F));
            mainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 20.5882359F));
            mainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 3.8363173F));
            mainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 38.36317F));
            mainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 3.8363173F));
            mainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 20.5882359F));
            mainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 6.39386225F));
            mainTLP.Size = new Size(320, 160);
            mainTLP.TabIndex = 0;
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Dock = DockStyle.Fill;
            lblPaciente.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPaciente.ImageAlign = ContentAlignment.MiddleRight;
            lblPaciente.Location = new Point(19, 48);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(282, 61);
            lblPaciente.TabIndex = 9;
            lblPaciente.Text = "Paciente";
            lblPaciente.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Dock = DockStyle.Fill;
            lblEstado.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(19, 115);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(282, 32);
            lblEstado.TabIndex = 10;
            lblEstado.Text = "Estado";
            lblEstado.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Dock = DockStyle.Fill;
            lblHora.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHora.Location = new Point(19, 10);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(282, 32);
            lblHora.TabIndex = 8;
            lblHora.Text = "Hora";
            lblHora.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Dock = DockStyle.Fill;
            lblID.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.Location = new Point(0, 0);
            lblID.Margin = new Padding(0);
            lblID.Name = "lblID";
            lblID.Size = new Size(16, 10);
            lblID.TabIndex = 11;
            lblID.Text = "Hora";
            lblID.TextAlign = ContentAlignment.MiddleLeft;
            lblID.Visible = false;
            // 
            // TarjetaTurno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mainTLP);
            Margin = new Padding(0);
            Name = "TarjetaTurno";
            Size = new Size(320, 160);
            Load += TarjetaTurno_Load;
            mainTLP.ResumeLayout(false);
            mainTLP.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTLP;
        private Label lblEstado;
        private Label lblPaciente;
        private Label lblHora;
        private Label lblID;
    }
}

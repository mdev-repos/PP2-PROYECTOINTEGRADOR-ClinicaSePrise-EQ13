namespace ClinicaSePriseApp.Vistas
{
    partial class AdmGestionInsumos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmGestionInsumos));
            mainTLP = new TableLayoutPanel();
            menuTLP = new TableLayoutPanel();
            picLogo = new PictureBox();
            btnVolver = new Button();
            btnAñadirInsumo = new Button();
            btnActualizarInsumo = new Button();
            contentTLP = new TableLayoutPanel();
            contentLbl = new Label();
            dataGridTLP = new TableLayoutPanel();
            dgvInsumos = new DataGridView();
            btnVerSolicitudes = new Button();
            mainTLP.SuspendLayout();
            menuTLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            contentTLP.SuspendLayout();
            dataGridTLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInsumos).BeginInit();
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
            mainTLP.Name = "mainTLP";
            mainTLP.RowCount = 1;
            mainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTLP.Size = new Size(1902, 1033);
            mainTLP.TabIndex = 1;
            // 
            // menuTLP
            // 
            menuTLP.BackColor = SystemColors.GradientInactiveCaption;
            menuTLP.ColumnCount = 1;
            menuTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            menuTLP.Controls.Add(picLogo, 0, 0);
            menuTLP.Controls.Add(btnAñadirInsumo, 0, 2);
            menuTLP.Controls.Add(btnActualizarInsumo, 0, 4);
            menuTLP.Controls.Add(btnVolver, 0, 8);
            menuTLP.Controls.Add(btnVerSolicitudes, 0, 6);
            menuTLP.Dock = DockStyle.Fill;
            menuTLP.Location = new Point(1426, 0);
            menuTLP.Margin = new Padding(0);
            menuTLP.Name = "menuTLP";
            menuTLP.RowCount = 10;
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 30.6122456F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 6.122449F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 8.163265F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 6.122449F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 8.163265F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 6.122449F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 8.163265F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 10.2040815F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 8.163265F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 8.163265F));
            menuTLP.Size = new Size(476, 1033);
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
            picLogo.Size = new Size(476, 316);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Pink;
            btnVolver.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(0, 862);
            btnVolver.Margin = new Padding(0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(476, 82);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "VOLVER AL DASHBOARD";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnAñadirInsumo
            // 
            btnAñadirInsumo.BackColor = Color.CornflowerBlue;
            btnAñadirInsumo.Dock = DockStyle.Fill;
            btnAñadirInsumo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnAñadirInsumo.ForeColor = Color.White;
            btnAñadirInsumo.Location = new Point(0, 379);
            btnAñadirInsumo.Margin = new Padding(0);
            btnAñadirInsumo.Name = "btnAñadirInsumo";
            btnAñadirInsumo.Size = new Size(476, 84);
            btnAñadirInsumo.TabIndex = 1;
            btnAñadirInsumo.Text = "AÑADIR INSUMO";
            btnAñadirInsumo.UseVisualStyleBackColor = false;
            // 
            // btnActualizarInsumo
            // 
            btnActualizarInsumo.BackColor = Color.CornflowerBlue;
            btnActualizarInsumo.Dock = DockStyle.Fill;
            btnActualizarInsumo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnActualizarInsumo.ForeColor = Color.White;
            btnActualizarInsumo.Location = new Point(0, 526);
            btnActualizarInsumo.Margin = new Padding(0);
            btnActualizarInsumo.Name = "btnActualizarInsumo";
            btnActualizarInsumo.Size = new Size(476, 84);
            btnActualizarInsumo.TabIndex = 2;
            btnActualizarInsumo.Text = "ACTUALIZAR INSUMO";
            btnActualizarInsumo.UseVisualStyleBackColor = false;
            // 
            // contentTLP
            // 
            contentTLP.ColumnCount = 1;
            contentTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            contentTLP.Controls.Add(contentLbl, 0, 1);
            contentTLP.Controls.Add(dataGridTLP, 0, 3);
            contentTLP.Dock = DockStyle.Fill;
            contentTLP.Location = new Point(0, 0);
            contentTLP.Margin = new Padding(0);
            contentTLP.Name = "contentTLP";
            contentTLP.RowCount = 4;
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            contentTLP.Size = new Size(1426, 1033);
            contentTLP.TabIndex = 1;
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
            contentLbl.Text = "      GESTION DE INSUMOS";
            contentLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridTLP
            // 
            dataGridTLP.ColumnCount = 3;
            dataGridTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            dataGridTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            dataGridTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            dataGridTLP.Controls.Add(dgvInsumos, 1, 0);
            dataGridTLP.Dock = DockStyle.Fill;
            dataGridTLP.Location = new Point(0, 205);
            dataGridTLP.Margin = new Padding(0);
            dataGridTLP.Name = "dataGridTLP";
            dataGridTLP.RowCount = 1;
            dataGridTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            dataGridTLP.Size = new Size(1426, 828);
            dataGridTLP.TabIndex = 2;
            // 
            // dgvInsumos
            // 
            dgvInsumos.AllowUserToResizeColumns = false;
            dgvInsumos.AllowUserToResizeRows = false;
            dgvInsumos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInsumos.Dock = DockStyle.Fill;
            dgvInsumos.Location = new Point(71, 0);
            dgvInsumos.Margin = new Padding(0, 0, 0, 51);
            dgvInsumos.Name = "dgvInsumos";
            dgvInsumos.RowHeadersWidth = 51;
            dgvInsumos.Size = new Size(1283, 777);
            dgvInsumos.TabIndex = 7;
            // 
            // btnVerSolicitudes
            // 
            btnVerSolicitudes.BackColor = Color.CornflowerBlue;
            btnVerSolicitudes.Dock = DockStyle.Fill;
            btnVerSolicitudes.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnVerSolicitudes.ForeColor = Color.White;
            btnVerSolicitudes.Location = new Point(0, 673);
            btnVerSolicitudes.Margin = new Padding(0);
            btnVerSolicitudes.Name = "btnVerSolicitudes";
            btnVerSolicitudes.Size = new Size(476, 84);
            btnVerSolicitudes.TabIndex = 9;
            btnVerSolicitudes.Text = "SOLICITUDES DE INSUMOS";
            btnVerSolicitudes.UseVisualStyleBackColor = false;
            btnVerSolicitudes.Click += btnVerSolicitudes_Click;
            // 
            // AdmGestionInsumos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(mainTLP);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1024, 766);
            Name = "AdmGestionInsumos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clinica SePrise  ||  Gestion de Insumos";
            WindowState = FormWindowState.Maximized;
            Load += AdmGestionInsumos_Load;
            mainTLP.ResumeLayout(false);
            menuTLP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            contentTLP.ResumeLayout(false);
            contentTLP.PerformLayout();
            dataGridTLP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInsumos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTLP;
        private TableLayoutPanel menuTLP;
        private PictureBox picLogo;
        private Button btnVolver;
        private Button btnAñadirInsumo;
        private Button btnActualizarInsumo;
        private TableLayoutPanel contentTLP;
        private Label contentLbl;
        private TableLayoutPanel dataGridTLP;
        private DataGridView dgvInsumos;
        private Button btnVerSolicitudes;
    }
}
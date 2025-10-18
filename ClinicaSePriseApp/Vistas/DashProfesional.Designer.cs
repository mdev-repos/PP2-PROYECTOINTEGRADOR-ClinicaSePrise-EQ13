namespace ClinicaSePriseApp.Vistas
{
    partial class DashProfesional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashProfesional));
            mainTLP = new TableLayoutPanel();
            picImg = new PictureBox();
            menuTLP = new TableLayoutPanel();
            picLogo = new PictureBox();
            btnLogout = new Button();
            btnAgenda = new Button();
            btnInsumos = new Button();
            btnLiquidaciones = new Button();
            mainTLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImg).BeginInit();
            menuTLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // mainTLP
            // 
            mainTLP.ColumnCount = 2;
            mainTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            mainTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            mainTLP.Controls.Add(picImg, 0, 0);
            mainTLP.Controls.Add(menuTLP, 1, 0);
            mainTLP.Dock = DockStyle.Fill;
            mainTLP.Location = new Point(0, 0);
            mainTLP.Name = "mainTLP";
            mainTLP.RowCount = 1;
            mainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTLP.Size = new Size(1924, 1055);
            mainTLP.TabIndex = 0;
            // 
            // picImg
            // 
            picImg.Dock = DockStyle.Fill;
            picImg.Image = Properties.Resources.img_profesional;
            picImg.Location = new Point(3, 3);
            picImg.Name = "picImg";
            picImg.Size = new Size(1437, 1049);
            picImg.SizeMode = PictureBoxSizeMode.StretchImage;
            picImg.TabIndex = 0;
            picImg.TabStop = false;
            // 
            // menuTLP
            // 
            menuTLP.ColumnCount = 1;
            menuTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            menuTLP.Controls.Add(picLogo, 0, 0);
            menuTLP.Controls.Add(btnLogout, 0, 6);
            menuTLP.Controls.Add(btnAgenda, 0, 1);
            menuTLP.Controls.Add(btnInsumos, 0, 2);
            menuTLP.Controls.Add(btnLiquidaciones, 0, 4);
            menuTLP.Dock = DockStyle.Fill;
            menuTLP.Location = new Point(1446, 3);
            menuTLP.Name = "menuTLP";
            menuTLP.RowCount = 7;
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 24F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 9.5F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 9.5F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 9.5F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 9.5F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 9.5F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 9.5F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 9.5F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 9.5F));
            menuTLP.Size = new Size(475, 1049);
            menuTLP.TabIndex = 1;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = Properties.Resources.SePrise_logoApp;
            picLogo.Location = new Point(3, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(469, 304);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Fill;
            btnLogout.Location = new Point(3, 928);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(469, 118);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "LOG OUT";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnAgenda
            // 
            btnAgenda.Dock = DockStyle.Fill;
            btnAgenda.Location = new Point(3, 313);
            btnAgenda.Name = "btnAgenda";
            btnAgenda.Size = new Size(469, 117);
            btnAgenda.TabIndex = 6;
            btnAgenda.Text = "AGENDA DE TURNOS";
            btnAgenda.UseVisualStyleBackColor = true;
            // 
            // btnInsumos
            // 
            btnInsumos.Dock = DockStyle.Fill;
            btnInsumos.Location = new Point(3, 436);
            btnInsumos.Name = "btnInsumos";
            btnInsumos.Size = new Size(469, 117);
            btnInsumos.TabIndex = 7;
            btnInsumos.Text = "SOLICITAR INSUMOS";
            btnInsumos.UseVisualStyleBackColor = true;
            // 
            // btnLiquidaciones
            // 
            btnLiquidaciones.Dock = DockStyle.Fill;
            btnLiquidaciones.Location = new Point(3, 682);
            btnLiquidaciones.Name = "btnLiquidaciones";
            btnLiquidaciones.Size = new Size(469, 117);
            btnLiquidaciones.TabIndex = 8;
            btnLiquidaciones.Text = "CONSULTAR LIQUIDACIONES";
            btnLiquidaciones.UseVisualStyleBackColor = true;
            // 
            // DashProfesional
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(mainTLP);
            Font = new Font("LEMON MILK", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(1527, 912);
            Name = "DashProfesional";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clinica SePrise  ||  Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += DashProfesional_Load;
            mainTLP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picImg).EndInit();
            menuTLP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTLP;
        private PictureBox picImg;
        private TableLayoutPanel menuTLP;
        private PictureBox picLogo;
        private Button btnLogout;
        private Button btnAgenda;
        private Button btnInsumos;
        private Button btnLiquidaciones;
    }
}
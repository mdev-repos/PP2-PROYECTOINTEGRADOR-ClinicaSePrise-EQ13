namespace ClinicaSePriseApp.Vistas
{
    partial class ProfADAtencionMedica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfADAtencionMedica));
            mainTLP = new TableLayoutPanel();
            menuTLP = new TableLayoutPanel();
            picLogo = new PictureBox();
            btnVolver = new Button();
            btnAtender = new Button();
            contentTLP = new TableLayoutPanel();
            contentLbl = new Label();
            cardContainerPanel = new Panel();
            cardsTLP = new TableLayoutPanel();
            mainTLP.SuspendLayout();
            menuTLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            contentTLP.SuspendLayout();
            cardContainerPanel.SuspendLayout();
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
            mainTLP.Size = new Size(1006, 721);
            mainTLP.TabIndex = 4;
            // 
            // menuTLP
            // 
            menuTLP.BackColor = SystemColors.GradientInactiveCaption;
            menuTLP.ColumnCount = 1;
            menuTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            menuTLP.Controls.Add(picLogo, 0, 0);
            menuTLP.Controls.Add(btnVolver, 0, 8);
            menuTLP.Controls.Add(btnAtender, 0, 2);
            menuTLP.Dock = DockStyle.Fill;
            menuTLP.Location = new Point(754, 0);
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
            menuTLP.Size = new Size(252, 721);
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
            picLogo.Size = new Size(252, 216);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.MediumVioletRed;
            btnVolver.Dock = DockStyle.Fill;
            btnVolver.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(0, 602);
            btnVolver.Margin = new Padding(0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(252, 57);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "REGRESAR A LA AGENDA";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnAtender
            // 
            btnAtender.BackColor = Color.CornflowerBlue;
            btnAtender.Dock = DockStyle.Fill;
            btnAtender.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtender.ForeColor = Color.White;
            btnAtender.Location = new Point(0, 259);
            btnAtender.Margin = new Padding(0);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(252, 57);
            btnAtender.TabIndex = 9;
            btnAtender.Text = "SIN DEFINIR";
            btnAtender.UseVisualStyleBackColor = false;
            // 
            // contentTLP
            // 
            contentTLP.ColumnCount = 1;
            contentTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            contentTLP.Controls.Add(contentLbl, 0, 1);
            contentTLP.Controls.Add(cardContainerPanel, 0, 3);
            contentTLP.Dock = DockStyle.Fill;
            contentTLP.Location = new Point(0, 0);
            contentTLP.Margin = new Padding(0);
            contentTLP.Name = "contentTLP";
            contentTLP.RowCount = 5;
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 77F));
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            contentTLP.Size = new Size(754, 721);
            contentTLP.TabIndex = 1;
            // 
            // contentLbl
            // 
            contentLbl.AutoSize = true;
            contentLbl.BackColor = SystemColors.GradientInactiveCaption;
            contentLbl.Dock = DockStyle.Fill;
            contentLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contentLbl.Location = new Point(0, 36);
            contentLbl.Margin = new Padding(0);
            contentLbl.Name = "contentLbl";
            contentLbl.Size = new Size(754, 72);
            contentLbl.TabIndex = 0;
            contentLbl.Text = "    SIN DEFINIR";
            contentLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cardContainerPanel
            // 
            cardContainerPanel.AutoScroll = true;
            cardContainerPanel.Controls.Add(cardsTLP);
            cardContainerPanel.Dock = DockStyle.Fill;
            cardContainerPanel.Location = new Point(0, 136);
            cardContainerPanel.Margin = new Padding(0);
            cardContainerPanel.Name = "cardContainerPanel";
            cardContainerPanel.Size = new Size(754, 555);
            cardContainerPanel.TabIndex = 1;
            // 
            // cardsTLP
            // 
            cardsTLP.AutoSize = true;
            cardsTLP.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cardsTLP.ColumnCount = 3;
            cardsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            cardsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            cardsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            cardsTLP.Dock = DockStyle.Top;
            cardsTLP.Location = new Point(0, 0);
            cardsTLP.Margin = new Padding(0);
            cardsTLP.Name = "cardsTLP";
            cardsTLP.RowCount = 1;
            cardsTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            cardsTLP.Size = new Size(754, 0);
            cardsTLP.TabIndex = 0;
            // 
            // ProfADAtencionMedica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(mainTLP);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProfADAtencionMedica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clinica SePrise  ||  Atención Médica";
            WindowState = FormWindowState.Maximized;
            mainTLP.ResumeLayout(false);
            menuTLP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            contentTLP.ResumeLayout(false);
            contentTLP.PerformLayout();
            cardContainerPanel.ResumeLayout(false);
            cardContainerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTLP;
        private TableLayoutPanel menuTLP;
        private PictureBox picLogo;
        private Button btnVolver;
        private Button btnAtender;
        private TableLayoutPanel contentTLP;
        private Label contentLbl;
        private Panel cardContainerPanel;
        private TableLayoutPanel cardsTLP;
    }
}
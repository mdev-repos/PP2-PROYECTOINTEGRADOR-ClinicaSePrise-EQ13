namespace ClinicaSePriseApp.Vistas
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            mainPanel = new Panel();
            leftPanel = new Panel();
            rightPanel = new Panel();
            txtboxTLP = new TableLayoutPanel();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            rgBottomPanel = new Panel();
            btnLogin = new Button();
            rgTopPanel = new Panel();
            picLogo = new PictureBox();
            mainPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            txtboxTLP.SuspendLayout();
            rgBottomPanel.SuspendLayout();
            rgTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(leftPanel);
            mainPanel.Controls.Add(rightPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1902, 1033);
            mainPanel.TabIndex = 0;
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.IndianRed;
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(1120, 1033);
            leftPanel.TabIndex = 2;
            // 
            // rightPanel
            // 
            rightPanel.AutoScroll = true;
            rightPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            rightPanel.BackColor = Color.FromArgb(224, 224, 224);
            rightPanel.Controls.Add(txtboxTLP);
            rightPanel.Controls.Add(rgBottomPanel);
            rightPanel.Controls.Add(rgTopPanel);
            rightPanel.Dock = DockStyle.Right;
            rightPanel.Location = new Point(1120, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(782, 1033);
            rightPanel.TabIndex = 1;
            // 
            // txtboxTLP
            // 
            txtboxTLP.ColumnCount = 3;
            txtboxTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            txtboxTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            txtboxTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            txtboxTLP.Controls.Add(txtUsuario, 1, 1);
            txtboxTLP.Controls.Add(txtPassword, 1, 3);
            txtboxTLP.Dock = DockStyle.Fill;
            txtboxTLP.Location = new Point(0, 376);
            txtboxTLP.Margin = new Padding(0);
            txtboxTLP.Name = "txtboxTLP";
            txtboxTLP.RowCount = 5;
            txtboxTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 32.5F));
            txtboxTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            txtboxTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            txtboxTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            txtboxTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 32.5F));
            txtboxTLP.Size = new Size(782, 498);
            txtboxTLP.TabIndex = 2;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Dock = DockStyle.Top;
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(200, 166);
            txtUsuario.Margin = new Padding(5);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(381, 27);
            txtUsuario.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Dock = DockStyle.Bottom;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(200, 302);
            txtPassword.Margin = new Padding(5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.Size = new Size(381, 27);
            txtPassword.TabIndex = 3;
            // 
            // rgBottomPanel
            // 
            rgBottomPanel.Controls.Add(btnLogin);
            rgBottomPanel.Dock = DockStyle.Bottom;
            rgBottomPanel.Location = new Point(0, 874);
            rgBottomPanel.Name = "rgBottomPanel";
            rgBottomPanel.Size = new Size(782, 159);
            rgBottomPanel.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.CornflowerBlue;
            btnLogin.Font = new Font("LEMON MILK", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Transparent;
            btnLogin.Location = new Point(309, 58);
            btnLogin.Name = "btnLogin";
            btnLogin.Padding = new Padding(8);
            btnLogin.Size = new Size(167, 56);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // rgTopPanel
            // 
            rgTopPanel.AutoSize = true;
            rgTopPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            rgTopPanel.Controls.Add(picLogo);
            rgTopPanel.Dock = DockStyle.Top;
            rgTopPanel.Location = new Point(0, 0);
            rgTopPanel.Name = "rgTopPanel";
            rgTopPanel.Size = new Size(782, 376);
            rgTopPanel.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Anchor = AnchorStyles.None;
            picLogo.BackgroundImageLayout = ImageLayout.None;
            picLogo.Image = Properties.Resources.SePrise_logoApp;
            picLogo.Location = new Point(0, -43);
            picLogo.Margin = new Padding(0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(782, 419);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(mainPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1024, 768);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clinica SePrise  ||  Login";
            WindowState = FormWindowState.Maximized;
            Load += Login_Load;
            mainPanel.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            rightPanel.PerformLayout();
            txtboxTLP.ResumeLayout(false);
            txtboxTLP.PerformLayout();
            rgBottomPanel.ResumeLayout(false);
            rgTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel leftPanel;
        private Panel rightPanel;
        private Panel rgBottomPanel;
        private Panel rgTopPanel;
        private PictureBox picLogo;
        private Button btnLogin;
        private TableLayoutPanel txtboxTLP;
        private TextBox txtPassword;
        private TextBox txtUsuario;
    }
}
namespace ClinicaSePriseApp.Vistas
{
    partial class AdmGestionTurnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmGestionTurnos));
            mainTLP = new TableLayoutPanel();
            menuTLP = new TableLayoutPanel();
            picLogo = new PictureBox();
            btnVolver = new Button();
            btnTurno = new Button();
            btnAgenda = new Button();
            contentTLP = new TableLayoutPanel();
            contentLbl = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            fechaCbx = new ComboBox();
            especialidadCbx = new ComboBox();
            profesionalCbx = new ComboBox();
            estadoCbx = new ComboBox();
            dataGridTLP = new TableLayoutPanel();
            turnosDgv = new DataGridView();
            mainTLP.SuspendLayout();
            menuTLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            contentTLP.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            dataGridTLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)turnosDgv).BeginInit();
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
            mainTLP.Size = new Size(1924, 1055);
            mainTLP.TabIndex = 0;
            // 
            // menuTLP
            // 
            menuTLP.BackColor = SystemColors.GradientInactiveCaption;
            menuTLP.ColumnCount = 1;
            menuTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            menuTLP.Controls.Add(picLogo, 0, 0);
            menuTLP.Controls.Add(btnVolver, 0, 6);
            menuTLP.Controls.Add(btnTurno, 0, 2);
            menuTLP.Controls.Add(btnAgenda, 0, 4);
            menuTLP.Dock = DockStyle.Fill;
            menuTLP.Location = new Point(1443, 0);
            menuTLP.Margin = new Padding(0);
            menuTLP.Name = "menuTLP";
            menuTLP.RowCount = 8;
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 26F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            menuTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            menuTLP.Size = new Size(481, 1055);
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
            picLogo.Size = new Size(481, 316);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Pink;
            btnVolver.Dock = DockStyle.Fill;
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(0, 884);
            btnVolver.Margin = new Padding(0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(481, 84);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "VOLVER AL DASHBOARD";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnTurno
            // 
            btnTurno.BackColor = Color.CornflowerBlue;
            btnTurno.Dock = DockStyle.Fill;
            btnTurno.ForeColor = Color.White;
            btnTurno.Location = new Point(0, 379);
            btnTurno.Margin = new Padding(0);
            btnTurno.Name = "btnTurno";
            btnTurno.Size = new Size(481, 84);
            btnTurno.TabIndex = 1;
            btnTurno.Text = "IR AL TURNO";
            btnTurno.UseVisualStyleBackColor = false;
            // 
            // btnAgenda
            // 
            btnAgenda.BackColor = Color.CornflowerBlue;
            btnAgenda.Dock = DockStyle.Fill;
            btnAgenda.ForeColor = Color.White;
            btnAgenda.Location = new Point(0, 526);
            btnAgenda.Margin = new Padding(0);
            btnAgenda.Name = "btnAgenda";
            btnAgenda.Size = new Size(481, 84);
            btnAgenda.TabIndex = 2;
            btnAgenda.Text = "GESTIONAR AGENDAS";
            btnAgenda.UseVisualStyleBackColor = false;
            // 
            // contentTLP
            // 
            contentTLP.ColumnCount = 1;
            contentTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            contentTLP.Controls.Add(contentLbl, 0, 1);
            contentTLP.Controls.Add(tableLayoutPanel1, 0, 2);
            contentTLP.Controls.Add(dataGridTLP, 0, 3);
            contentTLP.Dock = DockStyle.Fill;
            contentTLP.Location = new Point(0, 0);
            contentTLP.Margin = new Padding(0);
            contentTLP.Name = "contentTLP";
            contentTLP.RowCount = 4;
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            contentTLP.Size = new Size(1443, 1055);
            contentTLP.TabIndex = 1;
            // 
            // contentLbl
            // 
            contentLbl.AutoSize = true;
            contentLbl.BackColor = SystemColors.GradientInactiveCaption;
            contentLbl.Dock = DockStyle.Fill;
            contentLbl.Font = new Font("LEMON MILK", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contentLbl.Location = new Point(0, 52);
            contentLbl.Margin = new Padding(0);
            contentLbl.Name = "contentLbl";
            contentLbl.Size = new Size(1443, 105);
            contentLbl.TabIndex = 0;
            contentLbl.Text = "      GESTION DE TURNOS";
            contentLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Controls.Add(fechaCbx, 1, 0);
            tableLayoutPanel1.Controls.Add(especialidadCbx, 2, 0);
            tableLayoutPanel1.Controls.Add(profesionalCbx, 3, 0);
            tableLayoutPanel1.Controls.Add(estadoCbx, 4, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 157);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1443, 105);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // fechaCbx
            // 
            fechaCbx.AllowDrop = true;
            fechaCbx.Anchor = AnchorStyles.None;
            fechaCbx.Font = new Font("LEMON MILK", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fechaCbx.FormattingEnabled = true;
            fechaCbx.Location = new Point(140, 29);
            fechaCbx.Name = "fechaCbx";
            fechaCbx.Size = new Size(187, 46);
            fechaCbx.TabIndex = 3;
            // 
            // especialidadCbx
            // 
            especialidadCbx.Anchor = AnchorStyles.None;
            especialidadCbx.Font = new Font("LEMON MILK", 16.2F);
            especialidadCbx.FormattingEnabled = true;
            especialidadCbx.Location = new Point(464, 29);
            especialidadCbx.Name = "especialidadCbx";
            especialidadCbx.Size = new Size(187, 46);
            especialidadCbx.TabIndex = 4;
            // 
            // profesionalCbx
            // 
            profesionalCbx.Anchor = AnchorStyles.None;
            profesionalCbx.Font = new Font("LEMON MILK", 16.2F);
            profesionalCbx.FormattingEnabled = true;
            profesionalCbx.Location = new Point(788, 29);
            profesionalCbx.Name = "profesionalCbx";
            profesionalCbx.Size = new Size(187, 46);
            profesionalCbx.TabIndex = 5;
            // 
            // estadoCbx
            // 
            estadoCbx.Anchor = AnchorStyles.None;
            estadoCbx.Font = new Font("LEMON MILK", 16.2F);
            estadoCbx.FormattingEnabled = true;
            estadoCbx.Location = new Point(1112, 29);
            estadoCbx.Name = "estadoCbx";
            estadoCbx.Size = new Size(187, 46);
            estadoCbx.TabIndex = 6;
            // 
            // dataGridTLP
            // 
            dataGridTLP.ColumnCount = 3;
            dataGridTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            dataGridTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            dataGridTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            dataGridTLP.Controls.Add(turnosDgv, 1, 0);
            dataGridTLP.Dock = DockStyle.Fill;
            dataGridTLP.Location = new Point(0, 262);
            dataGridTLP.Margin = new Padding(0);
            dataGridTLP.Name = "dataGridTLP";
            dataGridTLP.RowCount = 1;
            dataGridTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            dataGridTLP.Size = new Size(1443, 793);
            dataGridTLP.TabIndex = 2;
            // 
            // turnosDgv
            // 
            turnosDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            turnosDgv.Dock = DockStyle.Fill;
            turnosDgv.Location = new Point(72, 0);
            turnosDgv.Margin = new Padding(0, 0, 0, 50);
            turnosDgv.Name = "turnosDgv";
            turnosDgv.RowHeadersWidth = 51;
            turnosDgv.Size = new Size(1298, 743);
            turnosDgv.TabIndex = 7;
            // 
            // AdmGestionTurnos
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(mainTLP);
            Font = new Font("LEMON MILK", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(1527, 912);
            Name = "AdmGestionTurnos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clinica SePrise  ||  Gestion de Turnos";
            WindowState = FormWindowState.Maximized;
            Load += AdmGestionTurnos_Load;
            mainTLP.ResumeLayout(false);
            menuTLP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            contentTLP.ResumeLayout(false);
            contentTLP.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            dataGridTLP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)turnosDgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTLP;
        private TableLayoutPanel menuTLP;
        private PictureBox picLogo;
        private Button btnTurno;
        private Button btnAgenda;
        private Button btnVolver;
        private TableLayoutPanel contentTLP;
        private Label contentLbl;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox fechaCbx;
        private ComboBox especialidadCbx;
        private ComboBox profesionalCbx;
        private ComboBox estadoCbx;
        private TableLayoutPanel dataGridTLP;
        private DataGridView turnosDgv;
    }
}
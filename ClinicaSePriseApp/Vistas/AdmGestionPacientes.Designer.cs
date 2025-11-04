namespace ClinicaSePriseApp.Vistas
{
    partial class AdmGestionPacientes
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmGestionPacientes));
            mainTLP = new TableLayoutPanel();
            menuTLP = new TableLayoutPanel();
            btnVolver = new Button();
            picLogo = new PictureBox();
            btnModificarPaciente = new Button();
            btnBuscar = new Button();
            btnAlta = new Button();
            contentTLP = new TableLayoutPanel();
            contentLbl = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtDni = new TextBox();
            dataGridTLP = new TableLayoutPanel();
            pacientesDgv = new DataGridView();
            profesionalBindingSource = new BindingSource(components);
            mainTLP.SuspendLayout();
            menuTLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            contentTLP.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            dataGridTLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pacientesDgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profesionalBindingSource).BeginInit();
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
            mainTLP.TabIndex = 1;
            // 
            // menuTLP
            // 
            menuTLP.BackColor = SystemColors.GradientInactiveCaption;
            menuTLP.ColumnCount = 1;
            menuTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            menuTLP.Controls.Add(btnVolver, 0, 8);
            menuTLP.Controls.Add(picLogo, 0, 0);
            menuTLP.Controls.Add(btnModificarPaciente, 0, 6);
            menuTLP.Controls.Add(btnBuscar, 0, 2);
            menuTLP.Controls.Add(btnAlta, 0, 4);
            menuTLP.Dock = DockStyle.Fill;
            menuTLP.Location = new Point(1443, 0);
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
            menuTLP.Size = new Size(481, 1055);
            menuTLP.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Pink;
            btnVolver.Dock = DockStyle.Fill;
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(0, 883);
            btnVolver.Margin = new Padding(0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(481, 84);
            btnVolver.TabIndex = 13;
            btnVolver.Text = "VOLVER AL DASHBOARD";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
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
            // btnModificarPaciente
            // 
            btnModificarPaciente.BackColor = Color.CornflowerBlue;
            btnModificarPaciente.Dock = DockStyle.Fill;
            btnModificarPaciente.ForeColor = Color.White;
            btnModificarPaciente.Location = new Point(0, 673);
            btnModificarPaciente.Margin = new Padding(0);
            btnModificarPaciente.Name = "btnModificarPaciente";
            btnModificarPaciente.Size = new Size(481, 84);
            btnModificarPaciente.TabIndex = 8;
            btnModificarPaciente.Text = "MODIFICAR PACIENTE";
            btnModificarPaciente.UseVisualStyleBackColor = false;
            btnModificarPaciente.Click += btnModificarPaciente_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.CornflowerBlue;
            btnBuscar.Dock = DockStyle.Fill;
            btnBuscar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(0, 379);
            btnBuscar.Margin = new Padding(0);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(481, 84);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "BUSCAR PACIENTE";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAlta
            // 
            btnAlta.BackColor = Color.CornflowerBlue;
            btnAlta.Dock = DockStyle.Fill;
            btnAlta.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAlta.ForeColor = Color.White;
            btnAlta.Location = new Point(0, 526);
            btnAlta.Margin = new Padding(0);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(481, 84);
            btnAlta.TabIndex = 2;
            btnAlta.Text = "ALTA PACIENTE";
            btnAlta.UseVisualStyleBackColor = false;
            btnAlta.Click += btnAlta_Click;
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
            contentLbl.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contentLbl.Location = new Point(0, 52);
            contentLbl.Margin = new Padding(0);
            contentLbl.Name = "contentLbl";
            contentLbl.Size = new Size(1443, 105);
            contentLbl.TabIndex = 0;
            contentLbl.Text = "      GESTION DE PACIENTES";
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
            tableLayoutPanel1.Controls.Add(txtDni, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 157);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.Size = new Size(1443, 105);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // txtDni
            // 
            txtDni.Anchor = AnchorStyles.None;
            txtDni.ForeColor = Color.LightGray;
            txtDni.Location = new Point(129, 41);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(210, 22);
            txtDni.TabIndex = 0;
            txtDni.Text = "DNI";
            txtDni.TextChanged += txtDni_TextChanged;
            txtDni.Enter += txtDni_Enter;
            txtDni.KeyDown += txtDni_KeyDown;
            txtDni.Leave += txtDni_Leave;
            // 
            // dataGridTLP
            // 
            dataGridTLP.ColumnCount = 3;
            dataGridTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            dataGridTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            dataGridTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            dataGridTLP.Controls.Add(pacientesDgv, 1, 0);
            dataGridTLP.Dock = DockStyle.Fill;
            dataGridTLP.Location = new Point(0, 262);
            dataGridTLP.Margin = new Padding(0);
            dataGridTLP.Name = "dataGridTLP";
            dataGridTLP.RowCount = 1;
            dataGridTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            dataGridTLP.Size = new Size(1443, 793);
            dataGridTLP.TabIndex = 2;
            // 
            // pacientesDgv
            // 
            pacientesDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pacientesDgv.Dock = DockStyle.Fill;
            pacientesDgv.Location = new Point(72, 0);
            pacientesDgv.Margin = new Padding(0, 0, 0, 53);
            pacientesDgv.Name = "pacientesDgv";
            pacientesDgv.RowHeadersWidth = 51;
            pacientesDgv.Size = new Size(1298, 740);
            pacientesDgv.TabIndex = 7;
            // 
            // AdmGestionPacientes
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(mainTLP);
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1527, 912);
            Name = "AdmGestionPacientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clinica SePrise  ||  Gestion de Pacientes";
            WindowState = FormWindowState.Maximized;
            Load += AdmGestionPacientes_Load;
            mainTLP.ResumeLayout(false);
            menuTLP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            contentTLP.ResumeLayout(false);
            contentTLP.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            dataGridTLP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pacientesDgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)profesionalBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTLP;
        private TableLayoutPanel menuTLP;
        private PictureBox picLogo;
        private Button btnModificarPaciente;
        private Button btnBuscar;
        private Button btnAlta;
        private TableLayoutPanel contentTLP;
        private Label contentLbl;
        private TableLayoutPanel tableLayoutPanel1;
        private BindingSource profesionalBindingSource;
        private TableLayoutPanel dataGridTLP;
        private DataGridView pacientesDgv;
        private Button btnVolver;
        private TextBox txtDni;
    }
}
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmGestionTurnos));
            mainTLP = new TableLayoutPanel();
            menuTLP = new TableLayoutPanel();
            picLogo = new PictureBox();
            btnVolver = new Button();
            btnAgenda = new Button();
            btnTurno = new Button();
            btnFiltros = new Button();
            contentTLP = new TableLayoutPanel();
            contentLbl = new Label();
            filtrosTLP = new TableLayoutPanel();
            cbEspecialidad = new CheckBox();
            especialidadCbx = new ComboBox();
            cbFecha = new CheckBox();
            dtpTurnos = new DateTimePicker();
            cbEstado = new CheckBox();
            estadoCbx = new ComboBox();
            cbProfesional = new CheckBox();
            profesionalCbx = new ComboBox();
            profesionalBindingSource = new BindingSource(components);
            dataGridTLP = new TableLayoutPanel();
            turnosDgv = new DataGridView();
            mainTLP.SuspendLayout();
            menuTLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            contentTLP.SuspendLayout();
            filtrosTLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profesionalBindingSource).BeginInit();
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
            menuTLP.Controls.Add(btnVolver, 0, 8);
            menuTLP.Controls.Add(btnAgenda, 0, 6);
            menuTLP.Controls.Add(btnTurno, 0, 4);
            menuTLP.Controls.Add(btnFiltros, 0, 2);
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
            btnVolver.Location = new Point(0, 883);
            btnVolver.Margin = new Padding(0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(481, 84);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "VOLVER AL DASHBOARD";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnAgenda
            // 
            btnAgenda.BackColor = Color.CornflowerBlue;
            btnAgenda.Dock = DockStyle.Fill;
            btnAgenda.ForeColor = Color.White;
            btnAgenda.Location = new Point(0, 673);
            btnAgenda.Margin = new Padding(0);
            btnAgenda.Name = "btnAgenda";
            btnAgenda.Size = new Size(481, 84);
            btnAgenda.TabIndex = 2;
            btnAgenda.Text = "GESTIONAR AGENDAS";
            btnAgenda.UseVisualStyleBackColor = false;
            btnAgenda.Click += btnAgenda_Click;
            // 
            // btnTurno
            // 
            btnTurno.BackColor = Color.CornflowerBlue;
            btnTurno.Dock = DockStyle.Fill;
            btnTurno.ForeColor = Color.White;
            btnTurno.Location = new Point(0, 526);
            btnTurno.Margin = new Padding(0);
            btnTurno.Name = "btnTurno";
            btnTurno.Size = new Size(481, 84);
            btnTurno.TabIndex = 1;
            btnTurno.Text = "IR AL TURNO";
            btnTurno.UseVisualStyleBackColor = false;
            btnTurno.Click += btnTurno_Click;
            // 
            // btnFiltros
            // 
            btnFiltros.BackColor = Color.CornflowerBlue;
            btnFiltros.Dock = DockStyle.Fill;
            btnFiltros.ForeColor = Color.White;
            btnFiltros.Location = new Point(0, 379);
            btnFiltros.Margin = new Padding(0);
            btnFiltros.Name = "btnFiltros";
            btnFiltros.Size = new Size(481, 84);
            btnFiltros.TabIndex = 9;
            btnFiltros.Text = "APLICAR FILTROS";
            btnFiltros.UseVisualStyleBackColor = false;
            btnFiltros.Click += btnFiltros_Click;
            // 
            // contentTLP
            // 
            contentTLP.ColumnCount = 1;
            contentTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            contentTLP.Controls.Add(contentLbl, 0, 1);
            contentTLP.Controls.Add(filtrosTLP, 0, 2);
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
            // filtrosTLP
            // 
            filtrosTLP.ColumnCount = 7;
            filtrosTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            filtrosTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            filtrosTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            filtrosTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            filtrosTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            filtrosTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            filtrosTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            filtrosTLP.Controls.Add(cbEspecialidad, 1, 2);
            filtrosTLP.Controls.Add(especialidadCbx, 2, 2);
            filtrosTLP.Controls.Add(cbFecha, 1, 1);
            filtrosTLP.Controls.Add(dtpTurnos, 2, 1);
            filtrosTLP.Controls.Add(cbEstado, 4, 2);
            filtrosTLP.Controls.Add(estadoCbx, 5, 2);
            filtrosTLP.Controls.Add(cbProfesional, 4, 1);
            filtrosTLP.Controls.Add(profesionalCbx, 5, 1);
            filtrosTLP.Dock = DockStyle.Fill;
            filtrosTLP.Location = new Point(0, 157);
            filtrosTLP.Margin = new Padding(0);
            filtrosTLP.Name = "filtrosTLP";
            filtrosTLP.RowCount = 3;
            filtrosTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            filtrosTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            filtrosTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            filtrosTLP.Size = new Size(1443, 105);
            filtrosTLP.TabIndex = 1;
            // 
            // cbEspecialidad
            // 
            cbEspecialidad.CheckAlign = ContentAlignment.MiddleCenter;
            cbEspecialidad.Dock = DockStyle.Fill;
            cbEspecialidad.ImageAlign = ContentAlignment.TopLeft;
            cbEspecialidad.Location = new Point(75, 60);
            cbEspecialidad.Name = "cbEspecialidad";
            cbEspecialidad.Size = new Size(66, 42);
            cbEspecialidad.TabIndex = 9;
            cbEspecialidad.TextAlign = ContentAlignment.TopLeft;
            cbEspecialidad.UseVisualStyleBackColor = true;
            // 
            // especialidadCbx
            // 
            especialidadCbx.Dock = DockStyle.Fill;
            especialidadCbx.Font = new Font("LEMON MILK", 7.8F);
            especialidadCbx.FormattingEnabled = true;
            especialidadCbx.Location = new Point(147, 67);
            especialidadCbx.Margin = new Padding(3, 10, 3, 3);
            especialidadCbx.Name = "especialidadCbx";
            especialidadCbx.Size = new Size(499, 27);
            especialidadCbx.TabIndex = 4;
            // 
            // cbFecha
            // 
            cbFecha.CheckAlign = ContentAlignment.MiddleCenter;
            cbFecha.Dock = DockStyle.Fill;
            cbFecha.ImageAlign = ContentAlignment.TopLeft;
            cbFecha.Location = new Point(75, 13);
            cbFecha.Name = "cbFecha";
            cbFecha.Size = new Size(66, 41);
            cbFecha.TabIndex = 8;
            cbFecha.TextAlign = ContentAlignment.TopLeft;
            cbFecha.UseVisualStyleBackColor = true;
            // 
            // dtpTurnos
            // 
            dtpTurnos.Dock = DockStyle.Fill;
            dtpTurnos.Font = new Font("LEMON MILK", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpTurnos.Location = new Point(147, 20);
            dtpTurnos.Margin = new Padding(3, 10, 3, 3);
            dtpTurnos.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dtpTurnos.Name = "dtpTurnos";
            dtpTurnos.Size = new Size(499, 25);
            dtpTurnos.TabIndex = 7;
            // 
            // cbEstado
            // 
            cbEstado.CheckAlign = ContentAlignment.MiddleCenter;
            cbEstado.Dock = DockStyle.Fill;
            cbEstado.ImageAlign = ContentAlignment.TopLeft;
            cbEstado.Location = new Point(796, 60);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(66, 42);
            cbEstado.TabIndex = 11;
            cbEstado.TextAlign = ContentAlignment.TopLeft;
            cbEstado.UseVisualStyleBackColor = true;
            // 
            // estadoCbx
            // 
            estadoCbx.Dock = DockStyle.Fill;
            estadoCbx.Font = new Font("LEMON MILK", 7.8F);
            estadoCbx.FormattingEnabled = true;
            estadoCbx.Location = new Point(868, 67);
            estadoCbx.Margin = new Padding(3, 10, 3, 3);
            estadoCbx.Name = "estadoCbx";
            estadoCbx.Size = new Size(499, 27);
            estadoCbx.TabIndex = 6;
            // 
            // cbProfesional
            // 
            cbProfesional.CheckAlign = ContentAlignment.MiddleCenter;
            cbProfesional.Dock = DockStyle.Fill;
            cbProfesional.ImageAlign = ContentAlignment.TopLeft;
            cbProfesional.Location = new Point(796, 13);
            cbProfesional.Name = "cbProfesional";
            cbProfesional.Size = new Size(66, 41);
            cbProfesional.TabIndex = 10;
            cbProfesional.TextAlign = ContentAlignment.TopLeft;
            cbProfesional.UseVisualStyleBackColor = true;
            // 
            // profesionalCbx
            // 
            profesionalCbx.DataSource = profesionalBindingSource;
            profesionalCbx.Dock = DockStyle.Fill;
            profesionalCbx.Font = new Font("LEMON MILK", 7.8F);
            profesionalCbx.FormattingEnabled = true;
            profesionalCbx.Location = new Point(868, 20);
            profesionalCbx.Margin = new Padding(3, 10, 3, 3);
            profesionalCbx.Name = "profesionalCbx";
            profesionalCbx.Size = new Size(499, 27);
            profesionalCbx.TabIndex = 5;
            // 
            // profesionalBindingSource
            // 
            profesionalBindingSource.DataSource = typeof(Entidades.E_Profesional);
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
            turnosDgv.Location = new Point(72, 15);
            turnosDgv.Margin = new Padding(0, 15, 0, 15);
            turnosDgv.Name = "turnosDgv";
            turnosDgv.RowHeadersWidth = 51;
            turnosDgv.Size = new Size(1298, 763);
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
            filtrosTLP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)profesionalBindingSource).EndInit();
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
        private TableLayoutPanel filtrosTLP;
        private ComboBox especialidadCbx;
        private ComboBox profesionalCbx;
        private ComboBox estadoCbx;
        private TableLayoutPanel dataGridTLP;
        private DataGridView turnosDgv;
        private BindingSource profesionalBindingSource;
        private DateTimePicker dtpTurnos;
        private Button btnFiltros;
        private CheckBox cbFecha;
        private CheckBox cbEspecialidad;
        private CheckBox cbProfesional;
        private CheckBox cbEstado;
    }
}
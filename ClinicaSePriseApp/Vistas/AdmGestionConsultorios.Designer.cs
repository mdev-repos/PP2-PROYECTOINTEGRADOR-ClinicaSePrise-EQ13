namespace ClinicaSePriseApp.Vistas
{
    partial class AdmGestionConsultorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmGestionConsultorios));
            mainTLP = new TableLayoutPanel();
            menuTLP = new TableLayoutPanel();
            btnVolver = new Button();
            picLogo = new PictureBox();
            btnAsignarLiberar = new Button();
            contentTLP = new TableLayoutPanel();
            contentLbl = new Label();
            dataGridTLP = new TableLayoutPanel();
            dgvConsultorios = new DataGridView();
            profesionalBindingSource = new BindingSource(components);
            mainTLP.SuspendLayout();
            menuTLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            contentTLP.SuspendLayout();
            dataGridTLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultorios).BeginInit();
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
            mainTLP.Size = new Size(800, 450);
            mainTLP.TabIndex = 2;
            // 
            // menuTLP
            // 
            menuTLP.BackColor = SystemColors.GradientInactiveCaption;
            menuTLP.ColumnCount = 1;
            menuTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            menuTLP.Controls.Add(btnVolver, 0, 8);
            menuTLP.Controls.Add(picLogo, 0, 0);
            menuTLP.Controls.Add(btnAsignarLiberar, 0, 2);
            menuTLP.Dock = DockStyle.Fill;
            menuTLP.Location = new Point(600, 0);
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
            menuTLP.Size = new Size(200, 450);
            menuTLP.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Pink;
            btnVolver.Dock = DockStyle.Fill;
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(0, 378);
            btnVolver.Margin = new Padding(0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(200, 36);
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
            picLogo.Size = new Size(200, 135);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // btnAsignarLiberar
            // 
            btnAsignarLiberar.BackColor = Color.CornflowerBlue;
            btnAsignarLiberar.Dock = DockStyle.Fill;
            btnAsignarLiberar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAsignarLiberar.ForeColor = Color.White;
            btnAsignarLiberar.Location = new Point(0, 162);
            btnAsignarLiberar.Margin = new Padding(0);
            btnAsignarLiberar.Name = "btnAsignarLiberar";
            btnAsignarLiberar.Size = new Size(200, 36);
            btnAsignarLiberar.TabIndex = 1;
            btnAsignarLiberar.Text = "ASIGNAR / LIBERAR";
            btnAsignarLiberar.UseVisualStyleBackColor = false;
            // 
            // contentTLP
            // 
            contentTLP.ColumnCount = 1;
            contentTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            contentTLP.Controls.Add(contentLbl, 0, 1);
            contentTLP.Controls.Add(dataGridTLP, 0, 2);
            contentTLP.Dock = DockStyle.Fill;
            contentTLP.Location = new Point(0, 0);
            contentTLP.Margin = new Padding(0);
            contentTLP.Name = "contentTLP";
            contentTLP.RowCount = 3;
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 5.55555534F));
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 83.3333359F));
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            contentTLP.Size = new Size(600, 450);
            contentTLP.TabIndex = 1;
            // 
            // contentLbl
            // 
            contentLbl.AutoSize = true;
            contentLbl.BackColor = SystemColors.GradientInactiveCaption;
            contentLbl.Dock = DockStyle.Fill;
            contentLbl.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contentLbl.Location = new Point(0, 25);
            contentLbl.Margin = new Padding(0);
            contentLbl.Name = "contentLbl";
            contentLbl.Size = new Size(600, 50);
            contentLbl.TabIndex = 0;
            contentLbl.Text = "      GESTION DE CONSULTORIOS";
            contentLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridTLP
            // 
            dataGridTLP.ColumnCount = 3;
            dataGridTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            dataGridTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            dataGridTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            dataGridTLP.Controls.Add(dgvConsultorios, 1, 0);
            dataGridTLP.Dock = DockStyle.Fill;
            dataGridTLP.Location = new Point(0, 75);
            dataGridTLP.Margin = new Padding(0);
            dataGridTLP.Name = "dataGridTLP";
            dataGridTLP.RowCount = 1;
            dataGridTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            dataGridTLP.Size = new Size(600, 375);
            dataGridTLP.TabIndex = 2;
            // 
            // dgvConsultorios
            // 
            dgvConsultorios.BackgroundColor = Color.CornflowerBlue;
            dgvConsultorios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultorios.Dock = DockStyle.Fill;
            dgvConsultorios.Location = new Point(30, 0);
            dgvConsultorios.Margin = new Padding(0, 0, 0, 53);
            dgvConsultorios.Name = "dgvConsultorios";
            dgvConsultorios.RowHeadersWidth = 51;
            dgvConsultorios.Size = new Size(540, 322);
            dgvConsultorios.TabIndex = 7;
            // 
            // AdmGestionConsultorios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainTLP);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdmGestionConsultorios";
            Text = "Clinica SePrise  ||  Gestion de Consultorios";
            mainTLP.ResumeLayout(false);
            menuTLP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            contentTLP.ResumeLayout(false);
            contentTLP.PerformLayout();
            dataGridTLP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvConsultorios).EndInit();
            ((System.ComponentModel.ISupportInitialize)profesionalBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTLP;
        private TableLayoutPanel menuTLP;
        private Button btnVolver;
        private PictureBox picLogo;
        private Button btnAsignarLiberar;
        private TableLayoutPanel contentTLP;
        private Label contentLbl;
        private TableLayoutPanel dataGridTLP;
        private BindingSource profesionalBindingSource;
    }
}
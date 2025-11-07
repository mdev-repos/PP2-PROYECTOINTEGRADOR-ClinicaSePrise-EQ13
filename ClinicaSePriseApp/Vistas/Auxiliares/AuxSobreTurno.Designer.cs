namespace ClinicaSePriseApp.Vistas.Auxiliares
{
    partial class AuxSobreTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuxSobreTurno));
            containerTLP = new TableLayoutPanel();
            lblTitulo = new Label();
            buttonsTLP = new TableLayoutPanel();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            dniTLP = new TableLayoutPanel();
            pacienteDniTxt = new TextBox();
            dniSearchBtn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblHorario = new Label();
            dtpHorario = new DateTimePicker();
            containerTLP.SuspendLayout();
            buttonsTLP.SuspendLayout();
            dniTLP.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // containerTLP
            // 
            containerTLP.ColumnCount = 1;
            containerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            containerTLP.Controls.Add(lblTitulo, 0, 1);
            containerTLP.Controls.Add(buttonsTLP, 0, 7);
            containerTLP.Controls.Add(dniTLP, 0, 3);
            containerTLP.Controls.Add(tableLayoutPanel1, 0, 5);
            containerTLP.Dock = DockStyle.Fill;
            containerTLP.Location = new Point(0, 0);
            containerTLP.Margin = new Padding(0);
            containerTLP.Name = "containerTLP";
            containerTLP.RowCount = 9;
            containerTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            containerTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            containerTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            containerTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            containerTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            containerTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            containerTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 21F));
            containerTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            containerTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            containerTLP.Size = new Size(700, 500);
            containerTLP.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(0, 20);
            lblTitulo.Margin = new Padding(0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(700, 70);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GENERAR SOBRETURNO";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonsTLP
            // 
            buttonsTLP.ColumnCount = 5;
            buttonsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            buttonsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            buttonsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            buttonsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            buttonsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            buttonsTLP.Controls.Add(btnCancelar, 1, 0);
            buttonsTLP.Controls.Add(btnConfirmar, 3, 0);
            buttonsTLP.Dock = DockStyle.Fill;
            buttonsTLP.Location = new Point(0, 410);
            buttonsTLP.Margin = new Padding(0);
            buttonsTLP.Name = "buttonsTLP";
            buttonsTLP.RowCount = 1;
            buttonsTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            buttonsTLP.Size = new Size(700, 65);
            buttonsTLP.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.Dock = DockStyle.Fill;
            btnCancelar.Location = new Point(143, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(169, 59);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Dock = DockStyle.Fill;
            btnConfirmar.Location = new Point(388, 3);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(169, 59);
            btnConfirmar.TabIndex = 1;
            btnConfirmar.Text = "CONFIRMAR";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // dniTLP
            // 
            dniTLP.ColumnCount = 5;
            dniTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            dniTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            dniTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            dniTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            dniTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            dniTLP.Controls.Add(pacienteDniTxt, 1, 0);
            dniTLP.Controls.Add(dniSearchBtn, 3, 0);
            dniTLP.Dock = DockStyle.Fill;
            dniTLP.Location = new Point(3, 153);
            dniTLP.Name = "dniTLP";
            dniTLP.RowCount = 1;
            dniTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            dniTLP.Size = new Size(694, 39);
            dniTLP.TabIndex = 8;
            // 
            // pacienteDniTxt
            // 
            pacienteDniTxt.Dock = DockStyle.Fill;
            pacienteDniTxt.ImeMode = ImeMode.NoControl;
            pacienteDniTxt.Location = new Point(138, 5);
            pacienteDniTxt.Margin = new Padding(0, 5, 0, 0);
            pacienteDniTxt.MaxLength = 9;
            pacienteDniTxt.Name = "pacienteDniTxt";
            pacienteDniTxt.PlaceholderText = "DNI";
            pacienteDniTxt.Size = new Size(277, 27);
            pacienteDniTxt.TabIndex = 0;
            // 
            // dniSearchBtn
            // 
            dniSearchBtn.BackgroundImage = Properties.Resources.icon_lupa;
            dniSearchBtn.BackgroundImageLayout = ImageLayout.Zoom;
            dniSearchBtn.Dock = DockStyle.Fill;
            dniSearchBtn.ForeColor = SystemColors.ControlText;
            dniSearchBtn.Location = new Point(449, 0);
            dniSearchBtn.Margin = new Padding(0);
            dniSearchBtn.Name = "dniSearchBtn";
            dniSearchBtn.Padding = new Padding(6, 5, 6, 5);
            dniSearchBtn.Size = new Size(104, 39);
            dniSearchBtn.TabIndex = 1;
            dniSearchBtn.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(lblHorario, 1, 0);
            tableLayoutPanel1.Controls.Add(dtpHorario, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 263);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(694, 39);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.Dock = DockStyle.Fill;
            lblHorario.Location = new Point(138, 0);
            lblHorario.Margin = new Padding(0);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(104, 39);
            lblHorario.TabIndex = 0;
            lblHorario.Text = "Horario:";
            lblHorario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpHorario
            // 
            dtpHorario.Dock = DockStyle.Fill;
            dtpHorario.Location = new Point(276, 6);
            dtpHorario.Margin = new Padding(0, 6, 0, 0);
            dtpHorario.Name = "dtpHorario";
            dtpHorario.Size = new Size(277, 27);
            dtpHorario.TabIndex = 1;
            // 
            // AuxSobreTurno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 500);
            Controls.Add(containerTLP);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(700, 500);
            MinimumSize = new Size(700, 500);
            Name = "AuxSobreTurno";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Generacion de SobreTurno";
            containerTLP.ResumeLayout(false);
            containerTLP.PerformLayout();
            buttonsTLP.ResumeLayout(false);
            dniTLP.ResumeLayout(false);
            dniTLP.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel containerTLP;
        private Label lblTitulo;
        private TableLayoutPanel buttonsTLP;
        private Button btnCancelar;
        private Button btnConfirmar;
        private TableLayoutPanel dniTLP;
        private TextBox pacienteDniTxt;
        private Button dniSearchBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblHorario;
        private DateTimePicker dtpHorario;
    }
}
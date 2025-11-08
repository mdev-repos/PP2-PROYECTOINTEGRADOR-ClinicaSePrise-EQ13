namespace ClinicaSePriseApp.Vistas.Auxiliares
{
    partial class AuxSolicitarInsumos
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
            containerTLP = new TableLayoutPanel();
            lblTitulo = new Label();
            contentTLP = new TableLayoutPanel();
            insumosPanel = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            insumosTLP = new TableLayoutPanel();
            pedidoPanel = new Panel();
            listaTLP = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonsTLP = new TableLayoutPanel();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            containerTLP.SuspendLayout();
            contentTLP.SuspendLayout();
            insumosPanel.SuspendLayout();
            pedidoPanel.SuspendLayout();
            buttonsTLP.SuspendLayout();
            SuspendLayout();
            // 
            // containerTLP
            // 
            containerTLP.ColumnCount = 1;
            containerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            containerTLP.Controls.Add(lblTitulo, 0, 0);
            containerTLP.Controls.Add(contentTLP, 0, 1);
            containerTLP.Controls.Add(buttonsTLP, 0, 3);
            containerTLP.Dock = DockStyle.Fill;
            containerTLP.Location = new Point(0, 0);
            containerTLP.Margin = new Padding(0);
            containerTLP.Name = "containerTLP";
            containerTLP.RowCount = 5;
            containerTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            containerTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            containerTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 3F));
            containerTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            containerTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            containerTLP.Size = new Size(900, 600);
            containerTLP.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Margin = new Padding(0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(900, 84);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "SOLICITUD DE INSUMOS";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // contentTLP
            // 
            contentTLP.ColumnCount = 5;
            contentTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2F));
            contentTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53F));
            contentTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3F));
            contentTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            contentTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2F));
            contentTLP.Controls.Add(insumosPanel, 1, 0);
            contentTLP.Controls.Add(pedidoPanel, 3, 0);
            contentTLP.Dock = DockStyle.Fill;
            contentTLP.Location = new Point(3, 87);
            contentTLP.Name = "contentTLP";
            contentTLP.RowCount = 1;
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            contentTLP.Size = new Size(894, 384);
            contentTLP.TabIndex = 9;
            // 
            // insumosPanel
            // 
            insumosPanel.AutoScroll = true;
            insumosPanel.Controls.Add(tableLayoutPanel2);
            insumosPanel.Controls.Add(insumosTLP);
            insumosPanel.Dock = DockStyle.Fill;
            insumosPanel.Location = new Point(17, 0);
            insumosPanel.Margin = new Padding(0);
            insumosPanel.Name = "insumosPanel";
            insumosPanel.Size = new Size(473, 384);
            insumosPanel.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(473, 0);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // insumosTLP
            // 
            insumosTLP.AutoSize = true;
            insumosTLP.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            insumosTLP.ColumnCount = 4;
            insumosTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            insumosTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            insumosTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            insumosTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            insumosTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            insumosTLP.Dock = DockStyle.Top;
            insumosTLP.Location = new Point(0, 0);
            insumosTLP.Margin = new Padding(0);
            insumosTLP.Name = "insumosTLP";
            insumosTLP.RowCount = 1;
            insumosTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            insumosTLP.Size = new Size(473, 0);
            insumosTLP.TabIndex = 0;
            // 
            // pedidoPanel
            // 
            pedidoPanel.AutoScroll = true;
            pedidoPanel.Controls.Add(listaTLP);
            pedidoPanel.Controls.Add(tableLayoutPanel1);
            pedidoPanel.Dock = DockStyle.Fill;
            pedidoPanel.Location = new Point(516, 0);
            pedidoPanel.Margin = new Padding(0);
            pedidoPanel.Name = "pedidoPanel";
            pedidoPanel.Size = new Size(357, 384);
            pedidoPanel.TabIndex = 12;
            // 
            // listaTLP
            // 
            listaTLP.AutoSize = true;
            listaTLP.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            listaTLP.ColumnCount = 3;
            listaTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            listaTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            listaTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            listaTLP.Dock = DockStyle.Top;
            listaTLP.Location = new Point(0, 0);
            listaTLP.Margin = new Padding(0);
            listaTLP.Name = "listaTLP";
            listaTLP.RowCount = 1;
            listaTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            listaTLP.Size = new Size(357, 0);
            listaTLP.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(357, 0);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonsTLP
            // 
            buttonsTLP.ColumnCount = 5;
            buttonsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13F));
            buttonsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            buttonsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
            buttonsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            buttonsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13F));
            buttonsTLP.Controls.Add(btnCancelar, 1, 0);
            buttonsTLP.Controls.Add(btnConfirmar, 3, 0);
            buttonsTLP.Dock = DockStyle.Fill;
            buttonsTLP.Location = new Point(0, 492);
            buttonsTLP.Margin = new Padding(0);
            buttonsTLP.Name = "buttonsTLP";
            buttonsTLP.RowCount = 1;
            buttonsTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            buttonsTLP.Size = new Size(900, 84);
            buttonsTLP.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.Dock = DockStyle.Fill;
            btnCancelar.Location = new Point(120, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(219, 78);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Dock = DockStyle.Fill;
            btnConfirmar.Location = new Point(561, 3);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(219, 78);
            btnConfirmar.TabIndex = 1;
            btnConfirmar.Text = "CONFIRMAR";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // AuxSolicitarInsumos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            Controls.Add(containerTLP);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(900, 600);
            MinimumSize = new Size(900, 600);
            Name = "AuxSolicitarInsumos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Solicitud de Insumos";
            containerTLP.ResumeLayout(false);
            containerTLP.PerformLayout();
            contentTLP.ResumeLayout(false);
            insumosPanel.ResumeLayout(false);
            insumosPanel.PerformLayout();
            pedidoPanel.ResumeLayout(false);
            pedidoPanel.PerformLayout();
            buttonsTLP.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel containerTLP;
        private Label lblTitulo;
        private TableLayoutPanel contentTLP;
        private TableLayoutPanel buttonsTLP;
        private Button btnCancelar;
        private Button btnConfirmar;
        private Panel insumosPanel;
        private TableLayoutPanel insumosTLP;
        private Panel pedidoPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel listaTLP;
    }
}
namespace ClinicaSePriseApp.Vistas
{
    partial class AdmGTGestionAgendas
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
            mainTLP = new TableLayoutPanel();
            menuTLP = new TableLayoutPanel();
            picLogo = new PictureBox();
            btnVolver = new Button();
            btnSobreturno = new Button();
            btnEliminar = new Button();
            btnGenerar = new Button();
            contentTLP = new TableLayoutPanel();
            contentLbl = new Label();
            profesionalTLP = new TableLayoutPanel();
            btnBuscarProf = new Button();
            cboxContainerTLP = new TableLayoutPanel();
            profesionalCbx = new ComboBox();
            dataViewTLP = new TableLayoutPanel();
            calendarTLP = new TableLayoutPanel();
            calendarWeekTLP = new TableLayoutPanel();
            lblDomingo = new Label();
            lblSabado = new Label();
            lblViernes = new Label();
            lblJueves = new Label();
            lblMiercoles = new Label();
            lblMartes = new Label();
            lblLunes = new Label();
            calendarMonthTLP = new TableLayoutPanel();
            lblMes = new Label();
            btnMesSiguiente = new Button();
            btnMesAnterior = new Button();
            calendarDaysTLP = new TableLayoutPanel();
            AgendaContainerTLP = new TableLayoutPanel();
            AgendaHeadersTLP = new TableLayoutPanel();
            lblAgendaEstado = new Label();
            lblAgendaHora = new Label();
            lblFechaAgenda = new Label();
            AgendaScroll = new Panel();
            AgendaDataTLP = new TableLayoutPanel();
            mainTLP.SuspendLayout();
            menuTLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            contentTLP.SuspendLayout();
            profesionalTLP.SuspendLayout();
            cboxContainerTLP.SuspendLayout();
            dataViewTLP.SuspendLayout();
            calendarTLP.SuspendLayout();
            calendarWeekTLP.SuspendLayout();
            calendarMonthTLP.SuspendLayout();
            AgendaContainerTLP.SuspendLayout();
            AgendaHeadersTLP.SuspendLayout();
            AgendaScroll.SuspendLayout();
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
            mainTLP.TabIndex = 2;
            // 
            // menuTLP
            // 
            menuTLP.BackColor = SystemColors.GradientInactiveCaption;
            menuTLP.ColumnCount = 1;
            menuTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            menuTLP.Controls.Add(picLogo, 0, 0);
            menuTLP.Controls.Add(btnVolver, 0, 8);
            menuTLP.Controls.Add(btnSobreturno, 0, 6);
            menuTLP.Controls.Add(btnEliminar, 0, 4);
            menuTLP.Controls.Add(btnGenerar, 0, 2);
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
            btnVolver.BackColor = Color.Pink;
            btnVolver.Dock = DockStyle.Fill;
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(0, 602);
            btnVolver.Margin = new Padding(0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(252, 57);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "VOLVER A TURNOS";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnSobreturno
            // 
            btnSobreturno.BackColor = Color.CornflowerBlue;
            btnSobreturno.Dock = DockStyle.Fill;
            btnSobreturno.ForeColor = Color.White;
            btnSobreturno.Location = new Point(0, 459);
            btnSobreturno.Margin = new Padding(0);
            btnSobreturno.Name = "btnSobreturno";
            btnSobreturno.Size = new Size(252, 57);
            btnSobreturno.TabIndex = 2;
            btnSobreturno.Text = "GENERAR SOBRETURNO";
            btnSobreturno.UseVisualStyleBackColor = false;
            btnSobreturno.Click += btnSobreturno_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.CornflowerBlue;
            btnEliminar.Dock = DockStyle.Fill;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(0, 359);
            btnEliminar.Margin = new Padding(0);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(252, 57);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "ELIMINAR AGENDA";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.CornflowerBlue;
            btnGenerar.Dock = DockStyle.Fill;
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Location = new Point(0, 259);
            btnGenerar.Margin = new Padding(0);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(252, 57);
            btnGenerar.TabIndex = 9;
            btnGenerar.Text = "GENERAR AGENDA";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // contentTLP
            // 
            contentTLP.ColumnCount = 1;
            contentTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            contentTLP.Controls.Add(contentLbl, 0, 1);
            contentTLP.Controls.Add(profesionalTLP, 0, 3);
            contentTLP.Controls.Add(dataViewTLP, 0, 5);
            contentTLP.Dock = DockStyle.Fill;
            contentTLP.Location = new Point(0, 0);
            contentTLP.Margin = new Padding(0);
            contentTLP.Name = "contentTLP";
            contentTLP.RowCount = 7;
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 66F));
            contentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
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
            contentLbl.Text = "    GESTION DE AGENDAS";
            contentLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // profesionalTLP
            // 
            profesionalTLP.ColumnCount = 5;
            profesionalTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3F));
            profesionalTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            profesionalTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            profesionalTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            profesionalTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53F));
            profesionalTLP.Controls.Add(btnBuscarProf, 3, 0);
            profesionalTLP.Controls.Add(cboxContainerTLP, 1, 0);
            profesionalTLP.Dock = DockStyle.Fill;
            profesionalTLP.Location = new Point(0, 136);
            profesionalTLP.Margin = new Padding(0);
            profesionalTLP.Name = "profesionalTLP";
            profesionalTLP.RowCount = 1;
            profesionalTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            profesionalTLP.Size = new Size(754, 50);
            profesionalTLP.TabIndex = 1;
            // 
            // btnBuscarProf
            // 
            btnBuscarProf.BackgroundImage = Properties.Resources.icon_lupa;
            btnBuscarProf.BackgroundImageLayout = ImageLayout.Zoom;
            btnBuscarProf.ForeColor = SystemColors.ControlText;
            btnBuscarProf.Location = new Point(278, 0);
            btnBuscarProf.Margin = new Padding(0);
            btnBuscarProf.Name = "btnBuscarProf";
            btnBuscarProf.Padding = new Padding(6);
            btnBuscarProf.Size = new Size(75, 50);
            btnBuscarProf.TabIndex = 7;
            btnBuscarProf.UseVisualStyleBackColor = true;
            btnBuscarProf.Click += btnBuscarProf_Click;
            // 
            // cboxContainerTLP
            // 
            cboxContainerTLP.ColumnCount = 1;
            cboxContainerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            cboxContainerTLP.Controls.Add(profesionalCbx, 0, 1);
            cboxContainerTLP.Dock = DockStyle.Fill;
            cboxContainerTLP.Location = new Point(22, 0);
            cboxContainerTLP.Margin = new Padding(0);
            cboxContainerTLP.Name = "cboxContainerTLP";
            cboxContainerTLP.RowCount = 3;
            cboxContainerTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 17F));
            cboxContainerTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 66F));
            cboxContainerTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 17F));
            cboxContainerTLP.Size = new Size(226, 50);
            cboxContainerTLP.TabIndex = 8;
            // 
            // profesionalCbx
            // 
            profesionalCbx.Dock = DockStyle.Fill;
            profesionalCbx.Font = new Font("LEMON MILK", 7.8F);
            profesionalCbx.FormattingEnabled = true;
            profesionalCbx.Location = new Point(3, 11);
            profesionalCbx.Name = "profesionalCbx";
            profesionalCbx.Size = new Size(220, 27);
            profesionalCbx.TabIndex = 6;
            // 
            // dataViewTLP
            // 
            dataViewTLP.BackColor = SystemColors.Control;
            dataViewTLP.ColumnCount = 5;
            dataViewTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            dataViewTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56F));
            dataViewTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            dataViewTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41F));
            dataViewTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            dataViewTLP.Controls.Add(calendarTLP, 1, 0);
            dataViewTLP.Controls.Add(AgendaContainerTLP, 3, 0);
            dataViewTLP.Dock = DockStyle.Fill;
            dataViewTLP.Location = new Point(0, 214);
            dataViewTLP.Margin = new Padding(0);
            dataViewTLP.Name = "dataViewTLP";
            dataViewTLP.RowCount = 1;
            dataViewTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            dataViewTLP.Size = new Size(754, 475);
            dataViewTLP.TabIndex = 2;
            // 
            // calendarTLP
            // 
            calendarTLP.ColumnCount = 1;
            calendarTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            calendarTLP.Controls.Add(calendarWeekTLP, 0, 1);
            calendarTLP.Controls.Add(calendarMonthTLP, 0, 0);
            calendarTLP.Controls.Add(calendarDaysTLP, 0, 2);
            calendarTLP.Dock = DockStyle.Fill;
            calendarTLP.Location = new Point(7, 0);
            calendarTLP.Margin = new Padding(0);
            calendarTLP.Name = "calendarTLP";
            calendarTLP.RowCount = 3;
            calendarTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 7.5F));
            calendarTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 7.5F));
            calendarTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            calendarTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            calendarTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            calendarTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            calendarTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            calendarTLP.Size = new Size(422, 475);
            calendarTLP.TabIndex = 0;
            // 
            // calendarWeekTLP
            // 
            calendarWeekTLP.ColumnCount = 7;
            calendarWeekTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            calendarWeekTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            calendarWeekTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            calendarWeekTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            calendarWeekTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            calendarWeekTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            calendarWeekTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            calendarWeekTLP.Controls.Add(lblDomingo, 6, 0);
            calendarWeekTLP.Controls.Add(lblSabado, 5, 0);
            calendarWeekTLP.Controls.Add(lblViernes, 4, 0);
            calendarWeekTLP.Controls.Add(lblJueves, 3, 0);
            calendarWeekTLP.Controls.Add(lblMiercoles, 2, 0);
            calendarWeekTLP.Controls.Add(lblMartes, 1, 0);
            calendarWeekTLP.Controls.Add(lblLunes, 0, 0);
            calendarWeekTLP.Dock = DockStyle.Fill;
            calendarWeekTLP.Location = new Point(0, 35);
            calendarWeekTLP.Margin = new Padding(0);
            calendarWeekTLP.Name = "calendarWeekTLP";
            calendarWeekTLP.RowCount = 1;
            calendarWeekTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            calendarWeekTLP.Size = new Size(422, 35);
            calendarWeekTLP.TabIndex = 0;
            // 
            // lblDomingo
            // 
            lblDomingo.AutoSize = true;
            lblDomingo.Dock = DockStyle.Fill;
            lblDomingo.Location = new Point(360, 0);
            lblDomingo.Margin = new Padding(0);
            lblDomingo.Name = "lblDomingo";
            lblDomingo.Size = new Size(62, 35);
            lblDomingo.TabIndex = 6;
            lblDomingo.Text = "DOM";
            lblDomingo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSabado
            // 
            lblSabado.AutoSize = true;
            lblSabado.Dock = DockStyle.Fill;
            lblSabado.Location = new Point(300, 0);
            lblSabado.Margin = new Padding(0);
            lblSabado.Name = "lblSabado";
            lblSabado.Size = new Size(60, 35);
            lblSabado.TabIndex = 5;
            lblSabado.Text = "SAB";
            lblSabado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblViernes
            // 
            lblViernes.AutoSize = true;
            lblViernes.Dock = DockStyle.Fill;
            lblViernes.Location = new Point(240, 0);
            lblViernes.Margin = new Padding(0);
            lblViernes.Name = "lblViernes";
            lblViernes.Size = new Size(60, 35);
            lblViernes.TabIndex = 4;
            lblViernes.Text = "VIE";
            lblViernes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblJueves
            // 
            lblJueves.AutoSize = true;
            lblJueves.Dock = DockStyle.Fill;
            lblJueves.Location = new Point(180, 0);
            lblJueves.Margin = new Padding(0);
            lblJueves.Name = "lblJueves";
            lblJueves.Size = new Size(60, 35);
            lblJueves.TabIndex = 3;
            lblJueves.Text = "JUE";
            lblJueves.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMiercoles
            // 
            lblMiercoles.AutoSize = true;
            lblMiercoles.Dock = DockStyle.Fill;
            lblMiercoles.Location = new Point(120, 0);
            lblMiercoles.Margin = new Padding(0);
            lblMiercoles.Name = "lblMiercoles";
            lblMiercoles.Size = new Size(60, 35);
            lblMiercoles.TabIndex = 2;
            lblMiercoles.Text = "MIE";
            lblMiercoles.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMartes
            // 
            lblMartes.AutoSize = true;
            lblMartes.Dock = DockStyle.Fill;
            lblMartes.Location = new Point(60, 0);
            lblMartes.Margin = new Padding(0);
            lblMartes.Name = "lblMartes";
            lblMartes.Size = new Size(60, 35);
            lblMartes.TabIndex = 1;
            lblMartes.Text = "MAR";
            lblMartes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLunes
            // 
            lblLunes.AutoSize = true;
            lblLunes.Dock = DockStyle.Fill;
            lblLunes.Location = new Point(0, 0);
            lblLunes.Margin = new Padding(0);
            lblLunes.Name = "lblLunes";
            lblLunes.Size = new Size(60, 35);
            lblLunes.TabIndex = 0;
            lblLunes.Text = "LUN";
            lblLunes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // calendarMonthTLP
            // 
            calendarMonthTLP.ColumnCount = 5;
            calendarMonthTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            calendarMonthTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            calendarMonthTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            calendarMonthTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            calendarMonthTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            calendarMonthTLP.Controls.Add(lblMes, 2, 0);
            calendarMonthTLP.Controls.Add(btnMesSiguiente, 3, 0);
            calendarMonthTLP.Controls.Add(btnMesAnterior, 1, 0);
            calendarMonthTLP.Dock = DockStyle.Fill;
            calendarMonthTLP.Location = new Point(0, 0);
            calendarMonthTLP.Margin = new Padding(0);
            calendarMonthTLP.Name = "calendarMonthTLP";
            calendarMonthTLP.RowCount = 1;
            calendarMonthTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            calendarMonthTLP.Size = new Size(422, 35);
            calendarMonthTLP.TabIndex = 1;
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.Dock = DockStyle.Fill;
            lblMes.Location = new Point(105, 0);
            lblMes.Margin = new Padding(0);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(211, 35);
            lblMes.TabIndex = 7;
            lblMes.Text = "MES";
            lblMes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMesSiguiente
            // 
            btnMesSiguiente.Dock = DockStyle.Fill;
            btnMesSiguiente.Location = new Point(316, 0);
            btnMesSiguiente.Margin = new Padding(0);
            btnMesSiguiente.Name = "btnMesSiguiente";
            btnMesSiguiente.Size = new Size(42, 35);
            btnMesSiguiente.TabIndex = 8;
            btnMesSiguiente.Text = ">";
            btnMesSiguiente.UseVisualStyleBackColor = true;
            btnMesSiguiente.Click += btnMesSiguiente_Click;
            // 
            // btnMesAnterior
            // 
            btnMesAnterior.Dock = DockStyle.Fill;
            btnMesAnterior.Location = new Point(63, 0);
            btnMesAnterior.Margin = new Padding(0);
            btnMesAnterior.Name = "btnMesAnterior";
            btnMesAnterior.Size = new Size(42, 35);
            btnMesAnterior.TabIndex = 9;
            btnMesAnterior.Text = "<";
            btnMesAnterior.UseVisualStyleBackColor = true;
            btnMesAnterior.Click += btnMesAnterior_Click;
            // 
            // calendarDaysTLP
            // 
            calendarDaysTLP.ColumnCount = 7;
            calendarDaysTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857113F));
            calendarDaysTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            calendarDaysTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            calendarDaysTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            calendarDaysTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            calendarDaysTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            calendarDaysTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            calendarDaysTLP.Dock = DockStyle.Fill;
            calendarDaysTLP.Location = new Point(0, 70);
            calendarDaysTLP.Margin = new Padding(0);
            calendarDaysTLP.Name = "calendarDaysTLP";
            calendarDaysTLP.RowCount = 6;
            calendarDaysTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            calendarDaysTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            calendarDaysTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            calendarDaysTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            calendarDaysTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            calendarDaysTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            calendarDaysTLP.Size = new Size(422, 405);
            calendarDaysTLP.TabIndex = 2;
            // 
            // AgendaContainerTLP
            // 
            AgendaContainerTLP.ColumnCount = 1;
            AgendaContainerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            AgendaContainerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            AgendaContainerTLP.Controls.Add(AgendaHeadersTLP, 0, 0);
            AgendaContainerTLP.Controls.Add(AgendaScroll, 0, 1);
            AgendaContainerTLP.Dock = DockStyle.Fill;
            AgendaContainerTLP.Location = new Point(436, 0);
            AgendaContainerTLP.Margin = new Padding(0);
            AgendaContainerTLP.Name = "AgendaContainerTLP";
            AgendaContainerTLP.RowCount = 2;
            AgendaContainerTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 7.15789461F));
            AgendaContainerTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 92.8421F));
            AgendaContainerTLP.Size = new Size(309, 475);
            AgendaContainerTLP.TabIndex = 1;
            // 
            // AgendaHeadersTLP
            // 
            AgendaHeadersTLP.ColumnCount = 5;
            AgendaHeadersTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            AgendaHeadersTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            AgendaHeadersTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            AgendaHeadersTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            AgendaHeadersTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            AgendaHeadersTLP.Controls.Add(lblAgendaEstado, 2, 0);
            AgendaHeadersTLP.Controls.Add(lblAgendaHora, 1, 0);
            AgendaHeadersTLP.Controls.Add(lblFechaAgenda, 0, 0);
            AgendaHeadersTLP.Dock = DockStyle.Fill;
            AgendaHeadersTLP.Location = new Point(0, 0);
            AgendaHeadersTLP.Margin = new Padding(0);
            AgendaHeadersTLP.Name = "AgendaHeadersTLP";
            AgendaHeadersTLP.RowCount = 1;
            AgendaHeadersTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            AgendaHeadersTLP.Size = new Size(309, 34);
            AgendaHeadersTLP.TabIndex = 0;
            // 
            // lblAgendaEstado
            // 
            lblAgendaEstado.AutoSize = true;
            lblAgendaEstado.Dock = DockStyle.Fill;
            lblAgendaEstado.Location = new Point(154, 0);
            lblAgendaEstado.Margin = new Padding(0);
            lblAgendaEstado.Name = "lblAgendaEstado";
            lblAgendaEstado.Size = new Size(77, 34);
            lblAgendaEstado.TabIndex = 2;
            lblAgendaEstado.Text = "ESTADO";
            lblAgendaEstado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAgendaHora
            // 
            lblAgendaHora.AutoSize = true;
            lblAgendaHora.Dock = DockStyle.Fill;
            lblAgendaHora.Location = new Point(77, 0);
            lblAgendaHora.Margin = new Padding(0);
            lblAgendaHora.Name = "lblAgendaHora";
            lblAgendaHora.Size = new Size(77, 34);
            lblAgendaHora.TabIndex = 1;
            lblAgendaHora.Text = "HORA";
            lblAgendaHora.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFechaAgenda
            // 
            lblFechaAgenda.AutoSize = true;
            lblFechaAgenda.Dock = DockStyle.Fill;
            lblFechaAgenda.Location = new Point(0, 0);
            lblFechaAgenda.Margin = new Padding(0);
            lblFechaAgenda.Name = "lblFechaAgenda";
            lblFechaAgenda.Size = new Size(77, 34);
            lblFechaAgenda.TabIndex = 0;
            lblFechaAgenda.Text = "FECHA";
            lblFechaAgenda.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AgendaScroll
            // 
            AgendaScroll.AutoSize = true;
            AgendaScroll.Controls.Add(AgendaDataTLP);
            AgendaScroll.Dock = DockStyle.Fill;
            AgendaScroll.Location = new Point(0, 34);
            AgendaScroll.Margin = new Padding(0);
            AgendaScroll.Name = "AgendaScroll";
            AgendaScroll.Size = new Size(309, 441);
            AgendaScroll.TabIndex = 1;
            // 
            // AgendaDataTLP
            // 
            AgendaDataTLP.AutoScroll = true;
            AgendaDataTLP.ColumnCount = 5;
            AgendaDataTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            AgendaDataTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            AgendaDataTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            AgendaDataTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            AgendaDataTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            AgendaDataTLP.Dock = DockStyle.Top;
            AgendaDataTLP.Location = new Point(0, 0);
            AgendaDataTLP.Margin = new Padding(0);
            AgendaDataTLP.Name = "AgendaDataTLP";
            AgendaDataTLP.RowCount = 1;
            AgendaDataTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            AgendaDataTLP.Size = new Size(309, 441);
            AgendaDataTLP.TabIndex = 0;
            // 
            // AdmGTGestionAgendas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(mainTLP);
            MinimumSize = new Size(1024, 768);
            Name = "AdmGTGestionAgendas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clinica SePrise  ||  Gestion de Agendas ";
            WindowState = FormWindowState.Maximized;
            Load += AdmGTGestionAgendas_Load;
            mainTLP.ResumeLayout(false);
            menuTLP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            contentTLP.ResumeLayout(false);
            contentTLP.PerformLayout();
            profesionalTLP.ResumeLayout(false);
            cboxContainerTLP.ResumeLayout(false);
            dataViewTLP.ResumeLayout(false);
            calendarTLP.ResumeLayout(false);
            calendarWeekTLP.ResumeLayout(false);
            calendarWeekTLP.PerformLayout();
            calendarMonthTLP.ResumeLayout(false);
            calendarMonthTLP.PerformLayout();
            AgendaContainerTLP.ResumeLayout(false);
            AgendaContainerTLP.PerformLayout();
            AgendaHeadersTLP.ResumeLayout(false);
            AgendaHeadersTLP.PerformLayout();
            AgendaScroll.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTLP;
        private TableLayoutPanel menuTLP;
        private PictureBox picLogo;
        private Button btnVolver;
        private Button btnSobreturno;
        private Button btnEliminar;
        private Button btnGenerar;
        private TableLayoutPanel contentTLP;
        private Label contentLbl;
        private TableLayoutPanel profesionalTLP;
        private TableLayoutPanel dataViewTLP;
        private TableLayoutPanel calendarTLP;
        private TableLayoutPanel calendarWeekTLP;
        private TableLayoutPanel calendarMonthTLP;
        private TableLayoutPanel calendarDaysTLP;
        private ComboBox profesionalCbx;
        private Button btnBuscarProf;
        private TableLayoutPanel cboxContainerTLP;
        private Label lblSabado;
        private Label lblViernes;
        private Label lblJueves;
        private Label lblMiercoles;
        private Label lblMartes;
        private Label lblLunes;
        private Label lblDomingo;
        private Label lblMes;
        private Button btnMesSiguiente;
        private Button btnMesAnterior;
        private TableLayoutPanel AgendaContainerTLP;
        private TableLayoutPanel AgendaHeadersTLP;
        private Label lblFechaAgenda;
        private Label lblAgendaEstado;
        private Label lblAgendaHora;
        private Panel AgendaScroll;
        private TableLayoutPanel AgendaDataTLP;
    }
}
namespace WinFormsApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageLoad = new System.Windows.Forms.TabPage();
            this.pnlGraphMain = new System.Windows.Forms.Panel();
            this.btnRedrawGraph = new System.Windows.Forms.Button();
            this.chkShowWeights = new System.Windows.Forms.CheckBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.btnLoadGraph = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.tabPageLab4 = new System.Windows.Forms.TabPage();
            this.pnlGraphLab4 = new System.Windows.Forms.Panel();
            this.txtLab4Output = new System.Windows.Forms.TextBox();
            this.btnLab4Run = new System.Windows.Forms.Button();
            this.txtLab4Target = new System.Windows.Forms.TextBox();
            this.lblLab4Target = new System.Windows.Forms.Label();
            this.txtLab4Start = new System.Windows.Forms.TextBox();
            this.lblLab4Start = new System.Windows.Forms.Label();
            this.tabPageLab5 = new System.Windows.Forms.TabPage();
            this.pnlGraphLab5 = new System.Windows.Forms.Panel();
            this.txtLab5Output = new System.Windows.Forms.TextBox();
            this.btnLab5Run = new System.Windows.Forms.Button();
            this.txtLab5Target = new System.Windows.Forms.TextBox();
            this.lblLab5Target = new System.Windows.Forms.Label();
            this.txtLab5Start = new System.Windows.Forms.TextBox();
            this.lblLab5Start = new System.Windows.Forms.Label();
            this.tabPageLab6 = new System.Windows.Forms.TabPage();
            this.pnlGraphLab6 = new System.Windows.Forms.Panel();
            this.txtLab6Output = new System.Windows.Forms.TextBox();
            this.btnLab6Run = new System.Windows.Forms.Button();
            this.txtLab6Hospitals = new System.Windows.Forms.TextBox();
            this.lblLab6Hospitals = new System.Windows.Forms.Label();
            this.txtLab6Start = new System.Windows.Forms.TextBox();
            this.lblLab6Start = new System.Windows.Forms.Label();
            this.tabPageCompare = new System.Windows.Forms.TabPage();
            this.dgvCompare = new System.Windows.Forms.DataGridView();
            this.btnCompare = new System.Windows.Forms.Button();
            this.txtCompareTarget = new System.Windows.Forms.TextBox();
            this.lblCompareTarget = new System.Windows.Forms.Label();
            this.txtCompareStart = new System.Windows.Forms.TextBox();
            this.lblCompareStart = new System.Windows.Forms.Label();
            this.colAlgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabPageLoad.SuspendLayout();
            this.tabPageLab4.SuspendLayout();
            this.tabPageLab5.SuspendLayout();
            this.tabPageLab6.SuspendLayout();
            this.tabPageCompare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompare)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageLoad);
            this.tabControl.Controls.Add(this.tabPageLab4);
            this.tabControl.Controls.Add(this.tabPageLab5);
            this.tabControl.Controls.Add(this.tabPageLab6);
            this.tabControl.Controls.Add(this.tabPageCompare);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1000, 700);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageLoad
            // 
            this.tabPageLoad.Controls.Add(this.pnlGraphMain);
            this.tabPageLoad.Controls.Add(this.btnRedrawGraph);
            this.tabPageLoad.Controls.Add(this.chkShowWeights);
            this.tabPageLoad.Controls.Add(this.lblStatus);
            this.tabPageLoad.Controls.Add(this.btnBrowseFile);
            this.tabPageLoad.Controls.Add(this.btnLoadGraph);
            this.tabPageLoad.Controls.Add(this.txtFilePath);
            this.tabPageLoad.Controls.Add(this.lblFilePath);
            this.tabPageLoad.Location = new System.Drawing.Point(4, 29);
            this.tabPageLoad.Name = "tabPageLoad";
            this.tabPageLoad.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLoad.Size = new System.Drawing.Size(992, 667);
            this.tabPageLoad.TabIndex = 0;
            this.tabPageLoad.Text = "1. Загрузка графа";
            this.tabPageLoad.UseVisualStyleBackColor = true;
            // 
            // pnlGraphMain
            // 
            this.pnlGraphMain.BackColor = System.Drawing.Color.White;
            this.pnlGraphMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGraphMain.Location = new System.Drawing.Point(20, 130);
            this.pnlGraphMain.Name = "pnlGraphMain";
            this.pnlGraphMain.Size = new System.Drawing.Size(950, 510);
            this.pnlGraphMain.TabIndex = 7;
            this.pnlGraphMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGraphMain_Paint);
            // 
            // btnRedrawGraph
            // 
            this.btnRedrawGraph.Location = new System.Drawing.Point(200, 90);
            this.btnRedrawGraph.Name = "btnRedrawGraph";
            this.btnRedrawGraph.Size = new System.Drawing.Size(120, 30);
            this.btnRedrawGraph.TabIndex = 6;
            this.btnRedrawGraph.Text = "Обновить вид";
            this.btnRedrawGraph.UseVisualStyleBackColor = true;
            this.btnRedrawGraph.Click += new System.EventHandler(this.btnRedrawGraph_Click);
            // 
            // chkShowWeights
            // 
            this.chkShowWeights.AutoSize = true;
            this.chkShowWeights.Location = new System.Drawing.Point(20, 95);
            this.chkShowWeights.Name = "chkShowWeights";
            this.chkShowWeights.Size = new System.Drawing.Size(164, 21);
            this.chkShowWeights.TabIndex = 5;
            this.chkShowWeights.Text = "Показать веса рёбер";
            this.chkShowWeights.UseVisualStyleBackColor = true;
            this.chkShowWeights.CheckedChanged += new System.EventHandler(this.chkShowWeights_CheckedChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(20, 60);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(143, 20);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Статус: Не загружен";
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Location = new System.Drawing.Point(770, 15);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(100, 30);
            this.btnBrowseFile.TabIndex = 3;
            this.btnBrowseFile.Text = "Обзор...";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // btnLoadGraph
            // 
            this.btnLoadGraph.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnLoadGraph.FlatAppearance.BorderSize = 0;
            this.btnLoadGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadGraph.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLoadGraph.ForeColor = System.Drawing.Color.White;
            this.btnLoadGraph.Location = new System.Drawing.Point(640, 15);
            this.btnLoadGraph.Name = "btnLoadGraph";
            this.btnLoadGraph.Size = new System.Drawing.Size(120, 30);
            this.btnLoadGraph.TabIndex = 2;
            this.btnLoadGraph.Text = "Загрузить";
            this.btnLoadGraph.UseVisualStyleBackColor = false;
            this.btnLoadGraph.Click += new System.EventHandler(this.btnLoadGraph_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(120, 17);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(500, 25);
            this.txtFilePath.TabIndex = 1;
            this.txtFilePath.Text = "graph.txt";
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(20, 20);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(80, 19);
            this.lblFilePath.TabIndex = 0;
            this.lblFilePath.Text = "Файл графа:";
            // 
            // tabPageLab4
            // 
            this.tabPageLab4.Controls.Add(this.pnlGraphLab4);
            this.tabPageLab4.Controls.Add(this.txtLab4Output);
            this.tabPageLab4.Controls.Add(this.btnLab4Run);
            this.tabPageLab4.Controls.Add(this.txtLab4Target);
            this.tabPageLab4.Controls.Add(this.lblLab4Target);
            this.tabPageLab4.Controls.Add(this.txtLab4Start);
            this.tabPageLab4.Controls.Add(this.lblLab4Start);
            this.tabPageLab4.Location = new System.Drawing.Point(4, 29);
            this.tabPageLab4.Name = "tabPageLab4";
            this.tabPageLab4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLab4.Size = new System.Drawing.Size(992, 667);
            this.tabPageLab4.TabIndex = 1;
            this.tabPageLab4.Text = "2. ЛР 4: Обход";
            this.tabPageLab4.UseVisualStyleBackColor = true;
            // 
            // pnlGraphLab4
            // 
            this.pnlGraphLab4.BackColor = System.Drawing.Color.White;
            this.pnlGraphLab4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGraphLab4.Location = new System.Drawing.Point(20, 320);
            this.pnlGraphLab4.Name = "pnlGraphLab4";
            this.pnlGraphLab4.Size = new System.Drawing.Size(950, 320);
            this.pnlGraphLab4.TabIndex = 8;
            this.pnlGraphLab4.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGraphLab4_Paint);
            // 
            // txtLab4Output
            // 
            this.txtLab4Output.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtLab4Output.Location = new System.Drawing.Point(20, 60);
            this.txtLab4Output.Multiline = true;
            this.txtLab4Output.Name = "txtLab4Output";
            this.txtLab4Output.ReadOnly = true;
            this.txtLab4Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLab4Output.Size = new System.Drawing.Size(950, 250);
            this.txtLab4Output.TabIndex = 5;
            // 
            // btnLab4Run
            // 
            this.btnLab4Run.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnLab4Run.FlatAppearance.BorderSize = 0;
            this.btnLab4Run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLab4Run.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLab4Run.ForeColor = System.Drawing.Color.White;
            this.btnLab4Run.Location = new System.Drawing.Point(480, 15);
            this.btnLab4Run.Name = "btnLab4Run";
            this.btnLab4Run.Size = new System.Drawing.Size(150, 30);
            this.btnLab4Run.TabIndex = 4;
            this.btnLab4Run.Text = "Запустить BFS/DFS";
            this.btnLab4Run.UseVisualStyleBackColor = false;
            this.btnLab4Run.Click += new System.EventHandler(this.btnLab4Run_Click);
            // 
            // txtLab4Target
            // 
            this.txtLab4Target.Location = new System.Drawing.Point(310, 17);
            this.txtLab4Target.Name = "txtLab4Target";
            this.txtLab4Target.Size = new System.Drawing.Size(150, 25);
            this.txtLab4Target.TabIndex = 3;
            this.txtLab4Target.Text = "Hospital_South";
            // 
            // lblLab4Target
            // 
            this.lblLab4Target.AutoSize = true;
            this.lblLab4Target.Location = new System.Drawing.Point(250, 20);
            this.lblLab4Target.Name = "lblLab4Target";
            this.lblLab4Target.Size = new System.Drawing.Size(40, 19);
            this.lblLab4Target.TabIndex = 2;
            this.lblLab4Target.Text = "Цель:";
            // 
            // txtLab4Start
            // 
            this.txtLab4Start.Location = new System.Drawing.Point(80, 17);
            this.txtLab4Start.Name = "txtLab4Start";
            this.txtLab4Start.Size = new System.Drawing.Size(150, 25);
            this.txtLab4Start.TabIndex = 1;
            this.txtLab4Start.Text = "Hospital_Central";
            // 
            // lblLab4Start
            // 
            this.lblLab4Start.AutoSize = true;
            this.lblLab4Start.Location = new System.Drawing.Point(20, 20);
            this.lblLab4Start.Name = "lblLab4Start";
            this.lblLab4Start.Size = new System.Drawing.Size(46, 19);
            this.lblLab4Start.TabIndex = 0;
            this.lblLab4Start.Text = "Старт:";
            // 
            // tabPageLab5
            // 
            this.tabPageLab5.Controls.Add(this.pnlGraphLab5);
            this.tabPageLab5.Controls.Add(this.txtLab5Output);
            this.tabPageLab5.Controls.Add(this.btnLab5Run);
            this.tabPageLab5.Controls.Add(this.txtLab5Target);
            this.tabPageLab5.Controls.Add(this.lblLab5Target);
            this.tabPageLab5.Controls.Add(this.txtLab5Start);
            this.tabPageLab5.Controls.Add(this.lblLab5Start);
            this.tabPageLab5.Location = new System.Drawing.Point(4, 29);
            this.tabPageLab5.Name = "tabPageLab5";
            this.tabPageLab5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLab5.Size = new System.Drawing.Size(992, 667);
            this.tabPageLab5.TabIndex = 2;
            this.tabPageLab5.Text = "3. ЛР 5: Дейкстра";
            this.tabPageLab5.UseVisualStyleBackColor = true;
            // 
            // pnlGraphLab5
            // 
            this.pnlGraphLab5.BackColor = System.Drawing.Color.White;
            this.pnlGraphLab5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGraphLab5.Location = new System.Drawing.Point(20, 320);
            this.pnlGraphLab5.Name = "pnlGraphLab5";
            this.pnlGraphLab5.Size = new System.Drawing.Size(950, 320);
            this.pnlGraphLab5.TabIndex = 9;
            this.pnlGraphLab5.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGraphLab5_Paint);
            // 
            // txtLab5Output
            // 
            this.txtLab5Output.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtLab5Output.Location = new System.Drawing.Point(20, 60);
            this.txtLab5Output.Multiline = true;
            this.txtLab5Output.Name = "txtLab5Output";
            this.txtLab5Output.ReadOnly = true;
            this.txtLab5Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLab5Output.Size = new System.Drawing.Size(950, 250);
            this.txtLab5Output.TabIndex = 5;
            // 
            // btnLab5Run
            // 
            this.btnLab5Run.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnLab5Run.FlatAppearance.BorderSize = 0;
            this.btnLab5Run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLab5Run.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLab5Run.ForeColor = System.Drawing.Color.White;
            this.btnLab5Run.Location = new System.Drawing.Point(480, 15);
            this.btnLab5Run.Name = "btnLab5Run";
            this.btnLab5Run.Size = new System.Drawing.Size(150, 30);
            this.btnLab5Run.TabIndex = 4;
            this.btnLab5Run.Text = "Запустить Дейкстру";
            this.btnLab5Run.UseVisualStyleBackColor = false;
            this.btnLab5Run.Click += new System.EventHandler(this.btnLab5Run_Click);
            // 
            // txtLab5Target
            // 
            this.txtLab5Target.Location = new System.Drawing.Point(310, 17);
            this.txtLab5Target.Name = "txtLab5Target";
            this.txtLab5Target.Size = new System.Drawing.Size(150, 25);
            this.txtLab5Target.TabIndex = 3;
            this.txtLab5Target.Text = "MedPoint_7";
            // 
            // lblLab5Target
            // 
            this.lblLab5Target.AutoSize = true;
            this.lblLab5Target.Location = new System.Drawing.Point(250, 20);
            this.lblLab5Target.Name = "lblLab5Target";
            this.lblLab5Target.Size = new System.Drawing.Size(40, 19);
            this.lblLab5Target.TabIndex = 2;
            this.lblLab5Target.Text = "Цель:";
            // 
            // txtLab5Start
            // 
            this.txtLab5Start.Location = new System.Drawing.Point(80, 17);
            this.txtLab5Start.Name = "txtLab5Start";
            this.txtLab5Start.Size = new System.Drawing.Size(150, 25);
            this.txtLab5Start.TabIndex = 1;
            this.txtLab5Start.Text = "Hospital_Central";
            // 
            // lblLab5Start
            // 
            this.lblLab5Start.AutoSize = true;
            this.lblLab5Start.Location = new System.Drawing.Point(20, 20);
            this.lblLab5Start.Name = "lblLab5Start";
            this.lblLab5Start.Size = new System.Drawing.Size(46, 19);
            this.lblLab5Start.TabIndex = 0;
            this.lblLab5Start.Text = "Старт:";
            // 
            // tabPageLab6
            // 
            this.tabPageLab6.Controls.Add(this.pnlGraphLab6);
            this.tabPageLab6.Controls.Add(this.txtLab6Output);
            this.tabPageLab6.Controls.Add(this.btnLab6Run);
            this.tabPageLab6.Controls.Add(this.txtLab6Hospitals);
            this.tabPageLab6.Controls.Add(this.lblLab6Hospitals);
            this.tabPageLab6.Controls.Add(this.txtLab6Start);
            this.tabPageLab6.Controls.Add(this.lblLab6Start);
            this.tabPageLab6.Location = new System.Drawing.Point(4, 29);
            this.tabPageLab6.Name = "tabPageLab6";
            this.tabPageLab6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLab6.Size = new System.Drawing.Size(992, 667);
            this.tabPageLab6.TabIndex = 3;
            this.tabPageLab6.Text = "4. ЛР 6: Анализ";
            this.tabPageLab6.UseVisualStyleBackColor = true;
            // 
            // pnlGraphLab6
            // 
            this.pnlGraphLab6.BackColor = System.Drawing.Color.White;
            this.pnlGraphLab6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGraphLab6.Location = new System.Drawing.Point(20, 320);
            this.pnlGraphLab6.Name = "pnlGraphLab6";
            this.pnlGraphLab6.Size = new System.Drawing.Size(950, 320);
            this.pnlGraphLab6.TabIndex = 10;
            this.pnlGraphLab6.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGraphLab6_Paint);
            // 
            // txtLab6Output
            // 
            this.txtLab6Output.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtLab6Output.Location = new System.Drawing.Point(20, 60);
            this.txtLab6Output.Multiline = true;
            this.txtLab6Output.Name = "txtLab6Output";
            this.txtLab6Output.ReadOnly = true;
            this.txtLab6Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLab6Output.Size = new System.Drawing.Size(950, 250);
            this.txtLab6Output.TabIndex = 5;
            // 
            // btnLab6Run
            // 
            this.btnLab6Run.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnLab6Run.FlatAppearance.BorderSize = 0;
            this.btnLab6Run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLab6Run.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLab6Run.ForeColor = System.Drawing.Color.White;
            this.btnLab6Run.Location = new System.Drawing.Point(740, 15);
            this.btnLab6Run.Name = "btnLab6Run";
            this.btnLab6Run.Size = new System.Drawing.Size(200, 30);
            this.btnLab6Run.TabIndex = 4;
            this.btnLab6Run.Text = "Анализ (Точки/МОД)";
            this.btnLab6Run.UseVisualStyleBackColor = false;
            this.btnLab6Run.Click += new System.EventHandler(this.btnLab6Run_Click);
            // 
            // txtLab6Hospitals
            // 
            this.txtLab6Hospitals.Location = new System.Drawing.Point(420, 17);
            this.txtLab6Hospitals.Name = "txtLab6Hospitals";
            this.txtLab6Hospitals.Size = new System.Drawing.Size(300, 25);
            this.txtLab6Hospitals.TabIndex = 3;
            this.txtLab6Hospitals.Text = "Hospital_Central,Hospital_North,Hospital_South";
            // 
            // lblLab6Hospitals
            // 
            this.lblLab6Hospitals.AutoSize = true;
            this.lblLab6Hospitals.Location = new System.Drawing.Point(330, 20);
            this.lblLab6Hospitals.Name = "lblLab6Hospitals";
            this.lblLab6Hospitals.Size = new System.Drawing.Size(76, 19);
            this.lblLab6Hospitals.TabIndex = 2;
            this.lblLab6Hospitals.Text = "Больницы:";
            // 
            // txtLab6Start
            // 
            this.txtLab6Start.Location = new System.Drawing.Point(160, 17);
            this.txtLab6Start.Name = "txtLab6Start";
            this.txtLab6Start.Size = new System.Drawing.Size(150, 25);
            this.txtLab6Start.TabIndex = 1;
            this.txtLab6Start.Text = "MedPoint_4";
            // 
            // lblLab6Start
            // 
            this.lblLab6Start.AutoSize = true;
            this.lblLab6Start.Location = new System.Drawing.Point(20, 20);
            this.lblLab6Start.Name = "lblLab6Start";
            this.lblLab6Start.Size = new System.Drawing.Size(121, 19);
            this.lblLab6Start.TabIndex = 0;
            this.lblLab6Start.Text = "Местоположение:";
            // 
            // tabPageCompare
            // 
            this.tabPageCompare.Controls.Add(this.dgvCompare);
            this.tabPageCompare.Controls.Add(this.btnCompare);
            this.tabPageCompare.Controls.Add(this.txtCompareTarget);
            this.tabPageCompare.Controls.Add(this.lblCompareTarget);
            this.tabPageCompare.Controls.Add(this.txtCompareStart);
            this.tabPageCompare.Controls.Add(this.lblCompareStart);
            this.tabPageCompare.Location = new System.Drawing.Point(4, 29);
            this.tabPageCompare.Name = "tabPageCompare";
            this.tabPageCompare.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCompare.Size = new System.Drawing.Size(992, 667);
            this.tabPageCompare.TabIndex = 4;
            this.tabPageCompare.Text = "5. Сравнение";
            this.tabPageCompare.UseVisualStyleBackColor = true;
            // 
            // dgvCompare
            // 
            this.dgvCompare.AllowUserToAddRows = false;
            this.dgvCompare.BackgroundColor = System.Drawing.Color.White;
            this.dgvCompare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompare.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAlgo,
            this.colTime,
            this.colResult,
            this.colPath});
            this.dgvCompare.Location = new System.Drawing.Point(20, 60);
            this.dgvCompare.Name = "dgvCompare";
            this.dgvCompare.ReadOnly = true;
            this.dgvCompare.Size = new System.Drawing.Size(950, 580);
            this.dgvCompare.TabIndex = 5;
            // 
            // colAlgo
            // 
            this.colAlgo.HeaderText = "Алгоритм";
            this.colAlgo.Name = "colAlgo";
            this.colAlgo.ReadOnly = true;
            // 
            // colTime
            // 
            this.colTime.HeaderText = "Время (мс)";
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            // 
            // colResult
            // 
            this.colResult.HeaderText = "Результат";
            this.colResult.Name = "colResult";
            this.colResult.ReadOnly = true;
            // 
            // colPath
            // 
            this.colPath.HeaderText = "Найденный путь";
            this.colPath.Name = "colPath";
            this.colPath.ReadOnly = true;
            this.colPath.Width = 300;
            // 
            // btnCompare
            // 
            this.btnCompare.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnCompare.FlatAppearance.BorderSize = 0;
            this.btnCompare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompare.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCompare.ForeColor = System.Drawing.Color.White;
            this.btnCompare.Location = new System.Drawing.Point(480, 15);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(200, 30);
            this.btnCompare.TabIndex = 4;
            this.btnCompare.Text = "Сравнить алгоритмы";
            this.btnCompare.UseVisualStyleBackColor = false;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // txtCompareTarget
            // 
            this.txtCompareTarget.Location = new System.Drawing.Point(310, 17);
            this.txtCompareTarget.Name = "txtCompareTarget";
            this.txtCompareTarget.Size = new System.Drawing.Size(150, 25);
            this.txtCompareTarget.TabIndex = 3;
            this.txtCompareTarget.Text = "MedPoint_7";
            // 
            // lblCompareTarget
            // 
            this.lblCompareTarget.AutoSize = true;
            this.lblCompareTarget.Location = new System.Drawing.Point(260, 20);
            this.lblCompareTarget.Name = "lblCompareTarget";
            this.lblCompareTarget.Size = new System.Drawing.Size(46, 19);
            this.lblCompareTarget.TabIndex = 2;
            this.lblCompareTarget.Text = "Куда:";
            // 
            // txtCompareStart
            // 
            this.txtCompareStart.Location = new System.Drawing.Point(90, 17);
            this.txtCompareStart.Name = "txtCompareStart";
            this.txtCompareStart.Size = new System.Drawing.Size(150, 25);
            this.txtCompareStart.TabIndex = 1;
            this.txtCompareStart.Text = "Hospital_Central";
            // 
            // lblCompareStart
            // 
            this.lblCompareStart.AutoSize = true;
            this.lblCompareStart.Location = new System.Drawing.Point(20, 20);
            this.lblCompareStart.Name = "lblCompareStart";
            this.lblCompareStart.Size = new System.Drawing.Size(62, 19);
            this.lblCompareStart.TabIndex = 0;
            this.lblCompareStart.Text = "Откуда:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторные 4-6 | Вариант 17";
            this.tabControl.ResumeLayout(false);
            this.tabPageLoad.ResumeLayout(false);
            this.tabPageLoad.PerformLayout();
            this.tabPageLab4.ResumeLayout(false);
            this.tabPageLab4.PerformLayout();
            this.tabPageLab5.ResumeLayout(false);
            this.tabPageLab5.PerformLayout();
            this.tabPageLab6.ResumeLayout(false);
            this.tabPageLab6.PerformLayout();
            this.tabPageCompare.ResumeLayout(false);
            this.tabPageCompare.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompare)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageLoad;
        private System.Windows.Forms.TabPage tabPageLab4;
        private System.Windows.Forms.TabPage tabPageLab5;
        private System.Windows.Forms.TabPage tabPageLab6;
        private System.Windows.Forms.TabPage tabPageCompare;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnLoadGraph;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox chkShowWeights;
        private System.Windows.Forms.Button btnRedrawGraph;
        private System.Windows.Forms.Panel pnlGraphMain;
        private System.Windows.Forms.Label lblLab4Start;
        private System.Windows.Forms.TextBox txtLab4Start;
        private System.Windows.Forms.Label lblLab4Target;
        private System.Windows.Forms.TextBox txtLab4Target;
        private System.Windows.Forms.Button btnLab4Run;
        private System.Windows.Forms.TextBox txtLab4Output;
        private System.Windows.Forms.Panel pnlGraphLab4;
        private System.Windows.Forms.Label lblLab5Start;
        private System.Windows.Forms.TextBox txtLab5Start;
        private System.Windows.Forms.Label lblLab5Target;
        private System.Windows.Forms.TextBox txtLab5Target;
        private System.Windows.Forms.Button btnLab5Run;
        private System.Windows.Forms.TextBox txtLab5Output;
        private System.Windows.Forms.Panel pnlGraphLab5;
        private System.Windows.Forms.Label lblLab6Start;
        private System.Windows.Forms.TextBox txtLab6Start;
        private System.Windows.Forms.Label lblLab6Hospitals;
        private System.Windows.Forms.TextBox txtLab6Hospitals;
        private System.Windows.Forms.Button btnLab6Run;
        private System.Windows.Forms.TextBox txtLab6Output;
        private System.Windows.Forms.Panel pnlGraphLab6;
        private System.Windows.Forms.Label lblCompareStart;
        private System.Windows.Forms.TextBox txtCompareStart;
        private System.Windows.Forms.Label lblCompareTarget;
        private System.Windows.Forms.TextBox txtCompareTarget;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.DataGridView dgvCompare;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlgo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPath;
    }
}
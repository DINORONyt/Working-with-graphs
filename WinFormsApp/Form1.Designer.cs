namespace WinFormsApp;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.tabControl = new System.Windows.Forms.TabControl();
        this.tabPageLoad = new System.Windows.Forms.TabPage();
        this.pnlGraph = new System.Windows.Forms.Panel();
        this.lblStatus = new System.Windows.Forms.Label();
        this.btnBrowseFile = new System.Windows.Forms.Button();
        this.btnLoadGraph = new System.Windows.Forms.Button();
        this.txtFilePath = new System.Windows.Forms.TextBox();
        this.lblFilePath = new System.Windows.Forms.Label();
        this.tabPageLab4 = new System.Windows.Forms.TabPage();
        this.txtLab4Output = new System.Windows.Forms.TextBox();
        this.btnLab4Run = new System.Windows.Forms.Button();
        this.txtLab4Target = new System.Windows.Forms.TextBox();
        this.lblLab4Target = new System.Windows.Forms.Label();
        this.txtLab4Start = new System.Windows.Forms.TextBox();
        this.lblLab4Start = new System.Windows.Forms.Label();
        this.tabPageLab5 = new System.Windows.Forms.TabPage();
        this.txtLab5Output = new System.Windows.Forms.TextBox();
        this.btnLab5Run = new System.Windows.Forms.Button();
        this.txtLab5Target = new System.Windows.Forms.TextBox();
        this.lblLab5Target = new System.Windows.Forms.Label();
        this.txtLab5Start = new System.Windows.Forms.TextBox();
        this.lblLab5Start = new System.Windows.Forms.Label();
        this.tabPageLab6 = new System.Windows.Forms.TabPage();
        this.txtLab6Output = new System.Windows.Forms.TextBox();
        this.btnLab6Run = new System.Windows.Forms.Button();
        this.txtLab6Hospitals = new System.Windows.Forms.TextBox();
        this.lblLab6Hospitals = new System.Windows.Forms.Label();
        this.txtLab6Start = new System.Windows.Forms.TextBox();
        this.lblLab6Start = new System.Windows.Forms.Label();
        this.tabPageCompare = new System.Windows.Forms.TabPage();
        this.txtCompareOutput = new System.Windows.Forms.TextBox();
        this.btnCompare = new System.Windows.Forms.Button();
        this.txtCompareTarget = new System.Windows.Forms.TextBox();
        this.lblCompareTarget = new System.Windows.Forms.Label();
        this.txtCompareStart = new System.Windows.Forms.TextBox();
        this.lblCompareStart = new System.Windows.Forms.Label();
        this.btnRedrawGraph = new System.Windows.Forms.Button();
        this.chkShowWeights = new System.Windows.Forms.CheckBox();
        this.tabControl.SuspendLayout();
        this.tabPageLoad.SuspendLayout();
        this.tabPageLab4.SuspendLayout();
        this.tabPageLab5.SuspendLayout();
        this.tabPageLab6.SuspendLayout();
        this.tabPageCompare.SuspendLayout();
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
        this.tabControl.Location = new System.Drawing.Point(0, 0);
        this.tabControl.Name = "tabControl";
        this.tabControl.SelectedIndex = 0;
        this.tabControl.Size = new System.Drawing.Size(1100, 750);
        this.tabControl.TabIndex = 0;

        // 
        // tabPageLoad
        // 
        this.tabPageLoad.Controls.Add(this.pnlGraph);
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
        this.tabPageLoad.Size = new System.Drawing.Size(1092, 717);
        this.tabPageLoad.TabIndex = 0;
        this.tabPageLoad.Text = "Загрузка графа";
        this.tabPageLoad.UseVisualStyleBackColor = true;

        // 
        // lblFilePath
        // 
        this.lblFilePath.AutoSize = true;
        this.lblFilePath.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblFilePath.Location = new System.Drawing.Point(30, 20);
        this.lblFilePath.Name = "lblFilePath";
        this.lblFilePath.Size = new System.Drawing.Size(210, 23);
        this.lblFilePath.TabIndex = 0;
        this.lblFilePath.Text = "Путь к TXT файлу графа:";

        // 
        // txtFilePath
        // 
        this.txtFilePath.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.txtFilePath.Location = new System.Drawing.Point(30, 50);
        this.txtFilePath.Name = "txtFilePath";
        this.txtFilePath.Size = new System.Drawing.Size(550, 30);
        this.txtFilePath.TabIndex = 1;
        this.txtFilePath.Text = "graph.txt";

        // 
        // btnLoadGraph
        // 
        this.btnLoadGraph.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
        this.btnLoadGraph.FlatAppearance.BorderSize = 0;
        this.btnLoadGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnLoadGraph.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.btnLoadGraph.ForeColor = System.Drawing.Color.White;
        this.btnLoadGraph.Location = new System.Drawing.Point(600, 48);
        this.btnLoadGraph.Name = "btnLoadGraph";
        this.btnLoadGraph.Size = new System.Drawing.Size(140, 35);
        this.btnLoadGraph.TabIndex = 2;
        this.btnLoadGraph.Text = "Загрузить";
        this.btnLoadGraph.UseVisualStyleBackColor = false;
        this.btnLoadGraph.Click += new System.EventHandler(this.btnLoadGraph_Click);

        // 
        // btnBrowseFile
        // 
        this.btnBrowseFile.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
        this.btnBrowseFile.FlatAppearance.BorderSize = 0;
        this.btnBrowseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnBrowseFile.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.btnBrowseFile.ForeColor = System.Drawing.Color.White;
        this.btnBrowseFile.Location = new System.Drawing.Point(760, 48);
        this.btnBrowseFile.Name = "btnBrowseFile";
        this.btnBrowseFile.Size = new System.Drawing.Size(100, 35);
        this.btnBrowseFile.TabIndex = 3;
        this.btnBrowseFile.Text = "Обзор...";
        this.btnBrowseFile.UseVisualStyleBackColor = false;
        this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);

        // 
        // lblStatus
        // 
        this.lblStatus.AutoSize = true;
        this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.lblStatus.Location = new System.Drawing.Point(30, 95);
        this.lblStatus.Name = "lblStatus";
        this.lblStatus.Size = new System.Drawing.Size(0, 25);
        this.lblStatus.TabIndex = 4;

        // 
        // chkShowWeights
        // 
        this.chkShowWeights.AutoSize = true;
        this.chkShowWeights.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.chkShowWeights.Location = new System.Drawing.Point(300, 95);
        this.chkShowWeights.Name = "chkShowWeights";
        this.chkShowWeights.Size = new System.Drawing.Size(140, 27);
        this.chkShowWeights.TabIndex = 5;
        this.chkShowWeights.Text = "Показать веса";
        this.chkShowWeights.UseVisualStyleBackColor = true;
        this.chkShowWeights.CheckedChanged += new System.EventHandler(this.chkShowWeights_CheckedChanged);

        // 
        // btnRedrawGraph
        // 
        this.btnRedrawGraph.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
        this.btnRedrawGraph.FlatAppearance.BorderSize = 0;
        this.btnRedrawGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnRedrawGraph.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.btnRedrawGraph.ForeColor = System.Drawing.Color.White;
        this.btnRedrawGraph.Location = new System.Drawing.Point(460, 90);
        this.btnRedrawGraph.Name = "btnRedrawGraph";
        this.btnRedrawGraph.Size = new System.Drawing.Size(150, 35);
        this.btnRedrawGraph.TabIndex = 6;
        this.btnRedrawGraph.Text = "Перерисовать";
        this.btnRedrawGraph.UseVisualStyleBackColor = false;
        this.btnRedrawGraph.Click += new System.EventHandler(this.btnRedrawGraph_Click);

        // 
        // pnlGraph
        // 
        this.pnlGraph.BackColor = System.Drawing.Color.White;
        this.pnlGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlGraph.Location = new System.Drawing.Point(30, 140);
        this.pnlGraph.Name = "pnlGraph";
        this.pnlGraph.Size = new System.Drawing.Size(1030, 550);
        this.pnlGraph.TabIndex = 7;
        this.pnlGraph.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGraph_Paint);

        // 
        // tabPageLab4
        // 
        this.tabPageLab4.Controls.Add(this.txtLab4Output);
        this.tabPageLab4.Controls.Add(this.btnLab4Run);
        this.tabPageLab4.Controls.Add(this.txtLab4Target);
        this.tabPageLab4.Controls.Add(this.lblLab4Target);
        this.tabPageLab4.Controls.Add(this.txtLab4Start);
        this.tabPageLab4.Controls.Add(this.lblLab4Start);
        this.tabPageLab4.Location = new System.Drawing.Point(4, 29);
        this.tabPageLab4.Name = "tabPageLab4";
        this.tabPageLab4.Padding = new System.Windows.Forms.Padding(3);
        this.tabPageLab4.Size = new System.Drawing.Size(1092, 717);
        this.tabPageLab4.TabIndex = 1;
        this.tabPageLab4.Text = "Лаб 4: Обход графа";
        this.tabPageLab4.UseVisualStyleBackColor = true;

        // 
        // lblLab4Start
        // 
        this.lblLab4Start.AutoSize = true;
        this.lblLab4Start.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblLab4Start.Location = new System.Drawing.Point(30, 25);
        this.lblLab4Start.Name = "lblLab4Start";
        this.lblLab4Start.Size = new System.Drawing.Size(160, 23);
        this.lblLab4Start.TabIndex = 0;
        this.lblLab4Start.Text = "Стартовая вершина:";

        // 
        // txtLab4Start
        // 
        this.txtLab4Start.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.txtLab4Start.Location = new System.Drawing.Point(210, 22);
        this.txtLab4Start.Name = "txtLab4Start";
        this.txtLab4Start.Size = new System.Drawing.Size(150, 30);
        this.txtLab4Start.TabIndex = 1;
        this.txtLab4Start.Text = "Hospital_Central";

        // 
        // lblLab4Target
        // 
        this.lblLab4Target.AutoSize = true;
        this.lblLab4Target.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblLab4Target.Location = new System.Drawing.Point(30, 70);
        this.lblLab4Target.Name = "lblLab4Target";
        this.lblLab4Target.Size = new System.Drawing.Size(150, 23);
        this.lblLab4Target.TabIndex = 2;
        this.lblLab4Target.Text = "Целевая вершина:";

        // 
        // txtLab4Target
        // 
        this.txtLab4Target.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.txtLab4Target.Location = new System.Drawing.Point(210, 67);
        this.txtLab4Target.Name = "txtLab4Target";
        this.txtLab4Target.Size = new System.Drawing.Size(150, 30);
        this.txtLab4Target.TabIndex = 3;
        this.txtLab4Target.Text = "Hospital_South";

        // 
        // btnLab4Run
        // 
        this.btnLab4Run.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
        this.btnLab4Run.FlatAppearance.BorderSize = 0;
        this.btnLab4Run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnLab4Run.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.btnLab4Run.ForeColor = System.Drawing.Color.White;
        this.btnLab4Run.Location = new System.Drawing.Point(30, 115);
        this.btnLab4Run.Name = "btnLab4Run";
        this.btnLab4Run.Size = new System.Drawing.Size(200, 40);
        this.btnLab4Run.TabIndex = 4;
        this.btnLab4Run.Text = "Выполнить Лаб 4";
        this.btnLab4Run.UseVisualStyleBackColor = false;
        this.btnLab4Run.Click += new System.EventHandler(this.btnLab4Run_Click);

        // 
        // txtLab4Output
        // 
        this.txtLab4Output.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
        this.txtLab4Output.Font = new System.Drawing.Font("Consolas", 9F);
        this.txtLab4Output.Location = new System.Drawing.Point(30, 175);
        this.txtLab4Output.Multiline = true;
        this.txtLab4Output.Name = "txtLab4Output";
        this.txtLab4Output.ReadOnly = true;
        this.txtLab4Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtLab4Output.Size = new System.Drawing.Size(1030, 520);
        this.txtLab4Output.TabIndex = 5;

        // 
        // tabPageLab5
        // 
        this.tabPageLab5.Controls.Add(this.txtLab5Output);
        this.tabPageLab5.Controls.Add(this.btnLab5Run);
        this.tabPageLab5.Controls.Add(this.txtLab5Target);
        this.tabPageLab5.Controls.Add(this.lblLab5Target);
        this.tabPageLab5.Controls.Add(this.txtLab5Start);
        this.tabPageLab5.Controls.Add(this.lblLab5Start);
        this.tabPageLab5.Location = new System.Drawing.Point(4, 29);
        this.tabPageLab5.Name = "tabPageLab5";
        this.tabPageLab5.Padding = new System.Windows.Forms.Padding(3);
        this.tabPageLab5.Size = new System.Drawing.Size(1092, 717);
        this.tabPageLab5.TabIndex = 2;
        this.tabPageLab5.Text = "Лаб 5: Дейкстра";
        this.tabPageLab5.UseVisualStyleBackColor = true;

        // 
        // lblLab5Start
        // 
        this.lblLab5Start.AutoSize = true;
        this.lblLab5Start.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblLab5Start.Location = new System.Drawing.Point(30, 25);
        this.lblLab5Start.Name = "lblLab5Start";
        this.lblLab5Start.Size = new System.Drawing.Size(160, 23);
        this.lblLab5Start.TabIndex = 0;
        this.lblLab5Start.Text = "Стартовая вершина:";

        // 
        // txtLab5Start
        // 
        this.txtLab5Start.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.txtLab5Start.Location = new System.Drawing.Point(210, 22);
        this.txtLab5Start.Name = "txtLab5Start";
        this.txtLab5Start.Size = new System.Drawing.Size(150, 30);
        this.txtLab5Start.TabIndex = 1;
        this.txtLab5Start.Text = "Hospital_Central";

        // 
        // lblLab5Target
        // 
        this.lblLab5Target.AutoSize = true;
        this.lblLab5Target.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblLab5Target.Location = new System.Drawing.Point(30, 70);
        this.lblLab5Target.Name = "lblLab5Target";
        this.lblLab5Target.Size = new System.Drawing.Size(150, 23);
        this.lblLab5Target.TabIndex = 2;
        this.lblLab5Target.Text = "Целевая вершина:";

        // 
        // txtLab5Target
        // 
        this.txtLab5Target.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.txtLab5Target.Location = new System.Drawing.Point(210, 67);
        this.txtLab5Target.Name = "txtLab5Target";
        this.txtLab5Target.Size = new System.Drawing.Size(150, 30);
        this.txtLab5Target.TabIndex = 3;
        this.txtLab5Target.Text = "MedPoint_7";

        // 
        // btnLab5Run
        // 
        this.btnLab5Run.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
        this.btnLab5Run.FlatAppearance.BorderSize = 0;
        this.btnLab5Run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnLab5Run.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.btnLab5Run.ForeColor = System.Drawing.Color.White;
        this.btnLab5Run.Location = new System.Drawing.Point(30, 115);
        this.btnLab5Run.Name = "btnLab5Run";
        this.btnLab5Run.Size = new System.Drawing.Size(200, 40);
        this.btnLab5Run.TabIndex = 4;
        this.btnLab5Run.Text = "Выполнить Лаб 5";
        this.btnLab5Run.UseVisualStyleBackColor = false;
        this.btnLab5Run.Click += new System.EventHandler(this.btnLab5Run_Click);

        // 
        // txtLab5Output
        // 
        this.txtLab5Output.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
        this.txtLab5Output.Font = new System.Drawing.Font("Consolas", 9F);
        this.txtLab5Output.Location = new System.Drawing.Point(30, 175);
        this.txtLab5Output.Multiline = true;
        this.txtLab5Output.Name = "txtLab5Output";
        this.txtLab5Output.ReadOnly = true;
        this.txtLab5Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtLab5Output.Size = new System.Drawing.Size(1030, 520);
        this.txtLab5Output.TabIndex = 5;

        // 
        // tabPageLab6
        // 
        this.tabPageLab6.Controls.Add(this.txtLab6Output);
        this.tabPageLab6.Controls.Add(this.btnLab6Run);
        this.tabPageLab6.Controls.Add(this.txtLab6Hospitals);
        this.tabPageLab6.Controls.Add(this.lblLab6Hospitals);
        this.tabPageLab6.Controls.Add(this.txtLab6Start);
        this.tabPageLab6.Controls.Add(this.lblLab6Start);
        this.tabPageLab6.Location = new System.Drawing.Point(4, 29);
        this.tabPageLab6.Name = "tabPageLab6";
        this.tabPageLab6.Padding = new System.Windows.Forms.Padding(3);
        this.tabPageLab6.Size = new System.Drawing.Size(1092, 717);
        this.tabPageLab6.TabIndex = 3;
        this.tabPageLab6.Text = "Лаб 6: Анализ + Вариант 17";
        this.tabPageLab6.UseVisualStyleBackColor = true;

        // 
        // lblLab6Start
        // 
        this.lblLab6Start.AutoSize = true;
        this.lblLab6Start.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblLab6Start.Location = new System.Drawing.Point(30, 25);
        this.lblLab6Start.Name = "lblLab6Start";
        this.lblLab6Start.Size = new System.Drawing.Size(170, 23);
        this.lblLab6Start.TabIndex = 0;
        this.lblLab6Start.Text = "Местоположение:";

        // 
        // txtLab6Start
        // 
        this.txtLab6Start.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.txtLab6Start.Location = new System.Drawing.Point(210, 22);
        this.txtLab6Start.Name = "txtLab6Start";
        this.txtLab6Start.Size = new System.Drawing.Size(150, 30);
        this.txtLab6Start.TabIndex = 1;
        this.txtLab6Start.Text = "MedPoint_4";

        // 
        // lblLab6Hospitals
        // 
        this.lblLab6Hospitals.AutoSize = true;
        this.lblLab6Hospitals.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblLab6Hospitals.Location = new System.Drawing.Point(30, 70);
        this.lblLab6Hospitals.Name = "lblLab6Hospitals";
        this.lblLab6Hospitals.Size = new System.Drawing.Size(160, 23);
        this.lblLab6Hospitals.TabIndex = 2;
        this.lblLab6Hospitals.Text = "Список больниц:";

        // 
        // txtLab6Hospitals
        // 
        this.txtLab6Hospitals.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.txtLab6Hospitals.Location = new System.Drawing.Point(210, 67);
        this.txtLab6Hospitals.Name = "txtLab6Hospitals";
        this.txtLab6Hospitals.Size = new System.Drawing.Size(400, 30);
        this.txtLab6Hospitals.TabIndex = 3;
        this.txtLab6Hospitals.Text = "Hospital_Central,Hospital_North,Hospital_South";

        // 
        // btnLab6Run
        // 
        this.btnLab6Run.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
        this.btnLab6Run.FlatAppearance.BorderSize = 0;
        this.btnLab6Run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnLab6Run.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.btnLab6Run.ForeColor = System.Drawing.Color.White;
        this.btnLab6Run.Location = new System.Drawing.Point(30, 115);
        this.btnLab6Run.Name = "btnLab6Run";
        this.btnLab6Run.Size = new System.Drawing.Size(250, 40);
        this.btnLab6Run.TabIndex = 4;
        this.btnLab6Run.Text = "Выполнить Лаб 6";
        this.btnLab6Run.UseVisualStyleBackColor = false;
        this.btnLab6Run.Click += new System.EventHandler(this.btnLab6Run_Click);

        // 
        // txtLab6Output
        // 
        this.txtLab6Output.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
        this.txtLab6Output.Font = new System.Drawing.Font("Consolas", 9F);
        this.txtLab6Output.Location = new System.Drawing.Point(30, 175);
        this.txtLab6Output.Multiline = true;
        this.txtLab6Output.Name = "txtLab6Output";
        this.txtLab6Output.ReadOnly = true;
        this.txtLab6Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtLab6Output.Size = new System.Drawing.Size(1030, 520);
        this.txtLab6Output.TabIndex = 5;

        // 
        // tabPageCompare
        // 
        this.tabPageCompare.Controls.Add(this.txtCompareOutput);
        this.tabPageCompare.Controls.Add(this.btnCompare);
        this.tabPageCompare.Controls.Add(this.txtCompareTarget);
        this.tabPageCompare.Controls.Add(this.lblCompareTarget);
        this.tabPageCompare.Controls.Add(this.txtCompareStart);
        this.tabPageCompare.Controls.Add(this.lblCompareStart);
        this.tabPageCompare.Location = new System.Drawing.Point(4, 29);
        this.tabPageCompare.Name = "tabPageCompare";
        this.tabPageCompare.Padding = new System.Windows.Forms.Padding(3);
        this.tabPageCompare.Size = new System.Drawing.Size(1092, 717);
        this.tabPageCompare.TabIndex = 4;
        this.tabPageCompare.Text = "Сравнение алгоритмов";
        this.tabPageCompare.UseVisualStyleBackColor = true;

        // 
        // lblCompareStart
        // 
        this.lblCompareStart.AutoSize = true;
        this.lblCompareStart.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblCompareStart.Location = new System.Drawing.Point(30, 25);
        this.lblCompareStart.Name = "lblCompareStart";
        this.lblCompareStart.Size = new System.Drawing.Size(160, 23);
        this.lblCompareStart.TabIndex = 0;
        this.lblCompareStart.Text = "Стартовая вершина:";

        // 
        // txtCompareStart
        // 
        this.txtCompareStart.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.txtCompareStart.Location = new System.Drawing.Point(210, 22);
        this.txtCompareStart.Name = "txtCompareStart";
        this.txtCompareStart.Size = new System.Drawing.Size(150, 30);
        this.txtCompareStart.TabIndex = 1;
        this.txtCompareStart.Text = "Hospital_Central";

        // 
        // lblCompareTarget
        // 
        this.lblCompareTarget.AutoSize = true;
        this.lblCompareTarget.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblCompareTarget.Location = new System.Drawing.Point(30, 70);
        this.lblCompareTarget.Name = "lblCompareTarget";
        this.lblCompareTarget.Size = new System.Drawing.Size(150, 23);
        this.lblCompareTarget.TabIndex = 2;
        this.lblCompareTarget.Text = "Целевая вершина:";

        // 
        // txtCompareTarget
        // 
        this.txtCompareTarget.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.txtCompareTarget.Location = new System.Drawing.Point(210, 67);
        this.txtCompareTarget.Name = "txtCompareTarget";
        this.txtCompareTarget.Size = new System.Drawing.Size(150, 30);
        this.txtCompareTarget.TabIndex = 3;
        this.txtCompareTarget.Text = "MedPoint_7";

        // 
        // btnCompare
        // 
        this.btnCompare.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
        this.btnCompare.FlatAppearance.BorderSize = 0;
        this.btnCompare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnCompare.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.btnCompare.ForeColor = System.Drawing.Color.White;
        this.btnCompare.Location = new System.Drawing.Point(30, 115);
        this.btnCompare.Name = "btnCompare";
        this.btnCompare.Size = new System.Drawing.Size(280, 40);
        this.btnCompare.TabIndex = 4;
        this.btnCompare.Text = "Сравнить BFS и Дейкстру";
        this.btnCompare.UseVisualStyleBackColor = false;
        this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);

        // 
        // txtCompareOutput
        // 
        this.txtCompareOutput.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
        this.txtCompareOutput.Font = new System.Drawing.Font("Consolas", 9F);
        this.txtCompareOutput.Location = new System.Drawing.Point(30, 175);
        this.txtCompareOutput.Multiline = true;
        this.txtCompareOutput.Name = "txtCompareOutput";
        this.txtCompareOutput.ReadOnly = true;
        this.txtCompareOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtCompareOutput.Size = new System.Drawing.Size(1030, 520);
        this.txtCompareOutput.TabIndex = 5;

        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.White;
        this.ClientSize = new System.Drawing.Size(1100, 750);
        this.Controls.Add(this.tabControl);
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Лабораторные работы №4-6 | Вариант 17: Сеть больниц";
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
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.TabPage tabPageLoad;
    private System.Windows.Forms.Label lblFilePath;
    private System.Windows.Forms.TextBox txtFilePath;
    private System.Windows.Forms.Button btnLoadGraph;
    private System.Windows.Forms.Button btnBrowseFile;
    private System.Windows.Forms.Label lblStatus;
    private System.Windows.Forms.TabPage tabPageLab4;
    private System.Windows.Forms.Label lblLab4Start;
    private System.Windows.Forms.TextBox txtLab4Start;
    private System.Windows.Forms.Label lblLab4Target;
    private System.Windows.Forms.TextBox txtLab4Target;
    private System.Windows.Forms.Button btnLab4Run;
    private System.Windows.Forms.TextBox txtLab4Output;
    private System.Windows.Forms.TabPage tabPageLab5;
    private System.Windows.Forms.Label lblLab5Start;
    private System.Windows.Forms.TextBox txtLab5Start;
    private System.Windows.Forms.Label lblLab5Target;
    private System.Windows.Forms.TextBox txtLab5Target;
    private System.Windows.Forms.Button btnLab5Run;
    private System.Windows.Forms.TextBox txtLab5Output;
    private System.Windows.Forms.TabPage tabPageLab6;
    private System.Windows.Forms.Label lblLab6Start;
    private System.Windows.Forms.TextBox txtLab6Start;
    private System.Windows.Forms.Label lblLab6Hospitals;
    private System.Windows.Forms.TextBox txtLab6Hospitals;
    private System.Windows.Forms.Button btnLab6Run;
    private System.Windows.Forms.TextBox txtLab6Output;
    private System.Windows.Forms.TabPage tabPageCompare;
    private System.Windows.Forms.Label lblCompareStart;
    private System.Windows.Forms.TextBox txtCompareStart;
    private System.Windows.Forms.Label lblCompareTarget;
    private System.Windows.Forms.TextBox txtCompareTarget;
    private System.Windows.Forms.Button btnCompare;
    private System.Windows.Forms.TextBox txtCompareOutput;

    // Новые элементы для визуализации графа
    private System.Windows.Forms.Panel pnlGraph;
    private System.Windows.Forms.CheckBox chkShowWeights;
    private System.Windows.Forms.Button btnRedrawGraph;
}
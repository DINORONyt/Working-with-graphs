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
            splitContainer1 = new SplitContainer();
            groupBoxVariantTask = new GroupBox();
            btnVariantTask = new Button();
            cmbVariantTarget = new ComboBox();
            lblVariantTarget = new Label();
            cmbVariantStart = new ComboBox();
            groupBoxAnalysis = new GroupBox();
            btnExperiment = new Button();
            btnClearOutput = new Button();
            btnConnectedComponents = new Button();
            btnMST = new Button();
            btnArticulationPoints = new Button();
            groupBoxDijkstraRoute = new GroupBox();
            btnFindRoute = new Button();
            cmbDijkstraRouteTarget = new ComboBox();
            lblDijkstraRouteTarget = new Label();
            cmbDijkstraRouteStart = new ComboBox();
            groupBoxDijkstra = new GroupBox();
            btnDijkstraAll = new Button();
            cmbDijkstraSource = new ComboBox();
            lblDijkstraSource = new Label();
            groupBoxConnectivity = new GroupBox();
            btnCheckConnectivity = new Button();
            cmbConnectivityTarget = new ComboBox();
            lblConnectivityTarget = new Label();
            cmbConnectivityStart = new ComboBox();
            lblConnectivityStart = new Label();
            groupBoxDFS = new GroupBox();
            btnDFS = new Button();
            cmbDFSStart = new ComboBox();
            groupBoxBFS = new GroupBox();
            btnBFS = new Button();
            cmbBFSStart = new ComboBox();
            btnLoadGraph = new Button();
            lblTitle = new Label();
            txtOutput = new TextBox();
            lblResults = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBoxVariantTask.SuspendLayout();
            groupBoxAnalysis.SuspendLayout();
            groupBoxDijkstraRoute.SuspendLayout();
            groupBoxDijkstra.SuspendLayout();
            groupBoxConnectivity.SuspendLayout();
            groupBoxDFS.SuspendLayout();
            groupBoxBFS.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBoxVariantTask);
            splitContainer1.Panel1.Controls.Add(groupBoxAnalysis);
            splitContainer1.Panel1.Controls.Add(groupBoxDijkstraRoute);
            splitContainer1.Panel1.Controls.Add(groupBoxDijkstra);
            splitContainer1.Panel1.Controls.Add(groupBoxConnectivity);
            splitContainer1.Panel1.Controls.Add(groupBoxDFS);
            splitContainer1.Panel1.Controls.Add(groupBoxBFS);
            splitContainer1.Panel1.Controls.Add(btnLoadGraph);
            splitContainer1.Panel1.Controls.Add(lblTitle);
            splitContainer1.Panel1.Padding = new Padding(11, 13, 11, 13);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtOutput);
            splitContainer1.Panel2.Controls.Add(lblResults);
            splitContainer1.Panel2.Padding = new Padding(11, 13, 11, 13);
            splitContainer1.Size = new Size(1371, 933);
            splitContainer1.SplitterDistance = 628;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // groupBoxVariantTask
            // 
            groupBoxVariantTask.Controls.Add(btnVariantTask);
            groupBoxVariantTask.Controls.Add(cmbVariantTarget);
            groupBoxVariantTask.Controls.Add(lblVariantTarget);
            groupBoxVariantTask.Controls.Add(cmbVariantStart);
            groupBoxVariantTask.Dock = DockStyle.Top;
            groupBoxVariantTask.Location = new Point(11, 898);
            groupBoxVariantTask.Margin = new Padding(3, 4, 3, 4);
            groupBoxVariantTask.Name = "groupBoxVariantTask";
            groupBoxVariantTask.Padding = new Padding(3, 4, 3, 4);
            groupBoxVariantTask.Size = new Size(606, 127);
            groupBoxVariantTask.TabIndex = 8;
            groupBoxVariantTask.TabStop = false;
            groupBoxVariantTask.Text = "Задача варианта — из:";
            // 
            // btnVariantTask
            // 
            btnVariantTask.BackColor = Color.FromArgb(75, 0, 130);
            btnVariantTask.FlatAppearance.BorderSize = 0;
            btnVariantTask.FlatStyle = FlatStyle.Flat;
            btnVariantTask.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVariantTask.ForeColor = Color.White;
            btnVariantTask.Location = new Point(171, 73);
            btnVariantTask.Margin = new Padding(3, 4, 3, 4);
            btnVariantTask.Name = "btnVariantTask";
            btnVariantTask.Size = new Size(263, 40);
            btnVariantTask.TabIndex = 3;
            btnVariantTask.Text = "Кратчайший маршрут (вар. 3)";
            btnVariantTask.UseVisualStyleBackColor = false;
            btnVariantTask.Click += btnVariantTask_Click;
            // 
            // cmbVariantTarget
            // 
            cmbVariantTarget.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVariantTarget.FormattingEnabled = true;
            cmbVariantTarget.Location = new Point(171, 37);
            cmbVariantTarget.Margin = new Padding(3, 4, 3, 4);
            cmbVariantTarget.Name = "cmbVariantTarget";
            cmbVariantTarget.Size = new Size(262, 28);
            cmbVariantTarget.TabIndex = 2;
            // 
            // lblVariantTarget
            // 
            lblVariantTarget.AutoSize = true;
            lblVariantTarget.Location = new Point(7, 41);
            lblVariantTarget.Name = "lblVariantTarget";
            lblVariantTarget.Size = new Size(87, 20);
            lblVariantTarget.TabIndex = 1;
            lblVariantTarget.Text = "В вершину:";
            // 
            // cmbVariantStart
            // 
            cmbVariantStart.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVariantStart.FormattingEnabled = true;
            cmbVariantStart.Location = new Point(172, 0);
            cmbVariantStart.Margin = new Padding(3, 4, 3, 4);
            cmbVariantStart.Name = "cmbVariantStart";
            cmbVariantStart.Size = new Size(262, 28);
            cmbVariantStart.TabIndex = 0;
            cmbVariantStart.SelectedIndexChanged += cmbVariantStart_SelectedIndexChanged;
            // 
            // groupBoxAnalysis
            // 
            groupBoxAnalysis.Controls.Add(btnExperiment);
            groupBoxAnalysis.Controls.Add(btnClearOutput);
            groupBoxAnalysis.Controls.Add(btnConnectedComponents);
            groupBoxAnalysis.Controls.Add(btnMST);
            groupBoxAnalysis.Controls.Add(btnArticulationPoints);
            groupBoxAnalysis.Dock = DockStyle.Top;
            groupBoxAnalysis.Location = new Point(11, 618);
            groupBoxAnalysis.Margin = new Padding(3, 4, 3, 4);
            groupBoxAnalysis.Name = "groupBoxAnalysis";
            groupBoxAnalysis.Padding = new Padding(3, 4, 3, 4);
            groupBoxAnalysis.Size = new Size(606, 280);
            groupBoxAnalysis.TabIndex = 7;
            groupBoxAnalysis.TabStop = false;
            groupBoxAnalysis.Text = "Анализ графа";
            // 
            // btnExperiment
            // 
            btnExperiment.BackColor = Color.FromArgb(40, 40, 40);
            btnExperiment.FlatAppearance.BorderSize = 0;
            btnExperiment.FlatStyle = FlatStyle.Flat;
            btnExperiment.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExperiment.ForeColor = Color.White;
            btnExperiment.Location = new Point(171, 227);
            btnExperiment.Margin = new Padding(3, 4, 3, 4);
            btnExperiment.Name = "btnExperiment";
            btnExperiment.Size = new Size(263, 40);
            btnExperiment.TabIndex = 4;
            btnExperiment.Text = "⏱ Эксперимент (15–50 вершин)";
            btnExperiment.UseVisualStyleBackColor = false;
            btnExperiment.Click += btnExperiment_Click;
            // 
            // btnClearOutput
            // 
            btnClearOutput.BackColor = Color.FromArgb(80, 80, 80);
            btnClearOutput.FlatAppearance.BorderSize = 0;
            btnClearOutput.FlatStyle = FlatStyle.Flat;
            btnClearOutput.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClearOutput.ForeColor = Color.White;
            btnClearOutput.Location = new Point(171, 179);
            btnClearOutput.Margin = new Padding(3, 4, 3, 4);
            btnClearOutput.Name = "btnClearOutput";
            btnClearOutput.Size = new Size(263, 40);
            btnClearOutput.TabIndex = 3;
            btnClearOutput.Text = "Очистить вывод";
            btnClearOutput.UseVisualStyleBackColor = false;
            btnClearOutput.Click += btnClearOutput_Click;
            // 
            // btnConnectedComponents
            // 
            btnConnectedComponents.BackColor = Color.FromArgb(255, 165, 0);
            btnConnectedComponents.FlatAppearance.BorderSize = 0;
            btnConnectedComponents.FlatStyle = FlatStyle.Flat;
            btnConnectedComponents.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConnectedComponents.ForeColor = Color.White;
            btnConnectedComponents.Location = new Point(171, 131);
            btnConnectedComponents.Margin = new Padding(3, 4, 3, 4);
            btnConnectedComponents.Name = "btnConnectedComponents";
            btnConnectedComponents.Size = new Size(263, 40);
            btnConnectedComponents.TabIndex = 2;
            btnConnectedComponents.Text = "Компоненты связности";
            btnConnectedComponents.UseVisualStyleBackColor = false;
            btnConnectedComponents.Click += btnConnectedComponents_Click;
            // 
            // btnMST
            // 
            btnMST.BackColor = Color.FromArgb(0, 128, 128);
            btnMST.FlatAppearance.BorderSize = 0;
            btnMST.FlatStyle = FlatStyle.Flat;
            btnMST.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMST.ForeColor = Color.White;
            btnMST.Location = new Point(171, 83);
            btnMST.Margin = new Padding(3, 4, 3, 4);
            btnMST.Name = "btnMST";
            btnMST.Size = new Size(263, 40);
            btnMST.TabIndex = 1;
            btnMST.Text = "МОД — алгоритм Прима";
            btnMST.UseVisualStyleBackColor = false;
            btnMST.Click += btnMST_Click;
            // 
            // btnArticulationPoints
            // 
            btnArticulationPoints.BackColor = Color.FromArgb(220, 53, 69);
            btnArticulationPoints.FlatAppearance.BorderSize = 0;
            btnArticulationPoints.FlatStyle = FlatStyle.Flat;
            btnArticulationPoints.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnArticulationPoints.ForeColor = Color.White;
            btnArticulationPoints.Location = new Point(171, 35);
            btnArticulationPoints.Margin = new Padding(3, 4, 3, 4);
            btnArticulationPoints.Name = "btnArticulationPoints";
            btnArticulationPoints.Size = new Size(263, 40);
            btnArticulationPoints.TabIndex = 0;
            btnArticulationPoints.Text = "Точки сочленения";
            btnArticulationPoints.UseVisualStyleBackColor = false;
            btnArticulationPoints.Click += btnArticulationPoints_Click;
            // 
            // groupBoxDijkstraRoute
            // 
            groupBoxDijkstraRoute.Controls.Add(btnFindRoute);
            groupBoxDijkstraRoute.Controls.Add(cmbDijkstraRouteTarget);
            groupBoxDijkstraRoute.Controls.Add(lblDijkstraRouteTarget);
            groupBoxDijkstraRoute.Controls.Add(cmbDijkstraRouteStart);
            groupBoxDijkstraRoute.Dock = DockStyle.Top;
            groupBoxDijkstraRoute.Location = new Point(11, 511);
            groupBoxDijkstraRoute.Margin = new Padding(3, 4, 3, 4);
            groupBoxDijkstraRoute.Name = "groupBoxDijkstraRoute";
            groupBoxDijkstraRoute.Padding = new Padding(3, 4, 3, 4);
            groupBoxDijkstraRoute.Size = new Size(606, 107);
            groupBoxDijkstraRoute.TabIndex = 6;
            groupBoxDijkstraRoute.TabStop = false;
            groupBoxDijkstraRoute.Text = "Маршрут — из вершины:";
            // 
            // btnFindRoute
            // 
            btnFindRoute.BackColor = Color.FromArgb(111, 66, 193);
            btnFindRoute.FlatAppearance.BorderSize = 0;
            btnFindRoute.FlatStyle = FlatStyle.Flat;
            btnFindRoute.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFindRoute.ForeColor = Color.White;
            btnFindRoute.Location = new Point(14, 55);
            btnFindRoute.Margin = new Padding(3, 4, 3, 4);
            btnFindRoute.Name = "btnFindRoute";
            btnFindRoute.Size = new Size(225, 40);
            btnFindRoute.TabIndex = 3;
            btnFindRoute.Text = "Найти кратчайший маршрут";
            btnFindRoute.UseVisualStyleBackColor = false;
            btnFindRoute.Click += btnFindRoute_Click;
            // 
            // cmbDijkstraRouteTarget
            // 
            cmbDijkstraRouteTarget.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDijkstraRouteTarget.FormattingEnabled = true;
            cmbDijkstraRouteTarget.Location = new Point(338, 59);
            cmbDijkstraRouteTarget.Margin = new Padding(3, 4, 3, 4);
            cmbDijkstraRouteTarget.Name = "cmbDijkstraRouteTarget";
            cmbDijkstraRouteTarget.Size = new Size(262, 28);
            cmbDijkstraRouteTarget.TabIndex = 2;
            // 
            // lblDijkstraRouteTarget
            // 
            lblDijkstraRouteTarget.AutoSize = true;
            lblDijkstraRouteTarget.Location = new Point(245, 59);
            lblDijkstraRouteTarget.Name = "lblDijkstraRouteTarget";
            lblDijkstraRouteTarget.Size = new Size(87, 20);
            lblDijkstraRouteTarget.TabIndex = 1;
            lblDijkstraRouteTarget.Text = "В вершину:";
            // 
            // cmbDijkstraRouteStart
            // 
            cmbDijkstraRouteStart.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDijkstraRouteStart.FormattingEnabled = true;
            cmbDijkstraRouteStart.Location = new Point(202, 8);
            cmbDijkstraRouteStart.Margin = new Padding(3, 4, 3, 4);
            cmbDijkstraRouteStart.Name = "cmbDijkstraRouteStart";
            cmbDijkstraRouteStart.Size = new Size(262, 28);
            cmbDijkstraRouteStart.TabIndex = 0;
            // 
            // groupBoxDijkstra
            // 
            groupBoxDijkstra.Controls.Add(btnDijkstraAll);
            groupBoxDijkstra.Controls.Add(cmbDijkstraSource);
            groupBoxDijkstra.Controls.Add(lblDijkstraSource);
            groupBoxDijkstra.Dock = DockStyle.Top;
            groupBoxDijkstra.Location = new Point(11, 404);
            groupBoxDijkstra.Margin = new Padding(3, 4, 3, 4);
            groupBoxDijkstra.Name = "groupBoxDijkstra";
            groupBoxDijkstra.Padding = new Padding(3, 4, 3, 4);
            groupBoxDijkstra.Size = new Size(606, 107);
            groupBoxDijkstra.TabIndex = 5;
            groupBoxDijkstra.TabStop = false;
            groupBoxDijkstra.Text = "Дейкстра — кратчайшие пути";
            // 
            // btnDijkstraAll
            // 
            btnDijkstraAll.BackColor = Color.FromArgb(111, 66, 193);
            btnDijkstraAll.FlatAppearance.BorderSize = 0;
            btnDijkstraAll.FlatStyle = FlatStyle.Flat;
            btnDijkstraAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDijkstraAll.ForeColor = Color.White;
            btnDijkstraAll.Location = new Point(171, 60);
            btnDijkstraAll.Margin = new Padding(3, 4, 3, 4);
            btnDijkstraAll.Name = "btnDijkstraAll";
            btnDijkstraAll.Size = new Size(263, 40);
            btnDijkstraAll.TabIndex = 2;
            btnDijkstraAll.Text = "Расстояния до всех вершин";
            btnDijkstraAll.UseVisualStyleBackColor = false;
            btnDijkstraAll.Click += btnDijkstraAll_Click;
            // 
            // cmbDijkstraSource
            // 
            cmbDijkstraSource.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDijkstraSource.FormattingEnabled = true;
            cmbDijkstraSource.Location = new Point(171, 27);
            cmbDijkstraSource.Margin = new Padding(3, 4, 3, 4);
            cmbDijkstraSource.Name = "cmbDijkstraSource";
            cmbDijkstraSource.Size = new Size(262, 28);
            cmbDijkstraSource.TabIndex = 1;
            // 
            // lblDijkstraSource
            // 
            lblDijkstraSource.AutoSize = true;
            lblDijkstraSource.Location = new Point(7, 31);
            lblDijkstraSource.Name = "lblDijkstraSource";
            lblDijkstraSource.Size = new Size(115, 20);
            lblDijkstraSource.TabIndex = 0;
            lblDijkstraSource.Text = "Источник (все):";
            // 
            // groupBoxConnectivity
            // 
            groupBoxConnectivity.Controls.Add(btnCheckConnectivity);
            groupBoxConnectivity.Controls.Add(cmbConnectivityTarget);
            groupBoxConnectivity.Controls.Add(lblConnectivityTarget);
            groupBoxConnectivity.Controls.Add(cmbConnectivityStart);
            groupBoxConnectivity.Controls.Add(lblConnectivityStart);
            groupBoxConnectivity.Dock = DockStyle.Top;
            groupBoxConnectivity.Location = new Point(11, 294);
            groupBoxConnectivity.Margin = new Padding(3, 4, 3, 4);
            groupBoxConnectivity.Name = "groupBoxConnectivity";
            groupBoxConnectivity.Padding = new Padding(3, 4, 3, 4);
            groupBoxConnectivity.Size = new Size(606, 110);
            groupBoxConnectivity.TabIndex = 4;
            groupBoxConnectivity.TabStop = false;
            groupBoxConnectivity.Text = "Проверка достижимости (BFS)";
            // 
            // btnCheckConnectivity
            // 
            btnCheckConnectivity.BackColor = Color.FromArgb(66, 153, 225);
            btnCheckConnectivity.FlatAppearance.BorderSize = 0;
            btnCheckConnectivity.FlatStyle = FlatStyle.Flat;
            btnCheckConnectivity.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCheckConnectivity.ForeColor = Color.White;
            btnCheckConnectivity.Location = new Point(14, 55);
            btnCheckConnectivity.Margin = new Padding(3, 4, 3, 4);
            btnCheckConnectivity.Name = "btnCheckConnectivity";
            btnCheckConnectivity.Size = new Size(225, 40);
            btnCheckConnectivity.TabIndex = 3;
            btnCheckConnectivity.Text = "Проверить достижимость";
            btnCheckConnectivity.UseVisualStyleBackColor = false;
            btnCheckConnectivity.Click += btnCheckConnectivity_Click;
            // 
            // cmbConnectivityTarget
            // 
            cmbConnectivityTarget.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbConnectivityTarget.FormattingEnabled = true;
            cmbConnectivityTarget.Location = new Point(338, 44);
            cmbConnectivityTarget.Margin = new Padding(3, 4, 3, 4);
            cmbConnectivityTarget.Name = "cmbConnectivityTarget";
            cmbConnectivityTarget.Size = new Size(262, 28);
            cmbConnectivityTarget.TabIndex = 2;
            // 
            // lblConnectivityTarget
            // 
            lblConnectivityTarget.AutoSize = true;
            lblConnectivityTarget.Location = new Point(245, 44);
            lblConnectivityTarget.Name = "lblConnectivityTarget";
            lblConnectivityTarget.Size = new Size(87, 20);
            lblConnectivityTarget.TabIndex = 1;
            lblConnectivityTarget.Text = "В вершину:";
            // 
            // cmbConnectivityStart
            // 
            cmbConnectivityStart.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbConnectivityStart.FormattingEnabled = true;
            cmbConnectivityStart.Location = new Point(338, 11);
            cmbConnectivityStart.Margin = new Padding(3, 4, 3, 4);
            cmbConnectivityStart.Name = "cmbConnectivityStart";
            cmbConnectivityStart.Size = new Size(262, 28);
            cmbConnectivityStart.TabIndex = 0;
            // 
            // lblConnectivityStart
            // 
            lblConnectivityStart.AutoSize = true;
            lblConnectivityStart.Location = new Point(300, 14);
            lblConnectivityStart.Name = "lblConnectivityStart";
            lblConnectivityStart.Size = new Size(27, 20);
            lblConnectivityStart.TabIndex = 0;
            lblConnectivityStart.Text = "Из";
            // 
            // groupBoxDFS
            // 
            groupBoxDFS.Controls.Add(btnDFS);
            groupBoxDFS.Controls.Add(cmbDFSStart);
            groupBoxDFS.Dock = DockStyle.Top;
            groupBoxDFS.Location = new Point(11, 207);
            groupBoxDFS.Margin = new Padding(3, 4, 3, 4);
            groupBoxDFS.Name = "groupBoxDFS";
            groupBoxDFS.Padding = new Padding(3, 4, 3, 4);
            groupBoxDFS.Size = new Size(606, 87);
            groupBoxDFS.TabIndex = 3;
            groupBoxDFS.TabStop = false;
            groupBoxDFS.Text = "DFS — обход в глубину";
            // 
            // btnDFS
            // 
            btnDFS.BackColor = Color.FromArgb(92, 184, 92);
            btnDFS.FlatAppearance.BorderSize = 0;
            btnDFS.FlatStyle = FlatStyle.Flat;
            btnDFS.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDFS.ForeColor = Color.White;
            btnDFS.Location = new Point(301, 39);
            btnDFS.Margin = new Padding(3, 4, 3, 4);
            btnDFS.Name = "btnDFS";
            btnDFS.Size = new Size(263, 40);
            btnDFS.TabIndex = 2;
            btnDFS.Text = "Запустить DFS";
            btnDFS.UseVisualStyleBackColor = false;
            btnDFS.Click += btnDFS_Click;
            // 
            // cmbDFSStart
            // 
            cmbDFSStart.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDFSStart.FormattingEnabled = true;
            cmbDFSStart.Location = new Point(301, 8);
            cmbDFSStart.Margin = new Padding(3, 4, 3, 4);
            cmbDFSStart.Name = "cmbDFSStart";
            cmbDFSStart.Size = new Size(262, 28);
            cmbDFSStart.TabIndex = 1;
            // 
            // groupBoxBFS
            // 
            groupBoxBFS.Controls.Add(btnBFS);
            groupBoxBFS.Controls.Add(cmbBFSStart);
            groupBoxBFS.Dock = DockStyle.Top;
            groupBoxBFS.Location = new Point(11, 120);
            groupBoxBFS.Margin = new Padding(3, 4, 3, 4);
            groupBoxBFS.Name = "groupBoxBFS";
            groupBoxBFS.Padding = new Padding(3, 4, 3, 4);
            groupBoxBFS.Size = new Size(606, 87);
            groupBoxBFS.TabIndex = 2;
            groupBoxBFS.TabStop = false;
            groupBoxBFS.Text = "BFS — обход в ширину";
            // 
            // btnBFS
            // 
            btnBFS.BackColor = Color.FromArgb(92, 184, 92);
            btnBFS.FlatAppearance.BorderSize = 0;
            btnBFS.FlatStyle = FlatStyle.Flat;
            btnBFS.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBFS.ForeColor = Color.White;
            btnBFS.Location = new Point(300, 46);
            btnBFS.Margin = new Padding(3, 4, 3, 4);
            btnBFS.Name = "btnBFS";
            btnBFS.Size = new Size(263, 40);
            btnBFS.TabIndex = 2;
            btnBFS.Text = "Запустить BFS";
            btnBFS.UseVisualStyleBackColor = false;
            btnBFS.Click += btnBFS_Click;
            // 
            // cmbBFSStart
            // 
            cmbBFSStart.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBFSStart.FormattingEnabled = true;
            cmbBFSStart.Location = new Point(300, 11);
            cmbBFSStart.Margin = new Padding(3, 4, 3, 4);
            cmbBFSStart.Name = "cmbBFSStart";
            cmbBFSStart.Size = new Size(262, 28);
            cmbBFSStart.TabIndex = 1;
            // 
            // btnLoadGraph
            // 
            btnLoadGraph.BackColor = Color.FromArgb(66, 133, 244);
            btnLoadGraph.Dock = DockStyle.Top;
            btnLoadGraph.FlatAppearance.BorderSize = 0;
            btnLoadGraph.FlatStyle = FlatStyle.Flat;
            btnLoadGraph.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLoadGraph.ForeColor = Color.White;
            btnLoadGraph.Location = new Point(11, 73);
            btnLoadGraph.Margin = new Padding(3, 4, 3, 4);
            btnLoadGraph.Name = "btnLoadGraph";
            btnLoadGraph.Size = new Size(606, 47);
            btnLoadGraph.TabIndex = 1;
            btnLoadGraph.Text = "Загрузить граф из файла";
            btnLoadGraph.UseVisualStyleBackColor = false;
            btnLoadGraph.Click += btnLoadGraph_Click;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(11, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(606, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Дорожная сеть района";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtOutput
            // 
            txtOutput.BackColor = Color.FromArgb(30, 30, 30);
            txtOutput.BorderStyle = BorderStyle.None;
            txtOutput.Dock = DockStyle.Fill;
            txtOutput.Font = new Font("Consolas", 9.5F);
            txtOutput.ForeColor = Color.FromArgb(100, 255, 100);
            txtOutput.Location = new Point(11, 33);
            txtOutput.Margin = new Padding(3, 4, 3, 4);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(716, 887);
            txtOutput.TabIndex = 1;
            // 
            // lblResults
            // 
            lblResults.Dock = DockStyle.Top;
            lblResults.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblResults.Location = new Point(11, 13);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(716, 20);
            lblResults.TabIndex = 0;
            lblResults.Text = "Результаты:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(1371, 933);
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1140, 784);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ЛР №4–6 — Дорожная сеть района (Вариант 3)";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBoxVariantTask.ResumeLayout(false);
            groupBoxVariantTask.PerformLayout();
            groupBoxAnalysis.ResumeLayout(false);
            groupBoxDijkstraRoute.ResumeLayout(false);
            groupBoxDijkstraRoute.PerformLayout();
            groupBoxDijkstra.ResumeLayout(false);
            groupBoxDijkstra.PerformLayout();
            groupBoxConnectivity.ResumeLayout(false);
            groupBoxConnectivity.PerformLayout();
            groupBoxDFS.ResumeLayout(false);
            groupBoxBFS.ResumeLayout(false);
            ResumeLayout(false);

        }

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxBFS;
        private System.Windows.Forms.Button btnBFS;
        private System.Windows.Forms.ComboBox cmbBFSStart;
        private System.Windows.Forms.GroupBox groupBoxDFS;
        private System.Windows.Forms.Button btnDFS;
        private System.Windows.Forms.ComboBox cmbDFSStart;
        private System.Windows.Forms.GroupBox groupBoxConnectivity;
        private System.Windows.Forms.Button btnCheckConnectivity;
        private System.Windows.Forms.ComboBox cmbConnectivityTarget;
        private System.Windows.Forms.Label lblConnectivityTarget;
        private System.Windows.Forms.ComboBox cmbConnectivityStart;
        private System.Windows.Forms.Label lblConnectivityStart;
        private System.Windows.Forms.GroupBox groupBoxDijkstra;
        private System.Windows.Forms.Button btnDijkstraAll;
        private System.Windows.Forms.ComboBox cmbDijkstraSource;
        private System.Windows.Forms.Label lblDijkstraSource;
        private System.Windows.Forms.GroupBox groupBoxDijkstraRoute;
        private System.Windows.Forms.Button btnFindRoute;
        private System.Windows.Forms.ComboBox cmbDijkstraRouteTarget;
        private System.Windows.Forms.Label lblDijkstraRouteTarget;
        private System.Windows.Forms.ComboBox cmbDijkstraRouteStart;
        private System.Windows.Forms.GroupBox groupBoxAnalysis;
        private System.Windows.Forms.Button btnClearOutput;
        private System.Windows.Forms.Button btnConnectedComponents;
        private System.Windows.Forms.Button btnMST;
        private System.Windows.Forms.Button btnArticulationPoints;
        private System.Windows.Forms.GroupBox groupBoxVariantTask;
        private System.Windows.Forms.Button btnVariantTask;
        private System.Windows.Forms.ComboBox cmbVariantTarget;
        private System.Windows.Forms.Label lblVariantTarget;
        private System.Windows.Forms.ComboBox cmbVariantStart;
        private System.Windows.Forms.Button btnLoadGraph;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnExperiment;
    }
}
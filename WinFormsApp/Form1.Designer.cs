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
        this.lblStatus = new System.Windows.Forms.Label();
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
        this.tabControl.SuspendLayout();
        this.tabPageLoad.SuspendLayout();
        this.tabPageLab4.SuspendLayout();
        this.tabPageLab5.SuspendLayout();
        this.tabPageLab6.SuspendLayout();
        this.SuspendLayout();

        // tabControl
        this.tabControl.Controls.Add(this.tabPageLoad);
        this.tabControl.Controls.Add(this.tabPageLab4);
        this.tabControl.Controls.Add(this.tabPageLab5);
        this.tabControl.Controls.Add(this.tabPageLab6);
        this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tabControl.Location = new System.Drawing.Point(0, 0);
        this.tabControl.Name = "tabControl";
        this.tabControl.SelectedIndex = 0;
        this.tabControl.Size = new System.Drawing.Size(850, 550);
        this.tabControl.TabIndex = 0;

        // tabPageLoad
        this.tabPageLoad.Controls.Add(this.lblStatus);
        this.tabPageLoad.Controls.Add(this.btnLoadGraph);
        this.tabPageLoad.Controls.Add(this.txtFilePath);
        this.tabPageLoad.Controls.Add(this.lblFilePath);
        this.tabPageLoad.Location = new System.Drawing.Point(4, 29);
        this.tabPageLoad.Name = "tabPageLoad";
        this.tabPageLoad.Padding = new System.Windows.Forms.Padding(3);
        this.tabPageLoad.Size = new System.Drawing.Size(842, 517);
        this.tabPageLoad.TabIndex = 0;
        this.tabPageLoad.Text = "Загрузка графа";
        this.tabPageLoad.UseVisualStyleBackColor = true;

        // lblFilePath
        this.lblFilePath.AutoSize = true;
        this.lblFilePath.Location = new System.Drawing.Point(20, 30);
        this.lblFilePath.Name = "lblFilePath";
        this.lblFilePath.Size = new System.Drawing.Size(180, 20);
        this.lblFilePath.TabIndex = 0;
        this.lblFilePath.Text = "Путь к CSV файлу графа:";

        // txtFilePath
        this.txtFilePath.Location = new System.Drawing.Point(20, 60);
        this.txtFilePath.Name = "txtFilePath";
        this.txtFilePath.Size = new System.Drawing.Size(500, 27);
        this.txtFilePath.TabIndex = 1;
        this.txtFilePath.Text = "graph.csv";

        // btnLoadGraph
        this.btnLoadGraph.Location = new System.Drawing.Point(530, 58);
        this.btnLoadGraph.Name = "btnLoadGraph";
        this.btnLoadGraph.Size = new System.Drawing.Size(150, 30);
        this.btnLoadGraph.TabIndex = 2;
        this.btnLoadGraph.Text = "Загрузить граф";
        this.btnLoadGraph.UseVisualStyleBackColor = true;
        this.btnLoadGraph.Click += new System.EventHandler(this.btnLoadGraph_Click);

        // lblStatus
        this.lblStatus.AutoSize = true;
        this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.lblStatus.Location = new System.Drawing.Point(20, 110);
        this.lblStatus.Name = "lblStatus";
        this.lblStatus.Size = new System.Drawing.Size(0, 23);
        this.lblStatus.TabIndex = 3;

        // tabPageLab4
        this.tabPageLab4.Controls.Add(this.txtLab4Output);
        this.tabPageLab4.Controls.Add(this.btnLab4Run);
        this.tabPageLab4.Controls.Add(this.txtLab4Target);
        this.tabPageLab4.Controls.Add(this.lblLab4Target);
        this.tabPageLab4.Controls.Add(this.txtLab4Start);
        this.tabPageLab4.Controls.Add(this.lblLab4Start);
        this.tabPageLab4.Location = new System.Drawing.Point(4, 29);
        this.tabPageLab4.Name = "tabPageLab4";
        this.tabPageLab4.Padding = new System.Windows.Forms.Padding(3);
        this.tabPageLab4.Size = new System.Drawing.Size(842, 517);
        this.tabPageLab4.TabIndex = 1;
        this.tabPageLab4.Text = "Лаб 4: Обход графа";
        this.tabPageLab4.UseVisualStyleBackColor = true;

        // lblLab4Start
        this.lblLab4Start.AutoSize = true;
        this.lblLab4Start.Location = new System.Drawing.Point(20, 20);
        this.lblLab4Start.Name = "lblLab4Start";
        this.lblLab4Start.Size = new System.Drawing.Size(110, 20);
        this.lblLab4Start.TabIndex = 0;
        this.lblLab4Start.Text = "Стартовая вершина:";

        // txtLab4Start
        this.txtLab4Start.Location = new System.Drawing.Point(150, 17);
        this.txtLab4Start.Name = "txtLab4Start";
        this.txtLab4Start.Size = new System.Drawing.Size(100, 27);
        this.txtLab4Start.TabIndex = 1;

        // lblLab4Target
        this.lblLab4Target.AutoSize = true;
        this.lblLab4Target.Location = new System.Drawing.Point(20, 60);
        this.lblLab4Target.Name = "lblLab4Target";
        this.lblLab4Target.Size = new System.Drawing.Size(110, 20);
        this.lblLab4Target.TabIndex = 2;
        this.lblLab4Target.Text = "Целевая вершина:";

        // txtLab4Target
        this.txtLab4Target.Location = new System.Drawing.Point(150, 57);
        this.txtLab4Target.Name = "txtLab4Target";
        this.txtLab4Target.Size = new System.Drawing.Size(100, 27);
        this.txtLab4Target.TabIndex = 3;

        // btnLab4Run
        this.btnLab4Run.Location = new System.Drawing.Point(20, 100);
        this.btnLab4Run.Name = "btnLab4Run";
        this.btnLab4Run.Size = new System.Drawing.Size(150, 30);
        this.btnLab4Run.TabIndex = 4;
        this.btnLab4Run.Text = "Выполнить Лаб 4";
        this.btnLab4Run.UseVisualStyleBackColor = true;
        this.btnLab4Run.Click += new System.EventHandler(this.btnLab4Run_Click);

        // txtLab4Output
        this.txtLab4Output.Location = new System.Drawing.Point(20, 150);
        this.txtLab4Output.Multiline = true;
        this.txtLab4Output.Name = "txtLab4Output";
        this.txtLab4Output.ReadOnly = true;
        this.txtLab4Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtLab4Output.Size = new System.Drawing.Size(800, 340);
        this.txtLab4Output.TabIndex = 5;

        // tabPageLab5
        this.tabPageLab5.Controls.Add(this.txtLab5Output);
        this.tabPageLab5.Controls.Add(this.btnLab5Run);
        this.tabPageLab5.Controls.Add(this.txtLab5Target);
        this.tabPageLab5.Controls.Add(this.lblLab5Target);
        this.tabPageLab5.Controls.Add(this.txtLab5Start);
        this.tabPageLab5.Controls.Add(this.lblLab5Start);
        this.tabPageLab5.Location = new System.Drawing.Point(4, 29);
        this.tabPageLab5.Name = "tabPageLab5";
        this.tabPageLab5.Padding = new System.Windows.Forms.Padding(3);
        this.tabPageLab5.Size = new System.Drawing.Size(842, 517);
        this.tabPageLab5.TabIndex = 2;
        this.tabPageLab5.Text = "Лаб 5: Дейкстра";
        this.tabPageLab5.UseVisualStyleBackColor = true;

        // lblLab5Start
        this.lblLab5Start.AutoSize = true;
        this.lblLab5Start.Location = new System.Drawing.Point(20, 20);
        this.lblLab5Start.Name = "lblLab5Start";
        this.lblLab5Start.Size = new System.Drawing.Size(110, 20);
        this.lblLab5Start.TabIndex = 0;
        this.lblLab5Start.Text = "Стартовая вершина:";

        // txtLab5Start
        this.txtLab5Start.Location = new System.Drawing.Point(150, 17);
        this.txtLab5Start.Name = "txtLab5Start";
        this.txtLab5Start.Size = new System.Drawing.Size(100, 27);
        this.txtLab5Start.TabIndex = 1;

        // lblLab5Target
        this.lblLab5Target.AutoSize = true;
        this.lblLab5Target.Location = new System.Drawing.Point(20, 60);
        this.lblLab5Target.Name = "lblLab5Target";
        this.lblLab5Target.Size = new System.Drawing.Size(110, 20);
        this.lblLab5Target.TabIndex = 2;
        this.lblLab5Target.Text = "Целевая вершина:";

        // txtLab5Target
        this.txtLab5Target.Location = new System.Drawing.Point(150, 57);
        this.txtLab5Target.Name = "txtLab5Target";
        this.txtLab5Target.Size = new System.Drawing.Size(100, 27);
        this.txtLab5Target.TabIndex = 3;

        // btnLab5Run
        this.btnLab5Run.Location = new System.Drawing.Point(20, 100);
        this.btnLab5Run.Name = "btnLab5Run";
        this.btnLab5Run.Size = new System.Drawing.Size(150, 30);
        this.btnLab5Run.TabIndex = 4;
        this.btnLab5Run.Text = "Выполнить Лаб 5";
        this.btnLab5Run.UseVisualStyleBackColor = true;
        this.btnLab5Run.Click += new System.EventHandler(this.btnLab5Run_Click);

        // txtLab5Output
        this.txtLab5Output.Location = new System.Drawing.Point(20, 150);
        this.txtLab5Output.Multiline = true;
        this.txtLab5Output.Name = "txtLab5Output";
        this.txtLab5Output.ReadOnly = true;
        this.txtLab5Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtLab5Output.Size = new System.Drawing.Size(800, 340);
        this.txtLab5Output.TabIndex = 5;

        // tabPageLab6
        this.tabPageLab6.Controls.Add(this.txtLab6Output);
        this.tabPageLab6.Controls.Add(this.btnLab6Run);
        this.tabPageLab6.Controls.Add(this.txtLab6Hospitals);
        this.tabPageLab6.Controls.Add(this.lblLab6Hospitals);
        this.tabPageLab6.Controls.Add(this.txtLab6Start);
        this.tabPageLab6.Controls.Add(this.lblLab6Start);
        this.tabPageLab6.Location = new System.Drawing.Point(4, 29);
        this.tabPageLab6.Name = "tabPageLab6";
        this.tabPageLab6.Padding = new System.Windows.Forms.Padding(3);
        this.tabPageLab6.Size = new System.Drawing.Size(842, 517);
        this.tabPageLab6.TabIndex = 3;
        this.tabPageLab6.Text = "Лаб 6: Анализ и Вариант 17";
        this.tabPageLab6.UseVisualStyleBackColor = true;

        // lblLab6Start
        this.lblLab6Start.AutoSize = true;
        this.lblLab6Start.Location = new System.Drawing.Point(20, 20);
        this.lblLab6Start.Name = "lblLab6Start";
        this.lblLab6Start.Size = new System.Drawing.Size(110, 20);
        this.lblLab6Start.TabIndex = 0;
        this.lblLab6Start.Text = "Местоположение:";

        // txtLab6Start
        this.txtLab6Start.Location = new System.Drawing.Point(150, 17);
        this.txtLab6Start.Name = "txtLab6Start";
        this.txtLab6Start.Size = new System.Drawing.Size(100, 27);
        this.txtLab6Start.TabIndex = 1;

        // lblLab6Hospitals
        this.lblLab6Hospitals.AutoSize = true;
        this.lblLab6Hospitals.Location = new System.Drawing.Point(20, 60);
        this.lblLab6Hospitals.Name = "lblLab6Hospitals";
        this.lblLab6Hospitals.Size = new System.Drawing.Size(130, 20);
        this.lblLab6Hospitals.TabIndex = 2;
        this.lblLab6Hospitals.Text = "Список больниц:";

        // txtLab6Hospitals
        this.txtLab6Hospitals.Location = new System.Drawing.Point(150, 57);
        this.txtLab6Hospitals.Name = "txtLab6Hospitals";
        this.txtLab6Hospitals.Size = new System.Drawing.Size(300, 27);
        this.txtLab6Hospitals.TabIndex = 3;
        this.txtLab6Hospitals.Text = "HospitalA,HospitalB";

        // btnLab6Run
        this.btnLab6Run.Location = new System.Drawing.Point(20, 100);
        this.btnLab6Run.Name = "btnLab6Run";
        this.btnLab6Run.Size = new System.Drawing.Size(200, 30);
        this.btnLab6Run.TabIndex = 4;
        this.btnLab6Run.Text = "Выполнить Лаб 6";
        this.btnLab6Run.UseVisualStyleBackColor = true;
        this.btnLab6Run.Click += new System.EventHandler(this.btnLab6Run_Click);

        // txtLab6Output
        this.txtLab6Output.Location = new System.Drawing.Point(20, 150);
        this.txtLab6Output.Multiline = true;
        this.txtLab6Output.Name = "txtLab6Output";
        this.txtLab6Output.ReadOnly = true;
        this.txtLab6Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtLab6Output.Size = new System.Drawing.Size(800, 340);
        this.txtLab6Output.TabIndex = 5;

        // Form1
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(850, 550);
        this.Controls.Add(this.tabControl);
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Лабораторные работы №4, №5, №6 | Вариант 17";
        this.tabControl.ResumeLayout(false);
        this.tabPageLoad.ResumeLayout(false);
        this.tabPageLoad.PerformLayout();
        this.tabPageLab4.ResumeLayout(false);
        this.tabPageLab4.PerformLayout();
        this.tabPageLab5.ResumeLayout(false);
        this.tabPageLab5.PerformLayout();
        this.tabPageLab6.ResumeLayout(false);
        this.tabPageLab6.PerformLayout();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.TabPage tabPageLoad;
    private System.Windows.Forms.Label lblFilePath;
    private System.Windows.Forms.TextBox txtFilePath;
    private System.Windows.Forms.Button btnLoadGraph;
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
}
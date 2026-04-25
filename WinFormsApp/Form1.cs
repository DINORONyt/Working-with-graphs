using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Lab456.Core;

namespace WinFormsApp;

public partial class Form1 : Form
{
    private Graph _graph = new();
    private string _loadedFilePath = "";

    public Form1()
    {
        InitializeComponent();
    }

    // Загрузка графа (общая для всех вкладок)
    private void btnLoadGraph_Click(object sender, EventArgs e)
    {
        try
        {
            _graph.LoadFromCsv(txtFilePath.Text);
            _loadedFilePath = txtFilePath.Text;
            lblStatus.Text = $"✅ Граф загружен: {_graph.Vertices.Count} вершин, {_graph.AdjacencyList.Values.Sum(l => l.Count) / 2} рёбер";
            lblStatus.ForeColor = System.Drawing.Color.Green;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            lblStatus.Text = "❌ Ошибка загрузки";
            lblStatus.ForeColor = System.Drawing.Color.Red;
        }
    }

    // ==================== ЛАБОРАТОРНАЯ 4 ====================
    private void btnLab4Run_Click(object sender, EventArgs e)
    {
        if (_graph.Vertices.Count == 0) { ShowNotLoaded(); return; }
        string start = txtLab4Start.Text.Trim();
        if (!_graph.HasVertex(start)) { ShowInvalidVertex(start); return; }

        txtLab4Output.Clear();
        txtLab4Output.AppendText($"--- ЛАБОРАТОРНАЯ №4 ---\n");
        txtLab4Output.AppendText($"BFS от '{start}': {string.Join(" -> ", Algorithms.BFS(_graph, start))}\n");
        txtLab4Output.AppendText($"DFS от '{start}': {string.Join(" -> ", Algorithms.DFS(_graph, start))}\n");

        string target = txtLab4Target.Text.Trim();
        if (_graph.HasVertex(target))
        {
            bool reachable = Algorithms.IsReachable(_graph, start, target);
            txtLab4Output.AppendText($"Достижима ли '{target}' из '{start}'? {(reachable ? "ДА" : "НЕТ")}\n");
        }

        var components = Algorithms.GetConnectedComponents(_graph);
        txtLab4Output.AppendText($"\nКомпоненты связности ({components.Count} шт.):\n");
        for (int i = 0; i < components.Count; i++)
            txtLab4Output.AppendText($"  {i + 1}. [{string.Join(", ", components[i])}]\n");
    }

    // ==================== ЛАБОРАТОРНАЯ 5 ====================
    private void btnLab5Run_Click(object sender, EventArgs e)
    {
        if (_graph.Vertices.Count == 0) { ShowNotLoaded(); return; }
        string start = txtLab5Start.Text.Trim();
        if (!_graph.HasVertex(start)) { ShowInvalidVertex(start); return; }

        txtLab5Output.Clear();
        txtLab5Output.AppendText("--- ЛАБОРАТОРНАЯ №5 (Дейкстра) ---\n");

        var (distances, parents) = Algorithms.Dijkstra(_graph, start);
        txtLab5Output.AppendText("Кратчайшие расстояния:\n");
        foreach (var kvp in distances.OrderBy(x => x.Value))
            txtLab5Output.AppendText($"  {kvp.Key}: {kvp.Value} мин.\n");

        string target = txtLab5Target.Text.Trim();
        if (_graph.HasVertex(target))
        {
            var path = Algorithms.ReconstructPath(parents, target);
            txtLab5Output.AppendText($"\nМаршрут до '{target}': {string.Join(" -> ", path)}\n");
        }
    }

    // ==================== ЛАБОРАТОРНАЯ 6 ====================
    private void btnLab6Run_Click(object sender, EventArgs e)
    {
        if (_graph.Vertices.Count == 0) { ShowNotLoaded(); return; }

        txtLab6Output.Clear();
        txtLab6Output.AppendText("--- ЛАБОРАТОРНАЯ №6 ---\n");

        // 1. Точки сочленения
        var articulationPoints = Algorithms.FindArticulationPoints(_graph);
        txtLab6Output.AppendText($"Точки сочленения: {(articulationPoints.Count > 0 ? string.Join(", ", articulationPoints) : "Нет")}\n");

        // 2. Минимальное остовное дерево
        var mst = Algorithms.GetMSTPrim(_graph);
        int mstWeight = mst.Sum(e => e.W);
        txtLab6Output.AppendText($"МОД (Прим): вес = {mstWeight}\n");
        foreach (var edge in mst)
            txtLab6Output.AppendText($"  {edge.U} -- {edge.V} ({edge.W} мин.)\n");

        // 3. Вариант 17: Ближайшая больница
        string start = txtLab6Start.Text.Trim();
        string hospitalsInput = txtLab6Hospitals.Text.Trim();

        if (_graph.HasVertex(start) && !string.IsNullOrEmpty(hospitalsInput))
        {
            var hospitalsSet = new HashSet<string>(hospitalsInput.Split(',').Select(h => h.Trim()));
            var (nearest, path, time) = Algorithms.FindNearestHospital(_graph, start, hospitalsSet);

            txtLab6Output.AppendText($"\n[Вариант 17] Ближайшая больница к '{start}':\n");
            if (time >= 0)
            {
                txtLab6Output.AppendText($"  Больница: {nearest}\n");
                txtLab6Output.AppendText($"  Время: {time} мин.\n");
                txtLab6Output.AppendText($"  Маршрут: {string.Join(" -> ", path)}\n");
            }
            else
            {
                txtLab6Output.AppendText("  Не найдено ни одной больницы в графе.\n");
            }
        }
    }

    // Вспомогательные методы UI
    private void ShowNotLoaded() => MessageBox.Show("Сначала загрузите граф из файла!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    private void ShowInvalidVertex(string v) => MessageBox.Show($"Вершина '{v}' отсутствует в графе.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
}
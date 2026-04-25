using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        txtFilePath.Text = "graph.txt";
        txtLab6Hospitals.Text = "Hospital_Central,Hospital_North,Hospital_South";
    }

    private void btnLoadGraph_Click(object sender, EventArgs e)
    {
        try
        {
            _graph.LoadFromTxt(txtFilePath.Text);
            _loadedFilePath = txtFilePath.Text;
            lblStatus.Text = $"✅ Граф загружен: {_graph.Vertices.Count} вершин, {_graph.EdgeCount} рёбер";
            lblStatus.ForeColor = System.Drawing.Color.Green;

            // Показываем список вершин
            txtLab4Output.Clear();
            txtLab4Output.AppendText($"Загружен граф из файла: {_loadedFilePath}\n");
            txtLab4Output.AppendText($"Вершины: {string.Join(", ", _graph.Vertices.OrderBy(v => v))}\n");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            lblStatus.Text = "❌ Ошибка загрузки";
            lblStatus.ForeColor = System.Drawing.Color.Red;
        }
    }

    private void btnBrowseFile_Click(object sender, EventArgs e)
    {
        using var dialog = new OpenFileDialog();
        dialog.Filter = "Текстовые файлы|*.txt|CSV файлы|*.csv|Все файлы|*.*";
        dialog.Title = "Выберите файл графа";

        if (dialog.ShowDialog() == DialogResult.OK)
        {
            txtFilePath.Text = dialog.FileName;
        }
    }

    // ==================== ЛАБОРАТОРНАЯ 4 ====================
    private void btnLab4Run_Click(object sender, EventArgs e)
    {
        if (_graph.Vertices.Count == 0) { ShowNotLoaded(); return; }
        string start = txtLab4Start.Text.Trim();
        if (!_graph.HasVertex(start)) { ShowInvalidVertex(start); return; }

        var stopwatch = Stopwatch.StartNew();
        txtLab4Output.Clear();
        txtLab4Output.AppendText($"=== ЛАБОРАТОРНАЯ №4: Обход графа ===\n\n");

        // BFS
        stopwatch.Restart();
        var bfsResult = Algorithms.BFS(_graph, start);
        stopwatch.Stop();
        txtLab4Output.AppendText($"📊 BFS от '{start}':\n");
        txtLab4Output.AppendText($"   Порядок: {string.Join(" → ", bfsResult)}\n");
        txtLab4Output.AppendText($"   ⏱ Время: {stopwatch.ElapsedMilliseconds} мс\n\n");

        // DFS
        stopwatch.Restart();
        var dfsResult = Algorithms.DFS(_graph, start);
        stopwatch.Stop();
        txtLab4Output.AppendText($"📊 DFS от '{start}':\n");
        txtLab4Output.AppendText($"   Порядок: {string.Join(" → ", dfsResult)}\n");
        txtLab4Output.AppendText($"   ⏱ Время: {stopwatch.ElapsedMilliseconds} мс\n\n");

        // Достижимость
        string target = txtLab4Target.Text.Trim();
        if (_graph.HasVertex(target))
        {
            stopwatch.Restart();
            bool reachable = Algorithms.IsReachable(_graph, start, target);
            stopwatch.Stop();
            txtLab4Output.AppendText($" Достижимость '{target}' из '{start}': {(reachable ? "✅ ДА" : "❌ НЕТ")}\n");
            txtLab4Output.AppendText($"   ⏱ Время: {stopwatch.ElapsedMilliseconds} мс\n\n");
        }

        // Компоненты связности
        stopwatch.Restart();
        var components = Algorithms.GetConnectedComponents(_graph);
        stopwatch.Stop();
        txtLab4Output.AppendText($"📊 Компоненты связности ({components.Count} шт.):\n");
        for (int i = 0; i < components.Count; i++)
            txtLab4Output.AppendText($"   {i + 1}. [{string.Join(", ", components[i])}]\n");
        txtLab4Output.AppendText($"   ⏱ Время: {stopwatch.ElapsedMilliseconds} мс\n");
    }

    // ==================== ЛАБОРАТОРНАЯ 5 ====================
    private void btnLab5Run_Click(object sender, EventArgs e)
    {
        if (_graph.Vertices.Count == 0) { ShowNotLoaded(); return; }
        string start = txtLab5Start.Text.Trim();
        if (!_graph.HasVertex(start)) { ShowInvalidVertex(start); return; }

        var stopwatch = Stopwatch.StartNew();
        txtLab5Output.Clear();
        txtLab5Output.AppendText($"=== ЛАБОРАТОРНАЯ №5: Алгоритм Дейкстры ===\n\n");

        // Кратчайшие расстояния
        stopwatch.Restart();
        var (distances, parents) = Algorithms.Dijkstra(_graph, start);
        stopwatch.Stop();

        txtLab5Output.AppendText($"📊 Кратчайшие расстояния от '{start}':\n");
        foreach (var kvp in distances.OrderBy(x => x.Value))
        {
            string dist = kvp.Value == int.MaxValue ? "∞" : $"{kvp.Value} мин.";
            txtLab5Output.AppendText($"   {kvp.Key}: {dist}\n");
        }
        txtLab4Output.AppendText($"   ⏱ Время: {stopwatch.ElapsedMilliseconds} мс\n\n");

        // Маршрут до цели
        string target = txtLab5Target.Text.Trim();
        if (_graph.HasVertex(target))
        {
            stopwatch.Restart();
            var path = Algorithms.ReconstructPath(parents, target);
            stopwatch.Stop();

            if (distances[target] != int.MaxValue)
            {
                txtLab5Output.AppendText($"\n📊 Маршрут до '{target}':\n");
                txtLab5Output.AppendText($"   Путь: {string.Join(" → ", path)}\n");
                txtLab5Output.AppendText($"   Расстояние: {distances[target]} мин.\n");
                txtLab5Output.AppendText($"   ⏱ Время: {stopwatch.ElapsedMilliseconds} мс\n");
            }
            else
            {
                txtLab5Output.AppendText($"\n❌ '{target}' недостижима из '{start}'\n");
            }
        }

        // Анализ сложности
        txtLab5Output.AppendText($"\n📈 Анализ сложности:\n");
        txtLab5Output.AppendText($"   Вершин: {_graph.Vertices.Count}\n");
        txtLab5Output.AppendText($"   Рёбер: {_graph.EdgeCount}\n");
        txtLab5Output.AppendText($"   Сложность: O((V+E) log V) с PriorityQueue\n");
    }

    // ==================== ЛАБОРАТОРНАЯ 6 ====================
    private void btnLab6Run_Click(object sender, EventArgs e)
    {
        if (_graph.Vertices.Count == 0) { ShowNotLoaded(); return; }

        var stopwatch = Stopwatch.StartNew();
        txtLab6Output.Clear();
        txtLab6Output.AppendText($"=== ЛАБОРАТОРНАЯ №6: Анализ графа ===\n\n");

        // 1. Точки сочленения
        stopwatch.Restart();
        var articulationPoints = Algorithms.FindArticulationPoints(_graph);
        stopwatch.Stop();

        txtLab6Output.AppendText($"📊 Точки сочленения ({articulationPoints.Count} шт.):\n");
        if (articulationPoints.Count > 0)
        {
            txtLab6Output.AppendText($"   {string.Join(", ", articulationPoints)}\n");
            txtLab6Output.AppendText($"   💡 Это критические узлы сети. Их отказ разорвёт граф.\n");
        }
        else
        {
            txtLab6Output.AppendText($"   Нет точек сочленения - граф устойчив к отказу любой вершины\n");
        }
        txtLab6Output.AppendText($"   ⏱ Время: {stopwatch.ElapsedMilliseconds} мс\n\n");

        // 2. Минимальное остовное дерево
        stopwatch.Restart();
        var mst = Algorithms.GetMSTPrim(_graph);
        int mstWeight = mst.Sum(e => e.W);
        stopwatch.Stop();

        txtLab6Output.AppendText($"📊 Минимальное остовное дерево (Прим):\n");
        txtLab6Output.AppendText($"   Суммарный вес: {mstWeight} мин.\n");
        txtLab6Output.AppendText($"   Рёбер в МОД: {mst.Count}\n");
        foreach (var edge in mst)
            txtLab6Output.AppendText($"   {edge.U} ↔ {edge.V} ({edge.W} мин.)\n");
        txtLab6Output.AppendText($"   ⏱ Время: {stopwatch.ElapsedMilliseconds} мс\n\n");

        // 3. Вариант 17: Ближайшая больница
        string start = txtLab6Start.Text.Trim();
        string hospitalsInput = txtLab6Hospitals.Text.Trim();

        if (_graph.HasVertex(start) && !string.IsNullOrEmpty(hospitalsInput))
        {
            var hospitalsSet = new HashSet<string>(hospitalsInput.Split(',')
                .Select(h => h.Trim()).Where(h => !string.IsNullOrEmpty(h)));

            stopwatch.Restart();
            var (nearest, path, time) = Algorithms.FindNearestHospital(_graph, start, hospitalsSet);
            stopwatch.Stop();

            txtLab6Output.AppendText($"📊 [ВАРИАНТ 17] Ближайшая больница к '{start}':\n");
            if (time >= 0)
            {
                txtLab6Output.AppendText($"   🏥 Больница: {nearest}\n");
                txtLab6Output.AppendText($"   ⏱ Время в пути: {time} мин.\n");
                txtLab6Output.AppendText($"   🛣 Маршрут: {string.Join(" → ", path)}\n");
            }
            else
            {
                txtLab6Output.AppendText($"   ❌ Не найдено ни одной доступной больницы\n");
            }
            txtLab6Output.AppendText($"   ⏱ Время: {stopwatch.ElapsedMilliseconds} мс\n");
        }
    }

    // ==================== СРАВНЕНИЕ АЛГОРИТМОВ ====================
    private void btnCompare_Click(object sender, EventArgs e)
    {
        if (_graph.Vertices.Count == 0) { ShowNotLoaded(); return; }
        string start = txtCompareStart.Text.Trim();
        string target = txtCompareTarget.Text.Trim();

        if (!_graph.HasVertex(start) || !_graph.HasVertex(target))
        {
            MessageBox.Show("Обе вершины должны существовать в графе", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var stopwatch = Stopwatch.StartNew();
        txtCompareOutput.Clear();
        txtCompareOutput.AppendText($"=== СРАВНЕНИЕ BFS И ДЕЙКСТРЫ ===\n\n");
        txtCompareOutput.AppendText($"Маршрут: {start} → {target}\n\n");

        // BFS
        stopwatch.Restart();
        var (bfsHops, _, bfsPath) = Algorithms.CompareBfsAndDijkstra(_graph, start, target);
        stopwatch.Stop();

        txtCompareOutput.AppendText($"📊 BFS (по количеству рёбер):\n");
        txtCompareOutput.AppendText($"   Путь: {bfsPath}\n");
        txtCompareOutput.AppendText($"   Количество переходов: {bfsHops}\n");
        txtCompareOutput.AppendText($"   ⏱ Время: {stopwatch.ElapsedMilliseconds} мс\n\n");

        // Дейкстра
        stopwatch.Restart();
        var (distances, parents) = Algorithms.Dijkstra(_graph, start);
        var dijkstraPath = Algorithms.ReconstructPath(parents, target);
        int dijkstraWeight = distances[target];
        stopwatch.Stop();

        txtCompareOutput.AppendText($"📊 Дейкстра (по весу рёбер):\n");
        txtCompareOutput.AppendText($"   Путь: {string.Join(" → ", dijkstraPath)}\n");
        txtCompareOutput.AppendText($"   Суммарный вес: {dijkstraWeight} мин.\n");
        txtCompareOutput.AppendText($"   ⏱ Время: {stopwatch.ElapsedMilliseconds} мс\n\n");

        // Вывод
        txtCompareOutput.AppendText($"💡 ВЫВОД:\n");
        if (bfsPath == string.Join(" → ", dijkstraPath))
        {
            txtCompareOutput.AppendText($"   Пути совпадают! BFS даёт оптимальный результат.\n");
        }
        else
        {
            txtCompareOutput.AppendText($"   Пути разные! Дейкстра находит более быстрый маршрут.\n");
            txtCompareOutput.AppendText($"   BFS минимизирует количество переходов,\n");
            txtCompareOutput.AppendText($"   Дейкстра минимизирует общее время.\n");
        }
    }

    // Вспомогательные методы
    private void ShowNotLoaded() =>
        MessageBox.Show("Сначала загрузите граф из файла!", "Внимание",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);

    private void ShowInvalidVertex(string v) =>
        MessageBox.Show($"Вершина '{v}' отсутствует в графе.\n" +
            $"Доступные вершины: {string.Join(", ", _graph.Vertices.Take(10))}...",
            "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
}
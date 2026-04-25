using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Lab456.Core;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private Graph _graph = new Graph();
        private string _loadedFilePath = "";
        private Dictionary<string, int> _lastDistances = new Dictionary<string, int>();
        private Dictionary<string, string> _lastParents = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        // ==================== ВСПОМОГАТЕЛЬНЫЕ МЕТОДЫ ====================

        private void UpdateComboBoxes()
        {
            var vertices = _graph.Vertices.ToList();

            cmbBFSStart.Items.Clear();
            cmbDFSStart.Items.Clear();
            cmbConnectivityStart.Items.Clear();
            cmbConnectivityTarget.Items.Clear();
            cmbDijkstraSource.Items.Clear();
            cmbDijkstraRouteStart.Items.Clear();
            cmbDijkstraRouteTarget.Items.Clear();
            cmbVariantStart.Items.Clear();
            cmbVariantTarget.Items.Clear();

            foreach (var v in vertices)
            {
                cmbBFSStart.Items.Add(v);
                cmbDFSStart.Items.Add(v);
                cmbConnectivityStart.Items.Add(v);
                cmbConnectivityTarget.Items.Add(v);
                cmbDijkstraSource.Items.Add(v);
                cmbDijkstraRouteStart.Items.Add(v);
                cmbDijkstraRouteTarget.Items.Add(v);
                cmbVariantStart.Items.Add(v);
                cmbVariantTarget.Items.Add(v);
            }

            if (vertices.Count > 0)
            {
                cmbBFSStart.SelectedIndex = 0;
                cmbDFSStart.SelectedIndex = 0;
                cmbConnectivityStart.SelectedIndex = 0;
                cmbConnectivityTarget.SelectedIndex = vertices.Count > 1 ? 1 : 0;
                cmbDijkstraSource.SelectedIndex = 0;
                cmbDijkstraRouteStart.SelectedIndex = 0;
                cmbDijkstraRouteTarget.SelectedIndex = vertices.Count > 1 ? 1 : 0;
                cmbVariantStart.SelectedIndex = 0;
                cmbVariantTarget.SelectedIndex = vertices.Count > 1 ? 1 : 0;
            }
        }

        private void AppendOutput(string text, Color? color = null)
        {
            txtOutput.AppendText(text + "\n");
            if (color.HasValue)
            {
                // Можно добавить выделение цветом, если нужно
            }
        }

        private void ClearOutput()
        {
            txtOutput.Clear();
        }

        // ==================== ОСНОВНЫЕ ОБРАБОТЧИКИ ====================

        private void btnLoadGraph_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files|*.txt|CSV files|*.csv|All files|*.*";
                openFileDialog.Title = "Выберите файл графа";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _graph.LoadFromTxt(openFileDialog.FileName);
                        _loadedFilePath = openFileDialog.FileName;

                        UpdateComboBoxes();

                        AppendOutput($"✅ Граф успешно загружен из файла: {Path.GetFileName(_loadedFilePath)}");
                        AppendOutput($"📊 Вершин: {_graph.Vertices.Count}");
                        AppendOutput($"🔗 Рёбер: {_graph.EdgeCount}");
                        AppendOutput("");
                        AppendOutput($"Вершины: {string.Join(", ", _graph.Vertices.Take(10))}" +
                                    (_graph.Vertices.Count > 10 ? "..." : ""));
                        AppendOutput("");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка загрузки графа:\n{ex.Message}",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AppendOutput($"❌ Ошибка: {ex.Message}");
                    }
                }
            }
        }

        private void btnBFS_Click(object sender, EventArgs e)
        {
            if (_graph.Vertices.Count == 0)
            {
                MessageBox.Show("Сначала загрузите граф!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string start = cmbBFSStart.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(start)) return;

            ClearOutput();
            var stopwatch = Stopwatch.StartNew();

            var result = Algorithms.BFS(_graph, start);

            stopwatch.Stop();

            AppendOutput($"BFS от вершины «{start}» ({result.Count} вершин)");
            AppendOutput(new string('─', 60));
            AppendOutput("");

            // Группируем по уровням
            var levels = new Dictionary<string, int>();
            var queue = new Queue<string>();
            queue.Enqueue(start);
            levels[start] = 0;

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                foreach (var (neighbor, _) in _graph.AdjacencyList[current])
                {
                    if (!levels.ContainsKey(neighbor))
                    {
                        levels[neighbor] = levels[current] + 1;
                        queue.Enqueue(neighbor);
                    }
                }
            }

            var maxLevel = levels.Values.Max();
            for (int level = 0; level <= maxLevel; level++)
            {
                var verticesAtLevel = levels.Where(kvp => kvp.Value == level)
                    .Select(kvp => kvp.Key).OrderBy(v => v);
                AppendOutput($"Уровень {level}: {string.Join(", ", verticesAtLevel)}");
            }

            AppendOutput("");
            AppendOutput(new string('─', 60));
            AppendOutput($"⏱ Время: {stopwatch.ElapsedMilliseconds:F4} мс");
        }

        private void btnDFS_Click(object sender, EventArgs e)
        {
            if (_graph.Vertices.Count == 0)
            {
                MessageBox.Show("Сначала загрузите граф!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string start = cmbDFSStart.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(start)) return;

            ClearOutput();
            var stopwatch = Stopwatch.StartNew();

            var result = Algorithms.DFS(_graph, start);

            stopwatch.Stop();

            AppendOutput($"DFS от вершины «{start}» ({result.Count} вершин)");
            AppendOutput(new string('─', 60));
            AppendOutput("");
            AppendOutput($"Порядок обхода:");
            AppendOutput(string.Join(" → ", result));
            AppendOutput("");
            AppendOutput(new string('─', 60));
            AppendOutput($"⏱ Время: {stopwatch.ElapsedMilliseconds:F4} мс");
        }

        private void btnCheckConnectivity_Click(object sender, EventArgs e)
        {
            if (_graph.Vertices.Count == 0)
            {
                MessageBox.Show("Сначала загрузите граф!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string start = cmbConnectivityStart.SelectedItem?.ToString();
            string target = cmbConnectivityTarget.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(start) || string.IsNullOrEmpty(target)) return;

            ClearOutput();
            var stopwatch = Stopwatch.StartNew();

            bool reachable = Algorithms.IsReachable(_graph, start, target);

            stopwatch.Stop();

            AppendOutput($"Проверка достижимости (BFS)");
            AppendOutput(new string('─', 60));
            AppendOutput("");
            AppendOutput($"Из: {start}");
            AppendOutput($"В: {target}");
            AppendOutput("");

            if (reachable)
            {
                AppendOutput($"✅ Вершина «{target}» ДОСТИЖИМА из «{start}»");

                // Находим путь
                var path = FindBFSPath(start, target);
                if (path.Count > 0)
                {
                    AppendOutput("");
                    AppendOutput($"Путь: {string.Join(" → ", path)}");
                    AppendOutput($"Количество рёбер: {path.Count - 1}");
                }
            }
            else
            {
                AppendOutput($"❌ Вершина «{target}» НЕ ДОСТИЖИМА из «{start}»");
            }

            AppendOutput("");
            AppendOutput(new string('─', 60));
            AppendOutput($"⏱ Время: {stopwatch.ElapsedMilliseconds:F4} мс");
        }

        private List<string> FindBFSPath(string start, string target)
        {
            var visited = new HashSet<string>();
            var parents = new Dictionary<string, string>();
            var queue = new Queue<string>();

            queue.Enqueue(start);
            visited.Add(start);

            while (queue.Count > 0)
            {
                var currentNode = queue.Dequeue();  // ← Изменили current на currentNode
                if (currentNode == target) break;

                foreach (var (neighbor, _) in _graph.AdjacencyList[currentNode])
                {
                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor);
                        parents[neighbor] = currentNode;
                        queue.Enqueue(neighbor);
                    }
                }
            }

            // Восстанавливаем путь
            var path = new List<string>();
            string? currentNodePath = target;  // ← Изменили current на currentNodePath
            while (currentNodePath != null)
            {
                path.Add(currentNodePath);
                if (parents.TryGetValue(currentNodePath, out var parent))
                    currentNodePath = parent;
                else
                    currentNodePath = null;
            }

            path.Reverse();
            return path;
        }

        private void btnDijkstraAll_Click(object sender, EventArgs e)
        {
            if (_graph.Vertices.Count == 0)
            {
                MessageBox.Show("Сначала загрузите граф!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string source = cmbDijkstraSource.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(source)) return;

            ClearOutput();
            var stopwatch = Stopwatch.StartNew();

            var (distances, parents) = Algorithms.Dijkstra(_graph, source);

            _lastDistances = distances;
            _lastParents = parents;

            stopwatch.Stop();

            AppendOutput($"Алгоритм Дейкстры от «{source}»");
            AppendOutput(new string('─', 60));
            AppendOutput("");
            AppendOutput($"Кратчайшие расстояния до всех вершин:");
            AppendOutput("");

            foreach (var kvp in distances.OrderBy(x => x.Value))
            {
                string dist = kvp.Value == int.MaxValue ? "∞ (недостижима)" : $"{kvp.Value}";
                AppendOutput($"  {kvp.Key,-30} : {dist}");
            }

            AppendOutput("");
            AppendOutput(new string('─', 60));
            AppendOutput($"⏱ Время: {stopwatch.ElapsedMilliseconds:F4} мс");
        }

        private void btnFindRoute_Click(object sender, EventArgs e)
        {
            if (_graph.Vertices.Count == 0)
            {
                MessageBox.Show("Сначала загрузите граф!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string start = cmbDijkstraRouteStart.SelectedItem?.ToString();
            string target = cmbDijkstraRouteTarget.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(start) || string.IsNullOrEmpty(target)) return;

            ClearOutput();
            var stopwatch = Stopwatch.StartNew();

            var (distances, parents) = Algorithms.Dijkstra(_graph, start);
            var path = Algorithms.ReconstructPath(parents, target);

            stopwatch.Stop();

            AppendOutput($"Кратчайший маршрут (Дейкстра)");
            AppendOutput(new string('─', 60));
            AppendOutput("");
            AppendOutput($"От: {start}");
            AppendOutput($"До: {target}");
            AppendOutput("");

            if (distances[target] == int.MaxValue)
            {
                AppendOutput($"❌ Маршрут не найден (вершины не связаны)");
            }
            else
            {
                AppendOutput($"✅ Маршрут найден:");
                AppendOutput("");
                AppendOutput($"  {string.Join("\n  ↓\n  ", path)}");
                AppendOutput("");
                AppendOutput($"Суммарное расстояние: {distances[target]}");
                AppendOutput($"Количество вершин: {path.Count}");
                AppendOutput($"Количество рёбер: {path.Count - 1}");
            }

            AppendOutput("");
            AppendOutput(new string('─', 60));
            AppendOutput($"⏱ Время: {stopwatch.ElapsedMilliseconds:F4} мс");
        }

        private void btnArticulationPoints_Click(object sender, EventArgs e)
        {
            if (_graph.Vertices.Count == 0)
            {
                MessageBox.Show("Сначала загрузите граф!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ClearOutput();
            var stopwatch = Stopwatch.StartNew();

            var points = Algorithms.FindArticulationPoints(_graph);

            stopwatch.Stop();

            AppendOutput($"Точки сочленения (Articulation Points)");
            AppendOutput(new string('─', 60));
            AppendOutput("");

            if (points.Count == 0)
            {
                AppendOutput($"✅ Точки сочленения отсутствуют");
                AppendOutput("");
                AppendOutput("Граф устойчив к удалению любой отдельной вершины");
            }
            else
            {
                AppendOutput($"Найдено точек сочленения: {points.Count}");
                AppendOutput("");
                AppendOutput("Критические вершины:");
                foreach (var point in points.OrderBy(p => p))
                {
                    AppendOutput($"  • {point}");
                }
                AppendOutput("");
                AppendOutput("💡 Удаление любой из этих вершин разорвёт граф на компоненты");
            }

            AppendOutput("");
            AppendOutput(new string('─', 60));
            AppendOutput($"⏱ Время: {stopwatch.ElapsedMilliseconds:F4} мс");
        }

        private void btnMST_Click(object sender, EventArgs e)
        {
            if (_graph.Vertices.Count == 0)
            {
                MessageBox.Show("Сначала загрузите граф!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ClearOutput();
            var stopwatch = Stopwatch.StartNew();

            var mst = Algorithms.GetMSTPrim(_graph);
            int totalWeight = mst.Sum(edge => edge.W);

            stopwatch.Stop();

            AppendOutput($"Минимальное остовное дерево (МОД)");
            AppendOutput($"Алгоритм Прима");
            AppendOutput(new string('─', 60));
            AppendOutput("");
            AppendOutput($"Рёбра МОД ({mst.Count} шт.):");
            AppendOutput("");

            foreach (var edge in mst.OrderBy(e => e.W))
            {
                AppendOutput($"  {edge.U,-25} — {edge.V,-25} : {edge.W}");
            }

            AppendOutput("");
            AppendOutput(new string('─', 60));
            AppendOutput($"Суммарный вес МОД: {totalWeight}");
            AppendOutput("");
            AppendOutput(new string('─', 60));
            AppendOutput($"⏱ Время: {stopwatch.ElapsedMilliseconds:F4} мс");
        }

        private void btnConnectedComponents_Click(object sender, EventArgs e)
        {
            if (_graph.Vertices.Count == 0)
            {
                MessageBox.Show("Сначала загрузите граф!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ClearOutput();
            var stopwatch = Stopwatch.StartNew();

            var components = Algorithms.GetConnectedComponents(_graph);

            stopwatch.Stop();

            AppendOutput($"Компоненты связности графа");
            AppendOutput(new string('─', 60));
            AppendOutput("");
            AppendOutput($"Количество компонент: {components.Count}");
            AppendOutput("");

            for (int i = 0; i < components.Count; i++)
            {
                AppendOutput($"Компонента {i + 1} ({components[i].Count} вершин):");
                AppendOutput($"  {string.Join(", ", components[i].OrderBy(v => v))}");
                AppendOutput("");
            }

            if (components.Count == 1)
            {
                AppendOutput("✅ Граф связный (одна компонента)");
            }
            else
            {
                AppendOutput("⚠️ Граф несвязный (несколько компонент)");
            }

            AppendOutput("");
            AppendOutput(new string('─', 60));
            AppendOutput($"⏱ Время: {stopwatch.ElapsedMilliseconds:F4} мс");
        }

        private void btnVariantTask_Click(object sender, EventArgs e)
        {
            // Вариант 3: Дорожная сеть района
            // Задача: найти кратчайший маршрут между двумя точками

            if (_graph.Vertices.Count == 0)
            {
                MessageBox.Show("Сначала загрузите граф!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string start = cmbVariantStart.SelectedItem?.ToString();
            string target = cmbVariantTarget.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(start) || string.IsNullOrEmpty(target)) return;

            ClearOutput();
            var stopwatch = Stopwatch.StartNew();

            var (distances, parents) = Algorithms.Dijkstra(_graph, start);
            var path = Algorithms.ReconstructPath(parents, target);

            stopwatch.Stop();

            AppendOutput($"ЗАДАЧА ВАРИАНТА 3");
            AppendOutput($"Дорожная сеть района");
            AppendOutput(new string('─', 60));
            AppendOutput("");
            AppendOutput($"Найти кратчайший маршрут между двумя точками");
            AppendOutput("");
            AppendOutput($"От: {start}");
            AppendOutput($"До: {target}");
            AppendOutput("");

            if (distances[target] == int.MaxValue)
            {
                AppendOutput($"❌ Маршрут не найден");
            }
            else
            {
                AppendOutput($"✅ Кратчайший маршрут:");
                AppendOutput("");

                for (int i = 0; i < path.Count; i++)
                {
                    if (i > 0)
                    {
                        AppendOutput("        ↓");
                    }
                    AppendOutput($"  {i + 1}. {path[i]}");
                }

                AppendOutput("");
                AppendOutput(new string('─', 60));
                AppendOutput($"Длина маршрута: {distances[target]} км");
                AppendOutput($"Количество перекрёстков: {path.Count}");
                AppendOutput($"Количество дорог: {path.Count - 1}");
            }

            AppendOutput("");
            AppendOutput(new string('─', 60));
            AppendOutput($"⏱ Время: {stopwatch.ElapsedMilliseconds:F4} мс");
        }

        private void btnClearOutput_Click(object sender, EventArgs e)
        {
            ClearOutput();
        }

        private void btnExperiment_Click(object sender, EventArgs e)
        {
            if (_graph.Vertices.Count == 0)
            {
                MessageBox.Show("Сначала загрузите граф!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ClearOutput();

            AppendOutput($"ЭКСПЕРИМЕНТ: Сравнение алгоритмов");
            AppendOutput(new string('═', 60));
            AppendOutput("");
            AppendOutput($"Размер графа: {_graph.Vertices.Count} вершин, {_graph.EdgeCount} рёбер");
            AppendOutput("");

            string start = _graph.Vertices.First();
            string target = _graph.Vertices.Skip(Math.Min(5, _graph.Vertices.Count - 1)).First();

            // BFS
            var swBFS = Stopwatch.StartNew();
            Algorithms.BFS(_graph, start);
            swBFS.Stop();

            // DFS
            var swDFS = Stopwatch.StartNew();
            Algorithms.DFS(_graph, start);
            swDFS.Stop();

            // Dijkstra
            var swDijkstra = Stopwatch.StartNew();
            Algorithms.Dijkstra(_graph, start);
            swDijkstra.Stop();

            AppendOutput($"Результаты:");
            AppendOutput("");
            AppendOutput($"  BFS:       {swBFS.ElapsedMilliseconds,5} мс");
            AppendOutput($"  DFS:       {swDFS.ElapsedMilliseconds,5} мс");
            AppendOutput($"  Дейкстра:  {swDijkstra.ElapsedMilliseconds,5} мс");
            AppendOutput("");
            AppendOutput(new string('─', 60));
            AppendOutput("");
            AppendOutput("💡 Вывод:");
            AppendOutput("  • BFS и DFS работают за O(V+E)");
            AppendOutput("  • Дейкстра медленнее: O((V+E) log V)");
            AppendOutput("  • При увеличении графа разница растёт");
        }

        private void lblDijkstraRouteStart_Click(object sender, EventArgs e)
        {

        }

        private void cmbVariantStart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
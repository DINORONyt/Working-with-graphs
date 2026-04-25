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
        private Dictionary<string, PointF> _positions = new Dictionary<string, PointF>();
        private List<string> _highlightPath = new List<string>();
        private List<(string U, string V)> _highlightEdges = new List<(string U, string V)>();
        private List<string> _articulationPoints = new List<string>();

        public Form1()
        {
            InitializeComponent();

            // Устанавливаем значения по умолчанию
            txtFilePath.Text = "graph.txt";
            txtLab4Start.Text = "Hospital_Central";
            txtLab4Target.Text = "Hospital_South";
            txtLab5Start.Text = "Hospital_Central";
            txtLab5Target.Text = "MedPoint_7";
            txtLab6Start.Text = "MedPoint_4";
            txtLab6Hospitals.Text = "Hospital_Central,Hospital_North,Hospital_South";
            txtCompareStart.Text = "Hospital_Central";
            txtCompareTarget.Text = "MedPoint_7";
        }

        // ==================== ОТРИСОВКА ГРАФА ====================

        private void CalculatePositions(int width, int height)
        {
            _positions.Clear();
            var vertices = _graph.Vertices.ToList();
            if (vertices.Count == 0) return;

            float cx = width / 2f;
            float cy = height / 2f;
            float radius = Math.Min(cx, cy) - 80;

            for (int i = 0; i < vertices.Count; i++)
            {
                double angle = 2 * Math.PI * i / vertices.Count - Math.PI / 2;
                _positions[vertices[i]] = new PointF(
                    cx + radius * (float)Math.Cos(angle),
                    cy + radius * (float)Math.Sin(angle));
            }
        }

        private void DrawGraph(Graphics g, int width, int height)
        {
            g.Clear(Color.White);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (_graph.Vertices.Count == 0)
            {
                g.DrawString("Загрузите граф", new Font("Segoe UI", 14), Brushes.Gray, width / 2 - 70, height / 2);
                return;
            }

            CalculatePositions(width, height);

            // Рёбра
            foreach (var u in _graph.AdjacencyList.Keys)
            {
                foreach (var (v, w) in _graph.AdjacencyList[u])
                {
                    if (string.Compare(u, v) > 0) continue;

                    bool isHighlighted = _highlightEdges.Any(e => (e.U == u && e.V == v) || (e.U == v && e.V == u));
                    bool isPath = IsPathEdge(u, v);

                    using (var pen = new Pen(
                        isPath ? Color.Red : (isHighlighted ? Color.DarkGreen : Color.LightGray),
                        isPath || isHighlighted ? 3 : 1))
                    {
                        g.DrawLine(pen, _positions[u], _positions[v]);
                    }

                    if (chkShowWeights.Checked)
                    {
                        var mid = new PointF((_positions[u].X + _positions[v].X) / 2, (_positions[u].Y + _positions[v].Y) / 2);
                        var txt = w.ToString();
                        var sz = g.MeasureString(txt, new Font("Arial", 9));
                        g.FillRectangle(Brushes.White, mid.X - sz.Width / 2 - 2, mid.Y - sz.Height / 2 - 2, sz.Width + 4, sz.Height + 4);
                        g.DrawString(txt, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, mid.X - sz.Width / 2, mid.Y - sz.Height / 2);
                    }
                }
            }

            // Вершины
            foreach (var v in _positions.Keys)
            {
                var p = _positions[v];
                float r = 25;

                bool isArt = _articulationPoints.Contains(v);
                bool isPathNode = _highlightPath.Contains(v);
                bool isHospital = v.Contains("Hospital");

                Color fill = isArt ? Color.Red : (isPathNode ? Color.Orange : (isHospital ? Color.DodgerBlue : Color.LightGray));

                g.FillEllipse(new SolidBrush(fill), p.X - r, p.Y - r, r * 2, r * 2);
                g.DrawEllipse(Pens.Black, p.X - r, p.Y - r, r * 2, r * 2);

                var font = new Font("Segoe UI", 9, FontStyle.Bold);
                var sz = g.MeasureString(v, font);
                g.FillRectangle(Brushes.White, p.X - sz.Width / 2, p.Y + r + 2, sz.Width, sz.Height + 4);
                g.DrawString(v, font, Brushes.Black, p.X - sz.Width / 2, p.Y + r + 4);
            }
        }

        private bool IsPathEdge(string u, string v)
        {
            for (int i = 0; i < _highlightPath.Count - 1; i++)
            {
                if ((_highlightPath[i] == u && _highlightPath[i + 1] == v) ||
                    (_highlightPath[i] == v && _highlightPath[i + 1] == u)) return true;
            }
            return false;
        }

        private void RefreshAllGraphs()
        {
            if (pnlGraphMain != null) pnlGraphMain.Invalidate();
            if (pnlGraphLab4 != null) pnlGraphLab4.Invalidate();
            if (pnlGraphLab5 != null) pnlGraphLab5.Invalidate();
            if (pnlGraphLab6 != null) pnlGraphLab6.Invalidate();
        }

        // ==================== ОБРАБОТЧИКИ СОБЫТИЙ ====================

        private void btnLoadGraph_Click(object sender, EventArgs e)
        {
            try
            {
                _graph.LoadFromTxt(txtFilePath.Text);
                lblStatus.Text = $"✅ Загружено: {_graph.Vertices.Count} вершин, {_graph.EdgeCount} рёбер";
                lblStatus.ForeColor = Color.Green;

                _highlightPath.Clear();
                _highlightEdges.Clear();
                _articulationPoints.Clear();

                RefreshAllGraphs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "❌ Ошибка загрузки";
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = "Text files|*.txt|All files|*.*";
                dlg.Title = "Выберите файл графа";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = dlg.FileName;
                }
            }
        }

        private void btnRedrawGraph_Click(object sender, EventArgs e)
        {
            RefreshAllGraphs();
        }

        private void chkShowWeights_CheckedChanged(object sender, EventArgs e)
        {
            RefreshAllGraphs();
        }

        // ==================== ЛАБОРАТОРНАЯ 4 ====================

        private void btnLab4Run_Click(object sender, EventArgs e)
        {
            if (_graph.Vertices.Count == 0)
            {
                MessageBox.Show("Сначала загрузите граф!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string start = txtLab4Start.Text.Trim();
            string target = txtLab4Target.Text.Trim();

            if (!_graph.HasVertex(start))
            {
                MessageBox.Show($"Вершина '{start}' не найдена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var sw = Stopwatch.StartNew();
            var bfs = Algorithms.BFS(_graph, start);
            var dfs = Algorithms.DFS(_graph, start);
            bool reachable = _graph.HasVertex(target) ? Algorithms.IsReachable(_graph, start, target) : false;
            var components = Algorithms.GetConnectedComponents(_graph);
            sw.Stop();

            txtLab4Output.Clear();
            txtLab4Output.AppendText($"BFS от '{start}': {string.Join(" -> ", bfs)}\n\n");
            txtLab4Output.AppendText($"DFS от '{start}': {string.Join(" -> ", dfs)}\n\n");
            txtLab4Output.AppendText($"Достижима '{target}' из '{start}': {(reachable ? "ДА" : "НЕТ")}\n\n");
            txtLab4Output.AppendText($"Компонент связности: {components.Count}\n");
            for (int i = 0; i < components.Count; i++)
            {
                txtLab4Output.AppendText($"  {i + 1}. [{string.Join(", ", components[i])}]\n");
            }
            txtLab4Output.AppendText($"\n⏱ Время выполнения: {sw.ElapsedMilliseconds} мс");

            // Подсветка BFS пути
            _highlightPath = new List<string>(bfs);
            _highlightEdges.Clear();
            RefreshAllGraphs();
        }

        // ==================== ЛАБОРАТОРНАЯ 5 ====================

        private void btnLab5Run_Click(object sender, EventArgs e)
        {
            if (_graph.Vertices.Count == 0)
            {
                MessageBox.Show("Сначала загрузите граф!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string start = txtLab5Start.Text.Trim();
            string target = txtLab5Target.Text.Trim();

            if (!_graph.HasVertex(start))
            {
                MessageBox.Show($"Вершина '{start}' не найдена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var sw = Stopwatch.StartNew();
            var (distances, parents) = Algorithms.Dijkstra(_graph, start);
            var path = Algorithms.ReconstructPath(parents, target);
            sw.Stop();

            txtLab5Output.Clear();
            txtLab5Output.AppendText($"Кратчайшие расстояния от '{start}':\n");
            foreach (var kvp in distances.OrderBy(x => x.Value))
            {
                string dist = kvp.Value == int.MaxValue ? "∞" : kvp.Value.ToString();
                txtLab5Output.AppendText($"  {kvp.Key}: {dist}\n");
            }

            if (_graph.HasVertex(target) && distances[target] != int.MaxValue)
            {
                txtLab5Output.AppendText($"\nМаршрут до '{target}':\n");
                txtLab5Output.AppendText($"  Путь: {string.Join(" -> ", path)}\n");
                txtLab5Output.AppendText($"  Расстояние: {distances[target]}\n");
            }

            txtLab5Output.AppendText($"\n⏱ Время выполнения: {sw.ElapsedMilliseconds} мс");

            // Подсветка пути
            _highlightPath = new List<string>(path);
            _highlightEdges.Clear();
            RefreshAllGraphs();
        }

        // ==================== ЛАБОРАТОРНАЯ 6 ====================

        private void btnLab6Run_Click(object sender, EventArgs e)
        {
            if (_graph.Vertices.Count == 0)
            {
                MessageBox.Show("Сначала загрузите граф!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var sw = Stopwatch.StartNew();
            _articulationPoints = Algorithms.FindArticulationPoints(_graph);
            var mst = Algorithms.GetMSTPrim(_graph);
            sw.Stop();

            txtLab6Output.Clear();
            txtLab6Output.AppendText($"Точки сочленения ({_articulationPoints.Count}):\n");
            txtLab6Output.AppendText($"  {string.Join(", ", _articulationPoints)}\n\n");

            txtLab6Output.AppendText($"Минимальное остовное дерево:\n");
            txtLab6Output.AppendText($"  Суммарный вес: {mst.Sum(edge => edge.W)}\n");
            foreach (var edge in mst)
            {
                txtLab6Output.AppendText($"  {edge.U} -- {edge.V} ({edge.W})\n");
            }

            // Вариант 17: Ближайшая больница
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
                    txtLab6Output.AppendText("  Не найдено\n");
                }
            }

            txtLab6Output.AppendText($"\n⏱ Время выполнения: {sw.ElapsedMilliseconds} мс");

            // Подсветка МОД
            _highlightPath.Clear();
            _highlightEdges = mst.Select(edge => (edge.U, edge.V)).ToList();
            RefreshAllGraphs();
        }

        // ==================== СРАВНЕНИЕ ====================

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (_graph.Vertices.Count == 0)
            {
                MessageBox.Show("Сначала загрузите граф!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string start = txtCompareStart.Text.Trim();
            string target = txtCompareTarget.Text.Trim();

            if (!_graph.HasVertex(start) || !_graph.HasVertex(target))
            {
                MessageBox.Show("Обе вершины должны существовать!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvCompare.Rows.Clear();

            // BFS
            var sw1 = Stopwatch.StartNew();
            var bfsPath = Algorithms.BFS(_graph, start);
            int bfsIndex = bfsPath.IndexOf(target);
            var bfsResultPath = bfsIndex >= 0 ? string.Join(" -> ", bfsPath.Take(bfsIndex + 1)) : "Не найден";
            sw1.Stop();

            dgvCompare.Rows.Add("BFS", sw1.ElapsedMilliseconds,
                bfsIndex >= 0 ? $"{bfsIndex} переходов" : "Недостижима",
                bfsResultPath);

            // Dijkstra
            var sw2 = Stopwatch.StartNew();
            var (dist, parents) = Algorithms.Dijkstra(_graph, start);
            var dPath = Algorithms.ReconstructPath(parents, target);
            sw2.Stop();

            dgvCompare.Rows.Add("Дейкстра", sw2.ElapsedMilliseconds,
                dist[target] == int.MaxValue ? "Недостижима" : $"{dist[target]} ед.",
                string.Join(" -> ", dPath));
        }

        // ==================== PAINT EVENTS ====================

        private void pnlGraphMain_Paint(object sender, PaintEventArgs e)
        {
            DrawGraph(e.Graphics, pnlGraphMain.Width, pnlGraphMain.Height);
        }

        private void pnlGraphLab4_Paint(object sender, PaintEventArgs e)
        {
            DrawGraph(e.Graphics, pnlGraphLab4.Width, pnlGraphLab4.Height);
        }

        private void pnlGraphLab5_Paint(object sender, PaintEventArgs e)
        {
            DrawGraph(e.Graphics, pnlGraphLab5.Width, pnlGraphLab5.Height);
        }

        private void pnlGraphLab6_Paint(object sender, PaintEventArgs e)
        {
            DrawGraph(e.Graphics, pnlGraphLab6.Width, pnlGraphLab6.Height);
        }
    }
}
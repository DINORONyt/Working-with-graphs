using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lab456.Core;

/// <summary>
/// Представление графа в виде списка смежности
/// </summary>
public class Graph
{
    public Dictionary<string, List<(string Neighbor, int Weight)>> AdjacencyList { get; } = new();
    public HashSet<string> Vertices { get; } = new();
    public bool IsDirected { get; set; } = false; // По умолчанию неориентированный

    /// <summary>
    /// Загрузка графа из текстового файла
    /// Формат: Вершина1 Вершина2 Вес
    /// Строки с '#' - комментарии
    /// </summary>
    public void LoadFromTxt(string filePath)
    {
        AdjacencyList.Clear();
        Vertices.Clear();

        if (!File.Exists(filePath))
            throw new FileNotFoundException($"Файл не найден: {filePath}");

        var lines = File.ReadAllLines(filePath);
        int edgeCount = 0;

        foreach (var line in lines)
        {
            if (string.IsNullOrWhiteSpace(line) || line.Trim().StartsWith("#"))
                continue;

            char separator = line.Contains(',') ? ',' : ' ';
            var parts = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length < 2) continue;

            string u = parts[0].Trim();
            string v = parts[1].Trim();
            int weight = parts.Length > 2 ? int.Parse(parts[2].Trim()) : 1;

            if (weight < 0)
                throw new Exception($"Отрицательный вес ребра {u}-{v}: {weight}");

            Vertices.Add(u);
            Vertices.Add(v);

            if (!AdjacencyList.ContainsKey(u)) AdjacencyList[u] = new();
            if (!AdjacencyList.ContainsKey(v)) AdjacencyList[v] = new();

            AdjacencyList[u].Add((v, weight));

            if (!IsDirected)
                AdjacencyList[v].Add((u, weight));

            edgeCount++;
        }

        if (Vertices.Count == 0)
            throw new Exception("Граф пуст: файл не содержит валидных данных.");

        if (Vertices.Count < 15)
            throw new Exception($"Слишком мало вершин: {Vertices.Count} (требуется минимум 15)");

        if (edgeCount < 20)
            throw new Exception($"Слишком мало рёбер: {edgeCount} (требуется минимум 20)");
    }

    public bool HasVertex(string v) => Vertices.Contains(v);

    public int EdgeCount => AdjacencyList.Values.Sum(l => l.Count) / (IsDirected ? 1 : 2);
}

/// <summary>
/// Коллекция алгоритмов для работы с графами
/// </summary>
public static class Algorithms
{
    // ==================== ЛАБОРАТОРНАЯ 4 ====================

    public static List<string> BFS(Graph g, string start)
    {
        if (!g.HasVertex(start)) return new List<string>();

        var visited = new HashSet<string>();
        var queue = new Queue<string>();
        var order = new List<string>();

        queue.Enqueue(start);
        visited.Add(start);

        while (queue.Count > 0)
        {
            string current = queue.Dequeue();
            order.Add(current);

            foreach (var (neighbor, _) in g.AdjacencyList[current])
            {
                if (!visited.Contains(neighbor))
                {
                    visited.Add(neighbor);
                    queue.Enqueue(neighbor);
                }
            }
        }
        return order;
    }

    public static List<string> DFS(Graph g, string start)
    {
        if (!g.HasVertex(start)) return new List<string>();

        var visited = new HashSet<string>();
        var order = new List<string>();
        DFSRecursive(g, start, visited, order);
        return order;
    }

    private static void DFSRecursive(Graph g, string v, HashSet<string> visited, List<string> order)
    {
        visited.Add(v);
        order.Add(v);

        foreach (var (neighbor, _) in g.AdjacencyList[v])
        {
            if (!visited.Contains(neighbor))
                DFSRecursive(g, neighbor, visited, order);
        }
    }

    public static bool IsReachable(Graph g, string start, string target)
    {
        if (!g.HasVertex(start) || !g.HasVertex(target)) return false;
        return BFS(g, start).Contains(target);
    }

    public static List<List<string>> GetConnectedComponents(Graph g)
    {
        var visited = new HashSet<string>();
        var components = new List<List<string>>();

        foreach (var vertex in g.Vertices)
        {
            if (!visited.Contains(vertex))
            {
                var component = new List<string>();
                var queue = new Queue<string>();
                queue.Enqueue(vertex);
                visited.Add(vertex);

                while (queue.Count > 0)
                {
                    string current = queue.Dequeue();
                    component.Add(current);

                    foreach (var (neighbor, _) in g.AdjacencyList[current])
                    {
                        if (!visited.Contains(neighbor))
                        {
                            visited.Add(neighbor);
                            queue.Enqueue(neighbor);
                        }
                    }
                }
                components.Add(component);
            }
        }
        return components;
    }

    // ==================== ЛАБОРАТОРНАЯ 5 ====================

    public static (Dictionary<string, int> Distances, Dictionary<string, string> Parents) Dijkstra(Graph g, string start)
    {
        var distances = g.Vertices.ToDictionary(v => v, v => int.MaxValue);
        var parents = new Dictionary<string, string>();
        var visited = new HashSet<string>();
        var pq = new PriorityQueue<string, int>();

        if (!distances.ContainsKey(start)) return (distances, parents);

        distances[start] = 0;
        pq.Enqueue(start, 0);

        while (pq.Count > 0)
        {
            string current = pq.Dequeue();
            if (visited.Contains(current)) continue;
            visited.Add(current);

            foreach (var (neighbor, weight) in g.AdjacencyList[current])
            {
                if (!visited.Contains(neighbor))
                {
                    int newDist = distances[current] + weight;
                    if (newDist < distances[neighbor])
                    {
                        distances[neighbor] = newDist;
                        parents[neighbor] = current;
                        pq.Enqueue(neighbor, newDist);
                    }
                }
            }
        }
        return (distances, parents);
    }

    public static List<string> ReconstructPath(Dictionary<string, string> parents, string target)
    {
        var path = new List<string>();
        string? current = target;

        while (current != null)
        {
            path.Add(current);
            if (parents.TryGetValue(current, out var prev))
                current = prev;
            else
                current = null;
        }

        path.Reverse();
        return path;
    }

    // ==================== ЛАБОРАТОРНАЯ 6 ====================

    public static List<string> FindArticulationPoints(Graph g)
    {
        var points = new HashSet<string>();
        var visited = new HashSet<string>();
        var disc = new Dictionary<string, int>();
        var low = new Dictionary<string, int>();
        var parent = new Dictionary<string, string?>();
        int time = 0;

        void APUtil(string u)
        {
            int children = 0;
            visited.Add(u);
            disc[u] = low[u] = ++time;

            foreach (var (v, _) in g.AdjacencyList[u])
            {
                if (!visited.Contains(v))
                {
                    children++;
                    parent[v] = u;
                    APUtil(v);
                    low[u] = Math.Min(low[u], low[v]);

                    if (parent.GetValueOrDefault(u) == null && children > 1)
                        points.Add(u);
                    if (parent.GetValueOrDefault(u) != null && low[v] >= disc[u])
                        points.Add(u);
                }
                else if (v != parent.GetValueOrDefault(u))
                {
                    low[u] = Math.Min(low[u], disc[v]);
                }
            }
        }

        foreach (var v in g.Vertices)
        {
            if (!visited.Contains(v))
                APUtil(v);
        }
        return points.ToList();
    }

    public static List<(string U, string V, int W)> GetMSTPrim(Graph g)
    {
        var mst = new List<(string, string, int)>();
        var inMST = new HashSet<string>();
        var pq = new PriorityQueue<(string U, string V, int W), int>();

        if (g.Vertices.Count == 0) return mst;

        string start = g.Vertices.First();
        inMST.Add(start);

        foreach (var (neighbor, weight) in g.AdjacencyList[start])
            pq.Enqueue((start, neighbor, weight), weight);

        while (pq.Count > 0 && inMST.Count < g.Vertices.Count)
        {
            var edge = pq.Dequeue();
            if (inMST.Contains(edge.V)) continue;

            inMST.Add(edge.V);
            mst.Add(edge);

            foreach (var (neighbor, weight) in g.AdjacencyList[edge.V])
            {
                if (!inMST.Contains(neighbor))
                    pq.Enqueue((edge.V, neighbor, weight), weight);
            }
        }
        return mst;
    }

    /// <summary>
    /// Вариант 17: Поиск ближайшей больницы и маршрута к ней
    /// </summary>
    public static (string Hospital, List<string> Path, int Time) FindNearestHospital(
        Graph g, string start, HashSet<string> hospitals)
    {
        var (distances, parents) = Dijkstra(g, start);

        string? nearest = null;
        int minTime = int.MaxValue;

        foreach (var h in hospitals)
        {
            if (distances.ContainsKey(h) && distances[h] < minTime)
            {
                minTime = distances[h];
                nearest = h;
            }
        }

        if (nearest == null || minTime == int.MaxValue)
            return ("Не найдено", new List<string>(), -1);

        var path = ReconstructPath(parents, nearest);
        return (nearest, path, minTime);
    }

    /// <summary>
    /// Сравнение BFS и Дейкстры для поиска кратчайшего пути
    /// </summary>
    public static (int BfsHops, int DijkstraWeight, string Path) CompareBfsAndDijkstra(
        Graph g, string start, string target)
    {
        var bfsPath = new List<string>();
        int bfsHops = -1;

        // BFS для поиска пути (по количеству рёбер)
        var visited = new HashSet<string>();
        var queue = new Queue<(string Vertex, List<string> Path)>();
        queue.Enqueue((start, new List<string> { start }));
        visited.Add(start);

        while (queue.Count > 0)
        {
            var (current, path) = queue.Dequeue();
            if (current == target)
            {
                bfsPath = path;
                bfsHops = path.Count - 1;
                break;
            }

            foreach (var (neighbor, _) in g.AdjacencyList[current])
            {
                if (!visited.Contains(neighbor))
                {
                    visited.Add(neighbor);
                    var newPath = new List<string>(path) { neighbor };
                    queue.Enqueue((neighbor, newPath));
                }
            }
        }

        // Дейкстра для поиска пути (по весу)
        var (distances, parents) = Dijkstra(g, start);
        int dijkstraWeight = distances.ContainsKey(target) ? distances[target] : -1;

        return (bfsHops, dijkstraWeight, string.Join(" -> ", bfsPath));
    }
}
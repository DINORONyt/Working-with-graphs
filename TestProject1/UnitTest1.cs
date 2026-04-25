using Xunit;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Lab456.Core;

namespace TestProject1
{
    public class GraphTests
    {
        // ==================== ВСПОМОГАТЕЛЬНЫЕ МЕТОДЫ ====================

        /// <summary>
        /// Создаёт тестовый граф программно (без файла)
        /// </summary>
        private Graph CreateTestGraph()
        {
            var graph = new Graph();

            // Простой граф: A-B-C-D (цепочка)
            graph.Vertices.Add("A");
            graph.Vertices.Add("B");
            graph.Vertices.Add("C");
            graph.Vertices.Add("D");

            graph.AdjacencyList["A"] = new List<(string, int)> { ("B", 5) };
            graph.AdjacencyList["B"] = new List<(string, int)> { ("A", 5), ("C", 3) };
            graph.AdjacencyList["C"] = new List<(string, int)> { ("B", 3), ("D", 2) };
            graph.AdjacencyList["D"] = new List<(string, int)> { ("C", 2) };

            return graph;
        }

        /// <summary>
        /// Создаёт граф для варианта 17 (больницы)
        /// </summary>
        private Graph CreateHospitalGraph()
        {
            var graph = new Graph();

            // 3 больницы + 2 медпункта
            var vertices = new[] {
                "Central_Hospital", "North_Hospital", "South_Hospital",
                "MedPoint_1", "MedPoint_2"
            };

            foreach (var v in vertices)
            {
                graph.Vertices.Add(v);
                graph.AdjacencyList[v] = new List<(string, int)>();
            }

            // Рёбра с весами
            graph.AdjacencyList["Central_Hospital"].Add(("MedPoint_1", 10));
            graph.AdjacencyList["MedPoint_1"].Add(("Central_Hospital", 10));

            graph.AdjacencyList["Central_Hospital"].Add(("MedPoint_2", 15));
            graph.AdjacencyList["MedPoint_2"].Add(("Central_Hospital", 15));

            graph.AdjacencyList["North_Hospital"].Add(("MedPoint_1", 5));
            graph.AdjacencyList["MedPoint_1"].Add(("North_Hospital", 5));

            graph.AdjacencyList["South_Hospital"].Add(("MedPoint_2", 7));
            graph.AdjacencyList["MedPoint_2"].Add(("South_Hospital", 7));

            graph.AdjacencyList["MedPoint_1"].Add(("MedPoint_2", 20));
            graph.AdjacencyList["MedPoint_2"].Add(("MedPoint_1", 20));

            return graph;
        }

        /// <summary>
        /// Создаёт временный файл графа
        /// </summary>
        private string CreateTempGraphFile(string content)
        {
            var path = Path.GetTempFileName() + ".txt";
            File.WriteAllText(path, content);
            return path;
        }

        // ==================== ЛАБОРАТОРНАЯ 4 ====================

        public class Lab4_Tests : GraphTests
        {
            [Fact]
            public void BFS_VerifiesVisitOrder()
            {
                // Arrange
                var graph = CreateTestGraph();

                // Act
                var result = Algorithms.BFS(graph, "A");

                // Assert
                Assert.NotNull(result);
                Assert.Equal(4, result.Count);
                Assert.Equal("A", result[0]); // Начинается с A
                Assert.Contains("B", result);
                Assert.Contains("C", result);
                Assert.Contains("D", result);
            }

            [Fact]
            public void DFS_VerifiesVisitOrder()
            {
                // Arrange
                var graph = CreateTestGraph();

                // Act
                var result = Algorithms.DFS(graph, "A");

                // Assert
                Assert.NotNull(result);
                Assert.Equal(4, result.Count);
                Assert.Equal("A", result[0]);
                // DFS должен пойти в глубину: A->B->C->D
                Assert.Equal("D", result[^1]); // Последний элемент
            }

            [Fact]
            public void IsReachable_ReturnsTrue_ForConnectedVertices()
            {
                // Arrange
                var graph = CreateTestGraph();

                // Act & Assert
                Assert.True(Algorithms.IsReachable(graph, "A", "D"));
                Assert.True(Algorithms.IsReachable(graph, "D", "A"));
            }

            [Fact]
            public void IsReachable_ReturnsFalse_ForDisconnectedVertices()
            {
                // Arrange
                var graph = new Graph();
                graph.Vertices.Add("X");
                graph.Vertices.Add("Y");
                graph.AdjacencyList["X"] = new List<(string, int)>();
                graph.AdjacencyList["Y"] = new List<(string, int)>();

                // Act & Assert
                Assert.False(Algorithms.IsReachable(graph, "X", "Y"));
            }

            [Fact]
            public void GetConnectedComponents_ReturnsSingleComponent_ForConnectedGraph()
            {
                // Arrange
                var graph = CreateTestGraph();

                // Act
                var components = Algorithms.GetConnectedComponents(graph);

                // Assert
                Assert.Single(components); // Одна компонента
                Assert.Equal(4, components[0].Count);
            }

            [Fact]
            public void GetConnectedComponents_ReturnsMultipleComponents_ForDisconnectedGraph()
            {
                // Arrange
                var graph = new Graph();

                // Компонента 1: A-B
                graph.Vertices.Add("A");
                graph.Vertices.Add("B");
                graph.AdjacencyList["A"] = new List<(string, int)> { ("B", 1) };
                graph.AdjacencyList["B"] = new List<(string, int)> { ("A", 1) };

                // Компонента 2: C-D
                graph.Vertices.Add("C");
                graph.Vertices.Add("D");
                graph.AdjacencyList["C"] = new List<(string, int)> { ("D", 1) };
                graph.AdjacencyList["D"] = new List<(string, int)> { ("C", 1) };

                // Act
                var components = Algorithms.GetConnectedComponents(graph);

                // Assert
                Assert.Equal(2, components.Count);
            }

            [Fact]
            public void BFS_ReturnsEmptyList_ForInvalidStartVertex()
            {
                // Arrange
                var graph = CreateTestGraph();

                // Act
                var result = Algorithms.BFS(graph, "INVALID");

                // Assert
                Assert.Empty(result);
            }
        }

        // ==================== ЛАБОРАТОРНАЯ 5 ====================

        public class Lab5_Tests : GraphTests
        {
            [Fact]
            public void Dijkstra_CalculatesCorrectDistances()
            {
                // Arrange
                var graph = CreateTestGraph();

                // Act
                var (distances, _) = Algorithms.Dijkstra(graph, "A");

                // Assert
                Assert.Equal(0, distances["A"]);
                Assert.Equal(5, distances["B"]);
                Assert.Equal(8, distances["C"]); // A->B->C = 5+3
                Assert.Equal(10, distances["D"]); // A->B->C->D = 5+3+2
            }

            [Fact]
            public void Dijkstra_ReconstructsCorrectPath()
            {
                // Arrange
                var graph = CreateTestGraph();
                var (_, parents) = Algorithms.Dijkstra(graph, "A");

                // Act
                var path = Algorithms.ReconstructPath(parents, "D");

                // Assert
                Assert.NotNull(path);
                Assert.Equal(4, path.Count);
                Assert.Equal("A", path[0]);
                Assert.Equal("D", path[^1]);
                Assert.Contains("B", path);
                Assert.Contains("C", path);
            }

            [Fact]
            public void Dijkstra_HandlesUnreachableVertices()
            {
                // Arrange
                var graph = new Graph();
                graph.Vertices.Add("X");
                graph.Vertices.Add("Y");
                graph.AdjacencyList["X"] = new List<(string, int)>();
                graph.AdjacencyList["Y"] = new List<(string, int)>();

                // Act
                var (distances, _) = Algorithms.Dijkstra(graph, "X");

                // Assert
                Assert.Equal(0, distances["X"]);
                Assert.Equal(int.MaxValue, distances["Y"]); // Недостижима
            }

            [Fact]
            public void Dijkstra_Works_WithHospitalGraph()
            {
                // Arrange
                var graph = CreateHospitalGraph();

                // Act
                var (distances, parents) = Algorithms.Dijkstra(graph, "MedPoint_1");

                // Assert
                Assert.Equal(0, distances["MedPoint_1"]);
                Assert.Equal(5, distances["North_Hospital"]); // Ближайшая больница
                Assert.Equal(10, distances["Central_Hospital"]);
            }
        }

        // ==================== ЛАБОРАТОРНАЯ 6 ====================

        public class Lab6_Tests : GraphTests
        {
            [Fact]
            public void FindArticulationPoints_DetectsBridgeVertex()
            {
                // Arrange
                // Граф: A-B-C-D (B и C - точки сочленения)
                var graph = new Graph();
                var vertices = new[] { "A", "B", "C", "D" };
                foreach (var v in vertices)
                {
                    graph.Vertices.Add(v);
                    graph.AdjacencyList[v] = new List<(string, int)>();
                }

                graph.AdjacencyList["A"].Add(("B", 1));
                graph.AdjacencyList["B"].Add(("A", 1));
                graph.AdjacencyList["B"].Add(("C", 1));
                graph.AdjacencyList["C"].Add(("B", 1));
                graph.AdjacencyList["C"].Add(("D", 1));
                graph.AdjacencyList["D"].Add(("C", 1));

                // Act
                var points = Algorithms.FindArticulationPoints(graph);

                // Assert
                Assert.Contains("B", points);
                Assert.Contains("C", points);
                Assert.DoesNotContain("A", points); // Концевые вершины
                Assert.DoesNotContain("D", points);
            }

            [Fact]
            public void GetMSTPrim_CalculatesCorrectWeight()
            {
                // Arrange
                var graph = CreateTestGraph();

                // Act
                var mst = Algorithms.GetMSTPrim(graph);
                var totalWeight = mst.Sum(e => e.W);

                // Assert
                Assert.Equal(3, mst.Count); // V-1 рёбер для 4 вершин
                Assert.Equal(10, totalWeight); // 5+3+2
            }

            [Fact]
            public void GetMSTPrim_ConnectsAllVertices()
            {
                // Arrange
                var graph = CreateTestGraph();

                // Act
                var mst = Algorithms.GetMSTPrim(graph);

                // Assert
                var verticesInMst = new HashSet<string>();
                foreach (var edge in mst)
                {
                    verticesInMst.Add(edge.U);
                    verticesInMst.Add(edge.V);
                }

                Assert.Equal(graph.Vertices.Count, verticesInMst.Count);
            }

            [Fact]
            public void FindNearestHospital_ReturnsCorrectHospital()
            {
                // Arrange
                var graph = CreateHospitalGraph();
                var hospitals = new HashSet<string>
                {
                    "Central_Hospital",
                    "North_Hospital",
                    "South_Hospital"
                };

                // Act
                var (nearest, path, time) = Algorithms.FindNearestHospital(
                    graph, "MedPoint_1", hospitals);

                // Assert
                Assert.Equal("North_Hospital", nearest); // Ближайшая (5 мин)
                Assert.Equal(5, time);
                Assert.Contains("MedPoint_1", path);
                Assert.Contains("North_Hospital", path);
            }

            [Fact]
            public void FindNearestHospital_ReturnsNotFound_ForNoHospitals()
            {
                // Arrange
                var graph = CreateTestGraph();
                var hospitals = new HashSet<string> { "NonExistent" };

                // Act
                var (nearest, path, time) = Algorithms.FindNearestHospital(
                    graph, "A", hospitals);

                // Assert
                Assert.Equal(-1, time);
                Assert.Empty(path);
            }
        }

        // ==================== ЗАГРУЗКА ИЗ ФАЙЛА ====================

        public class FileLoading_Tests : GraphTests
        {
            [Fact]
            public void LoadFromTxt_ParsesCorrectFormat()
            {
                // Arrange
                var content = @"
                A B 5
                B C 3
                C D 2
                ";
                var filePath = CreateTempGraphFile(content);
                var graph = new Graph();

                try
                {
                    // Act
                    graph.LoadFromTxt(filePath);

                    // Assert
                    Assert.Equal(4, graph.Vertices.Count);
                    Assert.True(graph.HasVertex("A"));
                    Assert.True(graph.HasVertex("B"));
                }
                finally
                {
                    File.Delete(filePath);
                }
            }

            [Fact]
            public void LoadFromTxt_SkipsComments()
            {
                // Arrange
                var content = @"
                # Это комментарий
                A B 5
                # Ещё комментарий
                B C 3
                ";
                var filePath = CreateTempGraphFile(content);
                var graph = new Graph();

                try
                {
                    // Act
                    graph.LoadFromTxt(filePath);

                    // Assert
                    Assert.Equal(3, graph.Vertices.Count);
                }
                finally
                {
                    File.Delete(filePath);
                }
            }

            [Fact]
            public void LoadFromTxt_ThrowsException_ForNonExistentFile()
            {
                // Arrange
                var graph = new Graph();

                // Act & Assert
                Assert.Throws<FileNotFoundException>(() =>
                    graph.LoadFromTxt("non_existent_file.txt"));
            }

            [Fact]
            public void LoadFromTxt_ThrowsException_ForEmptyFile()
            {
                // Arrange
                var content = @"
                # Только комментарии
                ";
                var filePath = CreateTempGraphFile(content);
                var graph = new Graph();

                try
                {
                    // Act & Assert
                    Assert.Throws<Exception>(() => graph.LoadFromTxt(filePath));
                }
                finally
                {
                    File.Delete(filePath);
                }
            }
        }

        // ==================== ПРОИЗВОДИТЕЛЬНОСТЬ ====================

        public class Performance_Tests : GraphTests
        {
            [Fact]
            public void BFS_CompletesWithinTimeLimit_ForLargeGraph()
            {
                // Arrange
                var graph = CreateLargeGraph(100); // 100 вершин

                // Act
                var stopwatch = System.Diagnostics.Stopwatch.StartNew();
                var result = Algorithms.BFS(graph, "V0");
                stopwatch.Stop();

                // Assert
                Assert.Equal(100, result.Count);
                Assert.True(stopwatch.ElapsedMilliseconds < 1000,
                    $"BFS занял слишком много времени: {stopwatch.ElapsedMilliseconds} мс");
            }

            [Fact]
            public void Dijkstra_CompletesWithinTimeLimit_ForLargeGraph()
            {
                // Arrange
                var graph = CreateLargeGraph(100);

                // Act
                var stopwatch = System.Diagnostics.Stopwatch.StartNew();
                var (distances, _) = Algorithms.Dijkstra(graph, "V0");
                stopwatch.Stop();

                // Assert
                Assert.Equal(100, distances.Count);
                Assert.True(stopwatch.ElapsedMilliseconds < 1000,
                    $"Dijkstra занял слишком много времени: {stopwatch.ElapsedMilliseconds} мс");
            }

            /// <summary>
            /// Создаёт большой граф для тестов производительности
            /// </summary>
            private Graph CreateLargeGraph(int vertexCount)
            {
                var graph = new Graph();

                for (int i = 0; i < vertexCount; i++)
                {
                    var name = $"V{i}";
                    graph.Vertices.Add(name);
                    graph.AdjacencyList[name] = new List<(string, int)>();

                    // Соединяем с предыдущей вершиной (цепочка)
                    if (i > 0)
                    {
                        var prev = $"V{i - 1}";
                        graph.AdjacencyList[name].Add((prev, 1));
                        graph.AdjacencyList[prev].Add((name, 1));
                    }
                }

                return graph;
            }
        }
    }
}
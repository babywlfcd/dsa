using Practice.Graphs;

namespace PracticeTests.Graphs
{
    public class GraphMatrixTests
    {
        [Fact]
        public void TestAdjacencyMatrix_UnweightedUndirectedGraph()
        {
            var graph = new GraphMatrix(5);
            var graphMatrix = graph.CreateAdjacencyMatrix();
            graph.AddEdgeUnWeightedUndirected(1, 2);
            graph.AddEdgeUnWeightedUndirected(1, 4);
            graph.AddEdgeUnWeightedUndirected(2, 3);
            graph.AddEdgeUnWeightedUndirected(2, 5);
            graph.AddEdgeUnWeightedUndirected(2, 4);
            graph.AddEdgeUnWeightedUndirected(3, 5);
            graph.AddEdgeUnWeightedUndirected(3, 4);

            var result = graph.PrintGraph();
            Assert.Equal(
                "0 0 0 0 0 0 \r\n" +
                "0 0 1 0 1 0 \r\n" +
                "0 1 0 1 1 1 \r\n" +
                "0 0 1 0 1 1 \r\n" +
                "0 1 1 1 0 0 \r\n" +
                "0 0 1 1 0 0 \r\n", result);
        }

        [Fact]
        public void TestAdjacencyMatrix_UnweightedDirectedGraph()
        {
            var graph = new GraphMatrix(5);
            var graphMatrix = graph.CreateAdjacencyMatrix();
            graph.AddEdgeUnWeightedDirected(1, 2);
            graph.AddEdgeUnWeightedDirected(1, 4);
            graph.AddEdgeUnWeightedDirected(2, 3);
            graph.AddEdgeUnWeightedDirected(2, 5);
            graph.AddEdgeUnWeightedDirected(2, 4);
            graph.AddEdgeUnWeightedDirected(3, 5);
            graph.AddEdgeUnWeightedDirected(3, 4);

            var result = graph.PrintGraph();
            Assert.Equal(
                "0 0 0 0 0 0 \r\n" +
                "0 0 1 0 1 0 \r\n" +
                "0 0 0 1 1 1 \r\n" +
                "0 0 0 0 1 1 \r\n" +
                "0 0 0 0 0 0 \r\n" +
                "0 0 0 0 0 0 \r\n", result);
        }

        [Fact]
        public void TestAdjacencyMatrix_WeightedUndirectedGraph()
        {
            var graph = new GraphMatrix(5);
            var graphMatrix = graph.CreateAdjacencyMatrix();
            graph.AddEdgeWeightedUndirected(1, 2, 12);
            graph.AddEdgeWeightedUndirected(1, 4, 15);
            graph.AddEdgeWeightedUndirected(2, 3, 8);
            graph.AddEdgeWeightedUndirected(2, 5, 5);
            graph.AddEdgeWeightedUndirected(2, 4, 10);
            graph.AddEdgeWeightedUndirected(3, 5, 11);
            graph.AddEdgeWeightedUndirected(3, 4, 3);

            var result = graph.PrintGraph();
            Assert.Equal(
                "0 0 0 0 0 0 \r\n" +
                "0 0 12 0 15 0 \r\n" +
                "0 12 0 8 10 5 \r\n" +
                "0 0 8 0 3 11 \r\n" +
                "0 15 10 3 0 0 \r\n" +
                "0 0 5 11 0 0 \r\n", result);
        }

        [Fact]
        public void TestAdjacencyMatrix_WeightedDirectedGraph()
        {
            var graph = new GraphMatrix(5);
            var graphMatrix = graph.CreateAdjacencyMatrix();
            graph.AddEdgeWeightedDirected(1, 2, 12);
            graph.AddEdgeWeightedDirected(1, 4, 15);
            graph.AddEdgeWeightedDirected(2, 3, 8);
            graph.AddEdgeWeightedDirected(2, 5, 5);
            graph.AddEdgeWeightedDirected(2, 4, 10);
            graph.AddEdgeWeightedDirected(3, 5, 11);
            graph.AddEdgeWeightedDirected(3, 4, 3);

            var result = graph.PrintGraph();
            Assert.Equal(
                "0 0 0 0 0 0 \r\n" +
                "0 0 12 0 15 0 \r\n" +
                "0 0 0 8 10 5 \r\n" +
                "0 0 0 0 3 11 \r\n" +
                "0 0 0 0 0 0 \r\n" +
                "0 0 0 0 0 0 \r\n", result);
        }
    }
}

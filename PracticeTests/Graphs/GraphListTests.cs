using Practice.Graphs;

namespace PracticeTests.Graphs
{
    public class GraphListTests
    {
        public static IEnumerable<object[]> GraphData()
        {
            //graph = { 0: [1, 2], 1: [3], 2: [], 3: [4], 4: []}, source = 0, destination = 4.
            yield return new object[]
            {
                5,
                new int[][] {
                    new int[] { 1, 2 },
                    new int[] { 1, 4 },
                    new int[] { 2, 3 },
                    new int[] { 2, 5 },
                    new int[] { 2, 4 },
                    new int[] { 3, 5 },
                    new int[] { 3, 4 } },
                "0: 2 4 \r\n" +
                "1: 1 3 5 4 \r\n" +
                "2: 2 5 4 \r\n" +
                "3: 1 2 3 \r\n" +
                "4: 2 3 \r\n"
            };
        }

        [Theory]
        [MemberData(nameof(GraphData))]
        public void TestAdjacencyList_UnweightedUndirectedGraph(int v, int[][] edges, string expected)
        {
            var graph = new GraphList(v, edges);
            var graphMatrix = graph.CreateAdjacencyListUnWeightedUndirected();
           
            var result = graph.PrintGraph();
            Assert.Equal(
                //"0: \r\n" + // if  we want to not handle 0 based index we can create a list of size vertices + 1
                expected, result);
        }

        [Fact]
        public void TestAdjacencyList_UnweightedUndirectedGraph_CreateGraph()
        {
            var graph = new GraphList(5, new int[][] { });
            var graphMatrix = graph.CreateAdjacencyList();
            graph.AddEdgeUnWeightedUndirected(1, 2);
            graph.AddEdgeUnWeightedUndirected(1, 4);
            graph.AddEdgeUnWeightedUndirected(2, 3);
            graph.AddEdgeUnWeightedUndirected(2, 5);
            graph.AddEdgeUnWeightedUndirected(2, 4);
            graph.AddEdgeUnWeightedUndirected(3, 5);
            graph.AddEdgeUnWeightedUndirected(3, 4);

            var result = graph.PrintGraph();
            Assert.Equal(
                //"0: \r\n" + // if  we want to not handle 0 based index we can create a list of size vertices + 1
                "0: 2 4 \r\n" +
                "1: 1 3 5 4 \r\n" +
                "2: 2 5 4 \r\n" +
                "3: 1 2 3 \r\n" +
                "4: 2 3 \r\n", result);
        }

        [Fact]
        public void TestAdjacencyMatrix_UnweightedDirectedGraph()
        {
            var graph = new GraphList(5, new int[][] {});
            var graphMatrix = graph.CreateAdjacencyList();
            graph.AddEdgeUnWeightedDirected(1, 2);
            graph.AddEdgeUnWeightedDirected(1, 4);
            graph.AddEdgeUnWeightedDirected(2, 3);
            graph.AddEdgeUnWeightedDirected(2, 5);
            graph.AddEdgeUnWeightedDirected(2, 4);
            graph.AddEdgeUnWeightedDirected(3, 5);
            graph.AddEdgeUnWeightedDirected(3, 4);

            var result = graph.PrintGraph();
            Assert.Equal(
                //"0: \r\n" +
                "0: 2 4 \r\n" +
                "1: 3 5 4 \r\n" +
                "2: 5 4 \r\n" +
                "3: \r\n" +
                "4: \r\n", result);
        }

        [Fact]
        public void TestAdjacencyMatrix_WeightedUndirectedGraph()
        {
            var graph = new GraphList(5, new int[][] { });
            var graphMatrix = graph.CreateAdjacencyListWheighted();
            graph.AddEdgeWeightedUndirected(1, 2, 12);
            graph.AddEdgeWeightedUndirected(1, 4, 15);
            graph.AddEdgeWeightedUndirected(2, 3, 8);
            graph.AddEdgeWeightedUndirected(2, 5, 5);
            graph.AddEdgeWeightedUndirected(2, 4, 10);
            graph.AddEdgeWeightedUndirected(3, 5, 11);
            graph.AddEdgeWeightedUndirected(3, 4, 3);

            var result = graph.PrintGraphWeight();
            Assert.Equal(
                //"0 0 0 0 0 0 \r\n" +
                "0: (2, 12) (4, 15) \r\n" +
                "1: (1, 12) (3, 8) (5, 5) (4, 10) \r\n" +
                "2: (2, 8) (5, 11) (4, 3) \r\n" +
                "3: (1, 15) (2, 10) (3, 3) \r\n" +
                "4: (2, 5) (3, 11) \r\n", result);
        }

        [Fact]
        public void TestAdjacencyMatrix_WeightedDirectedGraph()
        {
            var graph = new GraphList(5, new int[][] { });
            var graphMatrix = graph.CreateAdjacencyListWheighted();
            graph.AddEdgeWeightedDirected(1, 2, 12);
            graph.AddEdgeWeightedDirected(1, 4, 15);
            graph.AddEdgeWeightedDirected(2, 3, 8);
            graph.AddEdgeWeightedDirected(2, 5, 5);
            graph.AddEdgeWeightedDirected(2, 4, 10);
            graph.AddEdgeWeightedDirected(3, 5, 11);
            graph.AddEdgeWeightedDirected(3, 4, 3);

            var result = graph.PrintGraphWeight();
            Assert.Equal(
                //"0 0 0 0 0 0 \r\n" +
                "0: (2, 12) (4, 15) \r\n" +
                "1: (3, 8) (5, 5) (4, 10) \r\n" +
                "2: (5, 11) (4, 3) \r\n" +
                "3: \r\n" +
                "4: \r\n", result);
        }
    }
}

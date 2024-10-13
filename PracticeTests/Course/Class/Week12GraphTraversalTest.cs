using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice.Course.Class;

namespace PracticeTests.Course.Class
{
    public class Week12GraphTraversalTest
    {
        //MethodName_StateUnderTest_ExpectedBehavior
        [Theory]
        [MemberData(nameof(PathValidationDataBST))]

        public void PathExist_Graph_ValidatePathBetweenTwoNodes(List<List<int>> graph, int s, int d, bool expected)
        {
            var sut = new Week12GraphTraversal();
            var actual = sut.PathExist(graph, s, d);
            Assert.Equal(expected, actual);
        }


        public static IEnumerable<object[]> PathValidationDataBST()
        {
            yield return new object[]
            {
                new List<List<int>>
                {
                    new List<int>(),
                    new List<int> {2, 4},
                    new List<int> {1, 3, 4},
                    new List<int> {2, 5},
                    new List<int> {1, 2, 5},
                    new List<int> {3, 4, 6},
                    new List<int> {5}
                },
                1, 6, true
            };
            yield return new object[]
            {
                new List<List<int>>
                {
                    new List<int>(),
                    new List<int> {2, 4},
                    new List<int> {1, 3, 4},
                    new List<int> {2, 5},
                    new List<int> {1, 2, 5},
                    new List<int> {3, 4, },
                    new List<int> {}
                },
                1, 6, false
            };
        }

        [Theory]
        [MemberData(nameof(ShortestPathValidationDataBST))]

        public void FindShortestPath_Graph_NumberOfEdgesBetweenSourceAndDestination(List<List<int>> graph, int s, int d, int expected)
        {
            var sut = new Week12GraphTraversal();
            var actual = sut.FindShortestPath(graph, s, d);
            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> ShortestPathValidationDataBST()
        {
            yield return new object[]
            {
                new List<List<int>>
                {
                    new List<int>(),
                    new List<int> {2, 4},
                    new List<int> {1, 3, 4},
                    new List<int> {2, 5},
                    new List<int> {1, 2, 5},
                    new List<int> {3, 4, 6},
                    new List<int> {5}
                },
                1, 6, 3
            };
        }

        [Theory]
        [MemberData(nameof(PathBetweenTwoNodesDataBST))]

        public void StorePath_Graph_PathBetweenTwoNodes(List<List<int>> graph, int s, int d, int[] expected)
        {
            var sut = new Week12GraphTraversal();
            var actual = sut.StorePath(graph, s, d);
            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> PathBetweenTwoNodesDataBST()
        {
            yield return new object[]
            {
                new List<List<int>>
                {
                    new List<int>(),
                    new List<int> {2, 4},
                    new List<int> {1, 3, 4},
                    new List<int> {2, 5},
                    new List<int> {1, 2, 5},
                    new List<int> {3, 4, 6},
                    new List<int> {5}
                },
                1, 6, 
                new int[] {1, 4, 5, 6}
            };
        }


        [Theory]
        [MemberData(nameof(TraverseGraphDataDFS))]

        public void TraverseGraph_Graph_ValidatePathBetweenTwoNodes(List<List<int>> graph, int u, bool expected)
        {
            var sut = new Week12GraphTraversal();
            var actual = sut.TraverseGraph(graph, u);
            Assert.Equal(expected, actual);
        }


        public static IEnumerable<object[]> TraverseGraphDataDFS()
        {
            yield return new object[]
            {
                new List<List<int>>
                {
                    new List<int>(),
                    new List<int> {2, 4},
                    new List<int> {1, 3, 4},
                    new List<int> {2, 5},
                    new List<int> {1, 2, 5},
                    new List<int> {3, 4, 6},
                    new List<int> {5}
                },
                6, true
            };
            yield return new object[]
            {
                new List<List<int>>
                {
                    new List<int>(),
                    new List<int> {2, 4},
                    new List<int> {1, 3, 4},
                    new List<int> {2, 5},
                    new List<int> {1, 2, 5},
                    new List<int> {3, 4, 6},
                    new List<int> {5}
                },
                7, false
            };
        }

        [Theory]
        [MemberData(nameof(ConnectedComponentsDataDFS))]

        public void FindConnectedComponents_Graph_NumberOfConnectedComponents(List<List<int>> graph, int expected)
        {
            var sut = new Week12GraphTraversal();
            var actual = sut.FindConnectedComponents(graph);
            Assert.Equal(expected, actual);
        }


        public static IEnumerable<object[]> ConnectedComponentsDataDFS()
        {
            yield return new object[]
            {
                new List<List<int>>
                {
                    //new List<int>(),
                    // 1 2 3 4 
                    new List<int> {2, 4},
                    new List<int> {1, 4},
                    new List<int> {4},
                    new List<int> {2, 1, 3},
                    // 5 6 7
                    new List<int> {7, 6},
                    new List<int> {7, 5},
                    new List<int> {6, 5},
                    // 9 10
                    new List<int> {10},
                    new List<int> {9},
                    //single nodes
                    new List<int> {8},
                    new List<int> {12}

                },
                5
            };
        }
    }
}

using Practice.Course.Assignments;
using Practice.Course.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTests.Course.Assignments
{
    public class GraphsAssignmentTests
    {
        [Theory]
        [MemberData(nameof(PathValidationDataBST))]

        public void PathExist_Graph_ValidatePathBetweenTwoNodes(List<List<int>> graph, int s, int d, bool expected)
        {
            var sut = new GraphsAssignment();
            var actual = sut.PathExist(graph, s, d);
            Assert.Equal(expected, actual);
        }


        public static IEnumerable<object[]> PathValidationDataBST()
        {
            // Input: graph = {0: [1], 1: [2], 2: [5], 3: [4], 4: [0], 5: [3]}, source = 0, destination = 3.
            yield return new object[]
            {
                new List<List<int>>
                {
                    new List<int> {1},
                    new List<int> {2},
                    new List<int> {5},
                    new List<int> {4},
                    new List<int> {0},
                    new List<int> {3}
                },
                0, 5, true
            };
            //graph = { 0: [1], 1: [2], 2: [3]}, source = 0, destination = 3
            yield return new object[]
            {
                new List<List<int>>
                {
                    new List<int> {1},
                    new List<int> {2},
                    new List<int> {3},
                    new List<int> {},
                },
                0, 3, true
            };
            //graph = { 0: [1, 2], 1: [3], 2: [], 3: [4], 4: []}, source = 0, destination = 4.
            yield return new object[]
            {
                new List<List<int>>
                {
                    new List<int> {1, 2},
                    new List<int> {3},
                    new List<int> {},
                    new List<int> {4},
                    new List<int> {}
                },
                0, 4, true
            };
            //Input: graph = {0: [1], 1: [2], 2: [3], 3: [0]}, source = 0, destination = 3.
            yield return new object[]
            {
                new List<List<int>>
                {
                    new List<int> {1},
                    new List<int> {2},
                    new List<int> {3},
                    new List<int> {0},
                },
                0, 3, true
            };
            //Input: graph = {0: [], 1: [], 2: [], 3: []}, source = 0, destination = 3.
            yield return new object[]
            {
                new List<List<int>>
                {
                    new List<int> {},
                    new List<int> {},
                    new List<int> {},
                    new List<int> {},
                },
                0, 3, false
            };

        }
    }
}

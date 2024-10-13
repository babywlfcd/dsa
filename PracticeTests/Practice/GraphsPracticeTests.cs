using Practice.Course.Class;
using Practice.Practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTests.Practice
{
    public class GraphsPracticeTests
    {
        [Theory]
        [MemberData(nameof(ValidPathData))]

        public void ValidPath_Graph_ValidatePathBetweenTwoNodes(int n,int[][] edges, int source, int destination, bool expected)
        {
            var sut = new GraphsPractice();
            var actual = sut.ValidPath(n, edges, source, destination);
            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> ValidPathData()
        {
            yield return new object[]
            {
                3,
                new int[][]
                {
                    new int[] {0, 1},
                    new int[] {1, 2},
                    new int[] {2, 0}
                },
                0, 2, true
            };
            yield return new object[]
            {
                6,
                new int[][]
                {
                    new int[] {0, 1},
                    new int[] {0, 2},
                    new int[] {3, 5},
                    new int[] {5, 4},
                    new int[] {4, 3}
                },
                0, 5, false
            };
        }
    }
}

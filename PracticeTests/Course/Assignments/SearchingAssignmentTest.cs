using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice.Course.Assignments;

namespace PracticeTests.Course.Assignments
{
    public class SearchingAssignmentTest
    {
        [Theory]
        [InlineData(new[] {1}, 0)]
        [InlineData(new []{5, 4, 3, 2, 1}, 0)]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 4)]
        public void FindPickElement_ShouldReturn_IndexOfAnyElementTharIsGreaterThanItdNeighbors_For_AGivenArray(
            int[] input, int expected)
        {
            var sut = new SearchingAssignment();
            var acctual = sut.FindPickElement(input);
            Assert.Equal(expected, acctual);
        }
    }
}

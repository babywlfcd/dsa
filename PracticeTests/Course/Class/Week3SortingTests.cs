using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice.Course.Class;

namespace PracticeTests.Course.Class
{
    public class Week3SortingTests
    {
        [Theory]
        [InlineData(new[] { 8, 4, 7, 3 }, 2, 7)]
        public void
            FindMaxKthElem_ShouldReturn_KthLargestNumber_For_AGivenArray(int[] input, int k, int expected)
        {
            var sut = new Week3Sorting();
            var actual = sut.FindMaxKthElem(input, k);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] {8, 4, 7, 3}, 5)]
        public void
            FindPairsBruteForce_ShouldReturn_NumberOfPairs_Where_ElementAGreaterThanElementBForIndexOfALessThenIndexOfB(int[] input, int expected)
        {
            var sut = new Week3Sorting();
            var actual = sut.FindPairsBruteForce(input);
            Assert.Equal(expected, actual);
        }
    }
}

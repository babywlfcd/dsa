using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice.Course.Assignments;
using Practice.Course.Class;

namespace PracticeTests.Course.Class
{
    public class Week3SortingAndSearchingTests
    {
        [Theory]
        [InlineData(new[] { 8, 4, 7, 3 }, 2, 7)]
        public void
            FindMaxKthElem_ShouldReturn_KthLargestNumber_For_AGivenArray(int[] input, int k, int expected)
        {
            var sut = new Week3SortingAndSearching();
            var actual = sut.FindMaxKthElem(input, k);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] {8, 4, 7, 3}, 5)]
        public void
            FindPairsBruteForce_ShouldReturn_NumberOfPairs_Where_ElementAGreaterThanElementBForIndexOfALessThenIndexOfB(int[] input, int expected)
        {
            var sut = new Week3SortingAndSearching();
            var actual = sut.FindPairsBruteForce(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 0, 1, 21, 33, 45, 45, 61, 71, 72, 73 }, 33, 3)]
        [InlineData(new[] { 0, 1, 21, 33, 45, 45, 61, 71, 72, 73 }, 32, -1)]
        public void BinarySearch_ShouldReturnTheIndexOfFoundedElementOrMinusOne_For_AGivenArrayThatContainTargetRespectiveNotContainTheTarget(
            int[] input, int target,int expected)
        {
            var sut = new Week3SortingAndSearching();
            var result = sut.BinarySearch(input, target);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 2, 3, 3, 4, 5 }, 2, 1)]
        [InlineData(new[] { 1, 2, 2, 3, 3, 4, 5 }, 6, -1)]
        [InlineData(new[] { 2, 2, 2, 2, 2, 2, 2 }, 2, 0)]
        public void FindFirstOccurrenceOfATarget_ShouldReturnTheIndexOfFoundedElementOrMinusOne_For_AGivenArrayThatContainTargetRespectiveNotContainTheTarget(
            int[] input, int target, int expected)
        {
            var sut = new Week3SortingAndSearching();
            var result = sut.FindFirstOccurrenceOfATarget(input, target);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 1 }, 0)]
        [InlineData(new[] { 5, 6, 7, 1, 2, 3, 4 }, 3)]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 0)]
        [InlineData(new[] { 5, 4, 3, 2, 1 }, 4)]
        public void FindPivot_ShouldReturn_IndexOfAnyElementTharIsGreaterThanItdNeighbors_For_AGivenArray(
            int[] input, int expected)
        {
            var sut = new Week3SortingAndSearching();
            var acctual = sut.FindPivot(input);
            Assert.Equal(expected, acctual);
        }

    }
}

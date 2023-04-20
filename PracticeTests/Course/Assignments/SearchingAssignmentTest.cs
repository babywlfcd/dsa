using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice.Course.Assignments;
using Practice.Course.Class;

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

        [Theory]
        [InlineData(new[] { 3, 4, 5, 1, 2 }, 1)]
        [InlineData(new[] { 4, 5, 6, 7, 0, 1, 2 }, 0)]
        [InlineData(new[] { 11, 13, 15, 17 }, 11)]
        [InlineData(new[] { 5, 6, 7, 8, 9, 10, 11, 1, 2, 3 }, 1)]
        [InlineData(new[] {1}, 1)]
        [InlineData(new[] {3, 2, 1 }, 1)]
        public void FindMinInSortedRotatedArray_ShouldReturn_TheMinimumElement_For_ForASortedArrayRotatedKTimes(
            int[] input, int expected)
        {
            var sut = new SearchingAssignment();
            var acctual = sut.FindMinInSortedRotatedArray(input);
            Assert.Equal(expected, acctual);
        }

        [Theory]
        [InlineData(new[] { 4, 5, 6, 7, 0, 1, 2 }, 0, 4)]
        [InlineData(new[] { 4, 5, 6, 7, 0, 1, 2 }, 3, -1)]
        [InlineData(new[] { 2, 2, 2, 2, 2, 2, 2 }, 2, 0)]
        [InlineData(new[] { 1 }, 0, -1)]
        [InlineData(new[] { 1, 3 }, 3, 1)]
        [InlineData(new[] { 1, 3 }, 1, 0)]
        public void FindFirstOccurrenceOfATarget_ShouldReturnTheIndexOfFoundedElementOrMinusOne_For_AGivenArrayThatContainTargetRespectiveNotContainTheTarget(
            int[] input, int target, int expected)
        {
            var sut = new Week3SortingAndSearching();
            var result = sut.FindFirstOccurrenceOfATarget(input, target);
            Assert.Equal(expected, result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignments;
using Xunit.Sdk;

namespace AssignmentsTests
{
    public class ArraysPracticeTest
    {
        [Theory]
        [InlineData(
            new [] {1, 2, 3, 8, 11, 18}, 
            new[] {1, 5, 28},
            new[] {1, 1, 2, 3, 5, 8, 11, 18, 28})]
        public static void MergeTwoOrderedArrays_ShouldReturn_AnAscendingOrderedArray_For_TwoGivenArrays(int[] input1, int[] input2, int[] expected)
        {
            var sut = new ArraysPractice();
            var result = sut.MergeTwoOrderedArrays(input1, input2);

            for(var i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], result[i]);
            }
        }

        [Theory]
        [InlineData(
            new[] { 1, 2, 3, 0, 0, 0 }, 3,
            new[] { 2, 5, 6 }, 3,
            new[] { 1, 2, 2, 3, 5, 6 })]
        [InlineData(
            new[] { 0, 2, 0, 0 }, 2,
            new[] { 0, 1 }, 2,
            new[] { 0, 0, 1, 2 })]
        [InlineData(
            new[] { 0, 0, 3, 0, 0, 0, 0, 0, 0 }, 3,
            new[] { -1, 1, 1, 1, 2, 3 }, 6,
            new[] { -1, 0, 0, 1, 1, 1, 2, 3, 3 })]
        [InlineData(
            new[] { 0, 0, 0, 0, 0 }, 0,
            new[] { 1, 2, 3, 4, 5 }, 5,
            new[] { 1, 2, 3, 4, 5 })]
        [InlineData(
            new[] { 0 }, 0,
            new[] { 1 }, 1,
            new[] { 1 })]

        public void MergeTwoArrays_ShouldReturn_FirstArrayOrderedAndMerged_For_TwoArrays(
            int[] list1, int m, int[] list2, int n, int[] expected)
        {
            var sut = new ArraysPractice();

            sut.Merge(list1, m, list2, n);

            for (var i = 0; i < list1.Length; i++)
                Assert.Equal(expected[i], list1[i]);
        }

        [Theory]
        [InlineData(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
        [InlineData(new[] { 1, 1 }, 1)]
        [InlineData(new[] { 1 }, 0)]
        public void MaxArea_ShouldReturn_MaxArea_For_AListOfGivenHeights(int[] height, int expected)
        {
            var sut = new ArraysPractice();

            var result = sut.MaxArea(height);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }, 6)]
        [InlineData(new[] { 4, 2, 0, 3, 2, 5 }, 9)]
        //[InlineData(new[] { 1 }, 0)]
        public void TrapOptimizeTime_ShouldReturn_WaterTrap_For_AListOfGivenHeights(int[] height, int expected)
        {
            var sut = new ArraysPractice();

            var result = sut.TrapOptimizeTime(height);

            Assert.Equal(expected, result);
        }
    }
}

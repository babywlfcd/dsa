﻿using Practice.Course.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice.Course.Assignments;

namespace PracticeTests.Course.Assignments
{
    public class ProblemsOnSortingTests
    {
        [Theory]
        [InlineData(new[] { 8, 4, 7, 3 }, 2, 7)]
        [InlineData(new[] { 3, 2, 1, 5, 6, 4 }, 2, 5)]
        [InlineData(new[] {3, 2, 3, 1, 2, 4, 5, 5, 6}, 4, 3)]
        public void
            FindMaxKthElem_ShouldReturn_KthDistinctLargestNumber_For_AGivenArray(int[] input, int k, int expected)
        {
            var sut = new ProblemsOnSorting();
            var actual = sut.FindMaxKthElem(input, k);
            Assert.Equal(expected, actual);
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

        public void  MergeTwoArrays_ShouldReturnMergedArray_AndKeepIndexItem(
            int[] list1, int m, int[] list2, int n, int[] expected)
        {
            var sut = new ProblemsOnSorting();

            sut.MergeTwoArrays(list1, m, list2, n);

            for (var i = 0; i < list1.Length; i++)
                Assert.Equal(expected[i], list1[i]);
        }
    }
}

﻿using Practice;

namespace PracticeTests
{
    
    public class SortingTests
    {
        [Fact]
        public void BubbleSort_UnsortedArray_AscendingSortedArray()
        {
            var input = new[] {1, 3, 8, 7, 9, 2, 8};
            var expected = new int[] {1, 2, 3, 7, 8, 8, 9};
            var sut = new Sorting();
            var result = sut.BubbleSort(input);

            for(var i = 0; i < result.Length; i++)
            {
                Assert.Equal(expected[i] , result[i]);
            }
        }

        [Fact]
        public void SelectionSort_UnsortedArray_AscendingSortedArray()
        {
            var input = new[] { 1, 3, 8, 7, 9, 2, 8 };
            var expected = new int[] { 1, 2, 3, 7, 8, 8, 9 };
            var sut = new Sorting();
            var result = sut.SelectionSort(input);

            for (var i = 0; i < result.Length; i++)
            {
                Assert.Equal(expected[i], result[i]);
            }
        }

        [Fact]
        public void InsertionSort_UnsortedArray_AscendingSortedArray()
        {
            var input = new[] { 1, 3, 8, 7, 9, 2, 8 };
            var expected = new int[] { 1, 2, 3, 7, 8, 8, 9 };
            var sut = new Sorting();
            var result = sut.InsertionSort(input);

            for (var i = 0; i < result.Length; i++)
            {
                Assert.Equal(expected[i], result[i]);
            }
        }

        [Fact]
        public void MergeSort_UnsortedArray_AscendingSortedArray()
        {
            var input = new[] { 1, 3, 8, 7, 9, 2, 8 };
            var expected = new int[] { 1, 2, 3, 7, 8, 8, 9 };
            var sut = new Sorting();
            var result = sut.MergeSort(input);

            for (var i = 0; i < result.Length; i++)
            {
                Assert.Equal(expected[i], result[i]);
            }
        }

        [Theory]
        [InlineData(new[] { 1, 3, 8, 7, 9, 2, 8 }, new [] { 1, 2, 3, 7, 8, 8, 9 })]
        [InlineData(new[] {2}, new[] {2})]
        public void MergeSort2_UnsortedArray_AscendingSortedArray(int[] input, int[]expected)
        {
            var sut = new Sorting();
            var result = sut.MergeSort2(input);

            for (var i = 0; i < result.Length; i++)
            {
                Assert.Equal(expected[i], result[i]);
            }
        }

        [Theory]
        [InlineData(new[] { 1, 8, 3, 9, 4, 5, 7 }, 0, 6, new[] { 1, 3, 4, 5, 7, 8, 9 })]
        [InlineData(new[] { 2 }, 0, 0, new[] { 2 })]
        public void QuickSort_UnsortedArray_AscendingSortedArray(int[] input, int low, int high,int[] expected)
        {
            var sut = new Sorting();
            var result = sut.QuickSort(input, low, high);

            for (var i = 0; i < result.Length; i++)
            {
                Assert.Equal(expected[i], result[i]);
            }
        }
    }
}

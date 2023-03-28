using Practice;
using Practice.Course.Assignments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice.Course.Class;

namespace PracticeTests.Course.Class
{
    public class Week2ArraysTests
    {
        [Fact]
        public void AddTwoMatrices_ShouldReturn_AMatrixSum_For_TwoGivenMatrix()
        {
            int[][] matrix1 = new[]
            {
                new[] { 1, 1, 1 },
                new[] { 1, 1, 0 },
                new[] { 1, 0, 1 }
            };
            int[][] matrix2 = new[]
            {
                new[] { 1, 0, 1 },
                new[] { 1, 1, 1 },
                new[] { 1, 1, 1 }
            };
            int[][] expected = new[]
            {
                new[] { 2, 1, 2 },
                new[] { 2, 2, 1 },
                new[] { 2, 1, 2 }
            };
            var sut = new Week2Arrays();

            var result = sut.SumTwoMatrices(matrix1, matrix2);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void AddTwoMatrices_ShouldReturn_AEmptyMatrix_For_TwoDifferentDimensionMatrix()
        {
            int[][] matrix1 = new[]
            {
                new[] { 1, 1, 1 },
                new[] { 1, 1, 0 },
                new[] { 1, 0, 1 }
            };
            int[][] matrix2 = new[]
            {
                new[] { 1, 0, 1 },
                new[] { 1, 1, 1 },
            };
            int[][] expected = Array.Empty<int[]>();
            
            var sut = new Week2Arrays();

            var result = sut.SumTwoMatrices(matrix1, matrix2);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] {1, 2, 7, 22, 5, 31}, new[] {31, 5, 22, 7, 2, 1})]
        public void ReverseAnArray_ShouldReturn_ReversedArray_For_AGivenArray(int[] input, int[] expected)
        {
            var sut = new Week2Arrays();

            var result = sut.ReverseAnArray(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }, 6)]
        [InlineData(new[] { 4, 2, 0, 3, 2, 5 }, 9)]
        [InlineData(new[] { 1 }, 0)]
        [InlineData(new[] { 1, 7 }, 0)]
        public void TrapRainWater_ShouldReturn_WaterTrap_For_AListOfGivenHeights(int[] height, int expected)
        {
            var sut = new Week2Arrays();

            var result = sut.TrapRainWater(height);

            Assert.Equal(expected, result);
        }
    }
}

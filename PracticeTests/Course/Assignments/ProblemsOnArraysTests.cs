using Practice.Course.Assignments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTests.Course.Assignments
{
    public class ProblemsOnArraysTests
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 4 }, 2, new[] { 3, 4, 1, 2 })]
        [InlineData(new[] { 8 }, 5, new[] { 8 })]
        [InlineData(new[] { 1, 2, 3 }, 8, new[] { 2, 3, 1 })]
        public void RotateBTimesBruteForce(int[] input, int b, int[] expected)
        {
            var sut = new ProblemsOnArray();

            var actual = sut.RotateBTimesBruteForce(input, b);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] {1, 2, 3, 4}, 2, new[] {3, 4, 1, 2})]
        [InlineData(new[] {8}, 5, new[] {8})]
        [InlineData(new[] { 1, 2, 3 }, 8, new[] { 2, 3, 1 })]
        public void RotateBTimes_ShouldReturn_RotatedArrayBTimesToRight_For_AGivenArray(int[] input, int b, int[] expected)
        {
            var sut = new ProblemsOnArray();

            var actual = sut.RotateBTimes(input, b);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3, 4 }, 7, 1)]
        [InlineData(new[] { 1, 2, 4 }, 4, 0)]
        [InlineData(new[] { 1, 2, 2 }, 4, 1)]
        public void CheckGoodPairBruteForce_ShouldReturn_OneOrZero_IfExist_TwoNumbersWithSumEqualTargetRespectiveNoPairNumbersSumMeetTheTarget(int[] input, int b, int expected)
        {
            var sut = new ProblemsOnArray();

            var actual = sut.CheckGoodPairBruteForce(input, b);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, "5 1")]
        [InlineData(new[] { 10, 50, 40, 80}, "80 10")]
        [InlineData(new[] {8}, "8")]
        public void FindMaxAndMin_ShouldReturnAStringWithMinAndMaxWithinAnArray_For_AGivenArray(int[] input, string expected)
        {
            var sut = new ProblemsOnArray();

            var actual = sut.FindMaxAndMin(input);

            Assert.Equal(expected, actual);
        }

        
    }
}

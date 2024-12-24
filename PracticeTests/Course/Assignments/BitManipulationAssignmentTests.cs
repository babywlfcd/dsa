using Practice.Course.Assignments;
using Practice.Course.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTests.Course.Assignments
{
    public class BitManipulationAssignmentTests
    {
        private BitManipulationAssignment _sut;
        public BitManipulationAssignmentTests()
        {
            _sut = new BitManipulationAssignment();
        }

        [Theory]
        [InlineData(new int[] { 2, 2, 1 }, 1)]
        public void FindSingleNumber_ShouldReturn_TheSingleNumberInTheArray(int[] nums, int expected)
        {
            var result = _sut.FindSingle(nums);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("10101", "1101", "100010")]
        public void AddBinary_ShouldReturn_TheSumOfTwoBinaryNumbers(string a, string b, string expected)
        {
            // 10101
            //  1101
            //     0
            var result = _sut.AddBinary(a, b);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 2)]
        [InlineData(45, 4)]
        public void CountOneBitsFor32Bit_ShouldReturn_TheNumberOfSetBitForAPositiveNumber(int n, int expected)
        {
            var result = _sut.CountOneBitsFor32Bit(n);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(13, 3)]

        public void CountDigitOne_ShouldReturn_TheNumberOfSetBitForAPositiveNumber(int n, int expected)
        {
            var result = _sut.HammingWeight(n);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 3, 2, 1, 0, 1, 2, 3 }, true)]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, false)]

        public void IsInterestingArray_Should_ValidateIfXOROfAllElementsIsZero(int[] input, bool expected)
        {
            var result = _sut.IsInterestingArray(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(13, 2952790016)]
        [InlineData(4294967293, 3221225471)]
        public void ReverseBits_ShouldReturn_TheReverseOfTheNumber(uint n, uint expected)
        {
            var result = _sut.ReverseBits(n);
            Assert.Equal(expected, result);
        }

        #region Single number problems - clasic approach
        [Theory]
        [InlineData(new[] { 1, 2, 3, 2, 5, 5, 1 }, 3)]
        [InlineData(new[] { 1, 2, 11, 2, 5, 5, 1 }, 11)]
        public void FindSingleNumbertBruteForce_ShouldReturn_TheSingleNumber(int[] input, int expected)
        {
            var result = _sut.FindSingleNumberClassicApproach(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 0, 1, 0, 1, 0, 1, 99 }, 99)]
        [InlineData(new[] { 1, 1, 2, 2, 3, 2, 5, 5, 1, 5 }, 3)]
        public void SingleNumber2_ShouldReturn_TheSingleNumber(int[] input, int expected)
        {
            var result = _sut.SingleNumber2(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 11, 2, 5, 5, 1 }, 2, 11)]
        [InlineData(new[] { 0, 1, 0, 1, 0, 1, 99 }, 3, 99)]
        [InlineData(new[] { 1, 1, 2, 2, 3, 2, 5, 5, 1, 5, 1, 2, 5 }, 4, 3)]
        public void SingleNumberGeneralisation_ShouldReturn_TheSingleNumber(int[] input, int k, int expected)
        {
            var result = _sut.SingleNumberGeneralisation(input, k);
            Assert.Equal(expected, result);
        }
        #endregion

        #region Single number problems - bit manipulation

        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 1, 2, 3 }, 4)]
        [InlineData(new[] { 1, 2, 3, 11, 1, 2, 3 }, 11)]
        public void FindSingle2_ShouldReturn_TheSingleNumberInTheArray(int[] nums, int expected)
        {
            var result = _sut.FindSingle2(nums);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 1, 1, 2, 2, 3, 2, 5, 5, 1, 5 }, 3)]
        [InlineData(new[] { 1, 1, 2, 2, 11, 2, 5, 5, 1, 5 }, 11)]
        public void FindSingle3_ShouldReturn_TheSingleNumberInTheArray(int[] nums, int expected)
        {
            var result = _sut.FindSingle3(nums);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 1, 2, 3 }, 2, 4)]
        [InlineData(new[] { 1, 2, 3, 11, 1, 2, 3 }, 2, 11)]
        [InlineData(new[] { 1, 1, 2, 2, 3, 2, 5, 5, 1, 5 }, 3, 3)]
        [InlineData(new[] { 1, 1, 2, 2, 11, 2, 5, 5, 1, 5 }, 3, 11)]
        [InlineData(new[] { 1, 1, 1, 1, 1, 5 }, 5, 5)]
        public void FindSingleNumberGeneralisation_ShouldReturn_TheSingleNumberInTheArray(int[] nums, int k, int expected)
        {
            var result = _sut.FindSingleNumberGeneralisation(nums, k);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3, 2, 5, 5, 1, 11 }, new[] { 3, 11 })]
        public void FindSingleTwoNo_ShouldReturn_TheSingleNumberInTheArray(int[] nums, int[] expected)
        {
            var result = _sut.FindSingleTwoNo(nums);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 17)]

        public void CountTotalSetBits_ShouldReturn_TheNumberOfSetBitAllNaturalNumbersTillN(int n, int expected)
        {
            var result = _sut.CountTotalSetBits(n);
            Assert.Equal(expected, result);
        }
        #endregion
    }
}

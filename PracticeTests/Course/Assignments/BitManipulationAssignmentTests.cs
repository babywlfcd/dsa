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
            var result = _sut.CountDigitOne(n);
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
    }
}

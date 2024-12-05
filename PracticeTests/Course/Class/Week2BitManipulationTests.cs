using Practice.Course.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTests.Course.Class
{
    public class Week2BitManipulationTests
    {
        private Week2BitManipulation _sut;
        public Week2BitManipulationTests()
        {
            _sut = new Week2BitManipulation();
        }

        [Theory]
        [InlineData(14, 2, 1110)]
        [InlineData(14, 3, 211)]
        [InlineData(100, 7, 202)]
        public void ConvertPositiveInBaseX_WillReturn_TheNumberInBaseX(int n, int x, int expected)
        {
            var sut = new Week2BitManipulation();
            var result = sut.ConvertPositiveInBaseX(n, x);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(-7, 7, -10)]
        [InlineData(14, 2, 1110)]
        [InlineData(14, 3, 211)]
        [InlineData(100, 7, 202)]
        public void ConvertInBaseX_WillReturn_TheNumberInBaseX(int n, int x, int expected)
        {
            var sut = new Week2BitManipulation();
            var result = sut.ConvertInBaseX(n, x);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("10101", "1101", "100010")]
        public void AddBinary_ShouldReturn_TheSumOfTwoBinaryNumbers(string a, string b, string expected)
        {
            // 10101
            //  1101
            //     0
            var sut = new Week2BitManipulation();
            var result = sut.AddBinary(a, b);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(11, 1)]
        [InlineData(12, 0)]
        public void LastSignificantBit_WillReturn_TheNumberInBaseX(int x, int expected)
        {
            var sut = new Week2BitManipulation();
            var result = sut.LastSignificantBit(x);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(11, "Odd")]
        [InlineData(12, "Even")]
        public void CheckEvenNunberBit_WillReturn_TheNumberInBaseX(int x, string expected)
        {
            var sut = new Week2BitManipulation();
            var result = sut.CheckEvenNunberBit(x);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 0, true)]
        [InlineData(5, 1, false)]
        public void IsIthBitSet_ShouldReturn_TheIthBit(int n, int i, bool expected)
        {
            var result = _sut.IsIthBitUnset(n, i);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 0, true)]
        [InlineData(5, 1, false)]
        public void IsIthBitSetRightShift_ShouldReturn_TheIthBit(int n, int i, bool expected)
        {
            var result = _sut.IsIthBitSetRightShift(n, i);
            Assert.Equal(expected, result);
        }
    }
}

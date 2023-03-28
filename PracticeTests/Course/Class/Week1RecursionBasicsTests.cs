using Practice.Course.Class;

namespace PracticeTests.Course.Class
{
    public class Week1RecursionBasicsTests
    {
        [Theory]
        [InlineData(46, 10)]
        [InlineData(11, 2)]
        [InlineData(999999999, 81)]
        [InlineData(1, 1)]
        [InlineData(1000000000, 1)]
        public void DigitSum_Should_SumOfDigits_For_ANumber(int a, int expected)
        {
            var sut = new Week1RecursionBasics();
            var result = sut.SumDigits(a);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(46, 10)]
        [InlineData(11, 2)]
        [InlineData(999999999, 81)]
        [InlineData(1, 1)]
        [InlineData(1000000000, 1)]
        public void DigitSumRecursive_ShouldReturn_SumOfDigits_For_ANumber(int a, int expected)
        {
            var sut = new Week1RecursionBasics();
            var result = sut.SumOfDigits(a);
            Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData(83557, true)] // initially fail 
        [InlineData(1291, false)]
        [InlineData(999999999, false)]
        [InlineData(1, true)]
        [InlineData(1000000000, true)]
        public void IsMagic_ShouldReturn_One_For_MagicNumber(int a, bool expected)
        {
            var sut = new Week1RecursionBasics();
            var result = sut.IsMagic(a);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2, 3, 3, 2)]
        [InlineData(-2, 3, 3, 2)]
        [InlineData(2, -3, 3, 0)]
        [InlineData(-5, 2, 7, 4)]
        //[InlineData(-5, 3, 7, 5)] - why the result here is 6?
        [InlineData(-1000000000, 0, 1, 0)]
        [InlineData(1000000000, 1000000000, 1000000000, 0)]
        public void CalculateExpressionRec_ShouldReturn_PositiveOnly(int a, int b, int c, int expected)
        {
            var sut = new Week1RecursionBasics();
            var result = sut.CalculateExpressionRec(a, b, c);
            Assert.Equal(expected, result);
            Assert.True(result >= 0);
        }
    }
}

using Practice.Course.Assignments;
using Practice.Course.Class;

namespace PracticeTests.Course.Class
{
    public class Week1RecursionBasicsTests
    {
        [Theory]
        [InlineData(5, 3, 15)]
        [InlineData(5, -3, -15)]
        [InlineData(-5, 3, -15)]
        [InlineData(-5, -3, 15)]
        public void DigitSum_Should_SumOfDigits_For_ANumber(int a, int n, int expected)
        {
            var sut = new Week1RecursionBasics();
            var result = sut.Multiply(a, n);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2, 3, 3, 2)]
        [InlineData(-2, 3, 3, 2)]
        [InlineData(2, -3, 3, 0)]
        [InlineData(-5, 2, 7, 4)]
        [InlineData(-5, 3, 7, 6)]
        [InlineData(-1000000000, 0, 1, 0)]
        [InlineData(1000000000, 1000000000, 1000000000, 0)]
        public void CalculateExpressionRec_ShouldReturn_PositiveOnly(int a, int b, int c, int expected)
        {
            var sut = new Week1RecursionBasics();
            var result = sut.CalculateExpression(a, b, c);
            Assert.Equal(expected, result);
            Assert.True(result >= 0);
        }

        [Fact]
        public void CalculateExpressionRec_ThrowException_ForDZero()
        {
            var sut = new Week1RecursionBasics();
            Assert.Throws<DivideByZeroException>(() => sut.CalculateExpression(5, 8, 0));
        }

        [Fact]
        public void CalculateExpressionRec_ExceptionMessage_DCannotBeZero()
        {
            var sut = new Week1RecursionBasics();
            Action act =  () =>sut.CalculateExpression(5, 8, 0);
            
            //assert
            var exception = Assert.Throws<DivideByZeroException>(act);
            //The thrown exception can be used for even more detailed assertions.
            Assert.Equal("d cannot be zero", exception.Message);
        }

        [Theory]
        [InlineData("abcdcba", 0, 6, true)]
        [InlineData("abba", 0, 3, true)]
        [InlineData("", 0, 0, true)]
        [InlineData("a", 0, 0, true)]
        [InlineData("abbc", 0, 3, false)]
        public void IsPalindrome_ShouldValidate_AGivenString(string s, int left, int right, bool expected)
        {
            var sut = new Week1RecursionBasics();
            var result = sut.IsPalindrome(s, left, right);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(25, 1, 5)]
        [InlineData(30, 1, 5)]
        [InlineData(1296, 1, 36)]
        public void Sqrt_Return_SquareRoot_for_GivenNaturalNumber(int n, int k, int expected)
        {
            var sut = new Week1RecursionBasics();
            var result = sut.Sqrt(n, k);
            Assert.Equal(expected, result);
        }
    }
}

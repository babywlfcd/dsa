using Practice.Course.Assignments;

namespace PracticeTests.Course.Assignments
{
    public class RecursionBasicsTest
    {
        [Theory]
        [InlineData(46, 10)]
        [InlineData(11, 2)]
        [InlineData(999999999, 81)]
        [InlineData(1, 1)]
        [InlineData(1000000000, 1)]
        public void DigitSum_Should_SumOfDigits_For_ANumber(int a, int expected)
        {
            var sut = new RecursionBasics();
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
            var sut = new RecursionBasics();
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
            var sut = new RecursionBasics();
            var result = sut.IsMagic(a);
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
            var sut = new RecursionBasics();
            var result = sut.CalculateExpressionRec(a, b, c);
            Assert.Equal(expected, result);
            Assert.True(result >= 0);
        }

        [Theory]
        [InlineData(2, 1)]
        [InlineData(9, 34)]
        [InlineData(0, 0)]
        [InlineData(20, 6765)]
        public void NthFibonacciNumberRecursive_ShouldReturn_NthElementOfFibonacciSeries_For_N(int n, int expected)
        {
            var sut = new RecursionBasics();
            var result = sut.NthFibonacciNumberRecursive(n);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(4, 24)]
        [InlineData(1, 1)]
        [InlineData(0, 0)]
        [InlineData(12, 479001600)]
        public void FindFactorial_ShouldReturn_FactorialOfN_For_AGivenNumber(int n, int expected)
        {
            var sut = new RecursionBasics();
            var result = sut.FindFactorial(n);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("algotutor", "rotutogla")]
        [InlineData("cool", "looc")]
        [InlineData("a", "a")]
        public void ReverseString_ShouldReturn_ReverseString_For_AGivenString(string s, string expected)
        {
            var sut = new RecursionBasics();
            var result = sut.ReverseString(s);
            Assert.Equal(expected, result);
        }

        /// <summary>
        /// Nth element that meet criteria f(A) = f(A-1) + f(A-2) + f(A-3) + A
        /// </summary>
        /// <param name="a"></param>
        /// <param name="expected"></param>
        [Theory]
        [InlineData(3, 7)]
        [InlineData(2, 2)]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(20, 300642)]
        public void SetAthNumber_ShouldReturn_NthElementOfExpression_For_AnInteger(int a, int expected)
        {
            var sut = new RecursionBasics();
            var result = sut.SetAthNumber(a);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2, 1, 0)]
        [InlineData(2, 2, 1)]
        [InlineData(4, 3, 1)]
        [InlineData(4, 0, 0)]
        public void GetKthValue_ShouldReturn_ZeroOrOne(int a, int b, int expected)
        {
            var sut = new RecursionBasics();
            var result = sut.GetKthValue(a, b);
            Assert.Equal(expected, result);
        }
    }
}

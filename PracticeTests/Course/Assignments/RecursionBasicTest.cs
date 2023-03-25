using Practice.Course.Assignments;

namespace PracticeTests.Course.Assignments
{
    public class RecursionBasicsTest
    {
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

using Practice.Mathematics;

namespace PracticeTests.Mathematics
{
    public class MathPracticeTest
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(9, 34)]
        [InlineData(20, 6765)]
        public void NthFibonacciNumber_ShouldReturn_NthElementOfFibonacciSeries_For_N(int n, int expected)
        {
            var sut = new MathPractice();
            var result = sut.NthFibonacciNumber(n);
            Assert.Equal(expected, result);
        }
    }
}

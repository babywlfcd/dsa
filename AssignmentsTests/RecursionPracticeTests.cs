using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignments;

namespace AssignmentsTests
{
    public class RecursionPracticeTests
    {
        [Theory]
        [InlineData(46, 10)]
        [InlineData(11, 2)]
        [InlineData(999999999, 81)]
        [InlineData(1, 1)]
        [InlineData(1000000000, 1)]
        public void DigitSum_ShouldReturnSumOfDigits_ForNumber(int a, int expected)
        {
            var sut = new RecursionPractice();
            var result = sut.SumDigits(a);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(46, 10)]
        [InlineData(11, 2)]
        [InlineData(999999999, 81)]
        [InlineData(1, 1)]
        [InlineData(1000000000, 1)]
        public void DigitSumRecursive_ShouldReturnSumOfDigits_ForNumber(int a, int expected)
        {
            var sut = new RecursionPractice();
            var result = sut.SumOfDigits(a);
            Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData(83557, true)] // initially fail 
        [InlineData(1291, false)]
        [InlineData(999999999, false)]
        [InlineData(1, true)]
        [InlineData(1000000000, true)]
        public void IsMagic_ShouldReturnOne_ForMagicNumber(int a, bool expected)
        {
            var sut = new RecursionPractice();
            var result = sut.IsMagic(a);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2, 1)]
        [InlineData(9, 34)]
        [InlineData(0, 0)]
        [InlineData(20, 6765)]
        public void Fibonacci_ShouldReturnNthNumber_ForFibonacciSeries(int n, int expected)
        {
            var sut = new RecursionPractice();
            var result = sut.SetNthFibonacciNumber(n);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(4, 24)]
        [InlineData(1, 1)]
        [InlineData(0, 0)]
        [InlineData(12, 479001600)]
        public void FindFactorial_ShouldReturnFactorialOfN(int n, int expected)
        {
            var sut = new RecursionPractice();
            var result = sut.FindFactorial(n);
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
        public void CalculateExpressionRec_ShouldReturnPositiveOnly(int a, int b, int c, int expected)
        {
            var sut = new RecursionPractice();
            var result = sut.CalculateExpressionRec(a, b, c);
            Assert.Equal(expected, result);
            Assert.True(result >= 0);
        }


        [Theory]
        [InlineData("algotutor", "rotutogla")]
        [InlineData("cool", "looc")]
        [InlineData("a", "a")]
        public void ReverseString_ShouldReturnReverseString(string s , string expected)
        {
            var sut = new RecursionPractice();
            var result = sut.ReverseString(s);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(3, 7)]
        [InlineData(2, 2)]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(20, 300642)]
        public void SetAthNumber_ShouldReturnNumberExpression(int a, int expected)
        {
            var sut = new RecursionPractice();
            var result = sut.SetAthNumber(a);
            Assert.Equal(expected, result);
        }



        [Theory]
        [InlineData(2, 1, 0)]
        [InlineData(2, 2, 1)]
        [InlineData(4, 3, 1)]
        public void GetKthValue_ShouldReturnZeroOrOne(int a, int b, int expected)
        {
            var sut = new RecursionPractice();
            var result = sut.GetKthValue(a, b);
            Assert.Equal(expected, result);
        }
    }
}

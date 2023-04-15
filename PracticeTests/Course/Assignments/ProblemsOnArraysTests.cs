using Practice.Course.Assignments;
using Practice.Course.Class;
using Xunit;

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
        [InlineData(new[] { 1, 2, 3, 4 }, 2, new[] { 3, 4, 1, 2 })]
        [InlineData(new[] { 8 }, 5, new[] { 8 })]
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
        public void CheckGoodPairBruteForce_ShouldReturn_OneOrZero_If_ExistTwoNumbersWithSumEqualTargetRespectiveNoPairNumbersSumMeetTheTarget(int[] input, int b, int expected)
        {
            var sut = new ProblemsOnArray();

            var actual = sut.CheckGoodPairBruteForce(input, b);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 7, 22, 5, 31 }, new[] { 31, 5, 22, 7, 2, 1 })]
        public void ReverseAnArray_ShouldReturn_ReversedArray_For_AGivenArray(int[] input, int[] expected)
        {
            var sut = new ProblemsOnArray();

            var result = sut.ReverseAnArray(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, "5 1" )]
        [InlineData(new[] { 10, 50, 40, 80 }, "80 10" )]
        [InlineData(new[] { 8 }, "8")]
        public void FindMaxAndMin_ShouldReturn_MinAndMaxWithinAnArray_For_AGivenArray(int[] input, string expected)
        {
            var sut = new ProblemsOnArray();

            var actual = sut.FindMaxAndMin(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(ScenariosData))]
        public void CheckIfBExistInEachScenario_ShouldReturn_ListOfOneAndZero_When_TargetExistRespectiveNotExist_ForAListOfScenarios(List<List<int>> input, int target, List<int> expected)
        {
            var sut = new ProblemsOnArray();

            var actual = sut.CheckIfBExistInEachScenario(input, target);

            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> ScenariosData()
        {
            yield return new object[]
            {
                new List<List<int>>
                {
                    new List<int>() {4, 1, 5, 9, 1},
                    new List<int>() {-1, 0, 1},
                    new List<int>() {1, 5, 9, 2}
                },
                5,
                new List<int> {1, 0 , 1}
            };
            yield return new object[]
            {
                new List<List<int>>
                {
                    new List<int>() {7, 7, 2},
                    new List<int>() {8, 1, 6, 12},
                    new List<int>() {}
                },
                3,
                new List<int> {0, 0, 0}
            };

        }

        [Theory]
        [InlineData(new[] { 2, 4, 3, 1, 5 }, 3, 1)]
        [InlineData(new[] { 1, 4, 2 }, 2, -1)]
        public void CalculateMinNumberForMaxB_ShouldReturn_MinNumberOfOperation_For_MakeBTheMaxNumber(int[] input, int b, int expected)
        {
            var sut = new ProblemsOnArray();

            var actual = sut.CalculateMinNumberForMaxB(input, b);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 2, 4, 3, 1, 5 }, 4)]
        [InlineData(new[] { 1 }, -1)]
        [InlineData(new int[] { }, -1)]

        public void GetSecondLargestValue_ShouldReturn_SecondMaximumValue_For_AGivenArray(int[] input, int expected)
        {
            var sut = new ProblemsOnArray();

            var actual = sut.GetSecondLargestValue(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 0, 2, 9 }, -7)]
        [InlineData(new[] { 5, 17, 100, 1 }, 99)]
        public void MinimumPicks_ShouldReturn_DifferenceBetweenMaxEvenAndMinOdd_For_AGivenArray(int[] input, int expected)
        {
            var sut = new ProblemsOnArray();

            var actual = sut.MinimumPicks(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(ScenariosMinPickData))]
        public void SeparateOddEven_ShouldReturn_OddNumbersAndEvenNumbers_For_ForAListOfScenarios(List<List<int>> input, string expected)
        {
            var sut = new ProblemsOnArray();

            var actual = sut.SeparateOddEven(input);

            Assert.Equal(expected, actual);
        }


        public static IEnumerable<object[]> ScenariosMinPickData()
        {
            yield return new object[]
            {
                new List<List<int>>
                {
                    new List<int>() {1, 2, 3, 4, 5},
                    new List<int>() {4, 3, 2},
                },
                "1 3 5 \r\n4 2 \r\n3 \r\n4 2 \r\n"
            };
        }

        [Theory]
        [MemberData(nameof(RotationData))]
        public void Rotate_ShouldReturn_ListOfTheArraysRotatedKTimesToLeft_For_ForAListOfScenariosAndListOfRotations( int[] input, int[] rotations, List<int[]> expected)
        {
            var sut = new ProblemsOnArray();

            var actual = sut.Rotate(input, rotations);

            Assert.Equal(expected, actual);
        }
        
        public static IEnumerable<object[]> RotationData()
        {
            yield return new object[]
            {
                new [] {1, 2, 3, 4, 5},
                new [] {2, 3},
                new List<int[]>
                {
                    new [] {3, 4, 5, 1, 2},
                    new [] {4, 5, 1, 2, 3},
                },
                
            };
        }

        [Theory]
        [InlineData(new[] { 16, 17, 4, 3, 5, 2 }, new[] { 2, 5, 17 })]
        [InlineData(new[] { 1 }, new[] { 1 })]
        public void FindLeaders_ShouldReturn_Leaders_For_AGivenArray(int[] input, int[] expected)
        {
            var sut = new ProblemsOnArray();

            var actual = sut.FindLeaders(input);

            Assert.Equal(expected.ToArray(), actual);
        }
        [Theory]
        [InlineData(new[] { 0, 1, 0, 1 }, 4)]
        [InlineData(new[] { 1, 1, 1, 1 }, 0)]
        [InlineData(new[] { 0, 0, 1, 1 }, 2)]
        public void Bubs_ShouldReturn_Leaders_For_AGivenArray(int[] input, int expected)
        {
            var sut = new ProblemsOnArray();

            var actual = sut.Bubs1(input);

            Assert.Equal(expected, actual);
        }
    }
}

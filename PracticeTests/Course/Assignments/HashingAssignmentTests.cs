using Practice;
using Practice.Course.Assignments;
using Practice.Course.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTests.Course.Assignments
{
    public class HashingAssignmentTests
    {

        [Theory]
        [InlineData(new[] {1, 2, 2, 1}, new[] {2, 2}, new[] {2, 2})]
        [InlineData(new[] {3, 4, 5, 6, 7}, new[] {7, 3, 4, 7, 8, 9}, new[] {7, 3, 4})]
        [InlineData(new[] {1, 2, 3, 4, 5}, new[] {6, 7, 8, 9, 10}, new int[] { })]
        [InlineData(new[] {4, 4, 4, 4, 4, 4}, new[] {4, 4, 4, 4}, new[] {4, 4, 4, 4})]
        public void GetIntersection_ShouldReturn_CommonNumbers_IfAny(int[] input1, int[] input2, int[] expected)
        {
            var sut = new HashingAssignment();

            var actual = sut.GetIntersection(input1, input2);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 10, 5, 3, 4, 3, 5, 6 }, 3)]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, -1)]
        [InlineData(new[] { 1, 2, 3, 4, 3, 5 }, 3)]
        [InlineData(new[] { 1, 2, 3, 1, 2, 3 }, 1)]
        [InlineData(new[] { 1, 2, 3, 4, 5, 5 }, 5)]
        public void FindFirstRepeatingElement_FirstDuplicateValue_IfAny(int[] input, int expected)
        {
            var sut = new HashingAssignment();

            var actual = sut.FindFirstRepeatingElement(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 3, 1, 2, 2, 1, 2, 3, 4, 4 }, 2, new[] {1, 3, 4})]
        [InlineData(new[] { 2, 2, 2, 2 }, 4, new [] {2})]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 1 , new[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] {} , 1, new int[] {})]
        [InlineData(new[] { 1, 1, 1, 2, 2, 2, 3, 3, 3 }, 3, new[] {1, 2, 3})]
        public void FindKOccurrence_ValuesWithOccurrenceK_IfAny(int[] input, int k, int[] expected)
        {
            var sut = new HashingAssignment();

            var actual = sut.FindKOccurrence(input, k);

            Assert.Equal(expected, actual.ToArray());
        }

        [Theory(Skip = "remove skip after implementation review")]
        [InlineData(new int[] { 1, 2, -3, 3, 1 }, new[] {-3, 3})]
        //[InlineData(new int[] { 0, 3, 5, -3, 2 }, 1)]
        //[InlineData(new int[] { 1, 2, -1, -2 }, 4)]
        //[InlineData(new int[] { 1, 2, -1, 8 }, 0)]
        public void LargestSubArraySumZero_SubArraySumZero_LengthOfLongestSubArray(int[] input, int[] expected)
        {
            var sut = new HashingAssignment();
            // act
            var actual = sut.LargestSubArraySumZero(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 4, 2, -3, 1, 6 }, true)]
        [InlineData(new int[] { 4, 2, 0, 1, 6 }, true)]
        [InlineData(new int[] { 1, 2, 3 }, false)]
        [InlineData(new int[] { 0, 0, 0 }, true)]
        [InlineData(new int[] { 1, -1, 1, -1, 1 }, true)]
        public void ExistSubArraySumZero_SubArraySumZero_ValidateIfExist(int[] input, bool expected)
        {
            var sut = new HashingAssignment();
            // act
            var actual = sut.ExistSubArraySumZero(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("A man, a plan, a canal: Panama", true)]
        [InlineData("race a car", false)]
        [InlineData("level", true)]
        [InlineData("Was it a car or a cat I saw?", true)]
        [InlineData("hello world", false)]
        [InlineData("abccba", true)]
        public void CheckPalindrome_String_ValidatePalindrome(string s, bool expected)
        {
            var sut = new HashingAssignment();
            // act
            var actual = sut.CheckPalindrome(s);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(236, true)]
        [InlineData(1234, true)]
        [InlineData(2233, false)]
        [InlineData(345, true)]
        [InlineData(111, false)]
        [InlineData(1, true)]
        public void IsColorfulNumber_Number_Validate(int n, bool expected)
        {
            var sut = new HashingAssignment();
            // act
            var actual = sut.IsColorfulNumber(n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 4, 20, 3, 10, 5 }, 33, new int[] {2, 4})]
        [InlineData(new int[] { 10, 2, -2, -20, 10 }, -10, new int[] { 0, 3 })]
        [InlineData(new int[] { 1, 2, 3, 12, 4 }, 10, new int[]{})]
        [InlineData(new int[] { 1, 2, 3, 7, 5 }, 12, new int[] {1, 3})]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 15, new int[] {0, 4})]
        [InlineData(new int[] { 1, 2, 0, 4, 5 }, 0, new int[] {0})]
        [InlineData(new int[] { 1, 0, 1 }, 0, new int[] { 0 })]
        public void FindSubArrayMarginsWithTargetSumK_Number_Validate(int[] input, int k, int[] expected)
        {
            var sut = new HashingAssignment();
            // act
            var actual = sut.FindSubArrayMarginsWithTargetSumK(input, k);
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(new int[] { 1, 5, 3 }, 2, true)]
        [InlineData(new int[] { 3, 1, 4, 1, 5 }, 2, true)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 1, true)]
        [InlineData(new int[] { 1, 3, 5 }, 3, false)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 7, false)]
        [InlineData(new int[] { 1, -3, -5 }, 2, true)]
        public void ValidateDiffK_SubArraySumZero_ValidateIfExist(int[] input, int k, bool expected)
        {
            var sut = new HashingAssignment();
            // act
            var actual = sut.ValidateDiffK(input, k);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 1, 3, 4, 2, 3 }, 4, "3 4 4 3" )]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 3, "3 3 3")]
        [InlineData(new int[] { 1, 2, 1, 2, 1 }, 2, "2 2 2 2")]
        [InlineData(new int[] { 1, 1, 1, 1, 1 }, 2, "1 1 1 1")]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 1, "1 1 1 1 1")]
        [InlineData(new int[] { 5, 4, 3, 2, 1 }, 5, "5")]
        [InlineData(new int[] { 5, 4, 3, 2, 1 }, 6, "1 1 1 1 1")]
        public void FindDistinctNumbersInWindow_SubArraySumZero_ValidateIfExist(int[] input, int k, string expected)
        {
            var sut = new HashingAssignment();
            // act
            var actual = sut.FindDistinctNumbersInWindow(input, k);
            Assert.Equal(expected, actual);
        }

    }
}

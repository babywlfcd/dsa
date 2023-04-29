using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice.Course.Class;

namespace PracticeTests.Course.Class
{
    public class Week4HashingTests
    {
        [Theory]
        [InlineData(new int[] { 6, -1, 2, 1, -1 }, true)]
        [InlineData(new int[] { 0, 3, 5, -3, 2 }, true)]
        [InlineData(new int[] { 1, 2, -1, -2 }, true)]
        [InlineData(new int[] { 1, 2, -1, 8 }, false)]
        public void ExitSubArraySumZero_SubArraySumZero_ValidateIfExist(int[] input, bool expected)
        {
            var sut = new Week4Hashing();
            // act
            var actual = sut.ExitSubArraySumZero(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 15, - 2, 2, -8, 1, 7,10, 23 }, 5)]
        [InlineData(new int[] { 0, 3, 5, -3, 2 }, 1)]
        [InlineData(new int[] { 1, 2, -1, -2 }, 4)]
        [InlineData(new int[] { 1, 2, -1, 8 }, 0)]
        public void LargestSubArraySumZero_SubArraySumZero_LengthOfLongestSubArray(int[] input, int expected)
        {
            var sut = new Week4Hashing();
            // act
            var actual = sut.LargestSubArraySumZero(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("anagram", "nagrama", true)]
        [InlineData("abc", "ab", false)]
        [InlineData("abc", "abd", false)]
        public void ValidateAnagram_TwoStrings_ValidateAnagram(string s, string t, bool expected)
        {
            var sut = new Week4Hashing();
            // act
            var actual = sut.ValidateAnagram(s, t);
            Assert.Equal(expected, actual);
        }
    }
}

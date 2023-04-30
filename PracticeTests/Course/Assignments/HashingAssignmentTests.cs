using Practice;
using Practice.Course.Assignments;
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

            var result = sut.GetIntersection(input1, input2);

            Assert.Equal(expected, result);
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

            var result = sut.FindFirstRepeatingElement(input);

            Assert.Equal(expected, result);
        }

    }
}

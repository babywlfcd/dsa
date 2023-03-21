using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignments;

namespace AssignmentsTests
{
    public class ArraysPracticeTest
    {
        [Theory]
        [InlineData(
            new [] {1, 2, 3, 8, 11, 18}, 
            new[] {1, 5, 28},
            new[] {1, 1, 2, 3, 5, 8, 11, 18, 28})]
        public static void MergeTwoOrderedArrays_ShouldReturn_AnAscendingOrderedArray_For_TwoGivenArrays(int[] input1, int[] input2, int[] expected)
        {
            var sut = new ArraysPractice();
            var result = sut.MergeTwoOrderedArrays(input1, input2);

            for(var i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], result[i]);
            }
        }
    }
}

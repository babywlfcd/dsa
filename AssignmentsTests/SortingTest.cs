using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignments;

namespace AssignmentsTests
{
    
    public class SortingTest
    {
        [Fact]
        public void BubbleSort_SortArrayElements()
        {
            var input = new[] {1, 3, 8, 7, 9, 2, 8};
            var expected = new int[] {1, 2, 3, 7, 8, 8, 9};
            var sut = new Sorting();
            var result = sut.BubbleSort(input);

            for(var i = 0; i < result.Length; i++)
            {
                Assert.Equal(expected[i] , result[i]);
            }
            
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practice.Course.Assignments
{
    public class SearchingAssignment
    {
        /// <summary>
        /// 1. Find Peak Element
        /// Solution:
        ///     1. if first element of the array is greater than second return index 0
        ///     2. If last element of the array is greater than preview one return last index of it
        ///     3. use binary search and check if neighbors are smaller
        ///     4 if not advance to the left if left > mid, otherwise to right
        /// T.C -> O(log(n))
        /// S. C -> O(1)
        /// </summary>
        /// <returns></returns>
        public int FindPickElement(int[] input)
        {
            if (input.Length == 1)
                return 0;

            var start = 1;
            var end = input.Length - 2;

            // check if 0th/n-1th index is the peak element
            if (input[0] > input[1]) return 0;
            if (input[^1] > input[^2]) return input.Length - 1;

            while (start <= end)
            {
                var mid = start + (end - start)/ 2;

                if (input[mid] > input[mid - 1] && input[mid] > input[mid + 1])
                    return mid;

                if (input[mid] <= input[mid - 1])
                    start = mid + 1;
                else
                    end = mid - 1;
            }
            return 0;
        }
    }
}

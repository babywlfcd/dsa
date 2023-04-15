using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Course.Assignments
{
    public class ProblemsOnSorting
    {
        // Sorting algorithms implementations for:
        // 1. Bubble sort
        // 2. Selection Sort
        // 3. Insertion Sort
        // 4. Merge Sort
        // 5. Quick Sort
        // https://github.com/babywlfcd/dsa/blob/main/Practice/Sorting.cs

        /// <summary>
        /// Question - 5
        /// Kth largest distinct element in the array
        /// Solution:
        ///     1. Sort the array
        ///     2. Traverse the array and count only distinct value till k
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int FindMaxKthElem(int[] input, int k)
        {
            if (input == null)
                return 0;

            Array.Sort(input);
            Array.Reverse(input);

            var lastDistinctIndex = 0;
            var maxValue = int.MinValue;
            var count = 1;
            for (var i = 1; i < input.Length; i++)
            {
                if (input[i] == input[lastDistinctIndex])
                    continue;

                maxValue = input[i];
                count++;
                lastDistinctIndex = i;

                if (count == k)
                    break;
            }

            return maxValue;
        }


        /// <summary>
        /// Question - 6
        /// Merge two array that are sorted ascending
        /// Solution: 3 pointer approach
        ///     1. Arrays are ordered so we start pointers from the end of the arrays
        ///         - i starts from the end of the first array
        ///         - j starts from the end of the second array
        ///         - index starts from end of the result array
        ///     4. compare values input1[i] and input2[j]
        ///     5. move the current value to the current index -> set in the result array the value of the index to the higher value
        ///     6  mark moved value by setting it to 0 and move pointer to the left
        ///     7. move index to the left
        /// T.C -> O(m + n)
        /// S.C -> O(1)
        /// </summary>
        /// <param name="input1"></param>
        /// <param name="m"></param>
        /// <param name="input2"></param>
        /// <param name="n"></param>
        public void MergeTwoArrays(int[] input1, int m, int[] input2, int n)
        {
            int i = m - 1, j = n - 1, index = m + n - 1;

            if (input2.Length == 0)
                return;

            // m = 0; n > 0 - move all elements from second array to the first array
            if (input1.Length == input2.Length)
            {
                while (index >= 0 && input1[index] == 0)
                {
                    input1[index] = input2[index];
                    index--;
                }
                return;
            }

            while (index >= 0 && input1[index] == 0)
            {
                if (input1[i] > input2[j])
                {
                    input1[index] = input1[i];
                    input1[i] = 0;
                    if (i > 0)
                        i--;
                }
                else
                {
                    input1[index] = input2[j];
                    input2[j] = 0;
                    if (j > 0)
                        j--;
                }

                index--;
            }
            
            // m < n - move remained values from second array into the first array from the start
            var x = 0;
            while (input2[x] != 0)
            {
                input1[x] = input2[x];
                x++;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Course.Class
{
    public class Week3Sorting
    {
        /// <summary>
        /// Example of problems using sorting
        /// Solution in the assignment
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int FindMaxKthElem(int[] arr, int k)
        {
            Array.Sort(arr);

            return arr[arr.Length - k];
        }

        /// <summary>
        /// Inversion count problem
        /// Find numbers of pair that meet the condition:
        /// i < j && A[i] > A[j]
        /// Solution 1 - Brut force
        /// T.C -> O(n^2)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int FindPairsBruteForce(int[] input)
        {
            var count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (i < j && input[i] > input[j])
                        count++;
                }
            }

            return count;
        }

    }
}

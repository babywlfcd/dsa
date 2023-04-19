using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practice.Course.Class
{
    public class Week3SortingAndSearching
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

        /// <summary>
        /// Binary Search
        /// n -> n/2 -> n / 2^2 ->...-> n / 2^k
        /// n / 2^k = n ->apply log -> log(n) = log(2^k) = k
        /// T.C -> O(log(n))
        /// S.C -> O(1)
        /// </summary>
        /// <param name="array"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int BinarySearch(int[] array, int target)
        {
            var low = 0;
            var high = array.Length - 1;

            while (low <= high)
            {
                var middle = low + (high - low) / 2;
                if (array[middle] == target)
                    return middle;

                if (array[middle] < target)
                    low = middle + 1;
                else
                    high = middle - 1;
            }

            return -1;
        }

        /// <summary>
        /// Solution - binary search
        /// T.C -> O(log(n))
        /// S.C -> O(1)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int FindFirstOccurrenceOfATarget(int[] input, int target)
        {

            var answer = -1;
            var low = 0;
            var high = input.Length - 1;

            while (low <= high)
            {
                var middle = low + (high - low) / 2;
                if (input[middle] == target)
                {
                    answer = middle;
                    high = middle - 1; //keep searching on the left
                }

                if (input[middle] < target)
                    low = middle + 1;
                else
                    high = middle - 1;
            }

            return answer;
        }

        /// <summary>
        /// Q. Given a sorted array rotated a number of time find the pivot
        /// Pivot is the start of the array
        /// after rotations the pivot is the single element that is less that its neighbor
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int FindPivot(int[] input)
        {
            if (input.Length == 1)
                return 0;

            var low = 0;
            var high = input.Length - 1;

            // validate if pivot is first element or last element
            if (input[0] < input[high])
                return 0;

            if (input[high] < input[high - 1])
                return high;

            while (low <= high)
            {
                var mid = low + (high - low) / 2;
                if (input[mid] < input[mid - 1] && input[mid] < input[mid + 1])
                    return mid;

                if (input[mid] > input[mid - 1])
                    high = mid + 1;
                else
                    low = mid + 1;
            }

            return 0;
        }

    }
}

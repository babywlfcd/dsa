using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    /// <summary>
    /// Sorting algorithms
    /// 1. Bubble Sort
    /// 2. Selection sort
    /// 3. Insertion sort
    /// 4. Merge sort
    /// 5. Quick sort
    /// </summary>
    public class Sorting
    {
        /// <summary>
        /// Compare and swap - 2 consecutive values
        /// B.C => O(n) for array already order
        /// W.C => 1 + 2 + ... + n = n * (n + 1)/2 => O(n^2)
        /// T.C = O(n^2)
        /// S.C => O(1)
        /// swaps is order of n^2
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int[] BubbleSort(int[] input)
        {
            for (var i = 0; i < input.Length; i++)
            {
                var swap = false;
                for (var j = 0; j < input.Length - 1; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        Swap(input, j, j+1);
                        swap = true;
                    }

                    if (swap)
                        break;
                }
            }

            return input;
        }

        /// <summary>
        /// Selection sort => select an element of unsorted list in each iteration and place eit at the beginning
        /// -> check the min value and swap elem at idx of min val with first elem
        /// B.C, W.C, T.C = O(n^2)
        /// number of swaps is n
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int[] SelectionSort(int[] input)
        {
            for (var i = 0; i < input.Length - 1; i++)
            {
                var minValueIndex = i;

                for(var j = i + 1; j < input.Length; j++)
                {
                    if (input[j] < input[minValueIndex])
                        minValueIndex = j;
                }

                Swap(input, i, minValueIndex);
            }

            return input;
        }

        
        /// <summary>
        /// Insertion sort - as playing cards
        /// choose a pivot and sift all values grater than pivot to right
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int[] InsertionSort(int[] input)
        {
            var length = input.Length - 1;
            for (var i = 0; i < input.Length; i++)
            {
                var pivot = input[i];
                var j = i;

                // condition ends when current value is less than pivot
                while (j >= 0 && input[j - 1] > pivot)
                {
                    input[j + 1] = input[j];
                    j--;
                }

                input[j + 1] = pivot;
            }

            return input;
        }

        private void Swap(int[] input, int idx1, int idx2)
        {
            if (input[idx1] > input[idx2])
            {
                (input[idx1], input[idx2]) = (input[idx2], input[idx1]);
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public class ArraysPractice
    {
        /// <summary>
        /// Merge 2 ordered arrays
        /// 2 pointers approach
        ///  - left index starts from first element of the first array
        ///  - right index stats from the firs element of the second array
        /// Add the min value between the two items and advance the index in the array where the value was added to the result
        /// T.C => O(n + m)
        /// S.C => O(n + m)
        /// </summary>
        /// <param name="leftArr"></param>
        /// <param name="rightArr"></param>
        /// <returns></returns>
        public int[] MergeTwoOrderedArrays(int[] leftArr, int[] rightArr)
        {
            var result = new int[leftArr.Length + rightArr.Length];
            var currentIndex = 0;
            var leftArrIndex = 0;
            var rightArrIndex = 0;

            while (leftArrIndex < leftArr.Length && rightArrIndex < rightArr.Length)
            {
                if (leftArr[leftArrIndex] < rightArr[rightArrIndex])
                {
                    result[currentIndex] = leftArr[leftArrIndex];
                    leftArrIndex++;
                }
                else
                {
                    result[currentIndex] = rightArr[rightArrIndex];
                    rightArrIndex++;
                }

                currentIndex++;
            }

            while (leftArrIndex < leftArr.Length)
            {
                result[currentIndex] = leftArr[leftArrIndex];
                leftArrIndex++;
                currentIndex++;
            }

            while (rightArrIndex < rightArr.LongLength)
            {
                result[currentIndex] = rightArr[rightArrIndex];
                rightArrIndex++;
                currentIndex++;
            }

            return result;
        }

        /// <summary>
        /// 88. Merge Sorted Array 
        /// https://leetcode.com/problems/merge-sorted-array/
        /// 2 pointers approach
        /// Values are ascending ordered so if the values in the result is added from the end the original values will not be available.
        /// Otherwise we need to keep the ols values to position them later 
        ///     - first pointer starts on the last element from the first array -> m - 1
        ///     - second pointer starts on the last element of the second input -> n - 1 
        /// edge cases
        ///     1. second array is empty
        ///     2. first array contain n elements - all zero
        /// </summary>
        /// <param name="input1"></param>
        /// <param name="m"></param>
        /// <param name="input2"></param>
        /// <param name="n"></param>
        public void Merge(int[] input1, int m, int[] input2, int n)
        {
            int i = m - 1, j = n - 1, index = m + n - 1;

            if (input2.Length == 0)
                return;

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

            var x = 0;
            while (input2[x] != 0)
            {
                input1[x] = input2[x];
                x++;
            }
        }

    }
}

using System;
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
        /// T.C => O(n)
        /// S.C => O(m + n)
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
    }
}

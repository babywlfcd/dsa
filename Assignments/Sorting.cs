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
        /// Compare and swap
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[] BubbleSort(int[] array)
        {
            
            for (var i = 0; i < array.Length; i++)
            {
                var swap = false;
                for (var j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swap = true;
                    }

                    if (swap)
                        break;
                }
            }

            return array;
        }
    }
}

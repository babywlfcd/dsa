﻿using System;
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
            if (input.Length < k)
                return -1;

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

            if (count < k)
                return -1;

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

        /// <summary>
        /// Question - 7
        /// Solution - using hash map
        ///     1. Traverse first the array and store color occurrence in a dictionary
        ///     2. Traverse again the array and set values to the corresponding color
        ///        value and decrease the occurrence in the map
        /// T.C -> O(n)
        /// S.C -> O(1) keep  constant (3) number of key - value
        /// </summary>
        /// <param name="input"></param>
        public void SortColors(int[] input)
        {
            if (input.Length == 0)
                return;

            var givenColors = new Dictionary<string, int>();
            givenColors["red"] = 0;
            givenColors["white"] = 0;
            givenColors["blue"] = 0;

            for (var i = 0; i < input.Length; i++)
            {
                if (input[i] == 0)
                {
                    givenColors["red"] += 1;
                    continue;
                }

                if (input[i] == 1)
                {
                    givenColors["white"] += 1;
                    continue;
                }

                givenColors["blue"] += 1;
            }

            for (var i = 0; i < input.Length; i++)
            {
                while (givenColors["red"] != 0)
                {
                    input[i] = 0;
                    givenColors["red"] -= 1;
                    i++;
                }

                while (givenColors["white"] != 0)
                {
                    input[i] = 1;
                    givenColors["white"] -= 1;
                    i++;
                }

                while (givenColors["blue"] != 0)
                {
                    input[i] = 2;
                    givenColors["blue"] -= 1;
                    i++;
                }
            }
        }

        /// <summary>
        /// Question - 8 - delete char to have a good string
        /// Solution:
        ///     1. Create and array with length 26 to store frequency of each char of the alphabet
        ///     2. Traverse the string and track char frequency
        ///     3. Order the frequency array and calculate number of char to delete
        /// T.C -> O(n)
        /// S.C -> O(1)
        /// </summary>
        /// <returns></returns>
        public int CreateAGoodString(string input)
        {
            var charIndex = new Dictionary<char, int>();
            var chars = "abcdefghijklmnopqrstuvwxyz";
            for (var i = 0; i < chars.Length; i++)
            {
                charIndex[chars[i]] = i;
            }
                
            var frequencyChars = new int[26];
            for (var i = 0; i < input.Length; i++)
            {
                frequencyChars[charIndex[input[i]]] += 1;
            }

            Array.Sort(frequencyChars);
            Array.Reverse(frequencyChars);
            
            var charToDelete = 0;
            for (var i = 0; i < frequencyChars.Length - 1; i++) // T.C  -> O(26) = O(1)
            {
                if (frequencyChars[i] == 0)
                    break;
                var j = i + 1;
                var charNo = 0;
                while (j < frequencyChars.Length - 1 && frequencyChars[i] == frequencyChars[j])
                {
                    charNo += 1;
                    charToDelete += charNo;
                    frequencyChars[j] -= charNo;
                    j++;
                }
            }

            return charToDelete;
        }
    }
}

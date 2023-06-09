﻿using System.Runtime.InteropServices.JavaScript;
using System.Text;

namespace Practice.Course.Assignments
{
    public class HashingAssignment
    {
        /// <summary>
        /// 1. Common Elements
        /// T.C -> O(n + m) where n = a.Length, m = b.Length
        /// S.C -> O(n)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int[] GetIntersection(int[] a, int[] b)
        {
            if (a.Length == 0 || b.Length == 0)
                return new int[] { };

            var result = new List<int>();
            var valueFrequency = new Dictionary<int, int>();

            for (int i = 0; i < a.Length; i++)
            {
                if (valueFrequency.ContainsKey(a[i]))
                    valueFrequency[a[i]] += 1;
                else
                    valueFrequency[a[i]] = 1;
            }

            for (int i = 0; i < b.Length; i++)
            {
                if (valueFrequency.ContainsKey(b[i]) && valueFrequency[b[i]] > 0)
                {
                    result.Add(b[i]);
                    valueFrequency[b[i]] -= 1;
                }
            }

            return result.ToArray();
        }

        /// <summary>
        /// 2. First Repeating Element
        /// T.C -> O(n)
        /// S.C -> O(n)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int FindFirstRepeatingElement(int[] input)
        {
            // key -> value from the array at index i
            // value -> index
            var elementFrequency = new Dictionary<int, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!elementFrequency.ContainsKey(input[i]))
                    elementFrequency[input[i]] = i;
                else
                    return input[i];

            }

            return -1;
        }

        /// <summary>
        /// 3. Largest Continuous Sequence Zero Sum
        /// TODO - need clarification
        /// Solution - prefix sum
        /// T.C -> O(n)
        /// S.C -> O(n)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int[] LargestSubArraySumZero(int[] input)
        {
            // I need clarifications for this ask
            // for [1, 2, -3, 3, 2] my expectation was to have the result [1, 2, -3] but is [-3,3] ?
            // for [1, 2, 3, -3, 4, -2, -1] the result is [2, 3, -3, 4, -2] but sum is not zero ?
            // for [0, 0, 0] the result is inconsistent comparing with the rest of test cases ?
            // test cases are valid?
            return new int[] {};
        }

        /// <summary>
        /// 4. Sub-array with 0 sum
        /// Solution 1. Brute force
        ///     Find all sub arrays and then find sum for sub arrays
        ///     T.C -> O(n^2)
        ///     S.C -> O(1)
        /// Solution 2 - prefix sum
        ///     Add values to a dictionary and if value already exist return true
        ///     T.C -> O(n)
        ///     S.C -> O(1)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool ExistSubArraySumZero(int[] input)
        {
            var values = new Dictionary<int, int>();
            values[0] = 1;
            var previewVal = 0;
            for (var i = 0; i < input.Length; i++)
            {
                previewVal += input[i];
                if (values.ContainsKey(previewVal))
                    return true;

                values[previewVal] = 1;
            }

            return false;
        }

        /// <summary>
        /// 5. Shaggy and distances
        /// Solution 1: brute force
        ///     1. fins min max in each sub-array and count if is even
        /// T.C -> O(n^3)
        /// S.C -> O(1)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int CountSumMaxMinEven(int[] input)
        {
            // I need clarifications for this ask
            // problem example:
            // -> Consider an array A = [1, 5, 6, 2, 1]. Here, the sub-array [1, 5] has the maximum element 5 and 
            //    the minimum element 1.Therefore, the sum of the maximum and minimum elements is 6, 
            //    which is even.Similarly, the sub-arrays[5, 6], [6, 2], [2, 1] and [1, 5, 6, 2, 1] also satisfy the given
            //    condition.Hence, the total number of sub - arrays that satisfy the condition is 5.
            // [5, 6], [2, 1] is odd right?
            // [1] is also SubArray and min = max = 1. Problem statement does not exclude this case. 
            // [1, 5, 6, 2, 1] - for this data set min is and mx is 6, right?
            //                   or min and max element should be first and last element in the subarray?

            var count = 0;
            for (var i = 0; i < input.Length - 1; i++)
            {
                for (var j = i + 1; j < input.Length; j++)
                {
                    var min = int.MaxValue;
                    var max = int.MinValue;
                    for (var k = i; k <= j; k++)
                    {
                        if(min > input[k])
                            min = input[k];
                        if(max < input[k]) 
                            max = input[k];
                    }

                    var sum = min + max;
                    if(sum % 2 == 0)
                        count++;
                }
            }

            return count;
        }


        /// <summary>
        /// 6. K Occurrences
        /// T.C -> O(n + m) where n = input length, m = valuesOccurrence length
        /// S.C -> O(m)
        /// </summary>
        /// <param name="input"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public List<int> FindKOccurrence(int[] input, int k)
        {
            var valuesOccurrence = new Dictionary<int, int>();

            for (var i = 0; i < input.Length; i++)
            {
                if (valuesOccurrence.ContainsKey(input[i]))
                    valuesOccurrence[input[i]] += 1;
                else
                    valuesOccurrence[input[i]] = 1;
            }

            var result = new List<int>();

            var j = 0;
            foreach (var item in valuesOccurrence)
            {
                if (item.Value == k)
                {
                    result.Add(item.Key);
                    j++;
                }
            }

            result.Sort();

            return result;
        }

        /// <summary>
        /// 7. Check Palindrome - II
        /// Solution: 2 pointer approach
        ///     1. left - starts from first char; right starts from the second char
        ///     2. compare chars and advance left and right by:
        ///         - skipping string empty
        ///         - ignore cases
        ///     3 return validation result
        /// T.C -> O(n)
        /// S.C -> O(1)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool CheckPalindrome(string s)
        {
            var left = 0;
            var right = s.Length - 1;

            var letters = new Dictionary<char, int>(); // O(1) - will contain 26 values
            var smallLetters = "abcdefghijklmnopqrstuwxyz";
            for (var i = 0; i < smallLetters.Length; i++)
                letters[smallLetters[i]] = 0;

            while (left < right)
            {
                //pass spaces
                while (!letters.ContainsKey(char.ToLower(s[left])))
                    left++;
                while (!letters.ContainsKey(char.ToLower(s[right])))
                    right--;

                if (!char.ToLower(s[left]).Equals(char.ToLower(s[right])))
                    return false;

                left++;
                right--;
            }

            return true;
        }

        /// <summary>
        /// 8. Colorful Number
        /// T.C -> O(n)
        /// S.C -> O(n)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool IsColorfulNumber(int n)
        {
            var digitsFrequency = new Dictionary<int, int>();
            while (n > 0)
            {
                var digit = n % 10;

                if (digitsFrequency.ContainsKey(digit))
                    return false;
                
                digitsFrequency[digit] = 1;
                n = n / 10;
            }

            return true;
        }

        /// <summary>
        /// 9. Sub-array with given sum
        /// Solution - using prefix sum
        ///     1. Traverse the array and store prefix sum in a dictionary: key = prefixSum, value first index
        ///     2. Compute sum starting from that index and if the target is found return
        ///     3. Otherwise continue
        ///     4. If no solution founded return an empty array
        /// T.C -> O(n)
        /// S.C -> O(n)
        /// </summary>
        /// <param name="input"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int[] FindSubArrayMarginsWithTargetSumK(int[] input, int k)
        {
            var prefixData = new Dictionary<int, int>();
            prefixData[0] = -1;

            var prefixSum = 0;

            for (var i = 0; i < input.Length; i++)
            {
                var result = new int[2];
                
                //[1, 0, 1]
                if (input[i] == 0)
                {
                    return new int[] {input[i]};
                }

                var j = i;
                prefixSum += input[i];

                if (!prefixData.ContainsKey(prefixSum))
                    prefixData[prefixSum] = i;

                
                var currentSum = 0;
                while (j < input.Length)
                {
                    currentSum += input[j];
                    if (currentSum == k)
                    {
                        result[0] = prefixData[prefixSum];
                        result[1] = j;
                        return result;
                    }

                    j++;
                }
            }

            return new int[] {};
        }


        /// <summary>
        /// 10. Diffk II
        /// T.C -> O(n)
        /// S.C -> O(n)
        /// </summary>
        /// <param name="input"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public bool ValidateDiffK(int[] input, int k)
        {
            // Question: why we need also to check input[i] - k?
            var diff = new Dictionary<int, int>();

            for (var i = 0; i < input.Length; ++i)
            {
                if (diff.ContainsKey(k + input[i]) || diff.ContainsKey(input[i] - k))
                    return true;

                diff[input[i]] = 0;
            }

            return false;
        }

        /// <summary>
        /// 11. Distinct Numbers in Window
        /// Solution
        ///     1. stat left and right pointer: left = i = 0, right = k - 1
        ///     2. keep a hash table to find distinct values
        ///     3. the length of the hash will represent the distinct no in window -> add to the result
        ///     4. advance pointers and repeat until the end of the array
        /// T.C -> O(k^2)
        /// S.C -> O(k)
        /// </summary>
        /// <param name="input"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public string FindDistinctNumbersInWindow(int[] input, int k)
        {
            /*
             * why in the next test cases we have 4 values in the response?
             * Both have only 3 possible window of length 3
             * Input: arr[] = {1, 2, 1, 2, 1}, k = 3 
             * Output: 2 2 2 2
             * Input: arr[] = {1, 1, 1, 1, 1}, k = 3
             * Output: 1 1 1 1
             */

            // Problem does not specify if k can be greater than input length
            // If yes, I take in consideration the smallest window possible 
            // I am assuming the k will start from the beginning of the array until find his right position
            // Is this the right assumption?
            if ( k > input.Length)
                k = k % input.Length;

            var right = k - 1;
            var result = new List<int>();
            for (var i = 0; i < input.Length - k + 1; i++)
            {
                var distinctValues = new Dictionary<int, int>();
                var j = i;
                while (j <= right)
                {
                    if (!distinctValues.ContainsKey(input[j]))
                        distinctValues[input[j]]= 0;
                    j++;
                }
                result.Add(distinctValues.Count);
                right++;
            }

            return string.Join(" ", result);
        }

        /// <summary>
        /// 12. 2 Sum
        /// Solution:
        ///     1. Add values to a dictionary: kew = value from the array, value = index where value is stored
        ///     2. Traverse the array again an check if the pair is present in the dictionary (k - input[i])
        ///     3. If yes add to the response and mark both keys as visited by ser the value to -i (invalid index)
        /// T.C -> O(n)
        /// S.C -> O(n)
        /// </summary>
        /// <param name="input"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int[][] FindSumPairs(int[] input, int k)
        {
            /*
             * Data set Input: nums = [3, 4, 5, 7, 8], target = 12
             * Output: [(4, 8)]
             * (5, 7) is also a valid pair. Please adjust the output in the assignment document
             */
            var result = new List<int[]>();
            var values = new Dictionary<int, int>();

            for (var i = 0; i < input.Length; i++)
            {
                if (!values.ContainsKey(input[i]))
                    values[input[i]] = i;
            }

            for (var i = 0; i < input.Length; i++)
            {
                var pair = new int[2];
                if (values.ContainsKey(k - input[i]) && values[input[i]] != -1)
                {
                    var pairIndex = values[k - input[i]];
                    
                    pair[0] = input[i];
                    pair[1] = input[pairIndex];

                    // set visited value with -1 - invalid index
                    values[input[i]] = -1;
                    values[input[pairIndex]] = -1;
                    result.Add(pair);
                }
            }

            return result.ToArray();
        }

        /// <summary>
        /// 13. Is Dictionary?
        /// Solution:
        ///     1. add words to a dictionary: key = word
        ///     2. traverse the string, create a substring an compute with chars from the  string
        ///     3. check check if the substring is present in the dictionary until wil potentially create a word
        ///     3. if the substring represent a word that is present continue with a new substring
        /// </summary>
        /// <param name="words"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool IsDictionary(string[] words, string input)
        {
            if (words.Length == 0 || input.Length == 0)
                return false;

            var wordsDic = new Dictionary<string, int>();
            for (var i = 0; i < words.Length; i++)
            {
                if (!wordsDic.ContainsKey(words[i]))
                    wordsDic[words[i]] = 0;
            }

            var sb = new StringBuilder();
            bool isWordPresent = false;
            for (var i = 0; i < input.Length; i++)
            {
                isWordPresent = false;
                sb.Append(input[i]);
                if (wordsDic.ContainsKey(sb.ToString()))
                {
                    if (wordsDic[sb.ToString()] == 1)
                        return false;

                    isWordPresent = true;
                    // key visited once
                    wordsDic[sb.ToString()] = 1;
                    sb.Clear();
                }
            }

            if (isWordPresent)
                return true;

            return false;
        }

        /// <summary>
        /// Medium
        /// 15. Longest Consecutive Sequence
        /// https://leetcode.com/problems/longest-consecutive-sequence/
        /// Complexity:
        /// foreach loop -> O(n)
        /// while can be  O(n) but is traversed only at i = const val.
        /// each value will be visited at most 2 times so T.C is O(n)
        /// T.C -> O(n)
        /// T.C -> O(n)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int LongestConsecutive(int[] input)
        {
            //add unique values to a dictionary 
            var numValues = new Dictionary<int, int>();
            for (var i = 0; i < input.Length; i++)
            {
                if (numValues.ContainsKey(input[i]))
                    continue;
                numValues[input[i]] = input[i];
            }
            var longest = 0;
            foreach (var item in numValues) // O(n)
            {
                //check if current value is a start of sequence
                if (!numValues.ContainsKey(item.Value - 1))
                {
                    var length = 0; // this will keep the sequence length
                    // check for current value if is end of sequence
                    while (numValues.ContainsKey(item.Value + length))
                        length++;

                    longest = Math.Max(length, longest);
                }
            }

            return longest;
        }

        /// <summary>
        /// 16. Sort Array in given Order
        /// Solution
        ///     1. keep frequency iv the values from the first array in a dictionary
        ///     2. save values from b that are in a in a different dictionary
        ///     3. save values that are not in b in a dynamic array
        ///     4. replace elements in the firs array with values from the second
        ///        by decreasing frequency of that particular value
        ///     5. at the end order the dynamic array and set remaining elements in
        ///        the first array with values stored in the dynamic array
        /// T.C -> O(n * log(n) + m), where n = input1.Length and m = input2 length
        /// S.C -> O(n + m)
        /// </summary>
        /// <param name="input1"></param>
        /// <param name="input2"></param>
        /// <returns></returns>
        public int[] SortArrayInGivenOrder(int[] input1, int[] input2)
        {
            if (input2.Length == 0)
            {
                Array.Sort(input1); //O(n * log(n))
                return input1;
            }

            var frequencyInput1 = new Dictionary<int, int>();
            
            for (var i = 0; i < input1.Length; i++) //O(n)
            {
                if (!frequencyInput1.ContainsKey(input1[i]))
                    frequencyInput1[input1[i]] = 1;
                else
                    frequencyInput1[input1[i]] +=1;
            }

            var valuesInput2 = new Dictionary<int, int>();
            for (var i = 0; i < input2.Length; i++) //O(m)
            {
                // save only distinct values of b even though I am assuming that b contains only distinct values
                if (valuesInput2.ContainsKey(input2[i]) || !frequencyInput1.ContainsKey(input2[i]))
                    continue;
                valuesInput2[input2[i]] = 0;
            }

            // in b does not have any values that are in a return input 1 sorted
            if (!valuesInput2.Any())
            {
                Array.Sort(input1); //O(n * log(n))
                return input1;
            }

            var otherValues = new List<int>();
            for (var i = 0; i < input1.Length; i++) //O(n)
            {
                if (!valuesInput2.ContainsKey(input1[i]))
                    otherValues.Add(input1[i]);
            }

            var nextIndex = -1;
            var idx = 0;
            var coutItemInB = valuesInput2.Count;
            foreach(var item in valuesInput2) //O(n)
            {
                
                var frequency = frequencyInput1[item.Key];

                while (frequency > 0)
                {
                    input1[idx] = item.Key;
                    frequency--;
                    idx++;
                }

                coutItemInB--;
                if (coutItemInB == 0)
                    nextIndex = idx;
            }
            otherValues.Sort();

            for (var i = 0; i < otherValues.Count; i++)
            {
                input1[nextIndex + i] = otherValues[i];
            }

            return input1;
        }

        /// <summary>
        /// 17. Replicating Substring
        /// Solution:
        ///     1. Construct substring Using 2 pointers and traverse the string till middle of the string:
        ///        a. use string builder since string is immutable
        ///        b. start index and runner index = traverse index as follow
        ///           - continue advance start index and runner index if string contain same char from start
        ///           - advance runner index until we will find same char 
        ///     2. Store the substring in a dictionary
        ///     3. check if the substring divide string length. If no return false
        ///     4. iterate over string and check if the substring value is in the dictionary
        /// T.C -> O(n)
        /// S.C -> O(n)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool ReplicateSubstring(string s)
        {
            if (s.Length <= 1)
                return false;

            var sb = new StringBuilder();
            sb.Append(s[0]);
            var start = 0;
            var isDifferent = false;
            for (var i = 1; i < s.Length / 2; i++) 
            {
                if (isDifferent && s[i] == s[start])
                    break;

                //traverse string once and advance runner index in while -> O(n)
                while (s[i] == s[start]) 
                {
                    sb.Append(s[start]);
                    start++;
                    i++;
                }

                if (s[i] != s[start])
                    isDifferent = true;

                sb.Append(s[i]);
            }

            if (s.Length % sb.Length != 0)
                return false;

            var substrFrequency = new Dictionary<string, int>();
            substrFrequency[sb.ToString()] = 1;
            for (var i = sb.Length; i < s.Length; i = i + sb.Length)
            {
                if (!substrFrequency.ContainsKey(s.Substring(i, sb.Length)))
                    return false;
            }

            return true;
        }
    }
}

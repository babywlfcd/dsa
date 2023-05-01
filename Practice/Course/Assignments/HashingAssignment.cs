using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

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
        /// TODO - need help
        /// Solution - prefix sum
        /// T.C -> O(n)
        /// S.C -> O(n)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int[] LargestSubArraySumZero(int[] input)
        {
            var lenghtIdx = new Dictionary<int, int>();
            lenghtIdx[0] = -1;
            var maxLength = 0;
            var prefixSum = new int[input.Length];
            prefixSum[0] += input[0];
            for (int i = 1; i < input.Length; i++)
            {
                prefixSum[i] = prefixSum[i - 1] + input[i];
            }

            var firstIndex = -1;
            for (int i = 0; i < prefixSum.Length; i++)
            {
                if (lenghtIdx.ContainsKey(prefixSum[i]))
                    maxLength = i - lenghtIdx[prefixSum[i]];
                else
                {
                    lenghtIdx[prefixSum[i]] = i; // first index 
                }
            }

            var result = new List<int>();
            for (var i = firstIndex; i <= maxLength; i++)
            {
                result.Add(input[i]);
            }

            return result.ToArray();
        }

        /// <summary>
        /// 4. Sub-array with 0 sum
        /// TODO - need help
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

            var prefixSum = 0;

            for (var i = 0; i < input.Length; i++)
            {
                var j = i;
                prefixSum += input[i];

                if (!prefixData.ContainsKey(prefixSum))
                    prefixData[prefixSum] = i;

                var result = new int[2];
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

    }
}

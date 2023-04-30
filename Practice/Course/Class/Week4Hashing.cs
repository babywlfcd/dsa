using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Course.Class
{
    public class Week4Hashing
    {
        /// <summary>
        /// Sub array with sum zero.
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
        public bool ExitSubArraySumZero(int[] input)
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
        /// Longest string with sum zero
        /// TODO - need help - exclude prefix sum
        /// Solution - prefix sum
        /// T.C -> O(n)
        /// S.C -> O(n)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int LargestSubArraySumZero(int[] input)
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

            for (int i = 0; i < prefixSum.Length; i++)
            {
                if (lenghtIdx.ContainsKey(prefixSum[i]))
                    maxLength = i - lenghtIdx[prefixSum[i]];
                else
                    lenghtIdx[prefixSum[i]] = i; // first index 
            }

            return maxLength;
        }

        /// <summary>
        /// Validate if 2 strings are anagrams
        /// T.C -> O(n)
        /// S.C -> O(n)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool ValidateAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            var charFrequency = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (charFrequency.ContainsKey(s[i]))
                    charFrequency[s[i]] += 1;
                else
                {
                    charFrequency[s[i]] = 1;
                }
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (!charFrequency.ContainsKey(t[i]))
                    return false;

                charFrequency[t[i]] -= 1;
            }

            foreach (var charKey in charFrequency)
            {
                if (charKey.Value != 0)
                    return false;
            }

            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Course.Assignments
{
    public class BitManipulationAssignment
    {
        /// <summary>
        /// Easy
        /// 136. Single Number
        /// Source: https://leetcode.com/problems/single-number/
        /// Solution 1: Brut force approach
        ///     Sort the array and traverse the array and check if the current element is equal to the next element
        ///     T.C -> O(n log(n))
        ///     S.C -> O(1)
        /// Solution 2: Using hashset
        ///     Traverse the array and add the element to the hashset if it is not present
        ///     Hasset will have key = number and value = count
        ///     Traverse the Haset and return the element with count = 1
        ///     T.C -> O(n)
        ///     S.C -> O(n)
        /// Solution 3: Optimal Solution Using SOR operator
        ///     The next properties are used:
        ///     a ^ a = 0
        ///     comutativity a ^ b = b ^ a
        ///     asociativity a ^ b ^ c = a ^ (b ^ c) = (a ^ b) ^ c
        ///     a ^ 0 = a
        ///     We traverse the array once and based on properties of XOR double elements will
        ///     cancel each other and we will have the single element     
        /// </summary>
        public int FindSingle(int[] input)
        {
            var res = 0;

            for (var i = 0; i < input.Length; i++)
            {
                res ^= input[i];
            }

            return res;
        }

        /// <summary>
        /// Easy
        /// 66. Add Binary
        /// Source: https://leetcode.com/problems/add-binary/
        /// Solution:
        ///     - We will use two pointers to iterate over the two strings
        ///     - We will use a carry to store the value of the sum of the two numbers
        ///     - We will use a StringBuilder to store the result
        ///     - We will iterate over the two strings and calculate the sum and the carry
        ///       Remark: in case of string we need to convert the character to integer or
        ///               we can use the ASCII value of the character
        ///     - We will add the carry to the result
        ///     - We will reverse the result
        ///       Remark: reversing the sting at the end depends on the Programming language.
        ///               Some languages like Python can directly construct the reversed string
        ///               by adding the result in front of the string
        ///     - We will return the result
        /// T.C : O(n)
        /// S.C : O(n) -> for the result string builder is used
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string AddBinary(string a, string b)
        {
            var res = new StringBuilder();
            var carry = 0;
            var i = a.Length - 1;
            var j = b.Length - 1;

            while (i >= 0 || j >= 0)
            {
                var sum = carry;
                if (i >= 0)
                {
                    sum += a[i] - '0';
                    i--;
                }

                if (j >= 0)
                {
                    sum += b[j] - '0';
                    j--;
                }

                res.Append(sum % 2);
                carry = sum / 2;
            }

            if (carry > 0)
                res.Append(carry);

            // reverse the result
            var arr = res.ToString().ToCharArray();
            Array.Reverse(arr);
            return string.Join("", arr);
        }

        /// <summary>
        /// Question 5: Count all set bits 
        /// Solution 1: traverse each bit and check if it is set
        /// T.C = O(32) ~ O(1)
        /// S.C = O(1)
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int CountOneBitsFor32Bit(int num)
        {
            var count = 0;
            for (var i = 0; i < 32; i++)
            {
                if ((num & 1) == 1)
                {
                    count++;
                }
                num = num >> 1;
            }

            return count;
        }

        /// <summary>
        /// Solution 2: Using Brian Kernighan’s Algorithm
        /// 
        /// Remarks: THis is better algo as in Solution 1 we ignore 32 as constant 
        /// whereas in this solution 32 is max max value of log(n)
        /// 
        /// T.C = O(log n)
        /// S.C = O(1)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int CountDigitOne(int n)
        {
            var res = 0;

            while (n > 0)
            {
                if ((n & 1) == 1)
                {
                    res++;
                }
                n = n >> 1;
            }

            return res;
        }

        /// <summary>
        /// Given an array of integers, determine if bitwise XOR is zreo
        /// Source:  https://leetcode.com/problems/find-xor-sum-of-all-pairs-bitwise-and/ath
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public bool IsInterestingArray(int[] arr)
        {
            var n = arr.Length;
            var res = 0;
            for (var i = 0; i < n; i++)
            {
                res ^= arr[i];
            }

            return res == 0;
        }

        /// <summary>
        /// Easy
        /// 190. Reverse Bits
        /// Source: https://leetcode.com/problems/reverse-bits/
        /// Solution:
        ///     - We will iterate over the bits
        ///     - We will extract the least significant bit
        ///     - We will append the bit to the result
        ///     - We will right-shift n to process the next bit
        /// T.C : O(log(n))
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public uint ReverseBits(uint n)
        {
            uint result = 0;
            for (int i = 0; i < 32; i++)
            {
                int bit = (int)(n & 1);       // Extract the least significant bit
                result = (uint)((result << 1) | bit); // Append the bit to the result
                n = n >> 1;           // Right-shift n to process the next bit
            }
            return result;
        }
    }
}

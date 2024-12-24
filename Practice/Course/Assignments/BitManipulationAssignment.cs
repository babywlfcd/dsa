using System.Text;

namespace Practice.Course.Assignments
{
    public class BitManipulationAssignment
    {
        /// <summary>
        /// Easy - Q1
        /// 136. Single Number
        /// Source: https://leetcode.com/problems/single-number/
        /// Medium
        /// 540. Single Element in a Sorted Array
        /// https://leetcode.com/problems/single-element-in-a-sorted-array/description/
        /// Solution 1: Brut force approach
        ///     Sort the array and traverse the array and check if the current element is equal to the next element
        ///     T.C -> O(n log(n))
        ///     S.C -> O(1)
        /// Solution 2: Using hashset
        ///     Traverse the array and add the element to the hashset if it is not present
        ///     Hashset will have key = number and value = count
        ///     Traverse the Hashset and return the element with count = 1
        ///     T.C -> O(n)
        ///     S.C -> O(n)
        /// Solution 3: Optimal Solution Using XOR operator
        ///     The next properties are used:
        ///     a ^ a = 0
        ///     We traverse the array once and based on properties of XOR double elements will
        ///     cancel each other, and we will have the single element     
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
        /// Easy - Q2
        /// 66. Add Binary
        /// Source: https://leetcode.com/problems/add-binary/
        /// Solution:
        ///     - We will use two pointers to iterate over the two strings
        ///     - We will use a carry to store the value of the sum of the two numbers
        ///     - We will use a StringBuilder to store the result
        ///     - We will iterate over the two strings and calculate the sum and the carry
        ///       Remark: in case of string we need to convert the character to integer, or
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
        /// Easy: Question 3: Count all set bits 
        /// 191. Number of 1 Bits
        /// Source: https://leetcode.com/problems/number-of-1-bits
        /// Solution 1: Using Bitwise operator
        ///     - We will count the number of set bits from the least significant bit
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
        /// Easy -  Q3
        /// 191. Number of 1 Bits
        /// Source: https://leetcode.com/problems/number-of-1-bits
        /// Solution 2: Using Brian Kernighan’s Algorithm
        ///     - we will count the number of set bits from the least significant bit
        ///     - we will shift the bits to the right until the number becomes 0
        /// Remarks: This is better algo as in Solution 1 we ignore 32 as constant 
        /// whereas in this solution 32 is max value of log(n)
        /// 
        /// Remarks: THis is better algo as in Solution 1 we ignore 32 as constant 
        /// whereas in this solution 32 is max value of log(n)
        /// 
        /// T.C = O(log n)
        /// S.C = O(1)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int HammingWeight(int n)
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
        /// Q4
        /// Given an array of integers, determine if bitwise XOR is zero
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
        /// Easy: Q5
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
            for (var i = 0; i < 32; i++)
            {
                var bit = (int)(n & 1);       // Extract the least significant bit
                result = (uint)((result << 1) | bit); // Append the bit to the result
                n = n >> 1;           // Right-shift n to process the next bit
            }
            return result;
        }

        /// <summary>
        /// Q7
        /// Source: https://leetcode.com/problems/find-xor-sum-of-all-pairs-bitwise-and/
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int GoodDay(int[] input)
        {
            //Given a list of integers representing the stock prices for each day, you need to find the number of good days. A good day is defined as a day when the bitwise AND of the stock prices for that day and the next day is greater than zero.
            var res = 0;
            for (var i = 0; i < input.Length - 1; i++)
            {
                if ((input[i] & input[i + 1]) > 0)
                {
                    res++;
                }
            }
            return res;

        }

        #region Single number problems - Classic approach
        /// <summary>
        /// Easy
        /// 136. Single Number
        /// Source: https://leetcode.com/problems/single-number/
        /// 
        /// This problem can be solved using bit manipulation
        /// However we will solve this problem in a classic way first
        /// , and we will generalize it for classic approach 
        /// then we will solve and thing about bit manipulation
        /// Solution 1: Brute force
        ///     - Sort the array to cave the same numbers together
        ///     - Loop through the array and check if the current number is equal to the next number
        ///     - If it is equal then continue the loop and check next pair of numbers
        /// T.C = O(n log n)
        /// S.C = O(1)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int FindSingleNumberClassicApproach(int[] A)
        {
            Array.Sort(A);
            //for (var i = 0; i < A.Length; i = i + 2)
            //{
            //    for (var j = i + 1; j < A.Length - 1; j++)
            //    {
            //        if (A[i] == A[j])
            //        {
            //            break;
            //        }
            //        return A[i];
            //    }
            //}

            // We don't need to have 2 loops. one loop is enough and check next element
            // this will reduce the time complexity
            for (var i = 0; i < A.Length - 1; i = i + 2)
            {
                if (A[i] == A[i + 1])
                {
                    continue;
                }
                return A[i];
            }

            return A[A.Length - 1];
        }

        /// <summary>
        /// Medium
        /// 137. Single Number II
        /// https://leetcode.com/problems/single-number-ii/description/
        /// 
        /// This is similar with the above problem  only that 3 numbers are repeated
        /// Solution 1: Brute force
        ///     - Sort the array to cave the same numbers together
        ///     - Loop through the array and check if the current number is equal to the third number
        ///     - If it is equal then continue the loop and check next 3 elements
        /// T.C = O(n log n)
        /// S.C = O(1)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int SingleNumber2(int[] A)
        {
            Array.Sort(A);
            for (var i = 0; i < A.Length - 2; i = i + 3)
            {
                if (A[i] == A[i + 2])
                {
                    continue;
                }
                return A[i];
            }
            return A[A.Length - 1];
        }

        /// <summary>
        /// We can generalize the problem above.
        /// The above problems are a special case of the next problem:
        /// Given an array of integers, every element appears k (k > 1) times except for one, 
        /// which appears only once. Return the single number
        /// 
        /// T.C = O(n log n)
        /// S.C = O(1)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int SingleNumberGeneralisation(int[] A, int k)
        {
            Array.Sort(A);
            for (var i = 0; i < A.Length - k + 1; i = i + k)
            {
                if (A[i] == A[i + k - 1])
                {
                    continue;
                }
                return A[i];
            }
            return A[A.Length - 1];
        }
        #endregion

        #region Single number problems - bit manipulation
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
        ///     Hashset will have key = number and value = count
        ///     Traverse the Hashset and return the element with count = 1
        ///     T.C -> O(n)
        ///     S.C -> O(n)
        /// Solution 3: Optimal Solution Using XOR operator
        ///     The next properties are used:
        ///     a ^ a = 0
        ///     commutativity a ^ b = b ^ a.
        ///     associativity a ^ b ^ c = a ^ (b ^ c) = (a ^ b) ^ c
        ///     a ^ 0 = a.
        ///     We traverse the array once and based on properties of XOR double elements will
        ///     cancel each other, and we will have the single element
        ///     T.C -> O(n)
        ///     S.C -> O(1)
        ///     
        /// Sum = 5 + 2 + (-1) + (-2) + 1
        /// </summary>
        public int FindSingle2(int[] input)
        {
            var res = 0;

            for (var i = 0; i < input.Length; i++)
            {
                res ^= input[i];
            }
            return res;
        }

        /// <summary>
        /// Solution:
        ///     - Count the numbers in which they are set 
        ///     - check if is in 3n + 1 format to count
        /// 137. Single Number II
        /// https://leetcode.com/problems/single-number-ii/description/
        /// T.C = O(n)
        /// S.C = O(1)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int FindSingle3(int[] input)
        {
            /*
             * check this code
                int ones = 0, twos = 0;
                foreach(var num in input)
                {
                    ones = (num ^ ones) & ~twos;
                    twos = (num ^ twos) & ~ones;
                }
                return ones;
             * */
            var res = 0;

            for (var i = 0; i < 32; i++)
            {
                var count = 0;
                for (var j = 0; j < input.Length; j++)
                {
                    if (((input[j] >> i) & 1) == 1)
                        count++;
                }

                if (count % 3 == 1)
                {
                    res = (1 << i) | res;
                }
            }

            return res;
        }

        public int FindSingleNumberGeneralisation(int[] input, int k)
        {
            var res = 0;
            if (k % 2 == 0)
            {
                for (var i = 0; i < input.Length; i++)
                {
                    res ^= input[i];
                }
                
            }
            else
            {
                for (var i = 0; i < 32; i++)
                {
                    var count = 0;
                    for (var j = 0; j < input.Length; j++)
                    {
                        if (((input[j] >> i) & 1) == 1)
                            count++;
                    }

                    if (count % k == 1)
                    {
                        res = (1 << i) | res;
                    }
                }
            }

            return res;

        }
        #endregion

        /// <summary>
        /// Medium: Q8
        /// 260. Single Number III
        /// Source: https://leetcode.com/problems/single-number-iii/
        /// Solution:
        ///     - calculate the XOR of all the elements
        ///     - find the right most set bit
        ///     - calculate the XOR into 2 different groups
        ///         - if the bit is set then add to group 1
        ///         - if the bit is not set then add to group 2
        /// T.C = O(n)
        /// S.C = O(1)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>

        public int[] FindSingleTwoNo(int[] input)
        {
            var allXor = 0;
            for (var i = 0; i < input.Length; i++)
            {
                allXor ^= input[i];
            }

            for (var i = 0; i < 32; i++)
            {
                if (((allXor >> i) & 1) == 1)
                {
                    allXor = i;
                    break;
                }
            }

            var res = new int[2];
            for (var i = 0; i < input.Length; i++)
            {
                if (((input[i] >> allXor) & 1) == 0)
                {
                    res[0] ^= input[i];
                }
                else
                {
                    res[1] ^= input[i];
                }
            }

            return res;

        }
        /* Q6, Q7, Q9, Q10, Q11, Q13, Q14 */

        /// <summary>
        /// Q12
        /// Count the number of set bits for all numbers from 1 to n
        /// Source: https://www.geeksforgeeks.org/count-total-set-bits-in-all-numbers-from-1-to-n/
        ///     - Kernighan Algorithm is used to count the number of set bits for each number
        ///     - The function CountOneBit is used to count the number of set bits a number
        ///     - The function CountTotalSetBits is used to count the number of set bits for all numbers from 1 to n
        /// T.C = O(n log n) - where n is the number of bits. log(n) operations for right shift
        /// S.C = O(1)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int CountTotalSetBits(int n)
        {
            var res = 0;
            for (var i = 1; i <= n; i++)
            {
                res += CountOneBit(i);
            }

            return res;
        }

        public int CountOneBit(int n)
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
    }
}

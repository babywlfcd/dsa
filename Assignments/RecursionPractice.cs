using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public class RecursionPractice
    {
        /*
         * ----------------
         * || Assignment ||       
         * ----------------
         */

        // Q1. Sum of Digits!
        // Initial solution
        public int SumDigits(int n)
        {

            //var last_digit = n % 10;
            int sum = 0;
            while (n != 0)
            {
                var last_digit = n % 10;
                sum += last_digit;
                n = (n - last_digit) / 10;

            }

            return sum;
        }


        // Q1. Sum of Digits!
        // solved with while - 1 min
        // solved with recursion - check solution and ask
        // Solution complexity:
        //  10^(d-1) <= n < 10^d , d - digits of n
        //  d-1 <= log(n) < d
        //  d <= log(n) + 1
        // lower bound log(n); upper bound log(n) + 1
        // => time complexity O(log(n))
        //    space complexity O(log(n)) - recursion
        public int SumOfDigits(int n)
        {
            if (n <= 9)
                return n;

            return n % 10 + SumOfDigits(n / 10);
        }

        // Q2. Is magic?
        // Solution time 5 min
        // Complexity:
        // Time and space: O(log(n))
        public bool IsMagic(int n)
        {
            // preview problem return sum of digits for a given number;
            int sum = SumOfDigits(n);
            
            while (sum >= 10) // Remark: correct code by unit testing. Initially, the while condition was missing
                sum = sum % 10 + SumOfDigits(sum / 10);

            return sum == 1;
        }
        
        // Q3. Implement Power Function - pow(A, B) % C
        // Solution time 15 min - I looked for the idea
        // Time amd Space complexity - O(log(k))
        public int CalculateExpressionRec(int a, int b, int c)
        {
            if (a < 0)
                a = (-1) * a;

            if (b == 0)
                return 1 % c;

            // review the class negative power edge case
            if (b < 0)
                return 1 / CalculateExpressionRec(a, 0 - b, c); // this is always 0 ?
            // a^b = a^(b/2) * a^(b/2) - will work only for even power
            if (b % 2 == 0)
            {
                var x = CalculateExpressionRec(a, b / 2, c);
                return (x * x) % c;
            }
            else
            {
                var x = CalculateExpressionRec(a, b / 2, c);
                return (a * x * x) % c;
            }
        }

        // TODO: 4) Tower of hanoi - I understand the problem. Not sure about the implementation. 
        // TODO: 5) Gray Code - I need clarification to understand the ask


        /*
         * --------------
         * || Homework ||
         * --------------
         */

        // Q1. Find Fibonacci - II
        // Solution time 5 min
        // Complexity:
        // Time - O(2^n) 
        // 2^1 + 2^2 + 2^3 + ... + 2^(n-1) = 2^n - 1
        public int SetNthFibonacciNumber(int n)
        {
            if (n == 0)
                return 0;

            if (n == 1)
                return 1;

            return SetNthFibonacciNumber(n - 1) + SetNthFibonacciNumber(n - 2);
        }

        // Q2. Find Factorial!
        // Solution time 5 min
        // Time O(n)
        public int FindFactorial(int n)
        {
            //added after assignment sent
            if (n == 0)
                return 0;

            if (n == 1)
                return 1;

            return n * FindFactorial(n - 1);
        }

        // Q3. Print reverse string
        // Solution time 5 min
        // Complexity
        // time & space - O(n), n = length of given string
        public string ReverseString(string s)
        {
            if (s == string.Empty)
                return string.Empty;

            return s.Substring(s.Length - 1, 1) + ReverseString(s.Substring(0, (s.Length - 1)));
        }


        // Q4. Another sequence problem - f(A) = f(A-1) + f(A-2) + f(A-3) + A
        // Solution time 5 min
        // Complexity
        // Time & Space 3^a
        public int SetAthNumber(int a)
        {
            if (a == 0)
                return 1;

            if (a == 1)
                return 1;

            if (a == 2)
                return 2;

            return SetAthNumber(a - 1) + SetAthNumber(a - 2) + SetAthNumber(a - 3) + a;
        }

        // Kth Symbol
        //        0			=> a = 1 => 2^(1 - 1) el => 2^0 = 1
        //    0       1		=> a = 2 => 2^(2 - 1) el => 2^1 = 2
        // 0    1   1   0	=> a = 3 => 2^(3 - 1) el => 2^2 = 4
        // 0 1 1 0 1 0 0 1	=> a = 4 => 2^(4 - 1) el => 2^3 = 8
        // ...
        //                  => a = n => 2^(n-1) el => 2^(n -1)
        // Time Complexity - O(a * m), where m = 2^(a-1) -> 2^a
        //                  => O(a * 2^a)
        // Space complexity => O(a * 2^a) string immutable
        public int GetKthValue(int a, int b)
        {
            string myValues = "0";
            for (var i = 0; i < a; i++)
            {
                var newStringValues = string.Empty;
                for (var j = 0; j < myValues.Length; j++)
                {
                    if (int.Parse(myValues[j].ToString()) == 0)
                        newStringValues += "01";
                    else
                        newStringValues += "10";
                }
                myValues = newStringValues;
            }

            if (b == 0)
                return 0;

            return int.Parse(myValues[b - 1].ToString());
        }
    }
}

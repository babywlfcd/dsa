namespace Practice.Course.Assignments
{
    public class RecursionBasics
    {
        /*
         * --------------
         * || Homework ||
         * --------------
         */

        // Q1. Find Fibonacci - II
        // Solution time 5 min
        // Complexity:
        // Time => O(2^n) 
        // S.C. => O(n)
        // 2^1 + 2^2 + 2^3 + ... + 2^(n-1) = 2^n - 1
        public int NthFibonacciNumberRecursive(int n)
        {
            if (n == 0)
                return 0;

            if (n == 1)
                return 1;

            return NthFibonacciNumberRecursive(n - 1) + NthFibonacciNumberRecursive(n - 2);
        }

        /// <summary>
        /// Q2. Find Factorial!
        /// Solution time 5 min
        /// </summary>
        /// T.C => O(n)
        /// S.C => O(n)
        /// <param name="n"></param>
        /// <returns></returns>
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

            return s.Substring(s.Length - 1, 1) + ReverseString(s.Substring(0, s.Length - 1));
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

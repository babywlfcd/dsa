using System.Threading.Tasks.Sources;

namespace Practice.Course.Class
{
    public class Week1RecursionBasics
    {
        /// <summary>
        /// Calculate multiplication of a 2 integers using only +, - operators
        /// T.C -> O(n)
        /// S.C -> O(n)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public long Multiply(int a, int n)
        {
            if (n == 0) return 0;

            if (n < 0)
                return 0 - Multiply(a, 0 - n);

            return a + Multiply(a, n - 1);
        }

        /// <summary>
        /// Calculate expression pow(n, k) % d
        /// Math formula:
        ///     (a * b) % d = ((a % d) * (b % d)) % d
        /// Sol 1.
        ///     recursion formula (n^k) % d = n * (n^k) % d;
        ///     T.C -> O(k)
        ///     S.C -> O(k)
        /// Sol 2:  based on the math formula n ^ k = n ^ (k/2) * n ^ (k / 2)
        ///         number of iteration can be reduced looping with step d / 2
        ///         However the condition above is valid only for even numbers
        ///         so we need to take special attention for odd numbers and the formula is
        ///         n ^ k = N * (n ^ (k/2) * n ^ (k / 2))
        ///     T.C -> O(log k)
        ///     S.C -> O(log k)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public int CalculateExpression(int n, int k, int d)
        {
            // edge cases
            if (d == 0)
                throw new DivideByZeroException("d cannot be zero");

            if (n < 0)
                n = (-1) * n;

            if (k == 0)
                return 1 % d;

            // k < 0: pow(n, -k) = 1 / pow(n, k)
            if (k < 0)
                return 1 / CalculateExpression(n, 0 - k, d);

            // pow(n, k) = n * pow(n, k - 1)
            // n ^ k = n ^ (k/2) * n ^ (k / 2) - valid for odd numbers
            var x = CalculateExpression(n, k / 2, d);

            if (k % 2 == 0)
                return (x * x) % d;

            return (n * x * x) % d;
        }

        /// <summary>
        /// Check if the string is a Palindrome
        /// T.C -> O(n)
        /// S.C -> O(n)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public bool IsPalindrome(string s, int start, int end)
        {
            if (s.Length <= 1)
                return true;

            var left = s[0];
            var right = s[^1];

            if (left >= right)
                return true;

            if (left != right) return false;

            return IsPalindrome(s, start + 1, end - 1);
        }

        /// <summary>
        /// Calculate square root of a natural number
        /// T.C -> O(sqrt(n))
        /// S.C -&gt; O(sqrt(n))
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int Sqrt(int n, int k)
        {
            var temp = k * k;
            if (temp == n)
                return k;

            if (temp > n)
                return k - 1;

            return Sqrt(n, k + 1);
        }
    }
}

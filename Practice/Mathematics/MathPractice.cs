namespace Practice.Mathematics
{
    public class MathPractice
    {
        /// <summary>
        /// 509. Fibonacci Number
        /// Recursive approach can be founded in Recursive Practice
        /// https://leetcode.com/problems/fibonacci-number/
        /// T.C => O(n)
        /// S.C => O(1)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int NthFibonacciNumber(int n)
        {
            if (n == 0)
                return 0;

            if (n == 1)
                return 1;

            var count = 2;
            var a = 0;
            var b = 1;
            var next = 0;


            while (count <= n)
            {
                count++;
                next = a + b;
                a = b;
                b = next;
            }

            return next;
        }
    }
}

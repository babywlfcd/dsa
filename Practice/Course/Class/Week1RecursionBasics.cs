namespace Practice.Course.Class
{
    public class Week1RecursionBasics
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
    }
}

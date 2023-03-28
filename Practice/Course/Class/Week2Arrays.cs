using System.Reflection.Metadata.Ecma335;

namespace Practice.Course.Class
{
    public class Week2Arrays
    {
        public int[][] SumTwoMatrices(int[][] matrix1, int[][] matrix2)
        {
            var rows = matrix1.Length;
            var cols = matrix1[0].Length;
            var rows2 = matrix2.Length;
            var cols2 = matrix2[0].Length;

            if (rows != rows2 || cols != cols2)
                return Array.Empty<int[]>();

            var result = new int[rows][];

            for (var i = 0; i < rows; i++)
            {
                result[i] = new int[cols];
                for (var j = 0; j < cols; j++)
                    result[i][j] = matrix1[i][j] + matrix2[i][j];
            }

            return result;
        }

        public int[] PrimeNumbers(int n)
        {
            var primeNumbers = new int[] { };
            for (var i = 0; i <= n; i++)
            {
                var isPrime = true;
                for (var j = 0; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if(isPrime)
                    primeNumbers[i] = i;
            }

            return primeNumbers;
        }

        /// <summary>
        /// Reverse an array
        /// T.C -> O(n)
        /// S.C -> O(1)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int[] ReverseAnArray(int[] input)
        {
            var left = 0;
            var right = input.Length - 1;
            while (left < right)
            {
                var temp = input[left];
                input[left] = input[right];
                input[right] = temp;
                left++;
                right--;
            }

            return input;
        }

        /// <summary>
        /// Rain Water Trapping
        /// Store left anf right max value for each current value in a array
        /// and apply min(maxLeft, maxRight) - current values
        /// T.C -> O(n)
        /// S.C -> O(n)
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int TrapRainWater(int[] height)
        {
            var length = height.Length - 1;
            var maxLeft = new int[height.Length];
            maxLeft[0] = 0;
            var maxRight = new int[height.Length];
            maxRight[length] = 0;
            var result = new int[height.Length];
            var totalWater = 0;

            if (height.Length < 3)
                return 0;

            for (var i = 0; i < height.Length - 1; i++)
            {
                if (height[i] > maxLeft[i])
                    maxLeft[i + 1] = height[i];
                else
                    maxLeft[i + 1] = maxLeft[i];

                if (height[length - i] > maxRight[length - i])
                    maxRight[length - i - 1] = height[length - i];
                else
                    maxRight[length - i - 1] = maxRight[length - i];
            }

            for (var i = 0; i < height.Length; i++)
            {
                var minHeight = Math.Min(maxLeft[i], maxRight[i]);
                result[i] = minHeight - height[i];
            }

            foreach (var item in result)
            {
                if (item > 0)
                    totalWater += item;
            }

            return totalWater;
        }
    }
}

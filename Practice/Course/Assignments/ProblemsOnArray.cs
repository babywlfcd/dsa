using System.Text;

namespace Practice.Course.Assignments
{
    public class ProblemsOnArray
    {
        /*
         * --------------
         * || Assignment we 2 - Arrays ||
         * --------------
         */

        /// <summary>
        /// Q1. Rotation game
        /// Solution 1 - brute force - release always the first position of the array:
        ///     1. keep last element in a variable
        ///     2. move all elements to the right
        ///     3. move it to the first position
        /// T.C -> b times O(n) -> O(n*b)
        /// S.C -> O(1)
        /// </summary>
        /// <param name="input"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int[] RotateBTimesBruteForce(int[] input, int b)
        {
            if (input.Length == 1)
                return input;

            // for case b > n after b numbers of iteration array will be in the same state
            // so is not need to rotate b times, only the number of times remained after complete rotations
            // Example: [1,2,3], b = 8, n = 3
            // b = 1 => [3, 1, 2]
            // b = 2 => [2, 3, 1]
            // b = 3 => [1, 2, 3] - complete rotation => b = 4 same as b = 1, etc
            // b = b % n => 8 % 3 => 2 => result is [2, 3, 1]
            b = b % input.Length;

            while (b > 0)
            {
                var move = input[^1];

                for (var i = input.Length - 1; i > 0; i--)
                {
                    input[i] = input[i - 1];
                }

                input[0] = move;

                b--;
            }

            return input;
        }

        /// <summary>
        /// Q1. Rotation game
        /// Solution 2: rotate in place
        ///     1. rotate the array
        ///     2. rotate first k elements
        ///     3. rotate last elements back
        /// Example:[1 2 3 4 5] -> b = 3 --> [3 4 5 1 2]
        ///     1. reverse [5 4 3 2 1]
        ///     2. revers b elem back [5 4 3] -> 3 4 5
        ///     3. revers input.length - b back [2 1] -> [1 2]
        /// T.C -> O(n)
        /// S.C -> O(1)
        /// </summary>
        /// <param name="input"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int[] RotateBTimes(int[] input, int b)
        {
            if (input.Length == 1)
                return input;

            // array will be in the same position when n = k (n length of tha input array, k number of rotations)
            // -> k = k % n
            // Example: [ 1 2 3 ] k = 4, n = 3
            //  rotation 1 -> [ 2 3 1]
            //  rotation 2 ->[ 3 1 2 ] 
            //  rotation 3 ->[ 1 2 3 ]
            //  rotation 4 -> similar with rotation 1
            //  -> 4 -> 4 % 3 = 1 -> [2 3 1]
            b = b % input.Length;

            int temp;

            // [1,2,3,4,5] 3 -> 3:5 = 0 r 3 
            // [5,4,3,2,1]
            for (var i = 0; i < input.Length / 2; i++)
            {
                temp = input[i];
                input[i] = input[input.Length - 1 - i];
                input[input.Length - 1 - i] = temp;
            }

            // [5,4,3,2,1] - [3 4 5 2 1]
            // [5,4,3] -> [3 4 5]
            for (var i = 0; i < b / 2; i++)
            {
                temp = input[i];
                input[i] = input[b - 1 - i];
                input[b - 1 - i] = temp;
            }

            // [3 4 5 2 1] -> [3 4 5 1 2]
            // [2 1] -> [1 2]
            for (var i = b; i < (input.Length + b) / 2; i++)
            {
                temp = input[i];
                input[i] = input[input.Length + b - 1 - i];
                input[input.Length + b - 1 - i] = temp;
            }

            return input;
        }

        /// <summary>
        /// Q2. GoodPair
        /// Solution 1:
        ///     Brute force - check the condition for each pair of numbers
        /// T.C -> O(n^2)
        /// S.C -> O(1)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int CheckGoodPairBruteForce(int[] input, int b)
        {
            for (var i = 0; i < input.Length; i++)
            {
                for (var j = 0; j < input.Length; j++)
                {
                    if (i != j && input[i] + input[j] == b)
                    {
                        return 1;
                    }
                }
            }

            return 0;
        }

        /// <summary>
        /// Q2. GoodPair
        /// Solution 2:
        /// Improve time complexity with an extra space.
        /// TODO - implement later on hashing
        /// T.C ->
        /// S.C ->
        /// </summary>
        /// <param name="input"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int CheckGoodPair(int[] input, int b)
        {
            return 0;
        }

        /// <summary>
        /// Q3. Max and min of an array
        /// Solution:
        ///     Iterate once over the array and fins min and max
        /// T.C -> O(n)
        /// S.C -> O(1)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string FindMaxAndMin(int[] input)
        {
            
            if (input.Length < 2)
                return string.Join(" ", input);

            var result = new int[2];
            var min = int.MaxValue;
            var max = int.MinValue;
            foreach (var item in input)
            {
                if (item < min)
                    min = item;
                else
                    max = item;
            }

            result[0] = max;
            result[1] = min;

            return string.Join(" ", result);
        }

        //Q4 reverse an array - Implemented in Week2Array
        /// <summary>
        /// Q4. Reverse an array
        /// Solution:
        /// 2 pointers approach
        ///     1. start with one pointer at the beginning of the array and one at the end of the array
        ///     2. swap elements and advance with left pointer to the right and right pointer to the left
        ///     3. loops ends when left >= right     
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
        /// Q5. Search Element
        /// T.C -> O(m*n) where m = target, n = number of scenarios
        /// S.C -> O(1)
        /// </summary>
        /// <param name="input"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public List<int> CheckIfBExistInEachScenario(List<List<int>> input, int target)
        {
            var caseNo = 0;
            var result = new List<int>();
            
            while (caseNo < input.Count)
            {
                var hasTarget = false;

                if (input[caseNo].Count != 0)
                {
                    for (var i = 0; i < input[caseNo].Count; i++)
                    {
                        if (input[caseNo][i] == target)
                        {
                            hasTarget = true;
                            result.Add(1);
                            break;
                        }
                    }
                }


                if(!hasTarget) result.Add(0);
                
                caseNo++;
            }

            return result;
        }

        /*
         * --------------
         * || Homework ||
         * --------------
         */

        /// <summary>
        /// Q1. Little Pony and Maximum Element
        /// Solution - Iterate over array and count numbers grater than b
        /// T.C => O(n)
        /// S.C => O(1)
        /// </summary>
        /// <param name="input"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int CalculateMinNumberForMaxB(int[] input, int b)
        {
            var count = 0;
            var existB = false;
            for (var i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == b)
                    existB = true;
                if (input[i] > b)
                    count++;
            }

            if (!existB)
                return -1;

            return count;
        }

        /// <summary>
        /// Q2. Second Largest
        /// Solution:
        ///     1. traverse array twice.
        ///     2. max variable keep the max value
        ///     3. second variable will keep the second value
        /// T.C => O(n)
        /// S.C +> O(1)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int GetSecondLargestValue(int[] input)
        {
            //
            if (input.Length == 0)
                return -1;

            var max = int.MinValue;
            var secondMax = int.MinValue;
            
            // find first max
            for (var i = 0; i < input.Length; i++)
            {
                if(max < input[i])
                    max = input[i];
            }

            for (int i = 0; i < input.Length; i++)
            {
                //ignore the max value of the array
                if (input[i] == max)
                    continue;

                if(secondMax < input[i])
                    secondMax = input[i];
            }

            if (secondMax == int.MinValue)
                return -1;

            return secondMax;
        }

        /// <summary>
        /// Q3. MINIMUM PICKS
        /// Solution:
        ///     Traverse the array and track maximum value for even and minimum value for odds
        /// T.C -> O(n)
        /// S.C -> O(1)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int MinimumPicks(int[] input)
        {
            var max = int.MinValue;
            var min = int.MaxValue;

            for(var i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0 && max < input[i])
                    max = input[i];

                if (input[i] % 2 != 0 && min > input[i])
                    min = input[i];
            }

            return max - min;

        }

        /// <summary>
        /// Q4. Separate Odd Even
        /// Solution:
        /// 2 pointer approach
        ///     1. start oddIndex from the first element and evenIndex from the second
        ///     2. the odd advance for odd numbers
        ///     3. the evenIndex advance for event numbers
        ///     4. swap elements to have odd numbers to the left and even numbers to the right
        /// T.C -> O(n * m) where n = numbers of scenarios, m = sum of the arrays length in each scenario
        /// S.C -> O(m) where m = sum of the arrays length in each scenario
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string SeparateOddEven(List<List<int>> input)
        {
            var sbResult = new StringBuilder();
            for (var i = 0; i < input.Count; i++)
            {
                var oddIndex = 0;
                var evenIndex = oddIndex + 1;
                while (oddIndex < input[i].Count - 2 || evenIndex < input[i].Count - 1)
                {
                    if (input[i][oddIndex] % 2 != 0)
                    {
                        oddIndex++;
                        continue;
                    }
                    if (input[i][evenIndex] % 2 == 0)
                    {
                        evenIndex++;
                        continue;
                    }

                    var temp = input[i][oddIndex];
                    input[i][oddIndex] = input[i][evenIndex];
                    input[i][evenIndex] = temp;
                    oddIndex++;
                    evenIndex++;
                }
            }

            for (var i = 0; i < input.Count; i++)
            {
                var sbEven = new StringBuilder();
                var sbOdd = new StringBuilder();
                for (var j = 0; j < input[i].Count; j++)
                {
                    if (input[i][j] % 2 != 0)
                    {
                        sbOdd.Append(input[i][j]);
                        sbOdd.Append(" ");
                    }

                    if (input[i][j] % 2 == 0)
                    {
                        sbEven.Append(input[i][j]);
                        sbEven.Append(" ");
                    }
                }

                sbResult.AppendLine(sbOdd.ToString());
                sbResult.AppendLine(sbEven.ToString());
            }

            return sbResult.ToString();
        }


        /// <summary>
        /// Q5. Multiple left rotations of the array
        /// Solution:
        ///     1. Create an result array of the size of the input
        ///     2. Traverse the array and populate the result as follow
        ///         - last k elements with first k elements of the array
        ///         - first n - k elements with last n - k elements of the  array
        /// Example of 1 scenario:
        ///     [1, 2, 3, 4, 5] n = 5; k = 2
        ///     result -> [0 0 0 0 0]
        ///     first iteration -> [0 0 0 1 2]
        ///     second iteration -> [3 4 5 1 2]
        /// T.C -> O(n * m) where n - length of the rotations array, m - length of the input array
        /// S.C -> O(m) where m - length of the input array
        /// </summary>
        /// <param name="input"></param>
        /// <param name="k"></param>
        /// <param name="rotations"></param>
        /// <returns></returns>
        public List<int[]> Rotate(int[] input, int[] rotations)
        {
            var result = new List<int[]>();
            
            foreach (var val in rotations)
            {
                var response = new int[input.Length];

                // array will be in the same position when n = k (n length of tha input array, k number of rotations)
                // -> k = k % n
                // Example: [ 1 2 3 ] k = 4, n = 3
                //  rotation 1 -> [ 2 3 1]
                //  rotation 2 ->[ 3 1 2 ] 
                //  rotation 3 ->[ 1 2 3 ]
                //  rotation 4 -> similar with rotation 1
                //  -> 4 -> 4 % 3 = 1 -> [2 3 1]
                var k = val;
                k = k % input.Length;

                for (var i = 0; i < k; i++)
                {
                    response[i + input.Length - k] = input[i];
                }

                for (var i = k; i < input.Length; i++)
                {
                    response[i - k] = input[i];
                }

                result.Add(response);
            }

            return result;
        }

        /// <summary>
        /// Q6. Leaders in an array
        /// Solution:
        ///     1. Traverse the array from the end 
        ///     2. Keep tracking the max value
        ///     3. compare current value with maximum
        ///     4. if value is greater than max advance to the next element 
        ///     5. else add element to the result and update max
        /// T.C -> O(n)
        /// S.C -> O(n)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<int> FindLeaders(int[] input)
        {
            var max = int.MinValue;
            var result = new List<int>();
            for (var i = input.Length - 1 ; i >= 0; i--)
            {
                if (input[i] < max)
                    continue;
                result.Add(input[i]);
                max = input[i];
            }

            return result;
        }

        /// <summary>
        /// Q7.Bulbs
        /// Solution1: Brute force
        /// Traverse the array and change all next values of the array to 0 if is one or 1 if is 0
        /// T.C -> O(n)
        /// S.C -> O(1)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int Bubs(int[] input)
        {
            var count = 0;
            for (var i = 0; i < input.Length; i++)
            {
                if (input[i] == 0)
                {
                    for (var j = i; j < input.Length; j++)
                    {
                        if (input[j] == 0)
                            input[j] = 1;
                        else
                            input[j] = 0;
                    }

                    count++;
                }
            }

            return count;
        }
    }
}

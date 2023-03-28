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
        /// 1. keep last element in a variable
        /// 2. move all elements to the right
        /// 3. move it to the first position
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
        /// Solution 2:
        /// 1. rotate the array
        /// 2. rotate first k elements
        /// 3. rotate last elements back
        /// T.C -> O(n)
        /// S.C -> O(1)
        /// </summary>
        /// <param name="input"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int[] RotateBTimes(int[] input, int b)
        {
            // [1 2 3 4 5] -> b = 3 --> [3 4 5 1 2]
            //1 reverse [5 4 3 2 1]
            //2 revers b elem back [5 4 3]
            //3 revers input.length - b back [2 1] -> [1 2]

            if (input.Length == 1)
                return input;

            //for case b > n after b numbers of iteration array will be in the same state
            //so is not need to rotate b times, only the number of times remained after complete rotations
            //Example: [1,2,3], b = 8, n = 3
            //b = 1 => [3, 1, 2]
            //b = 2 => [2, 3, 1]
            //b = 3 => [1, 2, 3] - complete rotation => b = 4 same as b = 1, etc
            //b = b % n => 8 % 3 => 2 => result is [2, 3, 1]
            b = b % input.Length;

            int temp;

            // [1,2,3,4,5] 3 -> 3:5 = 0 r 3 
            //[5,4,3,2,1]
            for (var i = 0; i < input.Length / 2; i++)
            {
                temp = input[i];
                input[i] = input[input.Length - 1 - i];
                input[input.Length - 1 - i] = temp;
            }

            //[5,4,3,2,1] - [3 4 5 2 1]
            //[5,4,3] -> [3 4 5]
            for (var i = 0; i < b / 2; i++)
            {
                temp = input[i];
                input[i] = input[b - 1 - i];
                input[b - 1 - i] = temp;
            }

            //[3 4 5 2 1] -> [3 4 5 1 2]
            //[2 1] -> 1 2]
            for (var i = b; i < (input.Length + b) / 2; i++)
            {
                temp = input[i];
                input[i] = input[input.Length + b - 1 - i];
                input[input.Length + b - 1 - i] = temp;
            }

            return input;
        }

        /// <summary>
        /// Q2. GoodPair -
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
        /// T.C -> O(n)
        /// S.C -> O(1)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int[] FindMaxAndMin(int[] input)
        {
            
            if (input.Length < 2)
                return input;

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

            return result;
        }

        //Q4 reverse an array - Implemented in Week2Array

        /// <summary>
        /// Q5. Search Element
        /// T.C -> O(m*n) where m = target, n = number of scenarios
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
    }
}

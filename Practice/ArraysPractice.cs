namespace Practice
{
    public class ArraysPractice
    {
        /// <summary>
        /// Easy
        /// Merge 2 ordered arrays - general implementation
        /// 2 pointers approach
        ///  - left index starts from first element of the first array
        ///  - right index stats from the firs element of the second array
        /// Add the min value between the two items and advance the index in the array where the value was added to the result
        /// T.C => O(n + m)
        /// S.C => O(n + m)
        /// </summary>
        /// <param name="leftArr"></param>
        /// <param name="rightArr"></param>
        /// <returns></returns>
        public int[] MergeTwoOrderedArrays(int[] leftArr, int[] rightArr)
        {
            var result = new int[leftArr.Length + rightArr.Length];
            var currentIndex = 0;
            var leftArrIndex = 0;
            var rightArrIndex = 0;

            while (leftArrIndex < leftArr.Length && rightArrIndex < rightArr.Length)
            {
                if (leftArr[leftArrIndex] <= rightArr[rightArrIndex])
                {
                    result[currentIndex] = leftArr[leftArrIndex];
                    leftArrIndex++;
                }
                else
                {
                    result[currentIndex] = rightArr[rightArrIndex];
                    rightArrIndex++;
                }

                currentIndex++;
            }

            while (leftArrIndex < leftArr.Length)
            {
                result[currentIndex] = leftArr[leftArrIndex];
                leftArrIndex++;
                currentIndex++;
            }

            while (rightArrIndex < rightArr.LongLength)
            {
                result[currentIndex] = rightArr[rightArrIndex];
                rightArrIndex++;
                currentIndex++;
            }

            return result;
        }

        /// <summary>
        /// Easy 
        /// 88. Merge Sorted Array 
        /// https://leetcode.com/problems/merge-sorted-array/
        /// 2 pointers approach
        /// Values are ascending ordered so if the values in the result is added from the end the original values will not be available.
        /// Otherwise we need to keep the ols values to position them later 
        ///     - first pointer starts on the last element from the first array -> m - 1
        ///     - second pointer starts on the last element of the second input -> n - 1 
        /// edge cases
        ///     1. second array is empty
        ///     2. first array contain n elements - all zero
        /// </summary>
        /// <param name="input1"></param>
        /// <param name="m"></param>
        /// <param name="input2"></param>
        /// <param name="n"></param>
        public void Merge(int[] input1, int m, int[] input2, int n)
        {
            int i = m - 1, j = n - 1, index = m + n - 1;

            if (input2.Length == 0)
                return;

            if (input1.Length == input2.Length)
            {
                while (index >= 0 && input1[index] == 0)
                {
                    input1[index] = input2[index];
                    index--;
                }

                return;
            }

            while (index >= 0 && input1[index] == 0)
            {
                if (input1[i] > input2[j])
                {
                    input1[index] = input1[i];
                    input1[i] = 0;
                    if (i > 0)
                        i--;
                }
                else
                {
                    input1[index] = input2[j];
                    input2[j] = 0;
                    if (j > 0)
                        j--;
                }

                index--;
            }

            var x = 0;
            while (input2[x] != 0)
            {
                input1[x] = input2[x];
                x++;
            }
        }

        /// <summary>
        /// Medium
        /// 11. Container With Most Water
        /// https://leetcode.com/problems/container-with-most-water/
        /// Math basic formula Rectangle area = l * L = height * width = length * breadth 
        /// 2 pointers approach
        ///     - left pointer starts from the beginning of the array
        ///     - right pointer starts from the end of the array
        /// Get the mon value between left and right and apply formula for area
        /// Length = min(left, right; Breadth = distance(left, right)
        /// area = min(left, right) * distance(left, right)
        /// Keep tracking max Area and advance the index left or right based on min val used.
        /// if min value is left advance left, otherwise right
        /// T.C -> O(n)
        /// S.C -> O(1)
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int MaxArea(int[] height)
        {
            var maxArea = 0;
            var left = 0;
            var right = height.Length - 1;

            // edge cases
            if (height.Length < 2)
                return 0;

            var area = 0;
            while (left <= right)
            {
                if (height[left] <= height[right])
                {
                    area = height[left] * (right - left);
                    left++;
                }
                else
                {
                    area = height[right] * (right - left);
                    right--;
                }

                if (maxArea < area)
                    maxArea = area;
            }

            return maxArea;
        }

        #region water problems
        /// <summary>
        /// Hard
        /// 42. Trapping Rain Water - brute force solution
        /// T.C -> O(n^2)
        /// S.C -> O(1)
        /// TODO
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int Trap(int[] height)
        {
            return 0;
        }

        /// <summary>
        /// 42. Trapping Rain Water
        /// https://leetcode.com/problems/trapping-rain-water/
        /// Store left anf right max value for each current value in a array
        /// and apply min(maxLeft, maxRight) - current values
        /// T.C -> O(n)
        /// S.C -> O(n)
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int TrapOptimizeTime(int[] height)
        {
            var length = height.Length -1;
            var maxLeft = new int[height.Length];
            maxLeft[0] = 0;
            var maxRight = new int[height.Length];
            maxRight[length] = 0;
            var result = new int[height.Length];
            var totalWater = 0;

            for (var i = 0; i < height.Length - 1; i++)
            {
                if (height[i] > maxLeft[i])
                    maxLeft[i + 1] = height[i];
                else
                    maxLeft[i + 1]  = maxLeft[i];

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

            for (var i = 0; i < result.Length; i++)
            {
                if (result[i] > 0)
                    totalWater += result[i];
            }

            return totalWater;
        }

        #endregion

        /// <summary>
        /// Kth Rotation to left
        /// Solution 2: in place approach - optimal solution for k rotations instead of list of rotations, when additional space is not needed
        ///     1. rotate the array
        ///     2. rotate last k elements back
        ///     3. rotate first n - k back
        /// T.C -> O(n)
        /// S.C -> O(1)
        /// </summary>
        /// <param name="input"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int[] Rotate(int[] input, int k)
        {
            // array will be in the same position when n = k (n length of tha input array, k number of rotations)
            // -> k = k % n
            // Example: [ 1 2 3 ] k = 4, n = 3
            //  rotation 1 -> [ 2 3 1]
            //  rotation 2 ->[ 3 1 2 ] 
            //  rotation 3 ->[ 1 2 3 ]
            //  rotation 4 -> similar with rotation 1
            //  -> 4 -> 4 % 3 = 1 -> [2 3 1]
            k %= input.Length;

            // moving to the left:
            // start index = input.Length - k: end index = input.Length + (input.Length - k)
            Reverse(input, 0, input.Length);
            Reverse(input, 0, input.Length - k);
            Reverse(input, input.Length - k, input.Length + (input.Length - k));

            return input;
        }
        private void Reverse(int[] input, int indexStart, int indexEnd)
        {
            for (var i = indexStart; i < indexEnd / 2; i++)
            {
                var temp = input[i];
                input[i] = input[indexEnd - 1 - i];
                input[indexEnd - 1 - i] = temp;
            }
        }

        public int LongestSubstring(string s)
        {
            if (s.Length == 0) return 0;
            var count = 1;
            var p = 1;
            var maxChar = int.MinValue;

            for (var i = 2; i < s.Length - 1; i++)
            {
                if (maxChar < count)
                {
                    maxChar = count;
                }

                if (s[i] == s[p])
                {
                    p++;
                    i = p + 1;
                    count = 1;
                    continue;
                }
                if (s[i] != s[p])
                {
                    count++;
                }
            }
            return maxChar;
        }
    }
}
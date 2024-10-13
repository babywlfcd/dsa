namespace Practice.Course.Assignments
{
    public class SearchingAssignment
    {
        /// <summary>
        /// 1. Find Peak Element
        /// Solution:
        ///     1. if first element of the array is greater than second return index 0
        ///     2. If last element of the array is greater than preview one return last index of it
        ///     3. use binary search and check if neighbors are smaller
        ///     4 if not advance to the left if left > mid, otherwise to right
        /// T.C -> O(log(n))
        /// S. C -> O(1)
        /// </summary>
        /// <returns></returns>
        public int FindPickElement(int[] input)
        {
            if (input.Length == 1)
                return 0;

            var start = 1;
            var end = input.Length - 2;

            // check if 0th/n-1th index is the peak element
            if (input[0] > input[1]) return 0;
            if (input[^1] > input[^2]) return input.Length - 1;

            while (start <= end)
            {
                var mid = start + (end - start)/ 2;

                if (input[mid] > input[mid - 1] && input[mid] > input[mid + 1])
                    return mid;

                if (input[mid] <= input[mid - 1])
                    start = mid + 1;
                else
                    end = mid - 1;
            }
            return 0;
        }

        /// <summary>
        /// 2.Find First and Last Position of Element in Sorted Array
        /// T.C -> O(log(n))
        /// S. C -> O(1)
        /// </summary>
        /// <param name="input"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] FindFirstAndLastOccurrence(int[] input, int target)
        {
            var left = 0;
            var right = input.Length - 1;
            var result = new[] { -1, -1 };

            //track first position and search last position from his index
            var middleIndex = -1;

            if (input.Length == 0)
                return result;

            var tempFirstIndex = -1;

            //find start position
            while (left <= right)
            {
                var middle = left + (right - left) / 2;

                if (target == input[middle])
                {
                    tempFirstIndex = middle;
                    right = middle - 1;

                    if (tempFirstIndex == left)
                    {
                        middleIndex = middle;
                        break;
                    }
                }

                if (target > input[middle])
                    left = middle + 1;

                if (target < input[middle])
                    right = middle - 1;
            }

            result[0] = tempFirstIndex;

            if (result[0] == -1)
                return result;

            //find end position
            left = middleIndex;
            right = input.Length - 1;
            var tempLastIndex = -1;

            while (left <= right)
            {
                var middle = left + (right - left) / 2;

                if (target == input[middle])
                {
                    tempLastIndex = middle;
                    left = middle + 1;
                }

                if (target > input[middle])
                    left = middle + 1;

                if (target < input[middle])
                    right = middle - 1;
            }

            result[1] = tempLastIndex;

            return result;
        }

        /// <summary>
        /// 3. Search in Rotated Sorted Array
        /// T.C -> O(log(n))
        /// S.C -> O(1)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int FindTarget(int[] input, int target)
        {
            var slow = 0;
            var fast = input.Length - 1;
            const int result = -1;
            while (slow <= fast)
            {
                var mid = slow + (fast - slow) / 2;

                if (input[mid] == target)
                    return mid;

                if (input[slow] <= input[mid])
                {
                    //must use "<=" at here since we need to make sure target is in the left part,
                    //then safely drop the right part
                    if (input[slow] <= target && target < input[mid])
                        fast = mid - 1;
                    else
                        slow = mid + 1;
                }

                //if right part is monotonically increasing, or the pivot point is on the left part
                else
                {
                    //must use "<=" at here since we need to make sure target is in the right part,
                    //then safely drop the left part
                    if (input[mid] < target && target <= input[fast])
                        slow = mid + 1;
                    else
                        fast = mid - 1;
                }
            }

            return result;
        }
        /// <summary>
        /// 5. Find Minimum in Rotated Sorted Array
        /// After rotations the pivot is the single element that is less that its neighbor
        /// https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/description/
        /// T.C -> O(log(n))
        /// T.C -> O(1)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int FindMinInSortedRotatedArray(int[] input)
        {
            var left = 0;
            var right = input.Length - 1;

            //validation
            if (input.Length == 1)
                return input[0];

            if (input.Length == 2)
                return Math.Min(input[0], input[1]);

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (input[mid] > input[right])
                    left = mid + 1;

                if (input[mid] < input[right])
                    right = mid;
            }

            return input[left];
        }
    }
}

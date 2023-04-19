namespace Practice
{
    /// <summary>
    /// Sorting algorithms
    /// 1. Bubble Sort
    /// 2. Selection sort
    /// 3. Insertion sort
    /// 4. Merge sort
    /// 5. Quick sort
    /// </summary>
    public class Sorting
    {
        /// <summary>
        /// Compare and swap - 2 consecutive values
        /// B.C => O(n) for array already order
        /// W.C => 1 + 2 + ... + n = n * (n + 1)/2 => O(n^2)
        /// T.C = O(n^2)
        /// S.C => O(1)
        /// swaps is order of n^2
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int[] BubbleSort(int[] input)
        {
            for (var i = 0; i < input.Length; i++)
            {
                var swap = false;
                for (var j = 0; j < input.Length - 1; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        Swap(input, j, j+1);
                        swap = true;
                    }

                    if (swap)
                        break;
                }
            }

            return input;
        }

        /// <summary>
        /// Selection sort => select an element of unsorted list in each iteration and place eit at the beginning
        /// -> check the min value and swap elem at idx of min val with first elem
        /// B.C, W.C, T.C = O(n^2)
        /// number of swaps is n
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int[] SelectionSort(int[] input)
        {
            for (var i = 0; i < input.Length - 1; i++)
            {
                var minValueIndex = i;

                for(var j = i + 1; j < input.Length; j++)
                {
                    if (input[j] < input[minValueIndex])
                        minValueIndex = j;
                }

                Swap(input, i, minValueIndex);
            }

            return input;
        }

        
        /// <summary>
        /// Insertion sort - as playing cards
        /// choose a pivot and shift all values greater than pivot to right
        /// B.C => omega(n)
        /// W.c. => O(n^2)
        /// A.C => O(n^2)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int[] InsertionSort(int[] input)
        {
            for (var i = 0; i < input.Length; i++)
            {
                var pivot = input[i];
                var j = i - 1;

                // condition ends when current value is less than pivot
                while (j >= 0 && input[j] > pivot)
                {
                    input[j + 1] = input[j];
                    j--;
                }

                input[j + 1] = pivot;
            }

            return input;
        }

        /// <summary>
        /// Merge Sort
        /// Divide & concur
        /// Divide each half of the array till 1 array element
        /// Concur - merge two ordered array
        /// Time complexity:
        /// 1. Division n / 2^k => 1 (n elements, k divisions) => 2^k = n => apply log base 2
        ///     => log(2^k) = log(n) => k = log(n)
        /// 2. Merge -> O(n)
        /// T.C => O(n * log(n))
        /// S.C => O(n)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int[] MergeSort(int[] input)
        {
            if (input.Length <= 1)
                return input;

            var middleIndex = input.Length / 2;
            var leftHalf = input.Take(middleIndex).ToArray();
            var rightHalf = input.Skip(middleIndex).ToArray();
            var test = MergeSortedArrays(MergeSort(leftHalf), MergeSort(rightHalf));

            return test;
        }

        /// <summary>
        /// Merge Sort
        /// Divide & concur
        /// Divide each half of the array till 1 array element
        /// Concur - merge two ordered array
        /// O(n * log(n))
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int[] MergeSort2(int[] input)
        {
            if (input.Length <= 1)
                return input;

            var middleIndex = input.Length / 2;
            var leftHalf = MergeSort(input[..^middleIndex]);
            var rightHalf = MergeSort(input[(middleIndex+1)..input.Length]);
            var result = MergeSortedArrays(MergeSort(leftHalf), MergeSort(rightHalf));

            return result;
        }

        private int[] MergeSortedArrays(int[] leftArr, int[] rightArr)
        {
            var sortedArray = new int[rightArr.Length + leftArr.Length];
            var currentIndex = 0; //control elements for the result
            var leftIndex = 0; // control elements from the left array to fill the  result
            var rightIndex = 0; // control elements from the right array to fill the  result

            while (leftIndex < leftArr.Length && rightIndex < rightArr.Length)
            {
                
                if (leftArr[leftIndex] <= rightArr[rightIndex])
                {
                    sortedArray[currentIndex] = leftArr[leftIndex];
                    leftIndex++;
                    
                }
                else
                {
                    sortedArray[currentIndex] = rightArr[rightIndex];
                    rightIndex++;
                }

                currentIndex++;
            }

            // add elements from left array if any
            while (leftIndex < leftArr.Length)
            {
                sortedArray[currentIndex] = leftArr[leftIndex];
                leftIndex++;
                currentIndex++;
            }

            //add elements from the right array if any
            while (rightIndex < rightArr.Length)
            {
                sortedArray[currentIndex] = rightArr[rightIndex];
                rightIndex++;
                currentIndex++;
            }

            return sortedArray;
        }

        /// <summary>
        /// Quick sort - pick up a pivot and and place it in the right position by moving:
        ///     1. less than pivot to the left
        ///     2. greater than pivot to the right
        /// Repeat recursively till left >= right
        /// B.C, A.C => O(n * log(n)) => T.C => O(n * log(n)
        /// W.C (n^2) - when array is in descending order and pivot is always the last element witch is the min value of the array
        /// S.C => O(n * log(n). If we ignore the stack from recursion S.C => O(1)??
        /// </summary>
        /// <param name="input"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public int[] QuickSort(int[] input, int start, int end)
        {
            if (start >= end)
                return input;
            
            var index = Partition(input, start, end);
            QuickSort(input, start, index - 1);
            QuickSort(input, index + 1, end);

            return input;
        }

        private int Partition(int[] input, int low, int high)
        {
            var pivot = input[high];
            var i = low - 1;
            for (var j = low; j < high; j++)
            {
                if (input[j] < pivot)
                    i++;
                else
                    continue;

                var temp = input[i];
                input[i] = input[j];
                input[j] = temp;
            }

            var temp2 = input[i + 1];
            input[i + 1] = input[high];
            input[high] = temp2;

            return i + 1;
        }

        private void Swap(int[] input, int idx1, int idx2)
        {
            if (input[idx1] > input[idx2])
            {
                (input[idx1], input[idx2]) = (input[idx2], input[idx1]);
            }
        }
    }
}

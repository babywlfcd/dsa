﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

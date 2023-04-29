using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Course.Assignments
{
    public class HashingAssignment
    {
        /// <summary>
        /// 1. Common Elements
        /// T.C -> O(n)
        /// S.C -> O(n)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int[] GetIntersection(int[] a, int[] b)
        {
            if (a.Length == 0 || b.Length == 0)
                return new int[] { };

            var result = new List<int>();
            var valueFrequency = new Dictionary<int, int>();

            for (int i = 0; i < a.Length; i++)
            {
                if (valueFrequency.ContainsKey(a[i]))
                    valueFrequency[a[i]] += 1;
                else
                    valueFrequency[a[i]] = 1;
            }

            for (int i = 0; i < b.Length; i++)
            {
                if (valueFrequency.ContainsKey(b[i]) && valueFrequency[b[i]] > 0)
                {
                    result.Add(b[i]);
                    valueFrequency[b[i]] -= 1;
                }
            }

            return result.ToArray();
        }

        /// <summary>
        /// 2. First Repeating Element
        /// T.C -> O(n)
        /// S.C -> O(n)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int FindFirstRepeatingElement(int[] input)
        {
            // key -> value from the array at index i
            // value -> index
            var elementFrequency = new Dictionary<int, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!elementFrequency.ContainsKey(input[i]))
                    elementFrequency[input[i]] = i;
                else
                    return input[i];

            }
            return -1;
        }
    }
}

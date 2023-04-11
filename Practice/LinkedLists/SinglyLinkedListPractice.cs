using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.LinkedLists
{
    public class SinglyLinkedListPractice
    {
        /// <summary>
        /// 8. List Cycle
        /// Solution 1: Extra space
        ///     1. Store node value in hash map
        ///     2. Add nodes to  the map if are not already added
        ///     3. Find the answer if node value is already present in the dictionary
        /// T.C -> O(n)
        /// S.C -> O(n)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public bool HasCycleAdditionalSpace(SinglyNode head)
        {
            if (head == null)
                return false;

            var nodes = new Dictionary<int?, bool>();
            var current = head;

            // traverse whole linked list
            while (current != null)
            {
                if (nodes.ContainsKey(current.Value))
                    return true;

                nodes[current.Value] = false;
                current = current.Next;
            }

            return false;
        }

        /// <summary>
        /// 8. List Cycle
        /// Solution 2: slow / fast pointers
        /// Explanation:
        ///  Slow pointer advance 1 node
        ///  Fast pointer advance 2 nodes
        ///     1. Store node value in hash map
        ///     2. Add nodes to  the map if are not already added
        ///     3. Find the answer if node value is already present in the dictionary 
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public bool HasCycle(SinglyNode head)
        {
            if (head == null) return false;

            var fast = head;
            var slow = head;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                if (slow == fast)
                    return true;
            }

            return false;
        }
    }
}

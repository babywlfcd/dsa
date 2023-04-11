using Practice.LinkedLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Course.Assignments
{
    /// <summary>
    /// Singly node object: https://github.com/babywlfcd/dsa/blob/main/Practice/LinkedLists/SinglyNode.cs
    /// Singly linked list implementation: https://github.com/babywlfcd/dsa/blob/main/Practice/LinkedLists/SinglyLinkedList.cs
    /// </summary>
    public class LinkedListAssignment
    {
        /// <summary>
        /// 3. Find middle of a linked list 
        /// Solution 1:
        ///     1. Traverse the whole linked list and count the no of nodes
        ///     2. Calculate n / 2
        ///     3. Traverse the linked list again from starting to middle node
        /// T.O -> O(n)
        /// S.C -> O(1)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public SinglyNode FindMiddleNode(SinglyNode head)
        {
            var count = 0;
            var current = head;

            while (current != null && current.Next != null)
            {
                count++;
                current = current.Next;
            }

            var mid = count / 2;
            current = head;
            while (mid > 0)
            {

                current = current.Next;
                mid--;
            }

            head = current;
            return head;
        }

        /// <summary>
        /// 3. Find middle of a linked list 
        /// Solution 2: single iteration
        ///     1. two pointers (variables)
        ///         a. start slow, fast from Head
        ///     2. Traverse the linked list slow - 1 node; fast 2 nodes, until fast reach the tail
        ///     3. return slow node
        /// T.O -> O(n)
        /// S.C -> O(1)
        /// </summary>
        /// <param name="linkedList"></param>
        /// <returns></returns>
        public SinglyNode FindMiddleNodeSlowFaster(SinglyNode head)
        {
            var slow = head;
            var fast = head;
            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            return slow;
        }
    }
}

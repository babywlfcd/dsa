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
        // 1. Implement linked list
        // Singly node object: https://github.com/babywlfcd/dsa/blob/main/Practice/LinkedLists/SinglyNode.cs
        // Singly linked list implementation: https://github.com/babywlfcd/dsa/blob/main/Practice/LinkedLists/SinglyLinkedList.cs
        
        /// <summary>
        /// 2.Delete middle node of a Linked List
        /// Solution:
        ///     1. Find the middle of the linked list
        ///     2. Delete middle node
        ///     3. Traverse the linked list and print
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public string DeleteMiddle(SinglyNode head)
        {
            if (head == null)
                return string.Empty;

            //find middle of the node
            var slow = head;
            var fast = head;

            var nodes = 0;
            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
                nodes++;
            }

            var current = head;
            RemoveAtIndex(current, nodes);

            return Print(current);
        }
        private void RemoveAtIndex(SinglyNode head, int index)
        {
            if (head == null || head.Next == null || head.Next.Next == null)
                return;

            var current = head;

            while (index - 1 > 0)
            {
                current = current.Next;
                index--;
            }

            current.Next = current.Next.Next;
        }

        private string Print(SinglyNode head)
        {
            var sb = new StringBuilder();

            if (head == null)
                return string.Empty;

            var current = head;
            while (current != null && current.Next != null)
            {
                sb.Append(current.Value);
                sb.Append("->");
                current = current.Next;
            }

            head = current;
            sb.Append(head.Value);
            return sb.ToString();
        }


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

            var mid = 0;
            if (count % 2 == 0)
                mid = count / 2;
            else
                mid = count / 2 + 1;
            
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
        /// <param name="head"></param>
        /// <returns></returns>
        public SinglyNode FindMiddleNodeSlowFaster(SinglyNode head)
        {

            var slow = head;
            var fast = head.Next;
            var count = 1;
            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
                count++;
            }

            if (count % 2 == 0)
                return slow.Next;

            return slow;
        }


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

            var nodes = new Dictionary<int, bool>();
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

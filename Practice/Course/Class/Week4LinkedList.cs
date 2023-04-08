using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Practice.LinkedLists;

namespace Practice.Course.Class
{
    public class Week4LinkedList
    {
        /// <summary>
        /// Solution 1:
        ///     1. Traverse the whole linked list and count the no of nodes
        ///     2. Calculate n / 2
        ///     3. Traverse the linked list again from starting to middle node
        /// T.O -> O(n)
        /// S.C -> O(1)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public SinglyNode FindMiddleNode(SinglyLinkedList linkedList)
        {
            var count = 0;
            var current = linkedList.Head;

            while (current != null && current.Next != null)
            {
                count++;
                current = current.Next;
            }

            var mid = count / 2;
            current = linkedList.Head;
            while (mid > 0)
            {
                
                current = current.Next;
                mid--;
            }

            linkedList.Head = current;
            return linkedList.Head;
        }

        /// <summary>
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
        public SinglyNode FindMiddleNodeSlowFaster(SinglyLinkedList linkedList)
        {
            var slow = linkedList.Head;
            var fast = linkedList.Head;
            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            return slow;
        }

        /// <summary>
        /// Solution 1: Extra space
        ///     1. Store node value in hash map
        ///     2. Add nodes to  the map if are not already added
        ///     3. Find the answer if node value is already present in the dictionary
        /// T.C -> O(n)
        /// S.C -> O(n)
        /// </summary>
        /// <param name="linkedList"></param>
        /// <returns></returns>
        public bool HasLoopAdditionalSpace(SinglyNode head)
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
        /// Solution 2: slow / fast pointers
        /// Explanation:
        ///  Slow pointer advance 1 node
        ///  Fast pointer advance 2 nodes
        ///     1. Store node value in hash map
        ///     2. Add nodes to  the map if are not already added
        ///     3. Find the answer if node value is already present in the dictionary 
        /// </summary>
        /// <param name="linkedList"></param>
        /// <returns></returns>
        public bool HasLoop(SinglyNode head)
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

        /// <summary>
        /// 206. Reverse Linked List
        /// iterative solution: 3 pointers
        ///     1. prev - null
        ///     2. current - head
        ///     3. next - head.next
        /// T.C -> O(n);
        /// S.C -> O(1)
        /// https://leetcode.com/problems/reverse-linked-list/
        /// </summary>
        /// <param name="linkedList"></param>
        /// <returns></returns>
        public SinglyNode ReverseLinkedList(SinglyNode head)
        {
            SinglyNode previewNode = null;
            var current = head;

            while (current != null)
            {
                var nextNode = current.Next;
                current.Next = previewNode;
                previewNode = current;
                current = nextNode;
            }

            head = previewNode;
            return head;
        }

        /// <summary>
        /// 206. Reverse Linked List
        /// Recursive solution :T O(n); S O(n)
        /// https://leetcode.com/problems/reverse-linked-list/
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public SinglyNode ReverseLinkedListRecursive(SinglyNode head)
        {
            if (head == null)
                return null;

            if (head.Next == null)
                return head;

            var temp = ReverseLinkedListRecursive(head.Next);
            temp.Next = head;
            head.Next = null;
            head = temp;
            return head;
        }

        /// <summary>
        /// Reverse Doubly linked list
        /// Solution - 2 pointers
        ///     1. preview
        ///     2. current
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public DoublyNode ReverseDoublyLinkedList(DoublyNode head)
        {
            DoublyNode preview = null;
            var current = head;

            while (current != null)
            {
                preview = current.Previous;
                current.Previous = current.Next;
                current.Next = preview;
                current = current.Next;
            }

            if (preview != null)
            {
                head = preview.Previous;
            }

            return head;

        }

        //Solution 1 - traverse the linked list once then traverse again till n - k

        /// <summary>
        /// Solution:
        /// Find k - 1: 2 pointers:
        /// 1. p at head
        /// 2. q at k
        /// 3. traverse rest of the linked list until p is at the end
        /// 4. the result is p 
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        public SinglyNode GetNthNodeOfLinkedList(SinglyLinkedList singlyLinkedList,int k)
        {
            var p = singlyLinkedList.Head;
            var q = singlyLinkedList.Head;
            var count = 0;
            while (count < k)
            {
                q = q.Next;
            }

            p = p.Next;
            q = q.Next;
            return p;
        }

        /// <summary>
        /// Solution
        /// </summary>
        /// <param name="doublyLinkedList"></param>
        /// <returns></returns>
        public int[] Pair2Nodes(DoublyLinkedList doublyLinkedList)
        {
            var l = doublyLinkedList.Head;
            var r = doublyLinkedList.Head;

            /*while (r. != null)
            {
                r = r.Next;
            }

            while (l.Next != r)
            {
                var node = l.Value;
            }*/

            return new int[]{};

        }
    }
}

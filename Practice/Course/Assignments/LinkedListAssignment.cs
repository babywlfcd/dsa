﻿using Practice.LinkedLists;
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
        /*
         * QUESTION - I do not get why 11 is a problem included to linked list assignment. PLEASE ADVICE!
         * Problems that I will submit to to the session Problems and Patterns on Linked List:
         * TODO - 11. Flatten Nested List IteratorFlatten Nested List Iterator
         * TODO - 15.Longest Palindromic List
         * TODO - 16. Partition List
         * TODO - 17. LRU Cache
         */
        // 1. Implement linked list
        // Singly node object: https://github.com/babywlfcd/dsa/blob/main/Practice/LinkedLists/SinglyNode.cs
        // Singly linked list implementation: https://github.com/babywlfcd/dsa/blob/main/Practice/LinkedLists/SinglyLinkedList.cs

        /// <summary>
        /// 2.Delete middle node of a Linked List
        /// Solution:
        ///     1. Find the middle of the linked list
        ///     2. Delete middle node
        ///     3. Traverse the linked list and print
        /// T.C -> O(n)
        /// S.C -> O(1)
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
            var fast = head;
            var count = 1;
            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
                count++;
            }

            return slow;
        }

        /// <summary>
        /// 4. Reverse Linked List
        /// iterative solution: 3 pointers
        ///     1. prev - null
        ///     2. current - head
        ///     3. next - head.next
        /// T.C -> O(n);
        /// S.C -> O(1)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public string ReverseLinkedList(SinglyNode head)
        {
            SinglyNode prevNode = null;
            var current = head;

            while (current != null)
            {
                var nextNode = current.Next;
                current.Next = prevNode;
                prevNode = current;
                current = nextNode;
            }

            head = prevNode;

            return Print(head);
        }

        /// <summary>
        /// 5. Remove Nth Node from List End
        /// Solution - 2 pointers -> node and current
        ///     1. start node and current from head
        ///     2. move current till n position -> now distance between node and current is n
        ///     3. move node and current till the end of the linked list
        ///     4. remove node from the list
        /// T.C -> O(n)
        /// S.C -> O(1)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string RemoveNthNodeFromEnd(SinglyNode head, int n)
        {
            if (head == null)
                return null;

            var nodeToRemove = head;
            var current = head;
            var count = n;

            while (count > 0 && current != null)
            {
                current = current.Next;
                count--;
            }

            // if n exceed linked list length do not remove
            if (count != 0)
                return Print(head);

            if (current == null)
                return null;

            while (current != null && current.Next != null)
            {
                nodeToRemove = nodeToRemove.Next;
                current = current.Next;
            }

            nodeToRemove.Next = nodeToRemove.Next.Next;

            return Print(head);
        }

        /// <summary>
        /// 6. Remove Duplicates from Sorted List
        /// Solution:
        ///     1. start first pointer to head and second pointer to next
        ///     2. advance first pointer if values are different
        ///     3. else remove next node
        /// T.C -> O(n)
        /// S.C -> O(1)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public string RemoveDuplicates(SinglyNode head)
        {
            if (head == null)
                return null;

            var keepNode = head;
            var current = head.Next;

            while (current != null)
            {
                if (keepNode.Value != current.Value)
                {
                    keepNode.Next = current;
                    keepNode = current;
                }

                if (current.Next == null)
                {
                    keepNode.Next = null;
                    break;
                }

                current = current.Next;
            }

            return Print(head);
        }

        /// <summary>
        /// 7. K reverse linked list
        /// T.C ->O(k)
        /// S.C ->O(1)
        /// </summary>
        /// <param name="head"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public string ReverseKthNodes(SinglyNode head, int k)
        {
            if (k == 0)
                return Print(head);

            SinglyNode prevNode = null;
            var prevHead = head;
            var nextNodeUnreversed = head;

            var current = head;
            var count = k;
            while (k > 0)
            {
                var nextNode = current.Next;
                nextNodeUnreversed = nextNode;
                current.Next = prevNode;
                prevNode = current;
                current = nextNode;
                k--;
            }

            prevHead.Next = nextNodeUnreversed;

            head = prevNode;

            return Print(head);
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
        /// T.C -> O(n)
        /// S.C -> (1) 
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

        /// <summary>
        /// 9. Remove Loop from Linked List
        /// Solution:
        ///     1. Detect cycle node -> Floyd algorithm to find cycle
        ///     2. Detect second time the node to brake the link to the cycle
        /// T.C -> O(n)
        /// S.C -> O(1)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public string RemoveCycle(SinglyNode head)
        {
            if (head == null)
                return string.Empty;

            var slow = head;
            var fast = head;
            var commonNode = head;

            //detect if the linked list has cycle
            var hasCycle = false;
            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                if (slow == fast)
                {
                    commonNode = slow;
                    hasCycle = true;
                    break;
                }
            }

            if (!hasCycle)
                return Print(head);
            // detect cycle node
            fast = head;
            slow = commonNode;

            while (fast != slow)
            {
                fast = fast.Next;
                slow = slow.Next;
            }

            // detect cycle node again
            SinglyNode lastNodeSlow = slow;
            var nextNode = slow.Next;
            while (lastNodeSlow != nextNode)
            {
                nextNode = nextNode.Next;
                if (lastNodeSlow == nextNode.Next)
                {
                    nextNode.Next = null;
                    break;
                }
            }

            return Print(head);
        }

        /// <summary>
        /// 10. Reorder List
        /// Solution 1
        ///     1. Create an array with nodes value
        ///     2. Change values in the original linked list
        /// T.C -> O(n)
        /// S.C -> O(n)
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public string ReorderLinkedList(SinglyNode head)
        {
            if (head == null) return string.Empty;

            var current = head;
            var count = 0;
            while (current != null)
            {
                count++;
                current = current.Next;
            }

            var nodeValues = new int[count];
            current = head;
            var index = 0;
            while (current != null)
            {
                nodeValues[index++] = current.Value;
                current = current.Next;
            }

            current = head;
            index = 0;
            while (current != null)
            {
                var left = 0;
                var right = nodeValues.Length - 1;
                while (left <= right)
                {
                    current.Value = nodeValues[left];
                    if (current.Next != null)
                    {
                        current.Next.Value = nodeValues[right];
                        current = current.Next.Next;
                    }
                    else
                    {
                        current = current.Next;
                        break;
                    }

                    left++;
                    right--;
                }
            }

            return Print(head);
        }

        /// <summary>
        /// 12. Sort List
        /// Solution:
        ///     1. Traverse the linked list to find the length of the linked list
        ///     2. Create an array with length of the linked list length
        ///     3. Traverse the linked list again to store the nodes values
        ///     4. Sort the array
        ///     5. Traverse the linked list third time, track the index
        ///        and replace the linked list nodes values with the values stored in the array
        /// T.C -> O(n)
        /// S.C -> O(1)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public string SortLinkedList(SinglyNode head)
        {
            if (head == null)
                return string.Empty;

            var current = head;
            var length = 0;
            while (current != null)
            {
                current = current.Next;
                length++;
            }

            var nodeValues = new int[length];

            current = head;
            var index = 0;
            while (current != null)
            {
                nodeValues[index] = current.Value;
                current = current.Next;
                index++;
            }

            Array.Sort(nodeValues);
            index = 0;
            current = head;
            while (current != null)
            {
                current.Value = nodeValues[index];
                current = current.Next;
                index++;
            }

            return Print(head);
        }

        /// <summary>
        /// 13. Merge Two Sorted Lists
        ///     l1 - length of the first linked list
        ///     l2 - length of the second linked list
        /// T.C -> O(l1 + l2)
        /// S.C -> O(l1 + l2)
        /// </summary>
        /// <param name="head1"></param>
        /// <param name="head2"></param>
        /// <returns></returns>
        public string MergeTwoLinkedLists(SinglyNode head1, SinglyNode head2)
        {
            if (head1 == null && head2 == null)
                return null;

            if (head1 == null)
                return Print(head2);

            if (head2 == null)
                return Print(head1);

            var newHead = new SinglyNode(0); // Creating this dummy node ease the logic
            var runnerHead = newHead; // This is the runner node

            while (head1 != null && head2 != null)
            {
                if (head1.Value <= head2.Value)
                {
                    runnerHead.Next = head1;
                    head1 = head1.Next;
                }
                else
                {
                    runnerHead.Next = head2;
                    head2 = head2.Next;
                }

                runnerHead = runnerHead.Next;
            }

            // Simply add the 'leftover' from the while loop at the end 
            if (head1 != null) runnerHead.Next = head1;
            if (head2 != null) runnerHead.Next = head2;

            return Print(newHead.Next);
        }

        /// <summary>
        /// 14. Palindrome List (by keeping the same structure)
        /// Solution
        ///     1. Find Middle of the linked list - slow, fast pointer
        ///     2. Reverse the second half
        ///     3. check first half is same with second half
        ///     4. construct the original linked list by reversing the second half back
        /// T.C -> O(n)
        /// S.C -> O(1)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public bool IsPalindrome(SinglyNode head)
        {
            if (head == null || head.Next == null)
                return true;

            var slow = head;
            var fast = head;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            var secondHalfLinkedListHead = ReverseSinglyLinkedList(slow);
            var firstHalfHead = head;

            while (secondHalfLinkedListHead != null)
            {
                if (firstHalfHead.Value != secondHalfLinkedListHead.Value)
                    return false;

                firstHalfHead = firstHalfHead.Next;
                secondHalfLinkedListHead = secondHalfLinkedListHead.Next;
            }

            var originalLinkedList = ReverseSinglyLinkedList(firstHalfHead);

            return true;
        }

        private SinglyNode ReverseSinglyLinkedList(SinglyNode head)
        {
            SinglyNode previewNode = null;
            var currentNode = head;

            while (currentNode != null)
            {
                var nextNode = currentNode.Next;
                currentNode.Next = previewNode;
                previewNode = currentNode;
                currentNode = nextNode;
            }

            return previewNode;
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Practice.LinkedLists
{
    /// <summary>
    /// Singly list implementation
    /// </summary>
    public class SinglyLinkedList
    {
        public SinglyNode Head;
        public int Length;

        public SinglyLinkedList()
        {
            Head = null;
            Length = 0;
        }

        /// <summary>
        /// Add new node at head:
        /// 1. Initialize new node current
        /// 2. Link new node to head
        /// 3. Assign current to head
        /// T.C. -> O(1)
        /// </summary>
        /// <param name="val"></param>
        public void AddAtHead(int val)
        {
            if (Head == null)
            {
                Head = new SinglyNode(val);
                Length++;
                return;
            }

            var current = new SinglyNode(val);
            current.Next = Head;

            Head = current;
            Length++;
        }

        /// <summary>
        /// Add at tail:
        /// 1. Start from head.
        /// 2. Traverse the hole list till the tail
        /// 3. assign the new node to tail
        /// T.C  -> O(n)
        /// </summary>
        /// <param name="val"></param>
        public void AddAtTail(int val)
        {
            if (Head == null)
            {
                Head = new SinglyNode(val);
                Length++;
                return;
            }

            var current = Head;
            while (current != null && current.Next!= null)
            {
                current = current.Next;
            }

            var node = new SinglyNode(val);
            current.Next = node;
            current = node;
            Length++;
        }

        /// <summary>
        /// Add a node to a given position
        /// 1. for index 0 add at head
        /// 2. for index greater then length add node at the end of the linked list
        /// 3. find the index and add the node to index
        /// T.C -> O(1)
        /// </summary>
        /// <param name="index">index where the node is inserted</param>
        /// <param name="val"></param>
        public void AddAtIndex(int index,int val)
        {
            if (index >= Length)
            {
                AddAtTail(val);
                return;
            }

            var current = Head;

            while (index - 1 > 0)
            {
                current = current.Next;
                Length++;
                index--;
            }

            var nodeToAdd = new SinglyNode(val);
            var nextNode = current.Next;
            current.Next = nodeToAdd;
            current.Next.Next = nextNode;
            Length++;
        }

        /// <summary>
        /// T.C -> O(1)
        /// </summary>
        public void RemoveAtHead()
        {
            if (Head == null)
                return;

            Head = Head.Next;
            Length--;
        }

        /// <summary>
        /// Empty list or List with one node return null
        /// T.C -> O(n)
        /// </summary>
        public void RemoveAtTail()
        {
            if(Head == null)
                return;

            if (Head.Next == null)
            {
                Head = null;
                Length--;
                return;
            }

            var current = Head;
            var preview = current.Next;
            while (current != null && current.Next != null)
            {
                current = current.Next;
            }

            preview.Next = null;
            Length--;

        }
        /// <summary>
        /// T.C -> O(n)
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAtIndex(int index)
        {
            if (Head == null || index > Length)
                return;

            if (index == 0)
            {
                RemoveAtHead();
                return;
            }

            if (Length == index)
            {
                RemoveAtTail();
                return;
            }

            var current = Head;
           
            while (index - 1 > 0)
            {
                current = current.Next;
                Length++;
                index--;
            }

            current.Next = current.Next.Next;
            Length--;
        }

        /// <summary>
        /// T.C -> O(n)
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public SinglyNode GetNodeAtIndex(int index)
        {
            if (index > Length)
                return Head = null;

            if (Head == null )
                return Head;

            var current = Head;

            while (index - 1 > 0)
            {
                current = current.Next;
                Length++;
                index--;
            }

            Head = current;
            return Head;
        }

        /// <summary>
        /// T.C -> O(n)
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public SinglyNode GetNode(int val)
        {
            if (Head == null)
                return Head;

            var current = Head;

            while (current != null && current.Next != null)
            {
                if (current.Value == val)
                    return current;

                current = current.Next;
            }

            Head = null;
            return Head;
        }
    }
}

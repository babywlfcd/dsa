using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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

        public SinglyLinkedList()
        {
            Head = null;
        }

        /// <summary>
        /// Add new node at head:
        /// 1. Initialize new node current
        /// 2. Link new node to head
        /// 3. Assign current to head
        /// </summary>
        /// <param name="val"></param>
        public void AddAtHead(int val)
        {
            if (Head == null)
            {
                Head = new SinglyNode(val);
                return;
            }

            var current = new SinglyNode(val);
            current.Next = Head;

            Head = current;
        }

        /// <summary>
        /// Add at tail:
        /// 1. Start from head.
        /// 2. Traverse the hole list till the tail
        /// 3. assign the new node to tail
        /// </summary>
        /// <param name="val"></param>
        public void AddAtTail(int val)
        {
            if (Head == null)
            {
                Head = new SinglyNode(val);
                return;
            }

            var current = Head;
            while (current != null && current.Next!= null)
            {
                current = current.Next;
            }

            var node = new SinglyNode(val);
            current.Next = node;
        }

        /// <summary>
        /// Add a node to a given position
        /// 1. for index 0 add at head
        /// 2. 
        /// </summary>
        /// <param name="index">index where the node is inserted</param>
        /// <param name="val"></param>
        public void AddAtIndex(int index,int val)
        {
            if (index == 0)
                AddAtHead(val);

            var current = Head;

            while (index - 1 > 0)
            {
                current = current.Next;
                index--;
            }

            var nodeToAdd = new SinglyNode(val);
            var nextNode = current.Next;
            current.Next = nodeToAdd;
            current.Next.Next = nextNode;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public SinglyNode GetNode(int index)
        {
            if (Head == null)
                return Head;

            var current = Head;

            while (index > 0)
            {
                current = current.Next;
                index--;
            }

            return current;
        }
    }
}

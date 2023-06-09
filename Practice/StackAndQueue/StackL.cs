﻿using Practice.LinkedLists;

namespace Practice.StackAndQueue
{
    /// <summary>
    /// stack implementation using linked list
    /// TODO - need to maintain only data and next pointer?
    /// </summary>
    public class StackL
    {
        public int Top;
        public SinglyLinkedList StackNodes;

        public StackL()
        {
            Top = -1;
            StackNodes = new SinglyLinkedList();
        }

        /// <summary>
        /// Insert
        /// The new values are added to the head
        /// T.C -> O(1)
        /// </summary>
        /// <param name="value"></param>
        public bool Push(int value)
        {
            Top++;
            StackNodes.AddAtHead(value);
            return true;
        }

        /// <summary>
        /// Delete
        /// underflow condition for stack empty
        /// T.C -> O(1)
        /// </summary>
        /// <returns></returns>
        public int Pop()
        {
            if (Top == -1)
                return 0;

            StackNodes.RemoveAtHead();
            Top--;
            return Top;
        }

        /// <summary>
        /// return the value from the top of the stack without removing
        /// T.C -> O(1)
        /// </summary>
        /// <returns></returns>
        public int Peek()
        {
            if (Top < 0)
                return 0;

            var elem = StackNodes.GetNode(StackNodes.Head.Value);
            return elem.Value;
        }

        /// <summary>
        /// overflow
        /// T.C -> O(1)
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return Top == -1;
        }
    }
}

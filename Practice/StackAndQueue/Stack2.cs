using Practice.LinkedLists;

namespace Practice.StackAndQueue
{
    /// <summary>
    /// stack implementation using linked list
    /// TODO
    /// </summary>
    public class Stack2
    {
        public int Top;
        public SinglyLinkedList StackNodes;

        public Stack2(int capacity)
        {
            Top = -1;
            StackNodes = new SinglyLinkedList();
        }

        /// <summary>
        /// The new values are added to the head
        /// T.C -> O(1)
        /// </summary>
        /// <param name="value"></param>
        public void Push(int value)
        {
            Top++;
            StackNodes.AddAtHead(value);
        }

        /// <summary>
        /// 1. if stack is empty underflow exception 
        /// </summary>
        /// <returns></returns>
        public int Pop()
        {
            if (Top == -1)
                // return new Und
                StackNodes.RemoveAtTail();
            Top--;
            return Top;
        }

        /// <summary>
        /// return the element from the top of the stack
        /// T.C -> O(1)
        /// </summary>
        /// <returns></returns>
        public int Pick()
        {
            return 0;
        }

        /// <summary>
        /// overflow exception
        /// T.C -> O(1)
        /// </summary>
        /// <returns></returns>
        public bool IsFull()
        {
            return false;
        }

        /// <summary>
        /// overflow
        /// T.C -> O(1)
        /// </summary>
        /// <returns></returns>
        public bool IsEmmty()
        {
            return false;
        }
    }
}

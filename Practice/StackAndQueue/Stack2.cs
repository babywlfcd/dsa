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

        public Stack2()
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
        public void Push(int value)
        {
            Top++;
            StackNodes.AddAtHead(value);
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
        /// return the element from the top of the stack
        /// T.C -> O(1)
        /// </summary>
        /// <returns></returns>
        public int? Pick()
        {
            if (Top < 0)
            {
                return 0;
            }

            var elem = StackNodes.GetNode(Top);
            return elem.Value;
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

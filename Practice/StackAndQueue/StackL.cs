using Practice.LinkedLists;

namespace Practice.StackAndQueue
{
    /// <summary>
    /// stack implementation using linked list
    /// TODO
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

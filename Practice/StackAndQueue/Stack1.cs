namespace Practice.StackAndQueue
{
    /// <summary>
    /// Stack implementation using array
    /// </summary>
    public class Stack1
    {
        public int Top;
        public int Capacity;
        public int[] StackNodes;

        public Stack1(int capacity)
        {
            Top = -1;
            Capacity = capacity;
            StackNodes = new int[Capacity];
        }

        /// <summary>
        /// T.C -> O(1)
        /// </summary>
        /// <param name="value"></param>
        public bool Push(int value)
        {
            if (Top >= Capacity - 1)
            {
                return false;
            }

            Top++;
            StackNodes[Top] = value;
            return true;

        }

        /// <summary>
        /// 1. if stack is empty is underflow 
        /// T.C -> O(1)
        /// </summary>
        /// <returns></returns>
        public int Pop()
        {
            if (Top < 0)
            {
                return 0;
            }

            var elem = StackNodes[Top];
            Top--;
            return elem;
        }

        /// <summary>
        /// return the element from the top of the stack
        /// T.C -> O(1)
        /// </summary>
        /// <returns></returns>
        public int Pick()
        {
            if (Top < 0)
            {
                return 0;
            }

            var elem = StackNodes[Top];
            return elem;
        }

        /// <summary>
        /// overflow 
        /// T.C -> O(1)
        /// </summary>
        /// <returns></returns>
        public bool IsFull()
        {
            return Top < 0;
        }

        /// <summary>
        /// overflow
        /// T.C -> O(1)
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return Top >= Capacity;
        }
    }
}

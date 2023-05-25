using Practice.StackAndQueue;

namespace Practice.Course.Assignments.Queues_Stacks
{
    /// <summary>
    /// 1. Min Stack
    /// Solution explained in class
    ///     y = 2 * x - min(x)
    /// TODO 1:24:16 -  to review
    /// </summary>
    public class MinStack
    {
        private Stack<int> _stack;
        private int _minElem;

        public MinStack(Stack<int> stack = null)
        {
            _minElem = int.MaxValue;
            _stack = stack;
        }

        public void Push(int x)
        {
            if (_minElem > x)
                _minElem = x;
            else _minElem = 2 * x - _minElem;
            var minStack = new MinStack();
            minStack.Push(_minElem);
        }

        public int Pop()
        {
            int x = 0;
            var y = _stack.Peek();
            if (y >= _minElem)
                x = _stack.Pop();
            else
            {
                _minElem = 2 * _minElem - y;
            }


            return _minElem;

        }

        public int GetMin()
        {
            var x = _stack.Peek();
            return x;
        }
    }
}

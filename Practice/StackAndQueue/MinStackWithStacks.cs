namespace Practice.StackAndQueue
{
    public class MinStackWithStacks
    {
        private StackL _stack;
        private StackL _minSack;

        public MinStackWithStacks(StackL stack,
            StackL minStack)
        {
            _stack = stack;
            _minSack = minStack;
        }

        /// <summary>
        /// T.C -> O(1)
        /// S.C -> O(n)
        /// </summary>
        /// <param name="x"></param>
        public void Push(int x)
        {
            _stack.Push(x);
            if (_minSack.IsEmpty())
                _minSack.Push(x);
            else
                _minSack.Push(Math.Min(_minSack.Peek(), x));
        }

        /// <summary>
        /// TODO Q. THis should return min stack value?
        /// T.C -> O(1)
        /// </summary>
        /// <returns></returns>
        public int Pop()
        {
            var x = _stack.Pop();
            var y = _minSack.Pop();

            return y;

        }

        public int GetMin()
        {
            var x = _minSack.Peek();
            return x;
        }
    }
}

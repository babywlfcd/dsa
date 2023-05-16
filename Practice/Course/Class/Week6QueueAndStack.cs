using Practice.StackAndQueue;

namespace Practice.Course.Class
{
    public class Week6QueueAndStack
    {
        //design a data structure where we can perform push/pop/pick/is empty/getmin in O(1)
        public int Push(int value)
        {
            var stackoriginal = new StackA(10);
            var minStack = new StackA(10);
            if (minStack.IsEmpty())
            {
                minStack.Push(value);
            }
            else
            {
                minStack.Push(value);
            }
            return 0;
        }

        public int Pop(int value)
        {
            var stackoriginal = new StackA(10);
            var minStack = new StackA(10);
            var x = stackoriginal.Pop();

            return 0;
    }
    }

    public class stackMin
    {

    }
}

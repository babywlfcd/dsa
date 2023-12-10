using Practice.StackAndQueue;

namespace PracticeTests.StackAndQueue
{
    public class MinStackTests
    {
        [Fact]
        public void Push_MinStackEmpty_AddValueToMinStack()
        {
            // arrange
            var stack = new StackL();
            var minStack = new StackL();

            var sut = new MinStackWithStacks(stack, minStack);
            // act
            sut.Push(3);
            Assert.Equal(3, stack.StackNodes.Head.Value);
            Assert.Equal(3, minStack.StackNodes.Head.Value);
            Assert.Equal(0, stack.Top);
            Assert.Equal(0, minStack.Top);
        }

        [Fact]
        public void Push_MinStackNotEmpty_AddMinValueToMinStack()
        {
            // arrange
            var stack = new StackL();
            var minStack = new StackL();

            var sut = new MinStackWithStacks(stack, minStack);
            sut.Push(5);
            sut.Push(2);
            sut.Push(-1);

            // act
            sut.Push(10);
            Assert.Equal(10, stack.StackNodes.Head.Value);
            Assert.Equal(-1, minStack.StackNodes.Head.Value);
            Assert.Equal(3, stack.Top);
            Assert.Equal(3, minStack.Top);
        }

        [Fact]
        public void Push_MinStackNotEmpty_AddMinValueToMinStack2()
        {
            // arrange
            var stack = new StackL();
            var minStack = new StackL();

            var sut = new MinStackWithStacks(stack, minStack);
            sut.Push(5);
            sut.Push(2);

            // act
            sut.Push(-1);
            Assert.Equal(-1, stack.StackNodes.Head.Value);
            Assert.Equal(-1, minStack.StackNodes.Head.Value);
            Assert.Equal(2, stack.Top);
            Assert.Equal(2, minStack.Top);
        }

        [Fact]
        public void Pop_StackEmpty_ReturnZero()
        {
            // arrange
            var stack = new StackL();
            var minStack = new StackL();

            var sut = new MinStackWithStacks(stack, minStack);
            // act
            var actual = sut.Pop();
            Assert.Equal(0, actual);
            Assert.Equal(-1, stack.Top);
        }

        [Fact]
        public void Pop_MinStackEmpty_ReturnZero()
        {
            // arrange
            var stack = new StackL();
            stack.Push(3);
            var minStack = new StackL();

            var sut = new MinStackWithStacks(stack, minStack);
            // act
            var actual = sut.Pop();
            Assert.Equal(0, actual);
            Assert.Equal(-1, minStack.Top);
            Assert.Equal(-1, stack.Top);
        }
    }
}

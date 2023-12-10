using Practice.Course.Assignments.Queues_Stacks;
using Practice.StackAndQueue;

namespace PracticeTests.Course.Assignments.Queues_Stacks
{
    public class StackAssignmentTests
    {
        [Theory]
        [InlineData("((()))", "balanced")]
        [InlineData("()()()", "balanced")]
        [InlineData("(()))", "not balanced")]
        [InlineData("()", "balanced")]
        [InlineData("(())", "balanced")]
        [InlineData("(()())", "balanced")]
        [InlineData(")(", "not balanced")]
        [InlineData("(()", "not balanced")]
        [InlineData("", "balanced")]
        public void ValidateBalancedParenthesis_ShouldReturn_DuplicateConsecutiveChars_ForAString(string s,
            string expected)
        {
            var sut = new StackAssignment();
            var result = sut.ValidateBalancedParenthesis(s);
            Assert.Equal(expected, result);
        }

        [Fact]
       
        public void SortStack_ShouldReturn_SortedStack_IfStackIsNotEmpty()
        {
            var stack = new Stack<int>();
            stack.Push(3);

            var expected = new Stack<int>();
            expected.Push(3);

            var sut = new StackAssignment();

            var actual = sut.SortStack(stack);
            
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void SortStack_ShouldReturn_Stack_WhenStackHasOneValue()
        {
            var stack = new Stack<int>();
            stack.Push(3);

            var expected = new Stack<int>();
            expected.Push(3);

            var sut = new StackAssignment();

            var actual = sut.SortStack(stack);

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void SortStack_ShouldReturn_empty_WhenStackHasOneValue()
        {
            var stack = new Stack<int>();

            var expected = new Stack<int>();

            var sut = new StackAssignment();

            var actual = sut.SortStack(stack);

            Assert.Equal(expected, actual);

        }


    }
}

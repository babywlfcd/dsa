using Practice.StackAndQueue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice.Course.Assignments.Queues_Stacks;

namespace PracticeTests.Course.Assignments.Queues_Stacks
{
    public class MinStackTests
    {
        [Fact(Skip = "uncomment after implementation done")]
        public void Push_MinStackNotNull_CanInsertElementOnTopOfTheStack()
        {
            // arrange
            var stack = new Stack<int>();
            
            var sut = new MinStack(stack);
            sut.Push(16);
            sut.Push(15);

            // act 
            sut.Push(29);

            // assert
            Assert.Equal(43, stack.Peek());
        }

        [Fact(Skip = "uncomment after implementation done")]
        public void Pop_MinStackNotNull_CanInsertElementOnTopOfTheStack()
        {
            // arrange
            var stack = new Stack<int>();

            var sut = new MinStack(stack);
            sut.Push(16);
            sut.Push(15);
            sut.Push(29);
            sut.Push(19);

            // act 
            var actual = sut.Pop();

            // assert
            Assert.Equal(15, actual);
        }
    }
}

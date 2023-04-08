using Practice.Course.Class;
using Practice.LinkedLists;

namespace PracticeTests.Course.Class
{
    public class Week4LinkedListTests
    {
        [Fact]
        public void FindMiddleNode_SinglyLinkedList_NodeFromMiddleOfTheLinkedList()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(9);
            singlyLinkedList.AddAtTail(8);
            singlyLinkedList.AddAtTail(7);
            singlyLinkedList.AddAtTail(5);
            singlyLinkedList.AddAtTail(6);

            var sut = new Week4LinkedList();
            // act
            var actual = sut.FindMiddleNode(singlyLinkedList);
            Assert.Equal(7, actual.Value);
        }

        [Fact]
        public void FindMiddleNodeSlowFast_SinglyLinkedList_NodeFromMiddleOfTheLinkedList()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(9);
            singlyLinkedList.AddAtTail(8);
            singlyLinkedList.AddAtTail(7);
            singlyLinkedList.AddAtTail(5);
            singlyLinkedList.AddAtTail(6);

            var sut = new Week4LinkedList();

            var actual = sut.FindMiddleNodeSlowFaster(singlyLinkedList);
            Assert.Equal(7, actual.Value);
        }

        [Fact]
        public void HasLoopAdditionalSpace_EmptySinglyLinkedList_False()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();

            var sut = new Week4LinkedList();
            // act
            var result = sut.HasLoopAdditionalSpace(singlyLinkedList.Head);
            Assert.False(result);
        }

        [Fact]
        public void HasLoopAdditionalSpace_SinglyLinkedListTwoNodesLoop_True()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(9);
            singlyLinkedList.AddAtTail(9);

            var sut = new Week4LinkedList();
            // act
            var result = sut.HasLoopAdditionalSpace(singlyLinkedList.Head);
            Assert.True(result);
        }

        [Fact]
        public void HasLoopAdditionalSpace_SinglyLinkedListWithNoLoop_False()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(9);
            singlyLinkedList.AddAtTail(8);
            singlyLinkedList.AddAtTail(7);
            singlyLinkedList.AddAtTail(5);
            singlyLinkedList.AddAtTail(6);

            var sut = new Week4LinkedList();

            var result = sut.HasLoopAdditionalSpace(singlyLinkedList.Head);
            Assert.False(result);
        }

        [Fact]
        public void HasLoopAdditionalSpace_SinglyLinkedListWithLoop_True()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(9);
            singlyLinkedList.AddAtTail(8);
            singlyLinkedList.AddAtTail(7);
            singlyLinkedList.AddAtTail(5);
            singlyLinkedList.AddAtTail(6);
            singlyLinkedList.AddAtTail(7);

            var sut = new Week4LinkedList();

            var result = sut.HasLoopAdditionalSpace(singlyLinkedList.Head);
            Assert.True(result);
        }

        [Fact]
        public void HasLoop_SinglyLinkedListWithNoLoop_False()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(9);
            singlyLinkedList.AddAtTail(8);
            singlyLinkedList.AddAtTail(7);
            singlyLinkedList.AddAtTail(5);
            singlyLinkedList.AddAtTail(6);

            var sut = new Week4LinkedList();

            var result = sut.HasLoop(singlyLinkedList.Head);
            Assert.False(result);
        }

        [Fact]
        public void HasLoop_SinglyLinkedListWithLoop_True()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(9);
            singlyLinkedList.AddAtTail(8);
            singlyLinkedList.AddAtTail(7);
            singlyLinkedList.AddAtTail(5);
            singlyLinkedList.AddAtTail(6);
            singlyLinkedList.AddAtTail(11);
            var nodeToCycle = singlyLinkedList.GetNode(7);
            var cycle = singlyLinkedList.GetNode(11); 
            

            cycle.Next = nodeToCycle;

            var sut = new Week4LinkedList();

            var result = sut.HasLoop(singlyLinkedList.Head);
            Assert.True(result);
        }

        [Fact]
        public void ReverseLinkedList_SinglyLinkedList_ReversedSinglyLinkedList()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(9);
            singlyLinkedList.AddAtTail(7);
            singlyLinkedList.AddAtTail(6);
            
            var sut = new Week4LinkedList();
            // act
            var actual = sut.ReverseLinkedList(singlyLinkedList.Head);
            // assert
            Assert.Equal(6, actual.Value);
            Assert.Equal(7, actual.Next.Value);
            Assert.Equal(9, actual.Next.Next.Value);
            Assert.Null(actual.Next.Next.Next);
        }

        [Fact]
        public void ReverseLinkedListRecursive_SinglyLinkedList_ReversedSinglyLinkedList()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(9);
            singlyLinkedList.AddAtTail(7);
            singlyLinkedList.AddAtTail(6);

            var sut = new Week4LinkedList();
            // act
            var actual = sut.ReverseLinkedListRecursive(singlyLinkedList.Head);
            // assert
            Assert.Equal(6, actual.Value);
            Assert.Equal(7, actual.Next.Value);
            Assert.Equal(9, actual.Next.Next.Value);
            Assert.Null(actual.Next.Next.Next);
        }

        [Fact]
        public void ReverseLinkedListRecursive_EmptySinglyLinkedList_Null()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();

            var sut = new Week4LinkedList();
            // act
            var actual = sut.ReverseLinkedListRecursive(singlyLinkedList.Head);
            // assert
            Assert.Null(actual);
        }

        [Fact]
        public void ReverseLinkedListRecursive_SinglyLinkedListOneNode_Head()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(3);

            var sut = new Week4LinkedList();
            // act
            var actual = sut.ReverseLinkedListRecursive(singlyLinkedList.Head);
            // assert
            Assert.Equal(3, actual.Value);
            Assert.Null(actual.Next);
        }


        [Fact]
        public void ReverseDoublyLinkedList_SinglyLinkedListOneNode_Head()
        {
            // arrange
            var doublyLinkedList = new DoublyLinkedList();
            doublyLinkedList.AddAtHead(3);
            doublyLinkedList.AddAtHead(4);
            doublyLinkedList.AddAtHead(5);

            var sut = new Week4LinkedList();
            // act
            var actual = sut.ReverseDoublyLinkedList(doublyLinkedList.Head);
            // assert
            Assert.Equal(3, actual.Value);
            Assert.Null(actual.Next);
        }
    }
}

using Practice.Course.Assignments;
using Practice.Course.Class;
using Practice.LinkedLists;

namespace PracticeTests.Course.Assignments
{
    public class LinkedListAssignmentTests
    {
        [Fact]
        public void DeleteMiddle_SinglyLinkedListThreeNodes_PrintLinkedList()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(1);
            singlyLinkedList.AddAtTail(2);
            singlyLinkedList.AddAtTail(3);

            var expected = "1->3";

            var sut = new LinkedListAssignment();
            // act
            var actual = sut.DeleteMiddle(singlyLinkedList.Head);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DeleteMiddle_EmptySinglyLinkedList_StringEmpty()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();

            var expected = string.Empty;

            var sut = new LinkedListAssignment();
            // act
            var actual = sut.DeleteMiddle(singlyLinkedList.Head);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DeleteMiddle_SinglyLinkedListOneNode_PrintHead()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(9);

            var expected = "9";

            var sut = new LinkedListAssignment();
            // act
            var actual = sut.DeleteMiddle(singlyLinkedList.Head);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DeleteMiddle_SinglyLinkedList_PrintRemainedNodesLinkedList()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(1);
            singlyLinkedList.AddAtTail(2);
            singlyLinkedList.AddAtTail(3);
            singlyLinkedList.AddAtTail(4);
            singlyLinkedList.AddAtTail(5);

            var expected = "1->2->4->5";

            var sut = new LinkedListAssignment();
            // act
            var actual = sut.DeleteMiddle(singlyLinkedList.Head);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DeleteMiddle_SinglyLinkedListTwoNodes_PrintLinkedList()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(1);
            singlyLinkedList.AddAtTail(2);

            var expected = "1->2";

            var sut = new LinkedListAssignment();
            // act
            var actual = sut.DeleteMiddle(singlyLinkedList.Head);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FindMiddleNode_SinglyLinkedListOddNumberOfNodes_NodeFromMiddleOfTheLinkedList()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(1);
            singlyLinkedList.AddAtTail(2);
            singlyLinkedList.AddAtTail(3);
            singlyLinkedList.AddAtTail(4);
            singlyLinkedList.AddAtTail(5);

            var sut = new LinkedListAssignment();
            // act
            var actual = sut.FindMiddleNode(singlyLinkedList.Head);
            Assert.Equal(3, actual.Value);
        }

        [Fact]
        public void FindMiddleNode_SinglyLinkedListEvenNumberOfNodes_NodeFromMiddleOfTheLinkedList()
        {
            // arrange

            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(1);
            singlyLinkedList.AddAtTail(2);
            singlyLinkedList.AddAtTail(3);
            singlyLinkedList.AddAtTail(4);

            var sut = new LinkedListAssignment();
            // act
            var actual = sut.FindMiddleNode(singlyLinkedList.Head);
            Assert.Equal(3, actual.Value);
        }

        [Fact]
        public void FindMiddleNode_SinglyLinkedListTwoNodes_NodeFromMiddleOfTheLinkedList()
        {
            // arrange

            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(1);
            singlyLinkedList.AddAtTail(2);

            var sut = new LinkedListAssignment();
            // act
            var actual = sut.FindMiddleNode(singlyLinkedList.Head);
            Assert.Equal(2, actual.Value);
        }

        [Fact]
        public void FindMiddleNodeSlowFast_SinglyLinkedListEvenNumberOfNodes_NodeFromMiddleOfTheLinkedList()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(9);
            singlyLinkedList.AddAtTail(8);
            singlyLinkedList.AddAtTail(7);
            singlyLinkedList.AddAtTail(5);

            var sut = new LinkedListAssignment();

            var actual = sut.FindMiddleNodeSlowFaster(singlyLinkedList.Head);
            Assert.Equal(7, actual.Value);
        }

        [Fact]
        public void FindMiddleNodeSlowFaster_SinglyLinkedListOddNumberOfNodes_NodeFromMiddleOfTheLinkedList()
        {
            // arrange

            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(1);
            singlyLinkedList.AddAtTail(2);
            singlyLinkedList.AddAtTail(3);
            singlyLinkedList.AddAtTail(4);
            singlyLinkedList.AddAtTail(5);

            var sut = new LinkedListAssignment();
            // act
            var actual = sut.FindMiddleNodeSlowFaster(singlyLinkedList.Head);
            Assert.Equal(3, actual.Value);
        }

        [Fact]
        public void HasCycleAdditionalSpace_EmptySinglyLinkedList_False()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();

            var sut = new LinkedListAssignment();
            // act
            var result = sut.HasCycleAdditionalSpace(singlyLinkedList.Head);
            Assert.False(result);
        }

        [Fact]
        public void HasCycleAdditionalSpace_SinglyLinkedListTwoNodesLoop_True()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(9);
            singlyLinkedList.AddAtTail(9);

            var sut = new LinkedListAssignment();
            // act
            var result = sut.HasCycleAdditionalSpace(singlyLinkedList.Head);
            Assert.True(result);
        }

        [Fact]
        public void HasCycleAdditionalSpace_SinglyLinkedListWithNoLoop_False()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(9);
            singlyLinkedList.AddAtTail(8);
            singlyLinkedList.AddAtTail(7);
            singlyLinkedList.AddAtTail(5);
            singlyLinkedList.AddAtTail(6);

            var sut = new LinkedListAssignment();

            var result = sut.HasCycleAdditionalSpace(singlyLinkedList.Head);
            Assert.False(result);
        }

        [Fact]
        public void HasCycleAdditionalSpace_SinglyLinkedListWithLoop_True()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(9);
            singlyLinkedList.AddAtTail(8);
            singlyLinkedList.AddAtTail(7);
            singlyLinkedList.AddAtTail(5);
            singlyLinkedList.AddAtTail(6);
            singlyLinkedList.AddAtTail(7);

            var sut = new LinkedListAssignment();

            var result = sut.HasCycleAdditionalSpace(singlyLinkedList.Head);
            Assert.True(result);
        }

        [Fact]
        public void HasCycle_SinglyLinkedListWithNoLoop_False()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(9);
            singlyLinkedList.AddAtTail(8);
            singlyLinkedList.AddAtTail(7);
            singlyLinkedList.AddAtTail(5);
            singlyLinkedList.AddAtTail(6);

            var sut = new LinkedListAssignment();

            var result = sut.HasCycle(singlyLinkedList.Head);
            Assert.False(result);
        }

        [Fact]
        public void HasCycle_SinglyLinkedListWithLoop_True()
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

            var sut = new LinkedListAssignment();

            var result = sut.HasCycle(singlyLinkedList.Head);
            Assert.True(result);
        }

        [Fact]
        public void ReverseLinkedList_EmptySinglyLinkedList_StringEmpty()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();

            var sut = new LinkedListAssignment();
            // act
            var actual = sut.ReverseLinkedList(singlyLinkedList.Head);
            // assert
            Assert.Equal(string.Empty, actual);
        }

        [Fact]
        public void ReverseLinkedList_SinglyLinkedList_ReversedSinglyLinkedList()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(1);
            singlyLinkedList.AddAtTail(2);
            singlyLinkedList.AddAtTail(3);
            singlyLinkedList.AddAtTail(4);
            singlyLinkedList.AddAtTail(5);
            var expected = "5->4->3->2->1";

            var sut = new LinkedListAssignment();
            // act
            var head = sut.ReverseLinkedList(singlyLinkedList.Head);
            // assert
            Assert.Equal(expected, head);
        }

        [Fact]
        public void ReverseLinkedList_SinglyLinkedListOneNode_PrintHead()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(1);
            var expected = "1";

            var sut = new LinkedListAssignment();
            // act
            var head = sut.ReverseLinkedList(singlyLinkedList.Head);
            // assert
            Assert.Equal(expected, head);
        }

        [Fact]
        public void ReverseLinkedList_SinglyLinkedListTwoNodes_PrintReversedNodes()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(1);
            singlyLinkedList.AddAtTail(2);
            var expected = "2->1";

            var sut = new LinkedListAssignment();
            // act
            var head = sut.ReverseLinkedList(singlyLinkedList.Head);
            // assert
            Assert.Equal(expected, head);
        }
    }
}

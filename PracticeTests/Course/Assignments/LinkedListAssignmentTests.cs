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
        public void HasCycleAdditionalSpace_Null_False()
        {
            // arrange
            var sut = new LinkedListAssignment();
            // act
            var result = sut.HasCycleAdditionalSpace(null);
            Assert.False(result);
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
            singlyLinkedList.AddAtHead(9);
            var cycle = singlyLinkedList.GetNodeAtIndex(singlyLinkedList.Length - 1);
            var linkCycle = singlyLinkedList.GetNodeAtIndex(singlyLinkedList.Length - 1);
            linkCycle.Next = cycle;

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
            singlyLinkedList.AddAtHead(9);
            singlyLinkedList.AddAtHead(8);
            singlyLinkedList.AddAtHead(7);
            singlyLinkedList.AddAtHead(5);
            singlyLinkedList.AddAtHead(6);

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
            var cycle = singlyLinkedList.GetNodeAtIndex(singlyLinkedList.Length - 1);
            singlyLinkedList.AddAtTail(5);
            singlyLinkedList.AddAtTail(6);
            var linkCycle = singlyLinkedList.GetNodeAtIndex(singlyLinkedList.Length - 1);
            linkCycle.Next = cycle;

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


        [Fact]
        public void RemoveNthNodeFromEnd_SinglyLinkedList_PrintLinkedListWithoutNthNode()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(1);
            singlyLinkedList.AddAtTail(2);
            singlyLinkedList.AddAtTail(3);
            singlyLinkedList.AddAtTail(4);
            singlyLinkedList.AddAtTail(5);

            var expected = "1->2->3->5";

            var sut = new LinkedListAssignment();
            // act
            var head = sut.RemoveNthNodeFromEnd(singlyLinkedList.Head, 2);
            // assert
            Assert.Equal(expected, head);
        }

        [Fact]
        public void RemoveNthNodeFromEnd_SinglyLinkedListNGreaterThanLinkedListLength_PrintLinkedListNodes()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(1);

            var expected = "1";

            var sut = new LinkedListAssignment();
            // act
            var head = sut.RemoveNthNodeFromEnd(singlyLinkedList.Head, 2);
            // assert
            Assert.Equal(expected, head);
        }

        [Fact]
        public void RemoveNthNodeFromEnd_Null_PrintNull()
        {
            var sut = new LinkedListAssignment();
            // act
            var head = sut.RemoveNthNodeFromEnd(null, 1);
            // assert
            Assert.Null(head);
        }

        [Fact]
        public void RemoveNthNodeFromEnd_SinglyLinkedListOneNodes_PrintNull()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(1);

            var sut = new LinkedListAssignment();
            // act
            var head = sut.RemoveNthNodeFromEnd(singlyLinkedList.Head, 1);
            // assert
            Assert.Null(head);
        }

        [Fact]
        public void RemoveNthNodeFromEnd_SinglyLinkedListNLastNode_PrintLinkedListWithNull()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(1);
            singlyLinkedList.AddAtTail(2);


            var expected = "1";

            var sut = new LinkedListAssignment();
            // act
            var head = sut.RemoveNthNodeFromEnd(singlyLinkedList.Head, 1);
            // assert
            Assert.Equal(expected, head);
        }

        [Fact]
        public void RemoveNthNodeFromEnd_SinglyLinkedListIntegerNLessThanLinkedListLength_PrintLinkedListWithNull()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(1);
            singlyLinkedList.AddAtTail(2);
            singlyLinkedList.AddAtTail(3);

            var expected = "1->3";

            var sut = new LinkedListAssignment();
            // act
            var head = sut.RemoveNthNodeFromEnd(singlyLinkedList.Head, 2);
            // assert
            Assert.Equal(expected, head);
        }

        [Fact]
        public void RemoveNthNodeFromEnd_SinglyLinkedListNLastNode3_PrintLinkedListWithNull()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(1);
            singlyLinkedList.AddAtTail(2);
            singlyLinkedList.AddAtTail(3);
            singlyLinkedList.AddAtTail(4);


            var expected = "1->2->4";

            var sut = new LinkedListAssignment();
            // act
            var head = sut.RemoveNthNodeFromEnd(singlyLinkedList.Head, 2);
            // assert
            Assert.Equal(expected, head);
        }

        [Fact]
        public void RemoveDuplicates_Null_StringEmpty()
        {
            // arrange
            var sut = new LinkedListAssignment();
            // act
            var actual = sut.RemoveDuplicates(null);
            // assert
            Assert.Null(actual);
        }

        [Fact]
        public void RemoveDuplicates_LinkedList_LinkedListUniqueValueNodes()
        {
            // arrange
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtHead(3);
            singlyLinkedList.AddAtHead(3);
            singlyLinkedList.AddAtHead(2);
            singlyLinkedList.AddAtHead(2);
            singlyLinkedList.AddAtHead(2);
            singlyLinkedList.AddAtHead(1);
            singlyLinkedList.AddAtHead(1);

            var expected = "1->2->3";

            var sut = new LinkedListAssignment();
            // act
            var actual = sut.RemoveDuplicates(singlyLinkedList.Head);
            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RemoveDuplicates_LinkedListOneNode_LinkedListUniqueValueNodes()
        {
            // arrange
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtHead(1);

            var expected = "1";

            var sut = new LinkedListAssignment();
            // act
            var actual = sut.RemoveDuplicates(singlyLinkedList.Head);
            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RemoveDuplicates_LinkedListMultipleNodesSameValue_LinkedListOneNodes()
        {
            // arrange
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtHead(1);
            singlyLinkedList.AddAtHead(1);

            var expected = "1";

            var sut = new LinkedListAssignment();
            // act
            var actual = sut.RemoveDuplicates(singlyLinkedList.Head);
            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RemoveDuplicates_LinkedListUniqueNodesValues_LinkedListUniqueValueNodes()
        {
            // arrange
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtHead(3);
            singlyLinkedList.AddAtHead(2);
            singlyLinkedList.AddAtHead(1);

            var expected = "1->2->3";

            var sut = new LinkedListAssignment();
            // act
            var actual = sut.RemoveDuplicates(singlyLinkedList.Head);
            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReverseKthNodes_LinkedListAndAndIntegerN_LinkedListWithNNodesReversed()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtHead(5);
            singlyLinkedList.AddAtHead(4);
            singlyLinkedList.AddAtHead(3);
            singlyLinkedList.AddAtHead(2);
            singlyLinkedList.AddAtHead(1);

            var expected = "2->1->3->4->5";

            var sut = new LinkedListAssignment();
            // act
            var actual = sut.ReverseKthNodes(singlyLinkedList.Head, 2);
            // assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ReverseKthNodes_LinkedListAndAndIntegerNEqualToLinkedListLength_LinkedListReversed()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtHead(5);
            singlyLinkedList.AddAtHead(4);
            singlyLinkedList.AddAtHead(3);
            singlyLinkedList.AddAtHead(2);
            singlyLinkedList.AddAtHead(1);

            var expected = "5->4->3->2->1";

            var sut = new LinkedListAssignment();
            // act
            var actual = sut.ReverseKthNodes(singlyLinkedList.Head, 5);
            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReverseKthNodes_LinkedListAndAndIntegerNZero_LinkedList()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtHead(5);
            singlyLinkedList.AddAtHead(4);
            singlyLinkedList.AddAtHead(3);
            singlyLinkedList.AddAtHead(2);
            singlyLinkedList.AddAtHead(1);

            var expected = "1->2->3->4->5";

            var sut = new LinkedListAssignment();
            // act
            var actual = sut.ReverseKthNodes(singlyLinkedList.Head, 0);
            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RemoveCycle_SinglyLinkedListWithNoLoop_True()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(1);
            singlyLinkedList.AddAtTail(2);
           
            var expected = "1->2";
            var sut = new LinkedListAssignment();
            // act
            var actual = sut.RemoveCycle(singlyLinkedList.Head);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RemoveCycle_SinglyLinkedListWithLoop_PrintLinkedList()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(1);
            singlyLinkedList.AddAtTail(2);
            singlyLinkedList.AddAtTail(3);
            singlyLinkedList.AddAtTail(4);
            singlyLinkedList.AddAtTail(5);
            var cycleNode = singlyLinkedList.GetNodeAtIndex(2);
            var lastNode = singlyLinkedList.GetNodeAtIndex(4);

            lastNode.Next = cycleNode;
            var expected = "1->2->3->4->5";
            var sut = new LinkedListAssignment();
            // act
            var actual = sut.RemoveCycle(singlyLinkedList.Head);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RemoveCycle_Null_PrintStringEmpty()
        {
            var sut = new LinkedListAssignment();
            // act
            var actual = sut.RemoveCycle(null);

            Assert.Equal(string.Empty, actual);
        }


        [Fact]
        public void ReorderLinkedList_SinglyLinkedListMultipleNodes_PrintLinkedListReordered()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(1);
            singlyLinkedList.AddAtTail(2);
            singlyLinkedList.AddAtTail(3);
            singlyLinkedList.AddAtTail(4);
            singlyLinkedList.AddAtTail(5);

            var expected = "1->5->2->4->3";
            var sut = new LinkedListAssignment();
            // act
            var actual = sut.ReorderLinkedList(singlyLinkedList.Head);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReorderLinkedList_Null_StringEmpty()
        {
            var sut = new LinkedListAssignment();
            // act
            var actual = sut.ReorderLinkedList(null);

            Assert.Equal(string.Empty, actual);
        }

        [Fact]
        public void ReorderLinkedList_SinglyLinkedListWOneNode_PrintHead()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(1);

            var expected = "1";
            var sut = new LinkedListAssignment();
            // act
            var actual = sut.ReorderLinkedList(singlyLinkedList.Head);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReorderLinkedList_SinglyLinkedListTwoNodes_PrintNodes()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(1);
            singlyLinkedList.AddAtTail(2);

            var expected = "1->2";
            var sut = new LinkedListAssignment();
            // act
            var actual = sut.ReorderLinkedList(singlyLinkedList.Head);

            Assert.Equal(expected, actual);
        }

    }
}

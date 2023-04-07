using Practice.LinkedLists;

namespace PracticeTests.LinkedList
{
    public class SinglyLinkListTest
    {
        [Fact]
        public void AddAtHead_SinglyLinkedList_LinkedListWithNewNodeAtTheStart()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtHead(3);

            // act 
            singlyLinkedList.AddAtHead(11);

            // assert
            Assert.Equal(11, singlyLinkedList.Head.Value);
            Assert.NotNull(singlyLinkedList.Head.Next);
            Assert.Equal(2, singlyLinkedList.Length);
        }

        [Fact]
        public void AddAtHead_EmptySinglyLinkedList_LinkedListWithHead()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();

            // act
            singlyLinkedList.AddAtHead(3);

            //assert
            Assert.Equal(3, singlyLinkedList.Head.Value);
            Assert.Null(singlyLinkedList.Head.Next);
            Assert.Equal(1, singlyLinkedList.Length);
        }

        [Fact]
        public void AddAtTail_SinglyLinkedList_LinkedListWithNewNodeAtTheEnd()
        {
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(3);

            //act
            singlyLinkedList.AddAtTail(11);

            Assert.Equal(11, singlyLinkedList.Head.Next.Value);
            Assert.Null(singlyLinkedList.Head.Next.Next);
            Assert.Equal(2, singlyLinkedList.Length);
        }

        [Fact]
        public void AddAtTail_EmptySinglyLinkedList_LinkedListWithHeadOnly()
        {
            var singlyLinkedList = new SinglyLinkedList();

            //act
            singlyLinkedList.AddAtTail(3);

            Assert.Equal(3, singlyLinkedList.Head.Value);
            Assert.Null(singlyLinkedList.Head.Next);
            Assert.Equal(1, singlyLinkedList.Length);
        }

        [Fact]
        public void AddAtIndex_SinglyLinkedListAndANode_LinkedListWithNewNodeAtTheEnd()
        {
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(3);
            singlyLinkedList.AddAtTail(23);
            singlyLinkedList.AddAtTail(11);
            
            //act
            singlyLinkedList.AddAtIndex(1, 12);

            Assert.Equal(3, singlyLinkedList.Head.Value);
            Assert.Equal(12, singlyLinkedList.Head.Next.Value);
            Assert.Equal(4, singlyLinkedList.Length);
        }

        [Fact]
        public void AddAtIndex_EmptySinglyLinkedList_LinkedListWithHead()
        {
            var singlyLinkedList = new SinglyLinkedList();

            //act
            singlyLinkedList.AddAtIndex(0, 12);

            Assert.Equal(12, singlyLinkedList.Head.Value);
            Assert.Equal(1, singlyLinkedList.Length);
        }

        [Fact]
        public void AddAtIndex_SinglyLinkedListAndIndexGreaterThanLength_LinkedListWithNewNodeAtTheEnd()
        {
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(3);
            singlyLinkedList.AddAtTail(23);
            singlyLinkedList.AddAtTail(11);

            //act
            singlyLinkedList.AddAtIndex(5, 12);

            Assert.Equal(3, singlyLinkedList.Head.Value);
            Assert.Equal(12, singlyLinkedList.Head.Next.Next.Next.Value);
            Assert.Equal(4, singlyLinkedList.Length);
        }

        [Fact]
        public void GetNodeAtIndex_EmptySinglyLinkedList_Null()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            // act
            singlyLinkedList.GetNodeAtIndex(0);
            // assert
            Assert.Null(singlyLinkedList.Head);
            Assert.Equal(0, singlyLinkedList.Length);
        }

        [Fact]
        public void GetNodeAtIndex_SinglyLinkedListIndexGreaterThanLength_Null()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(3);
            singlyLinkedList.AddAtTail(23);
            singlyLinkedList.AddAtTail(11);
            // act
            singlyLinkedList.GetNodeAtIndex(5);
            // assert
            Assert.Null(singlyLinkedList.Head);
            Assert.Equal(3, singlyLinkedList.Length);
        }

        [Fact]
        public void GetNodeAtIndex_SinglyLinkedListAndANode_LinkedListWithNewNodeAtTheEnd()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(3);
            singlyLinkedList.AddAtTail(23);
            singlyLinkedList.AddAtTail(11);

            // act
            singlyLinkedList.GetNodeAtIndex(1);

            // assert
            Assert.Equal(23, singlyLinkedList.Head.Next.Value);
        }

        [Fact]
        public void RemoveAtHead_EmptySinglyLinkedList_Null()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            // act
            singlyLinkedList.RemoveAtHead();
            // assert
            Assert.Null(singlyLinkedList.Head);
            Assert.Equal(0, singlyLinkedList.Length);
        }
    

        [Fact]
        public void RemoveAtHead_SinglyLinkedListWithANode_Null()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(3);
            // act
            singlyLinkedList.RemoveAtHead();
            // assert
            Assert.Null(singlyLinkedList.Head);
            Assert.Equal(0, singlyLinkedList.Length);
        }

        [Fact]
        public void RemoveAtHead_SinglyLinkedListWith_LinkedListWithHeadTheNExtNode()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(3);
            singlyLinkedList.AddAtTail(11);
            singlyLinkedList.AddAtTail(23);
            // act
            singlyLinkedList.RemoveAtHead();
            // assert
            Assert.Equal(11, singlyLinkedList.Head.Value);
            Assert.Equal(2, singlyLinkedList.Length);
        }

        [Fact]
        public void RemoveAtTail_EmptySinglyLinkedList_Null()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            // act
            singlyLinkedList.RemoveAtTail();
            // assert
            Assert.Null(singlyLinkedList.Head);
            Assert.Equal(0, singlyLinkedList.Length);
        }

        [Fact]
        public void RemoveAtTail_SinglyLinkedListWithANode_Null()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(3);
            // act
            singlyLinkedList.RemoveAtTail();
            // assert
            Assert.Null(singlyLinkedList.Head);
            Assert.Equal(0, singlyLinkedList.Length);
        }

        [Fact]
        public void RemoveAtTail_SinglyLinkedListWith_LinkedListWithHeadTheNExtNode()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(3);
            singlyLinkedList.AddAtTail(11);
            singlyLinkedList.AddAtTail(23);
            // act
            singlyLinkedList.RemoveAtTail();
            // assert
            Assert.Equal(11, singlyLinkedList.Head.Next.Value);
            Assert.Equal(2, singlyLinkedList.Length);
        }

        [Fact]
        public void RemoveAtIndex_EmptySinglyLinkedList_Null()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            // act
            singlyLinkedList.RemoveAtIndex(0);
            // assert
            Assert.Null(singlyLinkedList.Head);
            Assert.Equal(0, singlyLinkedList.Length);
        }

        [Fact]
        public void RemoveAtIndex_SinglyLinkedListIndexGreaterThanLength_Null()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(3);
            // act
            singlyLinkedList.RemoveAtIndex(5);
            // assert
            Assert.Equal(3, singlyLinkedList.Head.Value);
            Assert.Equal(1, singlyLinkedList.Length);
        }

        [Fact]
        public void RemoveAtIndex_SinglyLinkedListIndexZero_RemoveHead()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(3);
            singlyLinkedList.AddAtTail(11);
            // act
            singlyLinkedList.RemoveAtIndex(0);
            // assert
            Assert.Equal(11, singlyLinkedList.Head.Value);
            Assert.Equal(1, singlyLinkedList.Length);
        }

        [Fact]
        public void RemoveAtIndex_SinglyLinkedList_RemoveNode()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(3);
            singlyLinkedList.AddAtTail(11);
            singlyLinkedList.AddAtTail(23);
            // act
            singlyLinkedList.RemoveAtIndex(1);
            // assert
            Assert.Equal(23, singlyLinkedList.Head.Next.Value);
        }

        [Fact]
        public void GetNode_EmptySinglyLinkedList_Null()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            // act
            singlyLinkedList.GetNode(3);
            // assert
            Assert.Null(singlyLinkedList.Head);
            Assert.Equal(0, singlyLinkedList.Length);
        }

        [Fact]
        public void GetNode_SinglyLinkedListIndexGreaterThanLength_Null()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(3);
            singlyLinkedList.AddAtTail(23);
            singlyLinkedList.AddAtTail(11);
            // act
            singlyLinkedList.GetNode(5);
            // assert
            Assert.Null(singlyLinkedList.Head);
            Assert.Equal(3, singlyLinkedList.Length);
        }

        [Fact]
        public void GetNode_SinglyLinkedListAndValidValue_NodeWithTheGivenValue()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(3);
            singlyLinkedList.AddAtTail(23);
            singlyLinkedList.AddAtTail(11);

            // act
            singlyLinkedList.GetNode(23);

            // assert
            Assert.Equal(23, singlyLinkedList.Head.Next.Value);
        }


        [Fact]
        public void GetNode_SinglyLinkedListAndInvalidValue_LinkedListWithNewNodeAtTheEnd()
        {
            // arrange
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtTail(3);
            singlyLinkedList.AddAtTail(23);
            singlyLinkedList.AddAtTail(11);

            // act
            singlyLinkedList.GetNode(5);

            // assert
            Assert.Null(singlyLinkedList.Head);
            Assert.Equal(3, singlyLinkedList.Length);
        }
    }
}

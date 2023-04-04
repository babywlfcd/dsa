using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice.LinkedLists;

namespace PracticeTests.SinglyLinkedList
{
    public class SinglyLinkListTest
    {
        [Fact]
        public void AddAtHead_SinglyLinkedListAndANode_LinkedListWithNewNodeAtTheStart()
        {
            var singlyLinkedList = new Practice.LinkedLists.SinglyLinkedList();
            singlyLinkedList.AddAtHead(3);
            singlyLinkedList.AddAtHead(23);

            //act 
            singlyLinkedList.AddAtHead(11);
            Assert.Equal(11, singlyLinkedList.Head.Value);
        }

        [Fact]
        public void AddAtStart_SinglyLinkedListAndANode_LinkedListWithNewNodeAtTheEnd()
        {
            var singlyLinkedList = new Practice.LinkedLists.SinglyLinkedList();
            singlyLinkedList.AddAtTail(3);
            singlyLinkedList.AddAtTail(23);

            //act
            singlyLinkedList.AddAtTail(11);
            Assert.Equal(3, singlyLinkedList.Head.Value);
        }

        [Fact]
        public void AddAtIndex_SinglyLinkedListAndANode_LinkedListWithNewNodeAtTheEnd()
        {
            var singlyLinkedList = new Practice.LinkedLists.SinglyLinkedList();
            singlyLinkedList.AddAtTail(3);
            singlyLinkedList.AddAtTail(23);
            singlyLinkedList.AddAtTail(11);
            
            //act
            singlyLinkedList.AddAtIndex(1, 12);
            Assert.Equal(3, singlyLinkedList.Head.Value);
            Assert.Equal(12, singlyLinkedList.Head.Next.Value);
        }

        [Fact]
        public void GetNode_SinglyLinkedListAndANode_LinkedListWithNewNodeAtTheEnd()
        {
            var singlyLinkedList = new Practice.LinkedLists.SinglyLinkedList();
            singlyLinkedList.AddAtTail(3);
            singlyLinkedList.AddAtTail(23);
            singlyLinkedList.AddAtTail(11);

            //act
            singlyLinkedList.GetNode(1);
            Assert.Equal(23, singlyLinkedList.Head.Next.Value);
        }
    }
}

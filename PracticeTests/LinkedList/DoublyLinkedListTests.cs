using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice.LinkedLists;

namespace PracticeTests.LinkedList
{
    public class DoublyLinkedListTests
    {


        [Fact]
        public void AddAtHead_EmptyDoublyLinkedList_LinkedListWithHead()
        {
            // arrange
            var sut = new DoublyLinkedList();

            // act 
            sut.AddAtHead(11);

            // assert
            Assert.Equal(11, sut.Head.Value);
            Assert.Null(sut.Head.Next);
            Assert.Null(sut.Head.Previous);
        }

        [Fact]
        public void AddAtHead_SinglyLinkedList_LinkedListWithNewNodeAtTheStart()
        {
            // arrange
            var sut = new DoublyLinkedList();
            sut.AddAtHead(12);

            // act
            sut.AddAtHead(3);

            //assert
            Assert.Equal(3, sut.Head.Value);
            Assert.Null(sut.Head.Previous);
            Assert.Equal(12, sut.Head.Next.Value);
        }

        [Fact]
        public void AddAtTail_EmptyDoublyLinkedList_LinkedListWithHead()
        {
            // arrange
            var sut = new DoublyLinkedList();

            // act 
            sut.AddAtTail(11);

            // assert
            Assert.Equal(11, sut.Head.Value);
            Assert.Null(sut.Head.Next);
            Assert.Null(sut.Head.Previous);
        }

        [Fact]
        public void AddAtTail_SinglyLinkedList_LinkedListWithNewNodeAtTheEnd()
        {
            // arrange
            var sut = new DoublyLinkedList();
            sut.AddAtHead(12);

            // act
            sut.AddAtTail(3);

            //assert
            Assert.Equal(12, sut.Head.Value); // same head
            Assert.Null(sut.Head.Previous);
            Assert.Equal(3, sut.Head.Next.Value);
            Assert.Null(sut.Head.Next.Next);
        }


        [Fact]
        public void AddAtIndex_EmptyDoublyLinkedList_LinkedListWithHead()
        {
            // arrange
            var sut = new DoublyLinkedList();

            // act 
            sut.AddAtIndex(0, 3);

            // assert
            Assert.Equal(3, sut.Head.Value);
            Assert.Null(sut.Head.Next);
            Assert.Null(sut.Head.Previous);
        }

        [Fact]
        public void AddAtIndex_SinglyLinkedList_LinkedListWithNewNode()
        {
            // arrange
            var sut = new DoublyLinkedList();
            sut.AddAtTail(12);
            sut.AddAtTail(3);

            // act
            sut.AddAtIndex(1, 8);

            //assert
            Assert.Equal(8, sut.Head.Next.Value); // same head
            Assert.Null(sut.Head.Previous);
            //Assert.Equal(3, sut.Head.Next.Value);
            //Assert.Null(sut.Head.Next.Next);
        }
    }
}
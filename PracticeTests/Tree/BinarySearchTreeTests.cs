using Practice.LinkedLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice.Tree;

namespace PracticeTests.Tree
{
    public class BinarySearchTreeTests
    {
        [Fact]
        public void Insert_EmptyBinaryTree_TreeWithRootNodeOnly()
        {
            // arrange
            var tree = new BinarySearchTree();

            // act 
            var actual = tree.Insert(3);

            // assert
            Assert.Equal(3, actual.Value);
            Assert.NotNull(actual);
        }

        [Fact]
        public void Insert_BinaryTreeAndValueLessThanHeadValue_TreeWithNodeAtLeft()
        {
            // arrange
            var tree = new BinarySearchTree();
            var head = tree.Insert(5);

            // act 
            var actual = tree.Insert(3);

            // assert
            Assert.Equal(3, actual.Left.Value);
            Assert.NotNull(head.Left);
            Assert.Null(head.Right);
        }

        [Fact]
        public void Insert_BinaryTreeAndValueGreaterThanHeadValue_TreeWithNodeAtRight()
        {
            // arrange
            var tree = new BinarySearchTree();
            var head = tree.Insert(4);
            tree.Insert(2);
            tree.Insert(7);

            // act 
            var actual = tree.Insert(8);

            // assert
            Assert.Equal(head.Value, actual.Value);
            Assert.NotNull(head.Right.Right);
            Assert.Null(head.Left.Left);
        }

        [Fact]
        public void Search_BinaryTreeAndValueExist_NodeWithGivenValue()
        {
            // arrange
            var tree = new BinarySearchTree();
            var head = tree.Insert(4);
            tree.Insert(2);
            tree.Insert(7);
            tree.Insert(1);
            tree.Insert(3);

            // act 
            var actual = tree.Search(head, 2);

            // assert
            Assert.Equal(2, actual.Value);
        }

        [Fact]
        public void Search_BinaryTreeAndValueNotExist_Null()
        {
            // arrange
            var tree = new BinarySearchTree();
            var head = tree.Insert(4);
            tree.Insert(2);
            tree.Insert(7);
            tree.Insert(1);
            tree.Insert(3);

            // act 
            var actual = tree.Search(head, 5);

            // assert
            Assert.Null(actual);
        }

        [Fact]
        public void SearchRecursive_BinaryTreeAndValueExist_NodeWithGivenValue()
        {
            // arrange
            var tree = new BinarySearchTree();
            var head = tree.Insert(4);
            tree.Insert(2);
            tree.Insert(7);
            tree.Insert(1);
            tree.Insert(3);

            // act 
            var actual = tree.SearchRecursive(head, 2);

            // assert
            Assert.Equal(2, actual.Value);
        }

        [Fact]
        public void SearchRecursive_BinaryTreeAndValueNotExist_Null()
        {
            // arrange
            var tree = new BinarySearchTree();
            var head = tree.Insert(4);
            tree.Insert(2);
            tree.Insert(7);
            tree.Insert(1);
            tree.Insert(3);

            // act 
            var actual = tree.SearchRecursive(head, 5);

            // assert
            Assert.Null(actual);
        }

        [Fact]
        public void IsValid_BinaryTreeValid_True()
        {
            // arrange
            var tree = new BinarySearchTree();
            var head = tree.Insert(4);
            tree.Insert(2);
            tree.Insert(7);
            tree.Insert(1);
            tree.Insert(3);

            // act 
            var actual = tree.IsValid(head);

            // assert
            Assert.True(actual);
        }
    }
}

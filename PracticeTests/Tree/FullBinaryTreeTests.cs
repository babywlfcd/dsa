using Practice.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTests.Tree
{
    public class FullBinaryTreeTests
    {
        [Fact]
        public void Insert_EmptyFullBinaryTree_TreeWithRootNodeOnly()
        {
            // arrange
            var sut = new FullBinaryTree();

            // act 
            var actual = sut.Insert(3);

            // assert
            Assert.Equal(3, actual.Value);
            Assert.Null(actual.Left);
            Assert.Null(actual.Right);
        }

        [Fact]
        public void Insert_NoEmptyFullBinaryTree_AddNodeToLeftIfLeftIsNull()
        {
            // arrange
            var tree = new FullBinaryTree();
            tree.Insert(1);
            tree.Insert(2);
            tree.Insert(3);
            tree.Insert(null);
            tree.Insert(null);
            tree.Insert(4);

            // act 
            var actual = tree.Insert(5);

            // assert
            Assert.Null(actual.Left.Left.Value);
            Assert.Null(actual.Left.Right.Value);
            Assert.Equal(5, actual.Right.Right.Value);
            Assert.NotNull(actual.Right.Left);
            Assert.NotNull(actual.Right.Right);
        }

        [Fact]
        public void Insert_NoEmptyFullBinaryTree_AddNodeToRightIfRightIsNull()
        {
            // arrange
            var tree = new CompleteBinaryTree();
            tree.Insert(1);
            tree.Insert(2);
            tree.Insert(3);
            tree.Insert(4);

            // act 
            var actual = tree.Insert(5);

            // assert
            Assert.Equal(4, actual.Left.Left.Value);
            Assert.NotNull(actual.Left.Left);
            Assert.NotNull(actual.Left.Right);
            Assert.Null(actual.Right.Left);
        }
    }
}

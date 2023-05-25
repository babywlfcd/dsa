using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice.Course.Class;
using Practice.Tree;

namespace PracticeTests.Course.Class
{
    public class Week6TreeTraversalTests
    {
        [Fact]
        public void LevelTraversal_Tree_NodesFromLevelTraversal()
        {
            var tree = new BinarySearchTree();
            tree.Insert(5);
            tree.Insert(1);
            tree.Insert(9);
            tree.Insert(2);
            tree.Insert(8);
            tree.Insert(3);
            tree.Insert(7);
            tree.Insert(6);
            tree.Insert(5);

            var expected = new List<int?> {5, 1, 9, 2, 8, 3, 7, 6, 5};
            var sut = new Week6TreeTraversals();
            var actual = sut.LevelTraversal(tree.Head);

            Assert.Equal(expected, actual);


        }
    }
}

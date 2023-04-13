using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Tree
{
    public class BSTreeNode
    {
        public int val;
        public BSTreeNode? left;
        public BSTreeNode? right;
        public BSTreeNode(int val = 0, BSTreeNode? left = null, BSTreeNode? right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}

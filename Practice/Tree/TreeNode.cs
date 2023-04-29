using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Tree
{
    public class TreeNode
    {
        public int Value;
        public TreeNode[] Children;
        public TreeNode(int val = 0, TreeNode[] children = null, TreeNode? right = null)
        {
            Value = val;
            Children = children;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Tree
{
    public class TreeNode
    {
        public int? Value;
        public TreeNode[] Children;

        public TreeNode(int? val, TreeNode[] children = null)
        {
            Value = val;
            Children = children;
        }
    }
}

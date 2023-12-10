using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Tree
{
    /// <summary>
    /// Binary tree node
    /// </summary>
    public class Node
    {
        // full binary tree can have null nodes
        public int? Value;
        public Node Left;
        public Node Right;
        public Node(int? value = null, Node left = null, Node right = null)
        {
            Value = value;
            Left = left;
            Right = right;
        }
    }
}

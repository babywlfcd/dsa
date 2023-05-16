using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Tree
{
    public class BinaryNode
    {
        public int? Value;
        public BinaryNode? Left;
        public BinaryNode? Right;
        public BinaryNode(int val = 0, BinaryNode? left = null, BinaryNode? right = null)
        {
            this.Value = val;
            this.Left = left;
            this.Right = right;
        }
    }
}

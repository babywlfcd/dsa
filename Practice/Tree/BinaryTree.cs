using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Practice.Tree
{
    /// <summary>
    /// Binary tree implementation / Full Binary tree
    /// This implementation can be used also to construct Full Binary Tree
    /// Full Binary Tree 
    /// Is a special binary tree where every node has either 2 children or 0 children.
    /// </summary>
    public class BinaryTree
    {
        public Node Head;
        public BinaryTree(Node head = null)
        {
            Head = head;
        }

        /// <summary>
        /// similar with  Complete binary tree but can add null node
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Node Insert(int? value)
        {
            var newNode = new Node(value);

            if (Head == null)
                return Head = newNode;

            var nodes = new Queue<Node>();
            nodes.Enqueue(Head);

            while (nodes.Count != 0)
            {
                var current = nodes.Peek();
                //check children of the current node

                if (current.Left == null)
                {
                    current.Left = newNode;
                    break;
                }

                if (current.Right == null)
                {
                    current.Right = newNode;
                    break;
                }

                nodes.Dequeue();
                nodes.Enqueue(current.Left);
                nodes.Enqueue(current.Right);
            }

            return Head;
        }
    }
}

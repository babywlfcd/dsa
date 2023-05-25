using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Tree
{
    /// <summary>
    /// Complete Binary tree is a special binary tree where all the levels of the tree
    /// are filled completely except the lowest level nodes which are filled from as left as possible
    /// Properties of CBT:
    ///     A complete binary tree is said to be a proper binary tree where all leaves have the same depth.
    ///     In a complete binary tree number of nodes at depth d is 2d.
    ///     In a  complete binary tree with n nodes height of the tree is log(n+1).
    ///     All the levels except the last level are completely full.
    /// </summary>
    public class CompleteBinaryTree
    {
        public Node Head;
        public CompleteBinaryTree(Node head = null)
        {
            Head = head;
        }
        /*
        /// <summary>
        /// T.C -> O(n^2)
        /// S.C -> O(1)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public bool IsValid(Node head)
        {
            var current = head;
            while (current != null && current.Left != null)
            {
                if (current.Left.Value >= head.Value)
                    return false;
                current = current.Left;
            }

            while (current != null && current.Right != null)
            {
                if (current.Value >= current.Right.Value)
                    return false;
                current = current.Right;
            }

            return true;
        }*/

        public Node Insert(int value)
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

        /*public Node Search(Node head, int val)
        {
            var current = head;
            while (current != null)
            {
                if (val == current.Value)
                    return current;

                if (val < current.Value)
                    current = current.Left;
                else
                    current = current.Right;
            }

            return current;
        }

        public Node SearchRecursive(Node head, int val)
        {
            var current = head;
            while (current != null)
            {
                if (val == current.Value)
                    return current;

                if (val < current.Value)
                    current = SearchRecursive(current.Left, val);
                else
                    current = SearchRecursive(current.Right, val);
            }

            return current;
        }*/
    }
}

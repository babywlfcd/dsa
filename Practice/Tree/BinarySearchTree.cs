using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Tree
{
    /// <summary>
    /// Binary Search Tree card
    /// https://leetcode.com/explore/learn/card/introduction-to-data-structure-binary-search-tree/
    /// </summary>
    public class BinarySearchTree
    {
        public Node Head;
        public BinarySearchTree(Node head = null)
        {
            Head = head;
        }

        /// <summary>
        /// Medium
        /// 98. Validate Binary Search Tree
        /// https://leetcode.com/problems/validate-binary-search-tree/description/
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public bool IsValid(Node head)
        {
            var current = head;
            while (current != null && current.Left != null)
            {
                if (current.Value < current.Left.Value)
                    return false;
                current = current.Left;
            }

            while (current != null && current.Right != null)
            {
                if (current.Value > current.Right.Value)
                    return false;
                current = current.Right;
            }

            return true;
        }

        /// <summary>
        /// Medium
        /// 701. Insert into a Binary Search Tree
        /// https://leetcode.com/problems/insert-into-a-binary-search-tree/
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Node Insert(int value)
        {
            if (Head == null)
                return Head = new Node(value);

            var currentNode = Head;
            while (true)
            {
                if (value < currentNode.Value)
                {
                    if (currentNode.Left == null)
                    {
                        currentNode.Left = new Node(value);
                        break;
                    }

                    currentNode = currentNode.Left;
                }
                else
                {
                    if (currentNode.Right == null)
                    {
                        currentNode.Right = new Node(value);
                        break;
                    }

                    currentNode = currentNode.Right;
                }
            }

            return Head;
        }

        public Node Search(Node head, int val)
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
        }
    }
}

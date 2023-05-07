using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Practice.Tree;

namespace Practice.Course.Assignments
{
    public class TreesAssignment
    {
        /// <summary>
        /// Easy - LNR
        /// 1. InOrder Traversal - LNR
        /// https://leetcode.com/problems/binary-head-inorder-traversal/
        /// T.C -> O(n) - where n = no of nodes
        /// S.C -> O(h) where h = height of head
        /// </summary>
        /// <param name="head"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public List<int> InOrderTraverse(Node head, List<int> result)
        {
            if (head?.Left != null)
                InOrderTraverse(head.Left, result);

            if (head == null) return result;
            result.Add(head.Value);

            if (head.Right != null)
                InOrderTraverse(head.Right, result);

            return result;
        }

        /// <summary>
        /// 2. PreOrder Traversal - NLR
        /// T.C -> O(n) - where n = no of nodes
        /// S.C -> O(h) where h = height of head
        /// </summary>
        /// <param name="head"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public List<int> PreOrderTraverse(Node head, List<int> result)
        {
            result.Add(head.Value);

            if (head.Left != null)
                PreOrderTraverse(head.Left, result);

            if (head.Right != null)
                PreOrderTraverse(head.Right, result);
            return result;
        }

        /// <summary>
        /// 3. PostOrder Traversal LRN
        /// T.C -> O(n) - where n = no of nodes
        /// S.C -> O(h) where h = height of head
        /// </summary>
        /// <param name="result"></param>
        /// <param name="array"></param>
        /// <returns></returns>
        public List<int> PostOrderTraverse(Node result, List<int> array)
        {
            if (result.Left != null)
                PostOrderTraverse(result.Left, array);

            if (result.Right != null)
                PostOrderTraverse(result.Right, array);

            array.Add(result.Value);

            return array;
        }

        /// <summary>
        /// 4. Binary Tree From Inorder And Postorder
        /// </summary>
        /// <param name="inOrder"></param>
        /// <param name="postOrder"></param>
        /// <returns></returns>
        public List<int> ConstructTree(int[] inOrder, int[] postOrder)
        {
            var result = new List<int>();


            return result;
        }

        public List<int[]> TraverseLevelFromLEftToRight(Node root)
        {
            var result = new List<int[]>();

            var nodes = new Queue<int>();

            nodes.Enqueue(root.Value);

            while (nodes.Any())
            {

                var x = nodes.Dequeue();
            }

            return result;
        }

    }
}

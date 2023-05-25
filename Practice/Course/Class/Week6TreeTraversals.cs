using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice.Tree;

namespace Practice.Course.Class
{
    public class Week6TreeTraversals
    {
        /// <summary>
        /// Binary Tree PreOrder Traversal - NLR
        /// T.C -> O(n) - where n = no of nodes
        /// S.C -> O(h) where h = height of head
        /// </summary>
        /// <param name="tree"></param>
        /// <param name="array"></param>
        /// <returns></returns>
        public List<int?> PreOrderTraverse(Node root, List<int?> treeNodes)
        {
            if(root == null)
                return treeNodes;
            
            treeNodes.Add(root.Value);
                
            PreOrderTraverse(root.Left, treeNodes);

            PreOrderTraverse(root.Right, treeNodes);

            return treeNodes;
        }

        /// <summary>
        /// Binary Tree InOrder Traversal - LNR
        /// T.C -> O(n) - where n = no of nodes
        /// S.C -> O(h) where h = height of head
        /// </summary>
        /// <param name="head"></param>
        /// <param name="treeNodes"></param>
        /// <returns></returns>
        public List<int?> InOrderTraverse(Node head, List<int?> treeNodes)
        {
            if (head == null)
                return treeNodes;

            InOrderTraverse(head.Left, treeNodes);

            treeNodes.Add(head.Value);

            InOrderTraverse(head.Right, treeNodes);

            return treeNodes;
        }


        /// <summary>
        /// Binary Tree PostOrder Traversal - LRN
        /// T.C -> O(n) - where n = no of nodes
        /// S.C -> O(h) where h = height of head
        /// </summary>
        /// <param name="head"></param>
        /// <param name="treeNodes"></param>
        /// <returns></returns>
        public List<int?> PostOrderTraverse(Node head, List<int?> treeNodes)
        {
            if (head == null)
                return treeNodes;
            
            PostOrderTraverse(head.Left, treeNodes);

            PostOrderTraverse(head.Right, treeNodes);

            treeNodes.Add(head.Value);

            return treeNodes;
        }

        // Level order traversal from the left to right
        public List<int?> LevelTraversal(Node head)
        {
            var result = new List<int?>();

            var nodes = new Queue<int?>();

            nodes.Enqueue(head.Value);
            var current = head;
            while (nodes.Any())
            {
                
                var x = nodes.Dequeue();
                result.Add(x);

                if (current.Left != null)
                {
                    nodes.Enqueue(current.Left.Value);
                    current = current.Left;
                }

                if (current.Right != null)
                {
                    nodes.Enqueue(current.Right.Value);
                    current = current.Right;
                }
            }

            return result;
        }
    }
}

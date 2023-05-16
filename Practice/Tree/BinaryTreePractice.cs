using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Tree
{
    public class BinaryTreePractice
    {
        private List<int?> result = new List<int?>();
        public List<int?> PreOrder(BinaryNode? root)
        {
            if(root == null)
                return result;

            result.Add(root.Value);
            PreOrder(root.Left);
            PreOrder(root.Right);

            return result;
        }

        public List<int?> InOrder(BinaryNode? root)
        {
            if (root == null)
                return result;
            
            PreOrder(root.Left);
            result.Add(root.Value);
            PreOrder(root.Right);

            return result;
        }

        public List<int?> PostOrder(BinaryNode? root)
        {
            if (root == null)
                return result;

            PreOrder(root.Left);
            PreOrder(root.Right);
            result.Add(root.Value);

            return result;
        }

    }
}

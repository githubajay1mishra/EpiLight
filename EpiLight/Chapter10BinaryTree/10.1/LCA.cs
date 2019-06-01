using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter10BinaryTree._10._1
{
    public class LeastCommonAncestor
    {
         public Node Find(Node root, int v1, int v2)
        {
            if (root == null)
            {
                return null;
            }

            if (root.Data == v1 || root.Data == v2)
            {
                return root;
            }

            Node lcaInLeft   = Find(root.Left, v1, v2);
            Node lcaInRight = Find(root.Right, v1, v2);

            if (lcaInLeft != null && lcaInRight != null)
            {
                return root;
            }

            return lcaInLeft ?? lcaInRight;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks
{
    public class SumOfLeftLeavesInBinaryTree
    {
        public void SumOfLeftLeavesInBinaryTreeMain()
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);

            Console.WriteLine(SumOfLeftLeaves(root));
        }

        public int SumOfLeftLeaves(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int sum = 0;
            if (root.left != null && root.left.left == null && root.left.right == null)
            {
                sum += root.left.val;
            }
            sum += SumOfLeftLeaves(root.left) + SumOfLeftLeaves(root.right);
            return sum;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

}

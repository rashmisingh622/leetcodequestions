using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions
{
    public class BinaryTreeHelper
    {
        public int SumOfLeftLeaves(TreeNode root)
        {
            return SumOfLeftLeaves(root, 0);
        }

        public int SumOfLeftLeaves(TreeNode root, int Sum)
        {
            if (root == null || root.left == null)
            {
                return Sum;
            }

            if (root.left != null && root.left.left == null && root.left.right == null)
            {
                Sum = Sum + root.left.val;
            }

            var leftSum = SumOfLeftLeaves(root.left, Sum);
            var rightSum = SumOfLeftLeaves(root.right, leftSum);

            return rightSum;
        }
    }
}

namespace LeetCode.Solutions;

public class MinimumDepthOfBinaryTree
{
    public int MinDepth(TreeNode root)
    {
        int path = 0;
        if (root == null)
        {
            return path;
        }
        return MinDepth(root, path + 1);

    }
    public int MinDepth(TreeNode root, int path = 1)
    {
        if (root == null || (root.right == null && root.left == null))
        {
            return path;
        }

        int left = int.MaxValue;
        int right = int.MaxValue;

        if (root.left != null)
        {
            left = MinDepth(root.left, path + 1);
        }
        if (root.right != null)
        {
            right = MinDepth(root.right, path + 1);
        }
        return Math.Min(left, right);
    }
}

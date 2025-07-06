namespace LeetCode.Solutions;

public class MaximumDepthOfBinaryTree
{
    public int Solve(TreeNode root)
    {
        int path = 0;
        return Path(root, path + 1);
    }
    public int Path(TreeNode root, int path)
    {
        if (root == null)
        {
            return 0;
        }
        int left = Path(root.left, path + 1);
        int right = Path(root.right, path + 1);
        if (left == 0 && right == 0)
        {
            return path;
        }
        if (left != 0 && right != 0)
        {
            return left > right ? left : right;
        }
        if (left == 0)
        {
            return right;
        }
        return left;
    }
}
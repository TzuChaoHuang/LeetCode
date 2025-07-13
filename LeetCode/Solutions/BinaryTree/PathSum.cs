namespace LeetCode.Solutions;

/// <summary>
/// Given the root of a binary tree and an integer targetSum, return true if the tree has a root-to-leaf path such that adding up all the values along the path equals targetSum.
/// https://leetcode.com/problems/path-sum/description/
/// </summary>
public class PathSum()
{
    public bool HasPathSum(TreeNode root, int targetSum, int sum = 0)
    {
        if (root == null)
        {
            return false;
        }

        sum += root.val;
        if (sum == targetSum)
        {
            if (root.left == null && root.right == null)
            {
                return true;
            }
        }

        return HasPathSum(root.left, targetSum, sum) ? true : HasPathSum(root.right, targetSum, sum) ? true : false;
    }
}
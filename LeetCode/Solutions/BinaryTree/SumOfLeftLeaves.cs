namespace LeetCode.Solutions;

/// <summary>
/// Given the root of a binary tree, return the sum of all left leaves.
/// https://leetcode.com/problems/sum-of-left-leaves/description/
/// </summary>
public class SumOfLeftLeaves
{
    public int Solve(TreeNode root)
    {
        return SearchLeftNode(root, false);
    }
    public int SearchLeftNode(TreeNode root, bool isLeft)
    {
        if (root == null)
        {
            return 0;
        }
        int left = SearchLeftNode(root.left, true);
        int right = SearchLeftNode(root.right, false);
        return ((root.left == null && root.right == null && isLeft) ? root.val : 0) + left + right;
    }
}
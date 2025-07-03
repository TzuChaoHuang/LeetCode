namespace LeetCode.Solutions;

/// <summary>
/// Given the root of a binary tree, check whether it is a mirror of itself (i.e., symmetric around its center).
/// https://leetcode.com/problems/symmetric-tree/description/
/// </summary>
public class SymmetricTree
{
    public bool Solve(TreeNode root)
    {
        return IsSymmetric(root.left, root.right);
    }
    bool IsSymmetric(TreeNode leftNode, TreeNode rightNode)
    {
        if (leftNode == null && rightNode == null)
        {
            return true;
        }
        if (leftNode?.val == rightNode?.val)
        {
            return IsSymmetric(leftNode?.left, rightNode?.right) && IsSymmetric(leftNode?.right, rightNode?.left);
        }
        return false;
    }

}
using System.Security.AccessControl;

namespace LeetCode.Solutions;

/// <summary>
/// Given a binary tree, determine if it is height-balanced.
/// https://leetcode.com/problems/balanced-binary-tree/description/
/// </summary>
public class BalancedBinaryTree
{
    public bool IsBalanced(TreeNode root)
    {
        return GetHeight(root) == -1 ? false : true;
    }
    public int GetHeight(TreeNode root)
    {
        if (root == null) return 0;
        int left = GetHeight(root.left);
        if (left == -1) return -1;
        int right = GetHeight(root.right);
        if (right == -1) return -1;
        int res;
        if (Math.Abs(left - right) > 1)
        {
            res = -1;
        }
        else
        {
            res = 1 + Math.Max(left, right);
        }
        return res;
    }
}
namespace LeetCode.Solutions;

/// <summary>
/// Given the root of a binary tree, determine if it is a valid binary search tree (BST).
/// https://leetcode.com/problems/validate-binary-search-tree/description/
/// </summary>
public class ValidateBinarySearchTree
{
    long minVal = Int64.MinValue;
    public bool IsValidBST(TreeNode root)
    {
        if (root == null)
        {
            return true;
        }
        bool left = IsValidBST(root.left);
        if (left && root.val > minVal)
        {
            minVal = root.val;
        }
        else
        {
            return false;
        }
        bool right = IsValidBST(root.right);
        return right;
    }
}
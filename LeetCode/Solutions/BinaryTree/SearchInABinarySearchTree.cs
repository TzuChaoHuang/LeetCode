namespace LeetCode.Solutions;

/// <summary>
/// You are given the root of a binary search tree (BST) and an integer val.
/// https://leetcode.com/problems/search-in-a-binary-search-tree/description/
/// </summary>
public class SearchInABinarySearchTree
{
    public TreeNode SearchBST(TreeNode root, int val)
    {
        if (root == null)
        {
            return null;
        }

        if (root.val == val)
        {
            return root;
        }
        else if (root.val < val)
        {
            return SearchBST(root.right, val);
        }
        else
        {
            return SearchBST(root.left, val);
        }
    }
}
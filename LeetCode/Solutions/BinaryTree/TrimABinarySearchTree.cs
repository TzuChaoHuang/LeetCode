namespace LeetCode.Solutions;

/// <summary>
/// Given the root of a binary search tree and the lowest and highest boundaries as low and high, trim the tree so that all its elements lies in [low, high]. Trimming the tree should not change the relative structure of the elements that will remain in the tree (i.e., any node's descendant should remain a descendant). It can be proven that there is a unique answer.
/// https://leetcode.com/problems/trim-a-binary-search-tree/description/
/// </summary>
public class TrimABinarySearchTree
{
    public TreeNode TrimBST(TreeNode root, int low, int high)
    {
        if (root == null) return null;
        if (root.val < low)
            return TrimBST(root.right, low, high);

        if (root.val > high)
            return TrimBST(root.left, low, high);

        root.left = TrimBST(root.left, low, high);
        root.right = TrimBST(root.right, low, high);
        return root;
    }
}
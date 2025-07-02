namespace LeetCode.Solutions;

/// <summary>
/// Given the root of a binary tree, invert the tree, and return its root.
/// https://leetcode.com/problems/invert-binary-tree/description/
/// </summary>
public class InvertBinaryTree
{
    public TreeNode Solve(TreeNode root)
    {
        Swap(root);
        return root;
    }
    public void Swap(TreeNode root)
    {
        if (root == null)
            return;
        TreeNode temp = root.left;
        root.left = root.right;
        root.right = temp;
        Swap(root.left);
        Swap(root.right);
    }
}
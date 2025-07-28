namespace LeetCode.Solutions;

/// <summary>
/// You are given the root node of a binary search tree (BST) and a value to insert into the tree. Return the root node of the BST after the insertion. It is guaranteed that the new value does not exist in the original BST.
/// https://leetcode.com/problems/insert-into-a-binary-search-tree/description/
/// </summary>
public class InsertIntoABinarySearchTree
{
    public TreeNode InsertIntoBST(TreeNode root, int val)
    {
        if (root == null) return new TreeNode(val);

        if (root.val > val) root.left = InsertIntoBST(root.left, val);
        if (root.val < val) root.right = InsertIntoBST(root.right, val);
        return root;
    }
}
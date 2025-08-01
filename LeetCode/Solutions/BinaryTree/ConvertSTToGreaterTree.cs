namespace LeetCode.Solutions;

/// <summary>
/// Given the root of a Binary Search Tree (BST), convert it to a Greater Tree such that every key of the original BST is changed to the original key plus the sum of all keys greater than the original key in BST.
/// https://leetcode.com/problems/convert-bst-to-greater-tree/description/
/// </summary>
public class ConvertSTToGreaterTree
{
    int sum = 0;
    public TreeNode ConvertBST(TreeNode root)
    {
        if (root == null)
        {
            return null;
        }
        MapBst(root);
        return root;
    }
    public void MapBst(TreeNode root)
    {
        if (root == null)
        {
            return;
        }
        MapBst(root.right);
        sum += root.val;
        root.val = sum;
        MapBst(root.left);
    }
}
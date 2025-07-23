namespace LeetCode.Solutions;

/// <summary>
/// Given the root of a Binary Search Tree (BST), return the minimum absolute difference between the values of any two different nodes in the tree.
/// https://leetcode.com/problems/minimum-absolute-difference-in-bst/description/
/// </summary>
public class MinimumAbsoluteDifferenceInBST
{
    public TreeNode previous = null;
    public int gap = Int32.MaxValue;
    public int GetMinimumDifference(TreeNode root)
    {
        GetDifference(root);
        return gap;
    }
    public void GetDifference(TreeNode root)
    {
        if (root == null)
        {
            return;
        }
        GetDifference(root.left);
        if (previous != null)
        {
            int temp = root.val - previous.val;
            if (temp < gap)
            {
                gap = temp;
            }
        }
        previous = root;
        GetDifference(root.right);
    }
}
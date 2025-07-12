namespace LeetCode.Solutions;

/// <summary>
/// Given the root of a binary tree, return the leftmost value in the last row of the tree.
/// https://leetcode.com/problems/find-bottom-left-tree-value/description/
/// </summary>
public class FindBottomLeftTreeValue()
{
    int maxPath = -1;
    int leftMostNode = 0;
    public int FindBottomLeftValue(TreeNode root)
    {
        DFSleftMostNode(root, 0);
        return leftMostNode;
    }
    public void DFSleftMostNode(TreeNode root, int path)
    {
        if (root == null)
        {
            return;
        }

        if (root.left == null && root.right == null)
        {
            if (path > maxPath)
            {
                maxPath = path;
                leftMostNode = root.val;
            }
            return;
        }
        DFSleftMostNode(root.left, path + 1);
        DFSleftMostNode(root.right, path + 1);
    }
}
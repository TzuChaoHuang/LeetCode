namespace LeetCode.Solutions;

/// <summary>
/// You are given two binary trees root1 and root2.
/// https://leetcode.com/problems/merge-two-binary-trees/description/
/// </summary>
public class MergeTwoBinaryTrees()
{
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
    {
        if (root1 == null)
        {
            return root2;
        }
        if (root2 == null)
        {
            return root1;
        }

        var root = new TreeNode(root1.val + root2.val);
        root.left = MergeTrees(root1.left, root2.left);
        root.right = MergeTrees(root1.right, root2.right);

        return root;
    }
}
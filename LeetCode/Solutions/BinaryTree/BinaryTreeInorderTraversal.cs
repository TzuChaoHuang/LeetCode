namespace LeetCode.Solutions;

/// <summary>
/// Given the root of a binary tree, return the inorder traversal of its nodes' values.
/// https://leetcode.com/problems/binary-tree-inorder-traversal/description/
/// </summary>
public class BinaryTreeInorderTraversal
{
    public IList<int> Solve(TreeNode root)
    {
        List<int> ans = new List<int>();
        MapTree(root, ans);
        return ans;
    }
    private void MapTree(TreeNode root, List<int> ans)
    {
        if (root == null)
        {
            return;
        }
        MapTree(root.left, ans);
        ans.Add(root.val);
        MapTree(root.right, ans);
    }
}
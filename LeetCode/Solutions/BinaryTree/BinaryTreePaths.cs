namespace LeetCode.Solutions;

/// <summary>
/// Given the root of a binary tree, return all root-to-leaf paths in any order.
/// https://leetcode.com/problems/binary-tree-paths/description/
/// </summary>
public class BinaryTreePaths
{
    public IList<string> Solve(TreeNode root)
    {
        List<string> paths = new();
        if (root == null)
        {
            return paths;
        }
        Path(root, "", paths);
        return paths;
    }
    public void Path(TreeNode root, string path, List<string> paths)
    {
        path += string.IsNullOrEmpty(path) ? root.val : "->" + root.val;
        if (root.right == null && root.left == null)
        {
            paths.Add(path);
            return;
        }

        if (root.left != null)
        {
            Path(root.left, path, paths);
        }
        if (root.right != null)
        {
            Path(root.right, path, paths);
        }
    }
}
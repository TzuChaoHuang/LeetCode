namespace LeetCode.Solutions;

public class InvertBinaryTree
{
    public TreeNode Solve(TreeNode root)
    {
        swip(root);
        return root;
    }
    public void swip(TreeNode root)
    {
        if (root == null)
            return;
        if (root.right != null && root.left != null)
        {
            TreeNode node1 = root.left;
            TreeNode node2 = root.right;
            root.left = node1.val > node2.val ? node1 : node2;
            root.right = node1.val > node2.val ? node2 : node1;
        }
        else if (root.left == null && root.right != null)
        {
            root.left = root.right;
            root.right = null;
        }
        if (root.left != null)
            swip(root.left);
        if (root.right != null)
            swip(root.right);
    }
}
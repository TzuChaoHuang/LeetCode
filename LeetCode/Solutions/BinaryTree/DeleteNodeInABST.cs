namespace LeetCode.Solutions;

/// <summary>
/// Given a root node reference of a BST and a key, delete the node with the given key in the BST. Return the root node reference (possibly updated) of the BST.
/// https://leetcode.com/problems/delete-node-in-a-bst/description/
/// </summary>
public class DeleteNodeInABST
{
    public TreeNode DeleteNode(TreeNode root, int key)
    {
        if (root == null)
        {
            return null;
        }
        if (root.val == key)
        {
            if (root.left == null && root.right == null) return null;
            if (root.left == null && root.right != null) return root.right;
            if (root.left != null && root.right == null) return root.left;
            if (root.left != null && root.right != null)
            {
                TreeNode leftNode = root.right;
                while (leftNode.left != null)
                    leftNode = leftNode.left;
                leftNode.left = root.left;
                return root.right;
            }
        }
        else if (root.val < key)
        {
            root.right = DeleteNode(root.right, key);
        }
        else if (root.val > key)
        {
            root.left = DeleteNode(root.left, key);
        }
        return root;
    }
}
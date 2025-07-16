namespace LeetCode.Solutions;

/// <summary>
/// Given two integer arrays inorder and postorder where inorder is the inorder traversal of a binary tree and postorder is the postorder traversal of the same tree, construct and return the binary tree.
/// https://leetcode.com/problems/construct-binary-tree-from-inorder-and-postorder-traversal/description/
/// </summary>
public class ConstructBinaryTreeFromInorderAndPostorderTraversal
{
    public TreeNode BuildTree(int[] inorder, int[] postorder)
    {
        if (inorder.Length == 0 || postorder.Length == 0)
        {
            return null;
        }
        int inIdx = inorder.Length - 1;
        var root = new TreeNode(postorder[postorder.Length - 1]);
        var stacks = new Stack<TreeNode>();
        stacks.Push(root);

        for (int i = postorder.Length - 2; i >= 0; i--)
        {
            var currentVal = postorder[i];
            var node = stacks.Peek();
            if (inorder[inIdx] != node.val)
            {
                node.right = new TreeNode(currentVal);
                stacks.Push(node.right);
            }
            else
            {
                while (stacks.Count > 0 && stacks.Peek().val == inorder[inIdx])
                {
                    node = stacks.Pop();
                    inIdx--;
                }
                node.left = new TreeNode(currentVal);
                stacks.Push(node.left);
            }

        }
        return root;
    }
}
namespace LeetCode.Solutions;

public class CountCompleteTreeNodes
{
    public int CountNodes(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        int count = 0;
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            count++;
            var node = queue.Dequeue();
            if (node.left != null)
            {
                queue.Enqueue(node.left);
            }
            if (node.right != null)
            {
                queue.Enqueue(node.right);
            }
        }

    }
}
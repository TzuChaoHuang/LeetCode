using System.Globalization;

namespace LeetCode.Solutions;

public class MaximumBinaryTree
{
   public TreeNode ConstructMaximumBinaryTree(int[] nums) {
        if (nums.Length == 0)
        {
            return null;
        }
        var root = new TreeNode(nums.Max());
        var rootIndex = Array.IndexOf(nums, root.val);
        root.left = ConstructMaximumBinaryTree(nums,0,rootIndex-1);
        root.right = ConstructMaximumBinaryTree(nums,rootIndex+1,nums.Length-1);
        return root;
    }

    public TreeNode ConstructMaximumBinaryTree(int[] nums, int start, int end)
    {
        if (start > end)
        {
            return null;
        }
        var root = new TreeNode(nums.Skip(start).Take(end-start+1).Max());
        var rootIndex = Array.IndexOf(nums, root.val);
        root.left = ConstructMaximumBinaryTree(nums,start,rootIndex-1);
        root.right = ConstructMaximumBinaryTree(nums,rootIndex+1,end);
        return root;
    }
}
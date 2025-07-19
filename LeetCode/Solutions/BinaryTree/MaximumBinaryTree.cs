using System.Globalization;

namespace LeetCode.Solutions;

/// <summary>
/// You are given an integer array nums with no duplicates. A maximum binary tree can be built recursively from nums using the following algorithm
/// https://leetcode.com/problems/maximum-binary-tree/description/
/// </summary>
public class MaximumBinaryTree
{
    public TreeNode ConstructMaximumBinaryTree(int[] nums)
    {
        return Construct(nums, 0, nums.Length - 1);
    }
    public TreeNode Construct(int[] nums, int left, int right)
    {
        if (left == right)
        {
            return new TreeNode(nums[left]);
        }
        int mid = (left + right) / 2;

        return Merge(
            Construct(nums, left, mid),
            Construct(nums, mid + 1, right)
        );
    }
    public TreeNode Merge(TreeNode leftTree, TreeNode rightTree)
    {
        if (leftTree == null)
        {
            return rightTree;
        }
        if (rightTree == null)
        {
            return leftTree;
        }
        if (leftTree.val > rightTree.val)
        {
            leftTree.right = Merge(leftTree.right, rightTree);
            return leftTree;
        }
        else
        {
            rightTree.left = Merge(leftTree, rightTree.left);
            return rightTree;
        }
    }
}
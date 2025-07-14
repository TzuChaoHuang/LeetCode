namespace LeetCode.Solutions;

/// <summary>
/// Given an integer array nums where the elements are sorted in ascending order, convert it to a height-balanced binary search tree.
/// https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/description/
/// </summary>
public class ConvertSortedArrayToBinarySearchTree
{
    public TreeNode SortedArrayToBST(int[] nums)
    {
        int mid = nums.Length / 2;
        var root = new TreeNode(val: nums[mid]);
        root.left = SortedArrayToBST(nums, 0, mid - 1);
        root.right = SortedArrayToBST(nums, mid + 1, nums.Length - 1);

        return root;
    }
    public TreeNode SortedArrayToBST(int[] nums, int start, int end)
    {
        if (start > end)
        {
            return null;
        }
        int mid = (start + end) / 2;
        var node = new TreeNode(val: nums[mid]);
        node.left = SortedArrayToBST(nums, start, mid - 1);
        node.right = SortedArrayToBST(nums, mid + 1, end);
        return node;
    }
}
namespace LeetCode.Solutions;

/// <summary>
/// Given the root of a binary search tree (BST) with duplicates, return all the mode(s) (i.e., the most frequently occurred element) in it.
/// https://leetcode.com/problems/find-mode-in-binary-search-tree/description/
/// </summary>
public class FindModeInBinarySearchTree
{
    public class Solution
    {
        public List<int> res = new List<int>();
        public int count = 0;
        public int maxCount = 0;
        public TreeNode pre = null;
        public int[] FindMode(TreeNode root)
        {
            SearchBST(root);
            return res.ToArray();
        }
        public void SearchBST(TreeNode root)
        {
            if (root == null) return;
            SearchBST(root.left);
            if (pre == null)
                count = 1;
            else if (pre.val == root.val)
                count++;
            else
                count = 1;

            pre = root;
            if (count == maxCount)
            {
                res.Add(root.val);
            }
            else if (count > maxCount)
            {
                res.Clear();
                res.Add(root.val);
                maxCount = count;
            }
            SearchBST(root.right);
        }
    }
}
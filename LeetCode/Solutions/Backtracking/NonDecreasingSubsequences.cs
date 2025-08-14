namespace LeetCode.Solutions;

/// <summary>
/// Given an integer array nums, return all the different possible non-decreasing subsequences of the given array with at least two elements. You may return the answer in any order.
/// https://leetcode.com/problems/non-decreasing-subsequences/description/
/// </summary>
public class NonDecreasingSubsequences
{
    public IList<IList<int>> res = new List<IList<int>>();
    public IList<int> path = new List<int>();
    public IList<IList<int>> FindSubsequences(int[] nums)
    {
        BackTracking(nums, 0);
        return res;
    }
    public void BackTracking(int[] nums, int start)
    {
        if (path.Count >= 2)
        {
            res.Add(new List<int>(path));
        }
        HashSet<int> hs = new HashSet<int>();
        for (int i = start; i < nums.Length; i++)
        {
            if (path.Count > 0 && path[path.Count - 1] > nums[i] || hs.Contains(nums[i]))
            {
                continue;
            }
            hs.Add(nums[i]);
            path.Add(nums[i]);
            BackTracking(nums, i + 1);
            path.RemoveAt(path.Count - 1);
        }
    }
}
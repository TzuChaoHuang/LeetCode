namespace LeetCode.Solutions;

/// <summary>
/// Given an integer array nums of unique elements, return all possible subsets (the power set).
/// https://leetcode.com/problems/subsets/description/
/// </summary>
public class Subsets
{
    public IList<IList<int>> res = new List<IList<int>>();
    public IList<int> path = new List<int>();
    public IList<IList<int>> Subset(int[] nums)
    {
        BackTracking(nums, 0);
        return res;
    }
    public void BackTracking(int[] nums, int start)
    {
        res.Add(new List<int>(path));
        if (start > nums.Length) return;
        for (int i = start; i < nums.Length; i++)
        {
            path.Add(nums[i]);
            BackTracking(nums, i + 1);
            path.RemoveAt(path.Count - 1);
        }
    }
}
namespace LeetCode.Solutions;

/// <summary>
/// Given an integer array nums that may contain duplicates, return all possible subsets (the power set).
/// https://leetcode.com/problems/subsets-ii/description/
/// </summary>
public class SubsetsII
{
    public IList<IList<int>> res = new List<IList<int>>();
    public IList<int> path = new List<int>();
    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        Array.Sort(nums);
        BackTracking(nums, 0);
        return res;
    }
    public void BackTracking(int[] nums, int start)
    {
        res.Add(new List<int>(path));
        for (int i = start; i < nums.Length; i++)
        {
            if (i > start && nums[i] == nums[i - 1]) continue;
            path.Add(nums[i]);
            BackTracking(nums, i + 1);
            path.RemoveAt(path.Count - 1);
        }
    }
}
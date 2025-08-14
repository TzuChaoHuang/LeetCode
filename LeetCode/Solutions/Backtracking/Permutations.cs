namespace LeetCode.Solutions;

/// <summary>
/// Given an array nums of distinct integers, return all the possible permutations. You can return the answer in any order.
/// https://leetcode.com/problems/permutations/description/
/// </summary>
public class Permutations
{
    public IList<IList<int>> res = new List<IList<int>>();
    public IList<int> path = new List<int>();
    public IList<IList<int>> Permute(int[] nums)
    {
        var used = new bool[nums.Length];
        BackTracking(nums, used);
        return res;
    }
    public void BackTracking(int[] nums, bool[] used)
    {
        if (path.Count == nums.Length)
        {
            res.Add(new List<int>(path));
            return;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (used[i]) continue;
            used[i] = true;
            path.Add(nums[i]);
            BackTracking(nums, used);
            used[i] = false;
            path.RemoveAt(path.Count - 1);
        }
    }
}
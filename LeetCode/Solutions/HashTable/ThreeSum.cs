namespace LeetCode.Solutions;

/// <summary>
/// Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
/// https://leetcode.com/problems/3sum/description/
/// </summary>
public class ThreeSum
{
    public IList<IList<int>> Solve(int[] nums)
    {
        // Check the current number is same as the previos one to avoid duplicate answers
        List<IList<int>> result = new();
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                return result;
            }
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }
            int left = i + 1;
            int right = nums.Length - 1;
            while (left < right)
            {
                if (nums[i] + nums[left] + nums[right] == 0)
                {
                    result.Add(new List<int>() { nums[i], nums[left], nums[right] });
                    left++;
                    right--;
                    while (left < right && nums[left] == nums[left - 1])
                    {
                        left++;
                    }
                    while (right > left && nums[right] == nums[right + 1])
                    {
                        right--;
                    }
                    continue;
                }
                if (nums[i] + nums[left] + nums[right] > 0)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
        }
        return result;
    }
}
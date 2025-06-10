namespace LeetCode.Solutions;

public class TwoSum
{
    /// <summary>
    /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    /// https://leetcode.com/problems/two-sum/description/
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public int[] Solve(int[] nums, int target)
    {
        /// Using HashMap to store the number and index 
        /// complement = target - nums[Current index];
        /// Check if complement is already in map ,return current index and HashMap[complement]
        Dictionary<int, int> seen = new();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (seen.ContainsKey(complement))
            {
                return new[] { seen[complement], i };
            }

            if (!seen.ContainsKey(nums[i]))
            {
                seen.Add(nums[i], i);
            }
        }

        return Array.Empty<int>();
    }
}
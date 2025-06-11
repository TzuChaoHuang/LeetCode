namespace LeetCode.Solutions;

public class MinimumSizeSubarraySum
{
    /// <summary>
    /// Given an array of positive integers nums and a positive integer target, return the minimal length of a subarray whose sum is greater than or equal to target. If there is no such subarray, return 0 instead.
    /// https://leetcode.com/problems/minimum-size-subarray-sum/description/
    /// </summary>
    /// <param name="target"></param>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int Solve(int target, int[] nums)
    {
        // Use k to record the start pointer
        // Use index to record the end pointer
        // If the sum is smaller than the target, add nums[index] to sum, then increment index by 1
        // If the sum is greater than the target, calculate the sublength, then subtract nums[k] from sum and increment k by 1
        int min = int.MaxValue;
        int index = 0;
        int k = 0;
        int sum = 0;
        while (index <= nums.Length)
        {
            if (sum < target)
            {
                if (index >= nums.Length)
                    break;
                sum += nums[index++];
            }

            if (sum >= target)
            {
                int subLength = index - 1 - k + 1;
                min = subLength < min ? subLength : min;
                sum -= nums[k++];
            }
        }

        return min == int.MaxValue ? 0 : min;

    }
}
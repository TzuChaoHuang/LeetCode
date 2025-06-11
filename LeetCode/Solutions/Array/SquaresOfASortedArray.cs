using System.ComponentModel;

namespace LeetCode.Solutions;

public class SquaresOfASortedArray
{
    /// <summary>
    /// Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.
    /// https://leetcode.com/problems/squares-of-a-sorted-array/description/
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] Solve(int[] nums)
    {
        // Use a new array to store the squares of the numbers
        // Compare nums[left] and nums[right], store the larger one in the new array
        int left = 0;
        int right = nums.Length - 1;
        int pow = right;
        int[] ans = new int[nums.Length];
        while (left <= right)
        {
            if (nums[left] * nums[left] < nums[right] * nums[right])
            {
                ans[pow--] = nums[right] * nums[right];
                right--;
            }
            else
            {
                ans[pow--] = nums[left] * nums[left];
                left++;
            }
        }
        return ans;
    }
}
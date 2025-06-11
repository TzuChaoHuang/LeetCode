using System.Runtime.InteropServices.Marshalling;

namespace LeetCode.Solutions;

public class RemoveElement
{
    /// <summary>
    /// Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The order of the elements may be changed. Then return the number of elements in nums which are not equal to val.
    /// https://leetcode.com/problems/remove-element/description/
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public int Solve(int[] nums, int val)
    {
        // Use k to record the excepted count
        // If nums[i] is not equal to val, assign nums[i] to nums[k] ,then k plus 1
        int k = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[k++] = nums[i];
            }
        }
        return k;
    }
}
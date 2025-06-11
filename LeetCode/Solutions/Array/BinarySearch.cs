namespace LeetCode.Solutions;


public class BinarySearch
{
    /// <summary>
    /// Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums. If target exists, then return its index. Otherwise, return -1.
    /// https://leetcode.com/problems/binary-search/description/
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public int Solve(int[] nums, int target)
    {
        // Calculate mid. If nums[mid] > target, set left = mid + 1; otherwise, set right = mid - 1.
        int left = 0;
        int right = nums.Length - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }
            if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1;
    }
}
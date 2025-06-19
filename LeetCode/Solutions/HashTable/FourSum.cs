namespace LeetCode.Solutions;

public class FourSum
{
    /// <summary>
    /// Given an array nums of n integers, return an array of all the unique quadruplets [nums[a], nums[b], nums[c], nums[d]] 
    /// https://leetcode.com/problems/4sum/description/
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public IList<IList<int>> Solve(int[] nums, int target)
    {
        // Convert int to long in case out of maxValue.
        if (nums.Length < 4)
        {
            return new List<IList<int>>();
        }
        List<IList<int>> result = new List<IList<int>>();
        Array.Sort(nums);
        for (int i = 0; i <= nums.Length - 4; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }
            for (int j = i + 1; j <= nums.Length - 2; j++)
            {
                if (j > (i + 1) && nums[j] == nums[j - 1])
                {
                    continue;
                }
                long targetSum = (long)target - nums[i] - nums[j];
                int left = j + 1;
                int right = nums.Length - 1;
                while (left < right)
                {
                    long sum = (long)nums[left] + nums[right];
                    if (sum == targetSum)
                    {
                        result.Add(new List<int>() { nums[i], nums[j], nums[left], nums[right] });

                        left++;
                        right--;
                        while (left < right && nums[left] == nums[left - 1])
                        {
                            left++;
                        }

                        while (left < right && nums[right] == nums[right + 1])
                        {
                            right--;
                        }
                    }
                    else if (sum < targetSum)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }

            }
        }
        return result;
    }
}
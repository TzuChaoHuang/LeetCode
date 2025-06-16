namespace LeetCode.Solutions;

/// <summary>
/// Given four integer arrays nums1, nums2, nums3, and nums4 all of length n, return the number of tuples (i, j, k, l) such that:
/// https://leetcode.com/problems/4sum-ii/
/// </summary>
public class FourSum2
{
    public int Solve(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        foreach (int num1 in nums1)
        {
            foreach (int num2 in nums2)
            {
                int gap = 0 - num1 - num2;
                if (map.ContainsKey(gap))
                {
                    map[gap]++;
                }
                else
                {
                    map.Add(gap, 1);
                }
            }
        }
        int count = 0;
        foreach (int num3 in nums3)
        {
            foreach (int num4 in nums4)
            {
                int gap = num3 + num4;
                if (map.ContainsKey(gap))
                {
                    count += map[gap];
                }
            }
        }
        return count;
    }
}
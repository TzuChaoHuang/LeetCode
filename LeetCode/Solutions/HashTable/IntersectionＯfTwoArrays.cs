namespace LeetCode.Solutions;

/// <summary>
/// Given two integer arrays nums1 and nums2, return an array of their intersection. Each element in the result must be unique and you may return the result in any order.
/// https://leetcode.com/problems/intersection-of-two-arrays/submissions/1663667262/
/// </summary>
public class IntersectionOfTwoArrays
{
    public int[] Solve(int[] nums1, int[] nums2)
    {
        // Use a Dictionary to store existing elements and a bool value to check whether each has been inserted or not.
        if (nums1.Length == 0 || nums2.Length == 0)
        {
            return new int[0];
        }
        var dic = new Dictionary<int, bool>() { { nums1[0], false } };
        List<int> ints = new List<int>();
        for (int i = 1; i < nums1.Length; i++)
        {
            dic[nums1[i]] = false;
        }

        foreach (int i in nums2)
        {
            if (dic.ContainsKey(i) && dic[i] == false)
            {
                ints.Add(i);
                dic[i] = true;
            }
        }

        return [.. ints];
    }

    public int[] SolveByArray(int[] nums1, int[] nums2)
    {
        // According to the description, the lengths of nums1 and nums2 are less than 1000,
        // so use a bool array to record the elements in nums1.
        // Then, check which elements in nums2 exist in the array,
        // and add those elements to the result list.
        if (nums1.Length == 0 || nums2.Length == 0)
        {
            return new int[0];
        }

        bool[] checkarr = new bool[1001];
        List<int> ints = new List<int>();
        foreach (int i in nums1)
        {
            checkarr[i] = true;
        }

        foreach (int i in nums2)
        {
            if (checkarr[i] == true)
            {
                checkarr[i] = false;
                ints.Add(i);
            }
        }

        return [.. ints];
    }
}
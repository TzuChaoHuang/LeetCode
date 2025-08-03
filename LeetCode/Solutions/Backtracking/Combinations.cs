namespace LeetCode.Solutions;

/// <summary>
/// Given two integers n and k, return all possible combinations of k numbers chosen from the range [1, n].
/// https://leetcode.com/problems/combinations/description/
/// </summary>
public class Combinations
{
    public IList<IList<int>> Combine(int n, int k)
    {
        List<IList<int>> res = new();
        for (int i = 1; i <= k; i++)
        {
            for (int l = i; l <= n; l++)
            {
                res.Add(new List<int>() { i, n });
            }
        }
        return (IList<IList<int>>)res;
    }
}
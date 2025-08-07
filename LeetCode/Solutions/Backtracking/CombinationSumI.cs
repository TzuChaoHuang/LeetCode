namespace LeetCode.Solutions;

/// <summary>
/// Given an array of distinct integers candidates and a target integer target, return a list of all unique combinations of candidates where the chosen numbers sum to target. You may return the combinations in any order.
/// https://leetcode.com/problems/combination-sum/description/
/// </summary>
public class CombinationSumI
{
    List<IList<int>> result = new();
    List<int> combine = new();
    int sum = 0;
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        Map(candidates, target, 0);
        return result;
    }
    public void Map(int[] c, int t, int s)
    {
        if (sum == t)
        {
            result.Add(new List<int>(combine));
            return;
        }
        if (sum > t)
        {
            return;
        }
        for (int i = s; i < c.Length; i++)
        {
            if (c[i] > t)
                continue;
            sum += c[i];
            combine.Add(c[i]);
            Map(c, t, i);
            sum -= c[i];
            combine.RemoveAt(combine.Count - 1);
        }
    }
}

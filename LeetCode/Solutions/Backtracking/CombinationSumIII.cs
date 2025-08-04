namespace LeetCode.Solutions;

/// <summary>
/// Find all valid combinations of k numbers that sum up to n 
/// https://leetcode.com/problems/combination-sum-iii/description/
/// </summary>
public class CombinationSumIII
{
    List<IList<int>> result = new();
    List<int> combine = new();
    public IList<IList<int>> CombinationSum3(int k, int n)
    {
        Map(k, n, 0, 1);
        return result;
    }
    public void Map(int k, int n, int sum, int l)
    {
        if (combine.Count == k)
        {
            if (sum == n)
            {
                result.Add(new List<int>(combine));
            }
            return;
        }
        for (int i = l; i <= 9; i++)
        {
            sum += i;
            combine.Add(i);
            Map(k, n, sum, i + 1);
            sum -= i;
            combine.RemoveAt(combine.Count - 1);
        }
    }
}
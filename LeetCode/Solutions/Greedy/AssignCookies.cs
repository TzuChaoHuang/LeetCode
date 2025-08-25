namespace LeetCode.Solutions;

/// <summary>
/// Assume you are an awesome parent and want to give your children some cookies. But, you should give each child at most one cookie.
/// https://leetcode.com/problems/assign-cookies/description/
/// </summary>
public class AssignCookies
{
    public int FindContentChildren(int[] g, int[] s)
    {
        Array.Sort(g);
        Array.Sort(s);
        int index = s.Length - 1;
        int ans = 0;
        for (int i = g.Length - 1; i >= 0; i--)
        {
            if (index < 0)
            {
                return ans;
            }
            if (g[i] <= s[index])
            {
                index--;
                ans++;
            }
        }
        return ans;
    }
}
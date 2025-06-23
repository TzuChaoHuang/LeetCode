using System.Text;

namespace LeetCode.Solutions;

/// <summary>
/// Given a string s, check if it can be constructed by taking a substring of it and appending multiple copies of the substring together.
/// https://leetcode.com/problems/repeated-substring-pattern/description/
/// </summary>
public class RepeatedSubstringPattern
{
    public bool Solve(string s)
    {
        int n = s.Length;

        for (int i = 1; i <= n / 2; i++)
        {
            if (n % i == 0)
            {
                string subString = s.Substring(0, i);
                StringBuilder pair = new StringBuilder();
                for (int j = 0; j < n / i; j++)
                {
                    pair.Append(subString);
                }

                if (pair.ToString() == s)
                {
                    return true;
                }
            }
        }
        return false;
    }
}
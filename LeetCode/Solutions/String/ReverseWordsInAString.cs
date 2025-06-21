namespace LeetCode.Solutions;

/// <summary>
/// Given an input string s, reverse the order of the words.
/// </summary>
public class ReverseWordsInAString
{
    public string Solve(string s)
    {
        string[] strings = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        string ans = string.Join(" ", strings.Reverse());
        return ans;
    }
}
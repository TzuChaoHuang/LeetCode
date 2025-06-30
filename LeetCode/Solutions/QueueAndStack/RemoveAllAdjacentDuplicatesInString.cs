namespace LeetCode.Solutions;

/// <summary>
/// You are given a string s consisting of lowercase English letters. A duplicate removal consists of choosing two adjacent and equal letters and removing them.
/// https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string/description/
/// </summary>
public class RemoveAllAdjacentDuplicatesInString
{
    public string Solve(string s)
    {
        Stack<char> chars = new Stack<char>() { };
        for (int i = 0; i < s.Length; i++)
        {
            if (chars.Count > 0 && s[i] == chars.Peek())
            {
                chars.Pop();
            }
            else
            {
                chars.Push(s[i]);
            }

        }
        return string.Join("", chars.Reverse());
    }
}
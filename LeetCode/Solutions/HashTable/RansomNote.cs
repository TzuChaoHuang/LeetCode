namespace LeetCode.Solutions;

/// <summary>
/// Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.
/// https://leetcode.com/problems/ransom-note/description/
/// </summary>
public class RansomNote
{
    public bool Solve(string ransomNote, string magazine)
    {
        if (ransomNote.Length > magazine.Length)
        {
            return false;
        }
        int[] letters = new int[26];
        foreach (char c in ransomNote)
        {
            letters[c - 'a']--;
        }

        foreach (char c in magazine)
        {
            letters[c - 'a']++;
        }

        foreach (int i in letters)
        {
            if (i < 0)
            {
                return false;
            }
        }
        return true;
    }
}

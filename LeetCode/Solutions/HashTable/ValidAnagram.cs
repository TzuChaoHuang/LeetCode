namespace LeetCode.Solutions;

/// <summary>
/// Given two strings s and t, return true if t is an anagram of s, and false otherwise.
/// https://leetcode.com/problems/valid-anagram/description/
/// </summary>
public class ValidAnagram
{
    public bool Solve(string s, string t)
    {
        // If the length of s doesn't equal the length of t, return false.
        // Count the letters in s using a Hashtable.
        // If any letter in t does not exist in the Hashtable or its count is zero, return false.
        Dictionary<char, int> dic = new();
        if (s.Length != t.Length)
        {
            return false;
        }
        foreach (char c in s)
        {
            if (dic.ContainsKey(c))
            {
                dic[c]++;
            }
            else
            {
                dic.Add(c, 1);
            }
        }
        foreach (char c in t)
        {
            if (dic.ContainsKey(c) && dic[c] > 0)
            {
                dic[c]--;
            }
            else
            {
                return false;
            }

        }
        return true;
    }
    public bool SolveByArray(string s, string t)
    {
        // If the length of s doesn't equal the length of t, return false.
        // Use an int array to count the letters in s and t.
        // Use ASCII values as indices to update the count.
        // Finally, check that all elements in the array are zero.
        if (s.Length != t.Length)
        {
            return false;
        }
        int[] letters = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            letters[s[i] - 'a']++;
            letters[t[i] - 'a']--;
        }

        foreach (int i in letters)
        {
            if (i != 0)
            {
                return false;
            }
        }

        return true;
    }
}
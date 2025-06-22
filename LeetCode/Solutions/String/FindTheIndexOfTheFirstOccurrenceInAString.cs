namespace LeetCode.Solutions;

/// <summary>
/// Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
/// https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/description/
/// </summary>
public class FindTheIndexOfTheFirstOccurrenceInAString
{
    public int StrStr(string haystack, string needle)
    {
        for (int i = 0; i <= haystack.Length - needle.Length; ++i)
        {
            if (haystack.Substring(i, needle.Length) == needle)
            {
                return i;
            }
        }
        return -1;
    }
}
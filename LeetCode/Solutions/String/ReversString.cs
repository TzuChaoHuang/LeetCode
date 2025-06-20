namespace LeetCode.Solutions;

public class ReversString
{
    /// <summary>
    /// Write a function that reverses a string. The input string is given as an array of characters s.
    /// https://leetcode.com/problems/reverse-string/description/
    /// </summary>
    /// <param name="s"></param>
    public void ReverseString(char[] s)
    {
        // use two pointer to swap the char
        int left = 0;
        int right = s.Length - 1;
        while (left < right)
        {
            char temp = s[left];
            s[left++] = s[right];
            s[right--] = temp;
        }
    }
}
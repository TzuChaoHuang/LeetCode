namespace LeetCode.Solutions;

/// <summary>
/// Given a string s and an integer k, reverse the first k characters for every 2k characters counting from the start of the string.
/// https://leetcode.com/problems/reverse-string-ii/description/
/// </summary>
public class ReverseString2
{
    public string Solve(string s, int k)
    {
        var arr = s.ToCharArray();
        for (int i = 0; i < arr.Length; i += 2 * k)
        {
            int left = i;
            int right = i + k < arr.Length ? i + k - 1 : arr.Length - 1;
            while (left < right)
            {
                char temp = arr[left];
                arr[left++] = arr[right];
                arr[right--] = temp;
            }
        }

        return new string(arr);
    }
}
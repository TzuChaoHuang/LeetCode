namespace LeetCode.Solutions;

/// <summary>
/// Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
/// https://leetcode.com/problems/roman-to-integer/description/?envType=problem-list-v2&envId=string
/// </summary>
public class RomanToInteger
{
    public int Solv(string s)
    {
        Dictionary<char, int> map = new Dictionary<char, int>() { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };
        int sum = 0;
        int last = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            int current = map[s[i]];
            if (current < last)
            {
                sum -= current;
            }
            else
            {
                sum += current;
            }

            last = current;
        }
        return sum;
    }
}
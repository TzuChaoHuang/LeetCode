using System.Text;

namespace LeetCode.Solutions;

/// <summary>
/// Roman numerals are formed by appending the conversions of decimal place values from highest to lowest
/// https://leetcode.com/problems/integer-to-roman/description/?envType=problem-list-v2&envId=string
/// </summary>
public class IntegerToRoman
{
    public string Solve(int num)
    {
        StringBuilder str = new();
        Dictionary<int, string> dic = new Dictionary<int, string>() { { 1000, "M" }, { 900, "CM" }, { 500, "D" }, { 400, "CD" }, { 100, "C" }, { 90, "XC" }, { 50, "L" }, { 40, "XL" }, { 10, "X" }, { 9, "IX" }, { 5, "V" }, { 4, "IV" }, { 1, "I" } };
        foreach (var map in dic)
        {
            var n = num / map.Key;
            for (int i = 0; i < n; i++)
            {
                str.Append(map.Value);
            }
            num = num % map.Key;
        }
        return str.ToString();
    }
}
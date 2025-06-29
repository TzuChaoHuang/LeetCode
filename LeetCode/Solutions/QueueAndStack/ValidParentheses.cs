using System.Collections;

namespace LeetCode.Solutions;

/// <summary>
/// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
/// https://leetcode.com/problems/valid-parentheses/description/
/// </summary>
public class ValidParentheses
{
    public bool Solve(string s)
    {
        Stack<char> stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            switch (s[i])
            {
                case '(':
                    stack.Push(')');
                    break;
                case '{':
                    stack.Push('}');
                    break;
                case '[':
                    stack.Push(']');
                    break;
                default:
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    var c = stack.Pop();
                    if (c != s[i])
                    {
                        return false;
                    }
                    break;
            }
        }

        return stack.Count == 0;
    }
}
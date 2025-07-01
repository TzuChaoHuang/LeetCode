namespace LeetCode.Solutions;

/// <summary>
/// You are given an array of strings tokens that represents an arithmetic expression in a Reverse Polish Notation.
/// https://leetcode.com/problems/evaluate-reverse-polish-notation/description/
/// </summary>
public class EvaluateReversePolishNotation
{
    public int Solve(string[] tokens)
    {
        Stack<int> stack = new Stack<int>();
        for (int i = 0; i < tokens.Length; i++)
        {
            if (tokens[i] == "+")
            {
                var num1 = stack.Pop();
                var num2 = stack.Pop();
                stack.Push(num2 + num1);
            }
            else if (tokens[i] == "-")
            {
                var num1 = stack.Pop();
                var num2 = stack.Pop();
                stack.Push(num2 - num1);
            }
            else if (tokens[i] == "*")
            {
                var num1 = stack.Pop();
                var num2 = stack.Pop();
                stack.Push(num2 * num1);
            }
            else if (tokens[i] == "/")
            {
                var num1 = stack.Pop();
                var num2 = stack.Pop();
                stack.Push(num2 / num1);
            }
            else
            {
                stack.Push(int.Parse(tokens[i]));
            }
        }
        return stack.Peek();
    }
}
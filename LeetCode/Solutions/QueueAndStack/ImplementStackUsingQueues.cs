namespace LeetCode.Solutions;

/// <summary>
/// Implement a last-in-first-out (LIFO) stack using only two queues. The implemented stack should support all the functions of a normal stack (push, top, pop, and empty).
/// https://leetcode.com/problems/implement-stack-using-queues/description/
/// </summary>
public class MyStack
{
    public List<int> _stack;

    public MyStack()
    {
        _stack = new List<int>();
    }

    public void Push(int x)
    {
        _stack.Add(x);
    }

    public int Pop()
    {
        int temp = _stack.Last();
        _stack.RemoveAt(_stack.Count - 1);
        return temp;

    }

    public int Top()
    {
        return _stack.Last();
    }

    public bool Empty()
    {
        return _stack.Count == 0;
    }
}
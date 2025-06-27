namespace LeetCode.Solutions;

/// <summary>
/// Implement a first in first out (FIFO) queue using only two stacks. The implemented queue should support all the functions of a normal queue (push, peek, pop, and empty).
/// https://leetcode.com/problems/implement-queue-using-stacks/submissions/1678374346/
/// </summary>
public class MyQueue
{

    private List<int> _queue;
    public MyQueue()
    {
        _queue = new List<int>();
    }

    public void Push(int x)
    {
        _queue.Add(x);
    }

    public int Pop()
    {
        if (_queue.Count == 0)
            return 0;
        int tmp = _queue[0];
        _queue.RemoveAt(0);
        return tmp;
    }

    public int Peek()
    {
        return _queue.Count > 0 ? _queue[0] : 0;
    }

    public bool Empty()
    {
        return _queue.Count == 0;
    }
}
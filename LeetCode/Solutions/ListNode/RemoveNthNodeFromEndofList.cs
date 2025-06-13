namespace LeetCode.Solutions;

/// <summary>
/// Given the head of a linked list, remove the nth node from the end of the list and return its head.
/// https://leetcode.com/problems/remove-nth-node-from-end-of-list/description/
/// </summary>
public class RemoveNthNodeFromEndofList
{
    int last = 0;
    public ListNode Solve(ListNode head, int n)
    {
        // Assign an index to each node.
        // When a node is null, set 'last' to count - 1.
        // Then, for each node, if (last - n) equals its index,
        // set node.next to node.next.next.
        var temp = new ListNode(0, head);
        Filter(temp, n, 0);
        return temp.next;
    }

    public void Filter(ListNode node, int n, int count)
    {
        if (node == null)
        {
            last = count - 1;
            return;
        }
        int current = count;
        count++;
        Filter(node.next, n, count);
        if (last - n == current)
        {
            node.next = node?.next?.next;
        }
    }
}
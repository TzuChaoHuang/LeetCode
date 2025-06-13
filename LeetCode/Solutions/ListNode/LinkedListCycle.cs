namespace LeetCode.Solutions;

/// <summary>
/// Given head, the head of a linked list, determine if the linked list has a cycle in it.
/// https://leetcode.com/problems/linked-list-cycle/description/
/// </summary>
public class LinkedListCycle
{
    public bool Solve(ListNode head)
    {
        // Set fast and slow pointers.
        // Fast moves two steps, and slow moves one step.
        // If fast becomes null, return false.
        // If slow equals fast, return true —
        // because in a cycle, they must meet at some point.
        ListNode fast = head;
        ListNode slow = head;
        while (fast != null && fast.next != null)
        {
            fast = fast.next?.next;
            slow = slow.next;

            if (fast == slow)
            {
                return true;
            }
        }
        return false;
    }
}
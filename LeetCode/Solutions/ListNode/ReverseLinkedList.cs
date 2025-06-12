using System.Collections;

namespace LeetCode.Solutions;

/// <summary>
/// Given the head of a singly linked list, reverse the list, and return the reversed list.
/// https://leetcode.com/problems/reverse-linked-list/description/
/// </summary>
public class ReverseLinkedList
{
    public ListNode Solve(ListNode head)
    {
        // create a new ListNode use current node val and previous node ,then set next to the new ListNode
        ListNode next = null;
        while (head != null)
        {
            next = new ListNode(head.val, next);
            head = head.next;
        }
        return next;
    }
}
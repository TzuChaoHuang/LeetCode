using System.Transactions;

namespace LeetCode.Solutions;

/// <summary>
/// Given a linked list, swap every two adjacent nodes and return its head. You must solve the problem without modifying the values in the list's nodes (i.e., only nodes themselves may be changed.)
/// https://leetcode.com/problems/swap-nodes-in-pairs/description/
/// </summary>
public class SwapNodesInPairs
{
    public ListNode Solve(ListNode head)
    {
        // Record first node and second node to swap
        // when set next of first node to next of second node, head lost second node.
        // Only variable two would be correct sort, so if swap equals null, set head to variable two.
        // Then set swap to variable one to new loop.
        // Afer first loop, we have to set swap.next to variable two, because since we have set next of first node to next of second node, head lost second node.
        ListNode swap = null;
        var one = head;
        var two = head?.next;
        while (one != null && two != null)
        {
            one.next = two.next;
            two.next = one;

            if (swap == null)
            {
                head = two;
            }
            else
            {
                swap.next = two;
            }

            swap = one;
            one = one?.next;
            two = one?.next;
        }
        return head;
    }
}
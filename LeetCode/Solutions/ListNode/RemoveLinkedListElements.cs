using System.Runtime.InteropServices.Marshalling;

namespace LeetCode.Solutions;

public class RemoveLinekedListElements
{
    /// <summary>
    /// Given the head of a linked list and an integer val, remove all the nodes of the linked list that has Node.val == val, and return the new head.
    /// https://leetcode.com/problems/remove-linked-list-elements/description/
    /// </summary>
    /// <param name="head"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public ListNode Solve(ListNode head, int val)
    {
        // Use Prev to record previous node
        // If current node equals val , skip the current node  to the next node of it
        // If current doesn't equal val, set prev to the current node
        ListNode temp = new ListNode(0);
        temp.next = head;
        ListNode currentNode = head;
        ListNode prev = temp;
        while (currentNode != null)
        {
            if (currentNode.val == val)
            {
                prev.next = currentNode.next;
            }
            else
            {
                prev = currentNode;
            }
            currentNode = currentNode.next;
        }
        return temp.next;
    }
}
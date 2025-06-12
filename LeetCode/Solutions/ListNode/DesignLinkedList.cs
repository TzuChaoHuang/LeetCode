namespace LeetCode.Solutions;

/// <summary>
/// Design your implementation of the linked list. You can choose to use a singly or doubly linked list.
/// https://leetcode.com/problems/design-linked-list/description/
/// </summary>
public class DesignLinkedList
{
    /// <summary>
    /// First node
    /// </summary>
    private ListNode Head;
    /// <summary>
    /// Last node
    /// </summary>
    private ListNode Last;
    /// <summary>
    /// Length of the nodes
    /// </summary>
    private int Length;
    public DesignLinkedList()
    {
        Head = null;
        Last = null;
        Length = 0;
    }

    /// <summary>
    /// If Index equal or smaller than Length return -1, otherwise, call FindNode
    /// </summary>
    /// <param name="index"></param>
    /// <returns>val</returns>
    public int Get(int index)
    {
        if (Length <= index)
        {
            return -1;
        }
        return FindNode(index).val;
    }

    /// <summary>
    /// According index and count to find the node
    /// </summary>
    /// <param name="index"></param>
    /// <returns>node</returns>
    private ListNode FindNode(int index)
    {
        ListNode node = null;
        int count = 1;
        node = Head;
        while (index >= count)
        {
            count++;
            node = node.next;
        }
        return node;
    }

    /// <summary>
    /// Use temp to record Head
    /// Create new ListNode and set the next to the temp
    /// Length increments 1
    /// </summary>
    /// <param name="val"></param>
    public void AddAtHead(int val)
    {
        ListNode temp = Head;
        Head = new ListNode(val, temp);
        if (Last == null)
        {
            Last = Head;
        }
        Length += 1;
    }

    /// <summary>
    /// If Last equal null, call AddAtHead.
    /// otherwise, Last.next equal new ListNode, then Last point to Last.next and Length increments one.
    /// </summary>
    /// <param name="val"></param>
    public void AddAtTail(int val)
    {
        if (Last == null)
        {
            AddAtHead(val);
            return;
        }
        else
        {
            Last.next = new ListNode(val);
            Last = Last.next;
        }
        Length += 1;
    }

    /// <summary>
    /// If index is greater than length, return.
    /// If index equals 0, call AddAtHead.
    /// If index equals length, call AddAtTail.
    /// Otherwise, find the previous node and create a new node,
    /// then set prev.next to point to the new node and Length increment one.
    /// </summary>
    /// <param name="index"></param>
    /// <param name="val"></param>
    public void AddAtIndex(int index, int val)
    {
        if (index > Length)
            return;
        if (index == 0)
        {
            AddAtHead(val);
            return;
        }
        if (index == Length)
        {
            AddAtTail(val);
            return;
        }

        var prev = FindNode(index - 1);
        var next = prev.next;
        prev.next = new ListNode(val, next);
        Length++;
    }

    /// <summary>
    /// If index is greater than length, return.
    /// If index equals 0, Head point to Head.next, then if Head equal null , set Last to null
    /// IF index equals last of index, find the Previous node and set prev.nexy to null then set Last to prev
    /// otherwise, find the previous node and set prev.next to prev.next.next 
    /// </summary>
    /// <param name="index"></param>
    public void DeleteAtIndex(int index)
    {
        if (index >= Length)
        {
            return;
        }
        if (index == 0)
        {
            Head = Head.next;
            if (Head == null)
            {
                Last = null;
            }
        }
        else if (index == Length - 1)
        {
            var prev = FindNode(index - 1);
            prev.next = null;
            Last = prev;
        }
        else
        {
            var prev = FindNode(index - 1);
            prev.next = prev.next?.next;
        }
        Length--;
    }
}
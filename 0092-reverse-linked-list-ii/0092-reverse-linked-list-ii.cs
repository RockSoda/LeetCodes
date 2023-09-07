/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution 
{
    private ListNode RecerseListNode(ListNode head, out ListNode tail)
    {
        ListNode reversed = null;
        tail = null;
        while(head != null)
        {
            var node = new ListNode(head.val);
            node.next = reversed;
            bool isTail = reversed == null;
            reversed = node;
            if (isTail) tail = reversed;
            head = head.next;
        }
        return reversed;
    }
    
    public ListNode ReverseBetween(ListNode head, int left, int right) 
    {
        if(left == right) return head;
        
        var toBeReversed = head;
        ListNode toBeReversedHead = null;
        ListNode toBeReversedTail = null;
        ListNode leftSide = null;
        ListNode rightSide = null;
        for(int i = 1; i <= right; i++)
        {
            if (i == left - 1)
            {
                leftSide = toBeReversed;
            }
            else if (i == left)
            {
                toBeReversedHead = toBeReversed;
            }
            else if (i == right)
            {
                toBeReversedTail = toBeReversed;
                rightSide = toBeReversedTail.next;
                toBeReversedTail.next = null;
            }
            
            toBeReversed = toBeReversed.next;
        }
        
        var reversedHead = RecerseListNode(toBeReversedHead, out ListNode reversedTail);
        if (leftSide != null) leftSide.next = reversedHead;
        reversedTail.next = rightSide;
        return leftSide != null ? head : reversedHead;
    }
}
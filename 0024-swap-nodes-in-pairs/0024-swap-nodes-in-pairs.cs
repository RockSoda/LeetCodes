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
    public ListNode SwapPairs(ListNode head) 
    {
        if(head == null || head.next == null) return head;
        
        ListNode dummy = new ListNode();
        dummy.next = head;
        
        ListNode first = dummy;
        ListNode second = dummy.next;
        ListNode third = dummy.next.next;
        
        while(first != null && second != null && third != null)
        {
            ListNode next = third.next;
            first.next = third;
            third.next = second;
            second.next = next;
            
            first = second;
            second = next;
            if(next != null) third = next.next;
        }
        
        return dummy.next;
    }
}
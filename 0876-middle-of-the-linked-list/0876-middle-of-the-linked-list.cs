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
    public ListNode MiddleNode(ListNode head) 
    {
        var head1 = head;
        var head2 = head;
        
        while(head1 != null && head2 != null && head2.next != null)
        {
            head1 = head1.next;
            head2 = head2.next.next;
        }
        
        return head1;
    }
}
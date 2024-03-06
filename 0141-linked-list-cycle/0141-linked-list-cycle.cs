/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution 
{
    public bool HasCycle(ListNode head) 
    {
        if(head == null) return false;
        
        ListNode slow = head, fast = head.next;
        
        while(slow != null && fast != null)
        {
            if(slow == fast) return true;
            slow = slow.next;
            
            if(fast.next == null) return false;
            else fast = fast.next.next;
        }
        
        return false;
    }
}
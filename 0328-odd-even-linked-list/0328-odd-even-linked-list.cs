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
    public ListNode OddEvenList(ListNode head) 
    {
        if(head == null) return null;
        
        var oddHead = head;
        var evenHead = head.next;
        var oddCurr = oddHead;
        var evenCurr = evenHead;
        try
        {
            while(head != null)
            {
                oddCurr.next = oddCurr.next.next;
                evenCurr.next = evenCurr.next.next;

                head = head.next.next;
                oddCurr = oddCurr.next;
                evenCurr = evenCurr.next;
            }

            oddCurr.next = evenHead;
            return oddHead;
        }
        catch(Exception)
        {
            while(oddCurr.next != null) oddCurr = oddCurr.next;
            oddCurr.next = evenHead;
            return oddHead;
        }
    }
}
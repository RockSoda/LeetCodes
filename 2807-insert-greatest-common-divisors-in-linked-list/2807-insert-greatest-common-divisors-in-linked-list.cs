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
    private int FindGCD(int a, int b)
    {   
        if (b == 0) return a;     
        return FindGCD(b, a % b);   
    }
       
    public ListNode InsertGreatestCommonDivisors(ListNode head) 
    {
        var prev = head;
        var curr = head.next;
        while(curr != null)
        {
            var node = new ListNode(FindGCD(prev.val, curr.val), curr);
            prev.next = node;
            
            prev = curr;
            curr = curr.next;
        }
        return head;
    }
}
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
        var stk = new Stack<ListNode>();
        var size = 0;
        while(head != null)
        {
            size++;
            stk.Push(head);
            head = head.next;
        }
        
        for(int i = 0; i < (size % 2 == 0 ? size/2-1 : size/2); i++) stk.Pop();
        
        return stk.Peek();
    }
}
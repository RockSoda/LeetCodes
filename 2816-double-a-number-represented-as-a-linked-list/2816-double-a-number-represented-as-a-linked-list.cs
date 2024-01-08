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
    private bool IsCarry;
    
    private void Recurse(ListNode node)
    {
        if(node == null) return;
        
        Recurse(node.next);
        
        node.val *= 2;
        
        if(IsCarry) node.val++;
        
        IsCarry = node.val >= 10;
        
        if(IsCarry) node.val -= 10;
    }
    
    public ListNode DoubleIt(ListNode head) 
    {
        IsCarry = false;
        
        Recurse(head);
        
        return IsCarry ? new ListNode(1, head) : head;
    }
}
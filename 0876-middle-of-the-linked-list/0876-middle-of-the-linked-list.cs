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
    private int SIZE;
    private ListNode output;
    
    private void GetMidNode(ListNode node, int len)
    {
        if(node == null)
        {
            SIZE = len;
            return;
        }
        
        GetMidNode(node.next, len+1);
        
        if(SIZE / 2 == len) output = node;
    }
    
    public ListNode MiddleNode(ListNode head) 
    {
        GetMidNode(head, 0);
        return output;
    }
}
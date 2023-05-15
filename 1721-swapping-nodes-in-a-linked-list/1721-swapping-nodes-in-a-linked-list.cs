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
    private int GetLen(ListNode node)
    {
        int counter = 0;
        while(node != null)
        {
            node = node.next;
            counter++;
        }
        
        return counter;
    }
    
    public ListNode SwapNodes(ListNode head, int k) 
    {
        int len = GetLen(head);
        
        if(len == 1) return head;
        
        if(k > len / 2) k = len - k + 1;
        
        var headHolder = head;
        
        var current = headHolder;
        ListNode firstHalf = null;
        ListNode secondHalf = null;
        
        for(int i = 0; i < len; i++)
        {
            if(i == k - 1) firstHalf = current;
            
            if(i == len - k)
            {
                secondHalf = current;
                break;
            }
            
            current = current.next;
        }
        var tmp = secondHalf.val;
        secondHalf.val = firstHalf.val;
        firstHalf.val = tmp;
        
        return headHolder;
    }
}
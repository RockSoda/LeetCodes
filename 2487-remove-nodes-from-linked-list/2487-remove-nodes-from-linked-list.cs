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
    private ListNode Reverse(ListNode node)
    {
        ListNode reversed = null;
        while(node != null)
        {
            var curr = new ListNode(node.val, reversed);
            
            reversed = curr;
            node = node.next;
        }
        
        return reversed;
    }
    
    public ListNode RemoveNodes(ListNode head) 
    {
        var curr = Reverse(head);
        var reversedHead = curr;
        ListNode prevMax = null;
        
        while (curr.next != null)
        {
            if (prevMax == null) prevMax = curr;
            else if (prevMax.val <= curr.val)
            {
                prevMax.next = curr;
                prevMax = curr;
            }
            
            curr = curr.next;
        }
        
        if (prevMax.val > curr.val) prevMax.next = null;
        
        return Reverse(reversedHead);
    }
}
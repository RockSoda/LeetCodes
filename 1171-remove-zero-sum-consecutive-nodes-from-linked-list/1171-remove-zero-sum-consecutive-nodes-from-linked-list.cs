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
    public ListNode RemoveZeroSumSublists(ListNode head) 
    {
        var map = new Dictionary<ListNode, int>();
        
        var dummyHead = new ListNode(0, head);
        
        var prev = dummyHead;
        
        var curr = dummyHead.next;
        
        while(curr != null)
        {
            foreach(var key in map.Keys)
            {
                map[key] += curr.val;
                
                if(map[key] == 0) key.next = curr.next;
            }
            
            if(curr.val == 0) prev.next = curr.next;
            map[prev] = curr.val;
            prev = curr;
            curr = curr.next;
        }
        
        return dummyHead.next;
    }
}
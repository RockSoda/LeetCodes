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
        var map = new Dictionary<int, List<ListNode>>();
        
        var dummyHead = new ListNode(0, head);
        
        var prev = dummyHead;
        
        var curr = dummyHead.next;
        
        var prefixSum = dummyHead.val;
        
        while(curr != null)
        {
            
            prefixSum += curr.val;
            
            if(!map.ContainsKey(prefixSum)) map[prefixSum] = new List<ListNode>();
            else map[prefixSum].ForEach(node => node.next = curr.next);
            
            map[prefixSum].Add(curr);
            
            if(prefixSum == 0) dummyHead.next = curr.next;
            
            if(curr.val == 0) prev.next = curr.next;
            else prev = curr;
            
            curr = curr.next;
        }
        
        return dummyHead.next;
    }
}
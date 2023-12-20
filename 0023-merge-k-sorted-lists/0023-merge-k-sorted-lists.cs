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
    private ListNode Merge(ListNode node1, ListNode node2)
    {
        var dummyHead = new ListNode();
        ListNode curr1 = node1, curr2 = node2, curr = dummyHead;
        
        while(curr1 != null || curr2 != null)
        {
            var val1 = curr1 == null ? int.MaxValue : curr1.val;
            var val2 = curr2 == null ? int.MaxValue : curr2.val;
            
            if(val1 <= val2)
            {
                curr.next = new ListNode(curr1.val);
                curr1 = curr1.next;
            }
            else 
            {
                curr.next = new ListNode(curr2.val);
                curr2 = curr2.next;
            }
            
            curr = curr.next;
        }
        
        return dummyHead.next;
    }
    
    public ListNode MergeKLists(ListNode[] lists) 
    {
        if(lists.Length == 0) return null;
        
        ListNode output = null;
        
        foreach(var list in lists) output = Merge(output, list);
        
        return output;
    }
}
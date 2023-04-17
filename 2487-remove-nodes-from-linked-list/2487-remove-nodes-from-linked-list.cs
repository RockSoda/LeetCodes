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
    public ListNode RemoveNodes(ListNode head) 
    {
        var list = new List<int>();
        while(head != null)
        {
            list.Add(head.val);
            head = head.next;
        }
        
        int max = list.Last();
        ListNode output = null;
        for(int i = list.Count - 1; i >= 0; i--)
        {
            if(max > list[i]) continue;
            
            max = list[i];
            var node = new ListNode();
            node.val = list[i];
            node.next = output;
            output = node;
        }
        
        return output;
    }
}
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
    private void AddToList(ref ListNode inNode, ref ListNode outNode)
    {
        outNode.next = new ListNode(inNode.val);
        outNode = outNode.next;
        inNode = inNode.next;
    }
    
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) 
    {
        ListNode cur1 = list1;
        ListNode cur2 = list2;
        
        ListNode head = new ListNode();
        ListNode cur = head;
        
        while(cur1 != null && cur2 != null)
        {
            if(cur1.val > cur2.val) AddToList(ref cur2, ref cur);
            else AddToList(ref cur1, ref cur);
        }

        while(cur1 != null) AddToList(ref cur1, ref cur);
        
        while(cur2 != null) AddToList(ref cur2, ref cur);
        
        return head.next;

    }
}
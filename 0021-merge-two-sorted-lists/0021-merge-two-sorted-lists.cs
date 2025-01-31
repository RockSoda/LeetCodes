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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) 
    {
        ListNode cur1 = list1;
        ListNode cur2 = list2;
        
        ListNode head = new ListNode();
        ListNode cur = head;

        void AddToList(ref ListNode node)
        {
            cur.next = new ListNode(node.val);
            cur = cur.next;
            node = node.next;
        }

        while(cur1 != null && cur2 != null)
        {
            if(cur1.val > cur2.val) AddToList(ref cur2);
            else AddToList(ref cur1);
        }

        while(cur1 != null) AddToList(ref cur1);
        
        while(cur2 != null) AddToList(ref cur2);
        
        return head.next;

    }
}
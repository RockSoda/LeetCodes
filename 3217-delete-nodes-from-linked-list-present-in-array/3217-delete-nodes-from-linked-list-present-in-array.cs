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
    public ListNode ModifiedList(int[] nums, ListNode head) 
    {
        var dummyHead = new ListNode(-1, head);
        ListNode curr = dummyHead.next, prev = dummyHead;
        var hSet = nums.ToHashSet();
        int idx = 0;
        while (curr != null)
        {
            if (hSet.Contains(curr.val)) prev.next = curr.next;
            else prev = curr;

            curr = curr.next;
        }
        return dummyHead.next;
    }
}
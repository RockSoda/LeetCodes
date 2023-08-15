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
    private void LoadLists(ListNode head, List<int> firstHalf, List<int> lastHalf, int x)
    {
        while(head != null)
        {
            if(head.val < x) firstHalf.Add(head.val);
            else lastHalf.Add(head.val);
            
            head = head.next;
        }
    }
    
    public ListNode Partition(ListNode head, int x) 
    {
        var firstHalf = new List<int>();
        var lastHalf = new List<int>();
        
        LoadLists(head, firstHalf, lastHalf, x);
        
        var dummyHead = new ListNode();
        var curr = dummyHead;
        
        void AddToListNode(List<int> list)
        {
            foreach(var num in list)
            {
                curr.next = new ListNode(num);
                curr = curr.next;
            }
        }
        
        AddToListNode(firstHalf);
        AddToListNode(lastHalf);
        
        return dummyHead.next;
    }
}
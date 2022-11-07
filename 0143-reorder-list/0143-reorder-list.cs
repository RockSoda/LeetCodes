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
    public void ReorderList(ListNode head) 
    {
        ListNode copy = head;
        Stack<int> stk = new Stack<int>();
        while (copy != null)
        {
            stk.Push(copy.val);
            copy = copy.next;
        }
        
        ListNode temp = head;
        bool isOdd = stk.Count % 2 != 0;
        
        int noOfIterations = (stk.Count / 2);
        
        while (noOfIterations > 0 && temp != null)
        {
            ListNode next = temp.next;
            ListNode n2 = new ListNode(stk.Pop());
            
            temp.next = n2;
            if (noOfIterations == 1 && !isOdd)
            {
                temp = null;
                return;
            }
            
            temp.next.next = next;
            temp = next;
            noOfIterations--;
        }
        temp.next = null;
    }
}
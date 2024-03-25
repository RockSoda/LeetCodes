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
    public bool IsPalindrome(ListNode head) 
    {
        var stk = new Stack<int>();
        var que = new Queue<int>();
        
        while(head != null)
        {
            stk.Push(head.val);
            que.Enqueue(head.val);
            
            head = head.next;
        }
        
        int half = stk.Count / 2, idx = 0;
        while(idx < half+1)
        {
            if(stk.Pop() != que.Dequeue()) return false;
            idx++;
        }
        
        return true;
    }
}
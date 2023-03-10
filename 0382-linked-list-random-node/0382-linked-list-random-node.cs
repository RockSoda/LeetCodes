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

    private int SIZE;
    private Random rng;
    private ListNode head;
    
    public Solution(ListNode head) 
    {
        this.head = head;
        rng = new Random();
        SIZE = GetSize(head);
    }
    
    private int GetSize(ListNode head)
    {
        int len = 0;
        while(head != null)
        {
            len++;
            head = head.next;
        }
        
        return len;
    }
    
    public int GetRandom() 
    {
        int target = rng.Next(SIZE);
        int index = 0;
        var curr = head;
        while(index < target)
        {
            curr = curr.next;
            index++;
        }
        
        return curr.val;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(head);
 * int param_1 = obj.GetRandom();
 */
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
    private int GetLength(ListNode head)
    {
        int counter = 0;
        while(head != null)
        {
            head = head.next;
            counter++;
        }
        return counter;
    }
    
    public ListNode[] SplitListToParts(ListNode head, int k) 
    {
        var list = new ListNode[k];
        ListNode current = head;
        int N = GetLength(head);
        int firstX = N % k;
        int elements = N / k;
        ListNode node = null;
        for(int i = 0; i < k; i++)
        {
            if(current == null) return list;
            node = new ListNode();
            node.val = current.val;
            list[i] = node;
            int iterations = i < firstX ? 1 : 0;
            iterations += elements;
                
            for(int j = 0; j < iterations-1; j++)
            {
                current = current.next;
                node.next = new ListNode(current.val, null);
                node = node.next;
            }
            current = current.next;
        }
        
        return list;
    }
}
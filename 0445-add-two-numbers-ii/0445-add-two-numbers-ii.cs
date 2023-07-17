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
    bool carry;
    ListNode output;
    ListNode current;
    
    private ListNode Solve(ListNode l1, ListNode l2)
    {
        if(l1 == null && l2 == null)
        {
            if(carry) current.next = new ListNode(1);
            
            return output;
        }
        else
        {
            int x = (l1 == null) ? 0 : l1.val;
            int y = (l2 == null) ? 0 : l2.val;
            current.val = carry ? (x+y+1) : (x+y);
            
            if(current.val >= 10)
            {
                carry = true;
                current.val = current.val%10;
            }
            else carry = false;
            
            if(l1 == null)
            {
                if(l2.next != null)
                {
                    current.next = new ListNode(0);
                    current = current.next;
                }
            
                return Solve(null, l2.next);
            }
            else if(l2 == null)
            {
                if(l1.next != null)
                {
                    current.next = new ListNode(0);
                    current = current.next;
                }
            
                return Solve(l1.next, null);
            }
            else
            {
                if(l1.next != null || l2.next != null)
                {
                    current.next = new ListNode(0);
                    current = current.next;
                }
            
                return Solve(l1.next, l2.next);
            }
        }
    }
    
    private ListNode Reverse(ListNode head)
    {
        ListNode reversed = null;
        while(head != null)
        {
            var node = new ListNode(head.val);
            node.next = reversed;
            reversed = node;
            head = head.next;
        }
        return reversed;
    }
    
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        carry = false;
        output = new ListNode();
        current = output;
        
        return Reverse(Solve(Reverse(l1), Reverse(l2)));
    }
}
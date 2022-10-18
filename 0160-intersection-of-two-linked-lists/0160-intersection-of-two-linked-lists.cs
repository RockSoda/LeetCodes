public class Solution 
{
    private Stack<ListNode> ToStack(ListNode head)
    {
        var stk = new Stack<ListNode>();
        while(head != null)
        {
            stk.Push(head);
            head = head.next;
        }
        
        return stk;
    }
    
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) 
    {
        var stkA = ToStack(headA);
        var stkB = ToStack(headB);
        
        ListNode ans = null;
        while(stkA.Count > 0 && stkB.Count > 0)
        {
            var curA = stkA.Pop();
            var curB = stkB.Pop();
            
            if(curA == curB) ans = curA;
        }
        
        return ans;
    }
}
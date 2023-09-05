/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution 
{
    public Node CopyRandomList(Node head) 
    {
        var map = new Dictionary<Node, Node>();
        var curr = head;
        Node copiedDummyHead = new Node(0);
        var copy = copiedDummyHead;
        
        var remained = new HashSet<(Node copied, Node org)>();
        
        while(curr != null)
        {
            copy.next = new Node(curr.val);
            map[curr] = copy.next;
            
            if (curr.random != null)
            {
                if(map.ContainsKey(curr.random)) copy.next.random = map[curr.random];
                else remained.Add((copy.next, curr.random));
            }
            
            copy = copy.next;
            curr = curr.next;
        }
        
        foreach(var pair in remained)
        {
            var copiedNode = pair.copied;
            var org = pair.org;
            
            copiedNode.random = map[org];
        }
        
        return copiedDummyHead.next;
    }
}
/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution 
{
    private void Traverse(Node node, List<int> list)
    {
        if(node == null) return;
        
        foreach(var child in node.children) Traverse(child, list);
        
        list.Add(node.val);
    }
    
    public IList<int> Postorder(Node root) 
    {
        var output = new List<int>();
        Traverse(root, output);
        return output;
    }
}
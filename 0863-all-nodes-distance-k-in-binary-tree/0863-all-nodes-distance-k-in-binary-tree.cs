/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution 
{
    List<int> list;
    
    List<TreeNode> parent;
    
    private void GetChildren(TreeNode node, TreeNode target, int k, int curr, bool isFound, List<TreeNode> trail)
    {
        if (node == null || curr > k) return;
        
        if (node == target)
        {
            parent = trail.ToList();
            isFound = true;
        }
        
        if (curr == k) list.Add(node.val);
        
        trail.Add(node);
        GetChildren(node.left, target, k, curr + (isFound ? 1 : 0), isFound, trail.ToList());
        GetChildren(node.right, target, k, curr + (isFound ? 1 : 0), isFound, trail.ToList());
    }
    
    private void GetParents(TreeNode node, TreeNode target, int k, int curr, HashSet<TreeNode> visited)
    {
        if(node == null || node == target || visited.Contains(node)) return;
        
        if(curr == k) list.Add(node.val);
        
        GetParents(node.left, target, k, curr + 1, visited);
        GetParents(node.right, target, k, curr + 1, visited);
    }

    public IList<int> DistanceK(TreeNode root, TreeNode target, int k) 
    {
        if(k == 0) return new List<int>{ target.val };
        
        list = new List<int>();
        GetChildren(root, target, k, 0, false, new List<TreeNode>());
        
        int curr = 1;
        var visited = new HashSet<TreeNode>();
        var idx = parent.Count - 1;
        while(idx >= 0)
        {
            var currParent = parent[idx--];
            GetParents(currParent, target, k, curr, visited);
            
            visited.Add(currParent);
            if(curr++ == k) break;
        }
        
        return list;
    }
}
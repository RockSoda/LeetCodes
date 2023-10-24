/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution 
{   
    private void Traverse(TreeNode node, Dictionary<int, int> map, int level = 0)
    {
        if (node == null) return;
        
        map[level] = map.ContainsKey(level) ? Math.Max(map[level], node.val) : node.val;
        
        Traverse(node.left, map, level+1);
        Traverse(node.right, map, level+1);
    }
    
    public IList<int> LargestValues(TreeNode root) 
    {
        var map = new Dictionary<int, int>();
        Traverse(root, map);
        return map.Values.ToList();
    }
}
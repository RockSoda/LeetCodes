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
    private void Traversal(TreeNode node, Dictionary<int, long> map, int level = 1)
    {
        if(node == null) return;
        
        map[level] = map.ContainsKey(level) ? map[level] + node.val : node.val;
        
        Traversal(node.left, map, level+1);
        Traversal(node.right, map, level+1);
    }
    
    public int MaxLevelSum(TreeNode root) 
    {
        var map = new Dictionary<int, long>();
        Traversal(root, map);
        return map.ToList().OrderByDescending(kvp => kvp.Value).ThenBy(kvp => kvp.Key).First().Key;
    }
}
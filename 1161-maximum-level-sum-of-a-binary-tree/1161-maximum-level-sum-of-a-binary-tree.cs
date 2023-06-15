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
    private void Traversal(TreeNode node, Dictionary<int, List<int>> map, int level = 1)
    {
        if(node == null) return;
        
        if(!map.ContainsKey(level)) map[level] = new List<int>();
        
        map[level].Add(node.val);
        
        Traversal(node.left, map, level+1);
        Traversal(node.right, map, level+1);
    }
    
    public int MaxLevelSum(TreeNode root) 
    {
        var levelMap = new Dictionary<int, List<int>>();
        Traversal(root, levelMap);
        
        int maxVal = int.MinValue;
        int minLevel = int.MaxValue;
        foreach(var kvp in levelMap)
        {
            var sum = kvp.Value.Sum();
            
            if(sum <= maxVal) continue;
            
            maxVal = sum;
            minLevel = kvp.Key;
        }
        
        return minLevel;
    }
}
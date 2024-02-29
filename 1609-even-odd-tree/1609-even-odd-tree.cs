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
    private void Traverse(TreeNode node, int level, Dictionary<int, List<int>> map, ref bool isBreak)
    {
        if(node == null) return;
        
        if(node.val % 2 == level % 2) isBreak = true;
        
        if(isBreak) return;
        
        if(!map.ContainsKey(level)) map[level] = new List<int>();
        
        map[level].Add(node.val);
        
        Traverse(node.left, level+1, map, ref isBreak);
        Traverse(node.right, level+1, map, ref isBreak);
    }
    
    public bool IsEvenOddTree(TreeNode root) 
    {
        var map = new Dictionary<int, List<int>>();
        
        bool isBreak = false;
        Traverse(root, 0, map, ref isBreak);
        if(isBreak) return false;
        
        bool IsValid(List<int> list, bool isEven)
        {
            var prev = list.First();
            for(int i = 1; i < list.Count; i++)
            {
                var val = list[i];
                
                if(isEven && val <= prev) return false;
                else if(!isEven && val >= prev) return false;
                
                prev = val;
            }
            
            return true;
        }
        
        foreach(var kvp in map)
            if(!IsValid(kvp.Value, kvp.Key % 2 == 0)) return false;
        
        return true;
    }
}
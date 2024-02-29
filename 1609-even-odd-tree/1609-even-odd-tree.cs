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
    private void Traverse(TreeNode node, int level, Dictionary<int, List<int>> map)
    {
        if(node == null) return;
        
        if(!map.ContainsKey(level)) map[level] = new List<int>();
        
        map[level].Add(node.val);
        
        Traverse(node.left, level+1, map);
        Traverse(node.right, level+1, map);
    }
    
    public bool IsEvenOddTree(TreeNode root) 
    {
        var map = new Dictionary<int, List<int>>();
        Traverse(root, 0, map);
        
        foreach(var kvp in map)
        {
            var list = kvp.Value;
            if(kvp.Key % 2 == 0)
            {
                var prev = list.First();
                if(prev % 2 == 0) return false;
                for(int i = 1; i < list.Count; i++)
                {
                    var val = list[i];
                    if(val % 2 == 0 || val <= prev) return false;
                    prev = val;
                }
            }
            else
            {
                var prev = list.First();
                if(prev % 2 == 1) return false;
                for(int i = 1; i < list.Count; i++)
                {
                    var val = list[i];
                    if(val % 2 == 1 || val >= prev) return false;
                    prev = val;
                }
            }
        }
        
        return true;
    }
}
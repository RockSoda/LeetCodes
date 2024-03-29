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
    private int _num;
    
    private bool IsPseudoPalin(Dictionary<int, int> map)
    {
        bool isOddOccurred = false;
        foreach(var kvp in map)
        {
            if(kvp.Value % 2 == 0) continue;
            
            if(isOddOccurred) return false;
            isOddOccurred = true;
        }
        
        return true;
    }
    
    private bool IsLeaf(TreeNode node) => node.left == null && node.right == null;
    
    private void Traverse(TreeNode node, Dictionary<int, int> map)
    {
        if(node == null) return;
        
        if(!map.ContainsKey(node.val)) map[node.val] = 0;
        map[node.val]++;
        
        if(IsLeaf(node) && IsPseudoPalin(map)) _num++;
        
        Traverse(node.left, map);
        Traverse(node.right, map);
        
        map[node.val]--;
    }
    
    public int PseudoPalindromicPaths (TreeNode root) 
    {
        _num = 0;
        Traverse(root, new Dictionary<int, int>());
        return _num;
    }
}
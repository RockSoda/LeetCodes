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
    private int maxLevel;
    
    private int val;
    
    private bool IsLeaf(TreeNode node) => node.left == null && node.right == null;
    
    private void Traverse(TreeNode node, int level)
    {
        if(node == null) return;
        
        if(IsLeaf(node) && maxLevel < level)
        {
            maxLevel = level;
            val = node.val;
        }
        
        Traverse(node.left, level+1);
        Traverse(node.right, level+1);
    }
    
    public int FindBottomLeftValue(TreeNode root) 
    {
        maxLevel = -1;
        val = 0;
        Traverse(root, 0);
        return val;
    }
}
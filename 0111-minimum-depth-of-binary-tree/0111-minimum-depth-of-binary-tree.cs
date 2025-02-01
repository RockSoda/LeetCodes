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
public class Solution {
    
    private bool IsLeaf(TreeNode node) => node.left == null && node.right == null;
    
    public int MinDepth(TreeNode root, bool isTop = true) 
    {
        if(root == null) return isTop ? 0 : (int)Math.Pow(10,5)+1;
        
        if(IsLeaf(root)) return 1;
        
        return Math.Min(MinDepth(root.left, false)+1, MinDepth(root.right, false)+1);
    }
}
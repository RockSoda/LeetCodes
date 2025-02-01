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
    
    public int MinDepth(TreeNode root) 
    {
        if(root == null) return 0;
        
        if(IsLeaf(root)) return 1;

        if(root.left == null) return 1+MinDepth(root.right);

        if(root.right == null) return 1+MinDepth(root.left);
        
        return 1+Math.Min(MinDepth(root.left), MinDepth(root.right));
    }
}
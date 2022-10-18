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
    private void Recurse(TreeNode node, ref int k, ref int output)
    {
        if(node == null || k == 0) return;
        
        Recurse(node.left, ref k, ref output);
        
        if(--k == 0) output = node.val;
        
        Recurse(node.right, ref k, ref output);
    }
    
    public int KthSmallest(TreeNode root, int k) 
    {        
        int output = 0;
        
        Recurse(root, ref k, ref output);
        
        return output;
    }
}
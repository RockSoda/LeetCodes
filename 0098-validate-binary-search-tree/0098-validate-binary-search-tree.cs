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
    private bool IsValidBST(TreeNode node, long up, long down) 
    {
        if(node == null) return true;
        
        if(node.val >= up || node.val <= down) return false;
        
        return IsValidBST(node.left, node.val, down) && IsValidBST(node.right, up, node.val);
    }
    
    public bool IsValidBST(TreeNode root) 
    {
        if(root == null) return true;
        
        return IsValidBST(root, long.MaxValue, long.MinValue);
    }
}
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
    private int diameter;
    
    private int Recurse(TreeNode node)
    {
        if(node == null) return 0;
        
        int left = Recurse(node.left);
        int right = Recurse(node.right);
        diameter = Math.Max(diameter, left + right);
        
        return Math.Max(left, right) + 1;
    }
    
    public int DiameterOfBinaryTree(TreeNode root) 
    {
        diameter = 0;
        Recurse(root);
        return diameter;
    }
}
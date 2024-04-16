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
    private void AddRowAtLevel(TreeNode node, int val, int depth, int currLevel)
    {
        if(node == null) return;
        
        if(depth-1 == currLevel)
        {
            node.left = new TreeNode(val: val, left: node.left);
            node.right = new TreeNode(val: val, right: node.right);
            
            return;
        }
        
        AddRowAtLevel(node.left, val, depth, currLevel+1);
        AddRowAtLevel(node.right, val, depth, currLevel+1);
    }
    
    public TreeNode AddOneRow(TreeNode root, int val, int depth)
    {
        if(depth == 1) return new TreeNode(val: val, left: root);
        
        AddRowAtLevel(root, val, depth, 1);
        return root;
    }
}
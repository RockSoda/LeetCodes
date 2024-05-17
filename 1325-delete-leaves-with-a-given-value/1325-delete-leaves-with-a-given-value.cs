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
    private bool IsLeaf(TreeNode node) => node.left == null && node.right == null;
    
    public TreeNode RemoveLeafNodes(TreeNode root, int target) 
    {
        if(root.left != null) root.left = RemoveLeafNodes(root.left, target);
        if(root.right != null) root.right = RemoveLeafNodes(root.right, target);
        
        if(IsLeaf(root) && root.val == target) return null;
        else return root;
    }
}
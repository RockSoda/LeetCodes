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
    private (TreeNode, int) PostOrder(TreeNode node)
    {
        if(node == null) return (null, 0);

        (TreeNode left, int leftLevel) = PostOrder(node.left);
        (TreeNode right, int rightLevel) = PostOrder(node.right);

        if(leftLevel > rightLevel) return (left, leftLevel+1);
        if(leftLevel < rightLevel) return (right, rightLevel+1);

        return (node, leftLevel+1);
    }
    
    public TreeNode SubtreeWithAllDeepest(TreeNode root) 
    {
        (TreeNode lca, int level) = PostOrder(root);
        return lca;
    }
}
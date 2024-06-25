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
    private void Traverse(TreeNode node, ref int sum)
    {
        if(node == null) return;
        
        Traverse(node.right, ref sum);
        
        sum += node.val;
        node.val = sum;
        
        Traverse(node.left, ref sum);
    }
    
    public TreeNode BstToGst(TreeNode root) 
    {
        int sum = 0;
        Traverse(root, ref sum);
        return root;
    }
}
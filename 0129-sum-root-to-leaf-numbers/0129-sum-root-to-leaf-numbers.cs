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
    private bool IsLeaf(TreeNode node) =>
        node.left == null && node.right == null;
    
    private int SumPath(TreeNode node, StringBuilder curr)
    {
        if(node == null) return 0;
        
        curr.Append(node.val);
        
        if(IsLeaf(node)) return int.Parse(curr.ToString());
        
        var tmp = curr.ToString();
        return SumPath(node.left, new StringBuilder(tmp)) + SumPath(node.right, new StringBuilder(tmp));
    }
    
    public int SumNumbers(TreeNode root) => SumPath(root, new StringBuilder());
}
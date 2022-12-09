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
    private int Diff;
    
    private void DFS(TreeNode node, int max, int min)
    {
        if(node == null) return;
        
        max = Math.Max(node.val, max);
        min = Math.Min(node.val, min);
        Diff = Math.Max(Diff, Math.Abs(max - min));
        
        DFS(node.left, max, min);
        DFS(node.right, max, min);
    }
    
    public int MaxAncestorDiff(TreeNode root) 
    {
        Diff = int.MinValue;
        DFS(root, int.MinValue, int.MaxValue);
        return Diff;
    }
}
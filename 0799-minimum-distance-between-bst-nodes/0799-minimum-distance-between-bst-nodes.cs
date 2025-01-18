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
    private int min;
    private int last;
    private void Traverse(TreeNode node)
    {
        if(node == null) return;

        Traverse(node.left);
        min = Math.Min(Math.Abs(node.val-last), min);
        last = node.val;
        Traverse(node.right);
    }

    public int MinDiffInBST(TreeNode root) 
    {
        min = int.MaxValue;
        last = int.MaxValue;
        Traverse(root);
        return min;
    }
}
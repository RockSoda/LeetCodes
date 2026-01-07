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
    private readonly long MOD = 1_000_000_007;

    private long MAX = 0;

    private long SUM = 0;

    private long GetSum(TreeNode node)
    {
        if(node == null) return 0;
        return node.val +GetSum(node.left) + GetSum(node.right);
    }

    private long FindMax(TreeNode node)
    {
        if(node == null) return 0;

        var leftSum = FindMax(node.left);
        var rightSum = FindMax(node.right);

        long subTreeSum = node.val + leftSum + rightSum;

        MAX = Math.Max(subTreeSum * (SUM - subTreeSum), MAX);

        return subTreeSum;
    }

    public int MaxProduct(TreeNode root)
    {
        SUM = GetSum(root);
        FindMax(root);

        return (int)(MAX % MOD);
    }
}
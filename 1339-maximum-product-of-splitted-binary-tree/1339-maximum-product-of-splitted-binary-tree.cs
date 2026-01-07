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

    private long SubtreeSum(TreeNode node)
    {
        if(node == null) return 0;

        long left = SubtreeSum(node.left);
        long right = SubtreeSum(node.right);

        return node.val += (int)(left + right);
    }

    private void FindMax(TreeNode node, long sum)
    {
        if(node == null) return;
        
        var restOfTheTreeSum = sum - node.val;

        if(restOfTheTreeSum > 0) MAX = Math.Max(MAX, (node.val * restOfTheTreeSum));

        FindMax(node.left, sum);
        FindMax(node.right, sum);
    }

    public int MaxProduct(TreeNode root)
    {
        var sum = SubtreeSum(root);
        FindMax(root, sum);

        return (int)(MAX % MOD);
    }
}
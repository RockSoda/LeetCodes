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

    private int Traverse(TreeNode root, int level)
    {
        if(root == null) return 100001;

        if(IsLeaf(root)) return level+1;

        return Math.Min(Traverse(root.left, level+1), Traverse(root.right, level+1));

    }
    public int MinDepth(TreeNode root)
    {
        var output = Traverse(root, 0);
        return output == 100001 ? 0 : output;
    }
}
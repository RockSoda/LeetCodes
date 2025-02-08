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
    private bool Traverse(TreeNode nodeLeft, TreeNode nodeRight)
    {
        if (nodeLeft == null && nodeRight == null) return true;

        if (nodeLeft == null || nodeRight == null) return false;

        if (nodeRight.val != nodeLeft.val) return false;

        return Traverse(nodeLeft.left, nodeRight.right) && Traverse(nodeLeft.right, nodeRight.left);
    }

    public bool IsSymmetric(TreeNode root) => Traverse(root.left, root.right);
}
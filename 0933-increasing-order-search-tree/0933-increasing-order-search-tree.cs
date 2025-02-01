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
    public TreeNode IncreasingBST(TreeNode root) 
    {
        var head = new TreeNode();
        var curr = head;

        void InOrder(TreeNode node)
        {
            if(node == null) return;

            InOrder(node.left);

            curr.right = new TreeNode(node.val);
            curr = curr.right;

            InOrder(node.right);
        }

        InOrder(root);
        return head.right;
    }
}
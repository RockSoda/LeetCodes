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
    private bool CheckValEqual(TreeNode node1, TreeNode node2)
    {
        if(node1 == null && node2 == null) return true;
        if(node1 == null || node2 == null) return false;

        if(node1.val == node2.val) return true;
        return false;
    }

    private bool Traverse(TreeNode node1, TreeNode node2)
    {
        if(node1 == null && node2 == null) return true;
        if(node1 == null || node2 == null) return false;

        if(node1.val != node2.val) return false;

        if(CheckValEqual(node1.left, node2.left) && CheckValEqual(node1.right, node2.right))
        {
            return Traverse(node1.left, node2.left) && Traverse(node1.right, node2.right);
        }
        else if(CheckValEqual(node1.left, node2.right) && CheckValEqual(node1.right, node2.left))
        {
            return Traverse(node1.left, node2.right) && Traverse(node1.right, node2.left);
        }

        return false;
    }

    public bool FlipEquiv(TreeNode root1, TreeNode root2) 
    {
        return Traverse(root1, root2);
    }
}
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
    private int Recurse(TreeNode node, int curr, bool isPrevLeft)
    {
        if(node == null) return curr;
        
        if(isPrevLeft)
        {
            return Math.Max(Recurse(node.left, 0, false), Recurse(node.right, curr+1, false));
        }
        else
        {
            return Math.Max(Recurse(node.right, 0, true), Recurse(node.left, curr+1, true));
        }
    }
    
    public int LongestZigZag(TreeNode root) 
    {
        return Math.Max(Recurse(root, 0, false), Recurse(root, 0, true)) - 1;
    }
}
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
    private int CountNodes(TreeNode node)
    {
        if(node == null) return 0;
        
        return 1 + CountNodes(node.left) + CountNodes(node.right);
    }
    
    private bool Recurse(TreeNode node, int index, int size)
    {
        if(node == null) return true;
        if(index > size) return false;
        
        return Recurse(node.left, index*2, size) && Recurse(node.right, 1+index*2, size);
    }
    
    public bool IsCompleteTree(TreeNode root) =>
        Recurse(root, 1, CountNodes(root));
}
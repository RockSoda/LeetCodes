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
    
    private void Traverse(TreeNode node, int target, TreeNode parent, bool isLeft)
    {
        if(node == null) return;
        
        Traverse(node.left, target, node, true);
        Traverse(node.right, target, node, false);
        
        if(IsLeaf(node) && node.val == target && parent != null) 
        {
            if(isLeft) parent.left = null;
            else parent.right = null;
        }
    }
    
    public TreeNode RemoveLeafNodes(TreeNode root, int target) 
    {
        Traverse(root, target, null, true);
        if(IsLeaf(root) && root.val == target) root = null;
        return root;
    }
}
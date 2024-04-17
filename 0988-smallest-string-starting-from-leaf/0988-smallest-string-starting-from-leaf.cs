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
    private string smallest;
    
    private bool IsLeaf(TreeNode node) => node.left == null && node.right == null;
    
    private void Traverse(TreeNode node, StringBuilder sb)
    {
        if(node == null) return;
        
        sb.Insert(0, (char)(node.val + 'a'));
        
        var currStr = sb.ToString();
        
        if(IsLeaf(node) && (string.IsNullOrEmpty(smallest) || string.Compare(smallest, currStr) > 0)) smallest = currStr;
        
        Traverse(node.left, new StringBuilder(currStr));
        Traverse(node.right, new StringBuilder(currStr));
    }
    
    public string SmallestFromLeaf(TreeNode root) 
    {
        smallest = string.Empty;
        
        Traverse(root, new StringBuilder());
        
        return smallest;
    }
}
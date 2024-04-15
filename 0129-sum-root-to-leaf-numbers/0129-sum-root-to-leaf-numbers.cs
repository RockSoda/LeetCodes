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
    private bool IsLeaf(TreeNode node) =>
        node.left == null && node.right == null;
    
    private void GetStrs(TreeNode node, StringBuilder curr, List<string> list)
    {
        if(node == null) return;
        
        curr.Append(node.val);
        
        if(IsLeaf(node)) list.Add(curr.ToString());
        
        var tmp = curr.ToString();
        GetStrs(node.left, new StringBuilder(tmp), list);
        GetStrs(node.right, new StringBuilder(tmp), list);
    }
    
    public int SumNumbers(TreeNode root) 
    {
        var list = new List<string>();
        GetStrs(root, new StringBuilder(), list);
        
        int output = 0;
        foreach(var num in list) output += int.Parse(num);
        
        return output;
    }
}
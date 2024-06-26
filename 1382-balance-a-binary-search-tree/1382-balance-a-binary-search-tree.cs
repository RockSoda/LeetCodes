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
    private void Traverse(TreeNode node, List<int> list)
    {
        if (node == null) return;
        
        Traverse(node.left, list);
        list.Add(node.val);
        Traverse(node.right, list);
    }
    
    private TreeNode BuildTree(List<int> list, int left, int right)
    {
        if (right < left) return null;
        
        var mid = left + (right - left) / 2;
        return new TreeNode(list[mid], BuildTree(list, left, mid-1), BuildTree(list, mid+1, right));
    }
    
    public TreeNode BalanceBST(TreeNode root) 
    {
        var list = new List<int>();
        Traverse(root, list);
        return BuildTree(list, 0, list.Count - 1);
    }
}
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
    private void Traversal(TreeNode node, SortedDictionary<int, int> map, int level = 0)
    {
        if(node == null) return;
        
        if(!map.ContainsKey(level)) map[level] = node.val;
        else map[level] = Math.Max(map[level], node.val);
        
        Traversal(node.left, map, level+1);
        Traversal(node.right, map, level+1);
    }
    
    public IList<int> LargestValues(TreeNode root) 
    {
        var map = new SortedDictionary<int, int>();
        Traversal(root, map);
        return map.Values.ToList();
    }
}
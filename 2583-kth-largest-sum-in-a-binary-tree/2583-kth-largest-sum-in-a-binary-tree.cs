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
    private void Traverse(TreeNode node, int level, Dictionary<int, long> map)
    {
        if(node == null) return;

        map[level] = map.ContainsKey(level) ? map[level] + node.val : node.val;
        
        Traverse(node.left, level+1, map);
        Traverse(node.right, level+1, map);
    }

    public long KthLargestLevelSum(TreeNode root, int k) 
    {
        var map = new Dictionary<int, long>();
        Traverse(root, 0, map);
        var skipped = map.Count - k;
        return skipped < 0 ? -1 : map.Select(kvp => kvp.Value).OrderBy(x => x).Skip(skipped).First();
    }
}
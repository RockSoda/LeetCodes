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
    private void Traverse(TreeNode node, int level, Dictionary<int, List<int>> map)
    {
        if(node == null) return;

        if(!map.ContainsKey(level)) map[level] = new List<int>();

        map[level].Add(node.val);

        Traverse(node.left, level+1, map);
        Traverse(node.right, level+1, map);
    }

    private int GetOprs(List<int> list)
    {
        var sorted = list.ToList();
        sorted.Sort();
        
        var swaps = 0;
        for(int i = 0; i < list.Count; i++)
        {
            if(list[i] != sorted[i]) swaps++;

            var idx = list.IndexOf(sorted[i]);
            (list[i], list[idx]) = (list[idx], list[i]);
        }
        return swaps;
    }

    public int MinimumOperations(TreeNode root) 
    {
        var map = new Dictionary<int, List<int>>();
        Traverse(root, 0, map);

        var totalSwaps = 0;
        foreach(var kvp in map) totalSwaps += GetOprs(kvp.Value);

        return totalSwaps;
    }
}
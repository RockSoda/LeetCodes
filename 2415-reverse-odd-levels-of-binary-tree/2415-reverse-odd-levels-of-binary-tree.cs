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
    private void LoadMap(TreeNode node, Dictionary<int, List<int>> map, int level)
    {
        if (node == null) return;

        if (!map.ContainsKey(level)) map[level] = new List<int>();
        map[level].Add(node.val);

        LoadMap(node.left, map, level+1);
        LoadMap(node.right, map, level+1);
    }

    private void BuildTree(TreeNode node, Dictionary<int, List<int>> map, int level)
    {
        if (!map.ContainsKey(level) || map[level].Count == 0) return;

        node.left.val = map[level].First();
        map[level].RemoveAt(0);
        node.right.val = map[level].First();
        map[level].RemoveAt(0);

        BuildTree(node.left, map, level+1);
        BuildTree(node.right, map, level+1);
    }

    public TreeNode ReverseOddLevels(TreeNode root) 
    {
        var map = new Dictionary<int, List<int>>();
        LoadMap(root, map, 0);
        for(int i = 0; i < map.Count; i++)
        {
            if(i % 2 == 0) continue;
            map[i].Reverse();
        }
        BuildTree(root, map, 1);
        return root;
    }
}
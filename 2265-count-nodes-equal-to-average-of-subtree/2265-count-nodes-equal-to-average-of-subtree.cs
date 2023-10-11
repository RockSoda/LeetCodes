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
    private int output;
    
    private int counter;
    
    private int sum;
    
    private (int, int) GetSubTreeInfo(TreeNode node, Dictionary<TreeNode, (int s, int c)> map)
    {
        if (node == null) return (-1, -1);
            
        counter++;
        sum += node.val;
        
        if (map.ContainsKey(node))
        {
            counter += map[node].c;
            sum += map[node].s;
        }
        else
        {
            GetSubTreeInfo(node.left, map);
            GetSubTreeInfo(node.right, map);
        }
        
        return map[node] = (sum, counter);
    }
    
    private void Traverse(TreeNode node, Dictionary<TreeNode, (int, int)> map)
    {
        if(node == null) return;
        
        Traverse(node.left, map);
        Traverse(node.right, map);
        
        counter = 0;
        sum = 0;
        (int sum, int counter) info = GetSubTreeInfo(node, map);
        
        if (info.sum / info.counter == node.val) output++;
    }
    
    public int AverageOfSubtree(TreeNode root) 
    {
        output = 0;
        var map = new Dictionary<TreeNode, (int, int)>();
        Traverse(root, map);
        return output;
    }
}
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
    private void Traversal(TreeNode node, List<int> levelSum, int level = 0)
    {
        if(node == null) return;
        
        if(level >= levelSum.Count) levelSum.Add(node.val);
        else levelSum[level] += node.val;
        
        Traversal(node.left, levelSum, level+1);
        Traversal(node.right, levelSum, level+1);
    }
    
    public int MaxLevelSum(TreeNode root) 
    {
        var levelSum = new List<int>();
        Traversal(root, levelSum);
        int minLevel = int.MaxValue, maxSum = int.MinValue;
        for(int i = 0; i < levelSum.Count; i++)
        {
            if(maxSum >= levelSum[i]) continue;

            maxSum = levelSum[i];
            minLevel = i;
        }
        return minLevel+1;
    }
}
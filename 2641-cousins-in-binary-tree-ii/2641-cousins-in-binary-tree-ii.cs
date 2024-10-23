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
    private void Traverse(TreeNode node, TreeNode parent, int level, Dictionary<TreeNode, int> mapParent, Dictionary<int, int> mapSum)
    {
        if(node == null) return;

        if(parent != null)
        {
            mapParent[parent] = mapParent.ContainsKey(parent) ? mapParent[parent] + node.val : node.val;
            mapSum[level] = mapSum.ContainsKey(level) ? mapSum[level] + node.val : node.val;
        }

        Traverse(node.left, node, level+1, mapParent, mapSum);
        Traverse(node.right, node, level+1, mapParent, mapSum);
    }

    private void LoadTree(TreeNode node, TreeNode parent, int level, Dictionary<TreeNode, int> mapParent, Dictionary<int, int> mapSum)
    {
        if(node == null) return;

        if(parent != null) node.val = mapSum[level] - mapParent[parent];

        LoadTree(node.left, node, level+1, mapParent, mapSum);
        LoadTree(node.right, node, level+1, mapParent, mapSum);
    }

    public TreeNode ReplaceValueInTree(TreeNode root) 
    {
        var mapParent = new Dictionary<TreeNode, int>();
        var mapSum = new Dictionary<int, int>();
        Traverse(root, null, 0, mapParent, mapSum);
        LoadTree(root, null, 0, mapParent, mapSum);
        root.val = 0;
        
        return root;
    }
}
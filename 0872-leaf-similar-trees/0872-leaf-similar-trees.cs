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
    private bool IsLeaf(TreeNode node) => node.left == null && node.right == null;
    
    private bool UnloadQueue(TreeNode node, Queue<int> que)
    {
        if(node == null) return true;
        
        if(IsLeaf(node))
        {
            if(que.Count == 0 || que.Dequeue() != node.val) return false;
        }
        
        return UnloadQueue(node.left, que) && UnloadQueue(node.right, que);
    }
    
    private void LoadQueue(TreeNode node, Queue<int> que)
    {
        if(node == null) return;
        
        if(IsLeaf(node)) que.Enqueue(node.val);
        
        LoadQueue(node.left, que);
        LoadQueue(node.right, que);
    }
    
    public bool LeafSimilar(TreeNode root1, TreeNode root2) 
    {
        var que = new Queue<int>();
        LoadQueue(root1, que);
        return UnloadQueue(root2, que) && que.Count == 0;
    }
}
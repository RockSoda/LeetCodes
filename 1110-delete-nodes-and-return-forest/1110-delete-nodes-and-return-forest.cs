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
    private void Traverse(TreeNode node, TreeNode parent, bool isLeft, HashSet<int> toDelete, List<TreeNode> list)
    {
        if(node == null) return;
        
        if(toDelete.Contains(node.val)) 
        {
            if(parent != null)
            {
                if(isLeft) parent.left = null;
                else parent.right = null;
            }
            
            if(node.left != null && !toDelete.Contains(node.left.val)) list.Add(node.left);
            if(node.right != null && !toDelete.Contains(node.right.val)) list.Add(node.right);
            
            Traverse(node.left, null, true, toDelete, list);
            Traverse(node.right, null, false, toDelete, list);
        }
        else
        {
            Traverse(node.left, node, true, toDelete, list);
            Traverse(node.right, node, false, toDelete, list);
        }
    }
    
    public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete) 
    {
        var output = new List<TreeNode>();
        var set = to_delete.ToHashSet();
        if(!set.Contains(root.val)) output.Add(root);
        Traverse(root, null, false, set, output);
        return output;
    }
}
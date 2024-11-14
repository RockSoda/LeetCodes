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
    private int nodeIdx = 0;
    
    private TreeNode BstHelper(int[] preorder, int start , int end)
    {
        if(nodeIdx == preorder.Length || preorder[nodeIdx] < start || preorder[nodeIdx] > end) return null;
        
        int val = preorder[nodeIdx++];
        
        TreeNode node = new TreeNode(val);
        node.left = BstHelper(preorder,start,val);
        node.right = BstHelper(preorder,val,end);
        
        return node;
    }
    
    public TreeNode BstFromPreorder(int[] preorder) 
    {
        if(preorder.Length == 0) return null;
        
        return BstHelper(preorder, int.MinValue, int.MaxValue);
    }
}
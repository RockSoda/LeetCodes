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
public class BSTIterator 
{
    private List<int> list;
    private int iterator;
    
    public BSTIterator(TreeNode root) 
    {
        list = new List<int>();
        LoadList(root);
        iterator = 0;
    }
    
    private void LoadList(TreeNode node)
    {
        if(node == null) return;
        
        LoadList(node.left);
        list.Add(node.val);
        LoadList(node.right);
    }
    
    public int Next() =>
        list[iterator++];
    
    public bool HasNext() =>
        iterator < list.Count;
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */
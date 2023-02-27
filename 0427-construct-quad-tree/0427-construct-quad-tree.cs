/*
// Definition for a QuadTree node.
public class Node {
    public bool val;
    public bool isLeaf;
    public Node topLeft;
    public Node topRight;
    public Node bottomLeft;
    public Node bottomRight;

    public Node() {
        val = false;
        isLeaf = false;
        topLeft = null;
        topRight = null;
        bottomLeft = null;
        bottomRight = null;
    }
    
    public Node(bool _val, bool _isLeaf) {
        val = _val;
        isLeaf = _isLeaf;
        topLeft = null;
        topRight = null;
        bottomLeft = null;
        bottomRight = null;
    }
    
    public Node(bool _val,bool _isLeaf,Node _topLeft,Node _topRight,Node _bottomLeft,Node _bottomRight) {
        val = _val;
        isLeaf = _isLeaf;
        topLeft = _topLeft;
        topRight = _topRight;
        bottomLeft = _bottomLeft;
        bottomRight = _bottomRight;
    }
}
*/

public class Solution 
{
    private (int[][], int[][], int[][], int[][]) GetSubs(int[][] grid)
    {
        var tl = new int[grid.Length/2][];
        var tr = new int[grid.Length/2][];
        var bl = new int[grid.Length/2][];
        var br = new int[grid.Length/2][];
        for(int i = 0; i < grid.Length; i++)
        {
            if(i < grid.Length/2)
            {
                tl[i] = new int[grid[i].Length/2];
                tr[i] = new int[grid[i].Length/2];
            }
            else
            {
                bl[i-grid.Length/2] = new int[grid[i].Length/2];
                br[i-grid.Length/2] = new int[grid[i].Length/2];
            }
            
            for(int j = 0; j < grid[i].Length; j++)
            {
                if(j < grid[i].Length/2)
                {
                    if(i < grid.Length/2) tl[i][j] = grid[i][j];
                    else bl[i-grid.Length/2][j] = grid[i][j];
                }
                else
                {
                    if(i < grid.Length/2) tr[i][j-grid[i].Length/2] = grid[i][j];
                    else br[i-grid.Length/2][j-grid[i].Length/2] = grid[i][j];
                }
            }
        }
        
        return (tl, tr, bl, br);
    }
    
    private bool AreSameVals(int[][] grid, out bool val)
    {
        int curr = grid[0][0];
        val = curr == 1;
        foreach(var row in grid)
            foreach(var cell in row)
                if(curr != cell) return false;
        
        return true;
    }
    
    private void LoadNodes(int[][] grid, Node node)
    {
        node.isLeaf = AreSameVals(grid, out node.val);
        
        if(node.isLeaf) return;
        
        (int[][] tl, int[][] tr, int[][] bl, int[][] br) subs = GetSubs(grid);
        
        node.topLeft = new Node();
        LoadNodes(subs.tl, node.topLeft);
        node.topRight = new Node();
        LoadNodes(subs.tr, node.topRight);
        node.bottomLeft = new Node();
        LoadNodes(subs.bl, node.bottomLeft);
        node.bottomRight = new Node();
        LoadNodes(subs.br, node.bottomRight);
    }
    
    public Node Construct(int[][] grid) 
    {
        Node root = new Node();
        LoadNodes(grid, root);
        return root;
    }
}
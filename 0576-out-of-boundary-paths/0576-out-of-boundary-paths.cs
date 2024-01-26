public class Solution 
{
    private int MOD = (int)Math.Pow(10, 9) + 7;
    
    private long Traverse(int m, int n, int moves, int i, int j, Dictionary<(int, int, int), long> memo)
    {
        if(i < 0 || i >= m || j < 0 || j >= n) return 1;
        
        if(moves <= 0) return 0;
        
        if(memo.ContainsKey((i, j, moves))) return memo[(i, j, moves)];
        
        return memo[(i, j, moves)] = (Traverse(m, n, moves-1, i+1, j, memo) +
                                      Traverse(m, n, moves-1, i, j+1, memo) +
                                      Traverse(m, n, moves-1, i-1, j, memo) +
                                      Traverse(m, n, moves-1, i, j-1, memo)) % MOD;
    }
    
    public int FindPaths(int m, int n, int maxMove, int startRow, int startColumn)
    {
        var memo = new Dictionary<(int, int, int), long>();
        return (int)Traverse(m, n, maxMove, startRow, startColumn, memo) % MOD;
    }
}
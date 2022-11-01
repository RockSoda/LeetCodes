public class Solution 
{
    private bool DFS(int[] ans, int i, bool[] memo) 
    {
        if (i == ans.Length) return true;
        
        if (ans[i] != 0) return DFS(ans, i + 1, memo);
        
        for (int j = memo.Length - 1; j > 0; j--) 
        {
            if(memo[j]) continue;
            
            if (j != 1 && (i + j >= ans.Length || ans[i + j] != 0)) continue;
            
            memo[j] = true;
            
            ans[i] = j;
            if (j != 1) ans[i + j] = j;
            
            if (DFS(ans, i + 1, memo)) return true;
            
            ans[i] = 0;
            if (j != 1) ans[i + j] = 0;
            
            memo[j] = false;
        }
        
        return false;
    }
    
    public int[] ConstructDistancedSequence(int n) 
    {
        var arr = new int[n*2-1];
        
        var memo = new bool[n+1];
        
        DFS(arr, 0, memo);
        
        return arr;
    }
}
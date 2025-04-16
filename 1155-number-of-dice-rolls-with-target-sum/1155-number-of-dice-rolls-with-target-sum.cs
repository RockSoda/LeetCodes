public class Solution 
{
    private readonly int MOD = (int)Math.Pow(10, 9) + 7;
    
    private int Recurse(int n, int k, int target, int[][] memo)
    {
        if(n == 0 && target == 0) return 1;
        if(target <= 0 || n == 0) return 0;
        if(memo[n][target] != -1) return memo[n][target];
        
        int num = 0;
        for(int i = 1; i <= k; i++) num = (num + Recurse(n-1, k, target-i, memo)) % MOD;
        
        return memo[n][target] = num;
    }
    
    public int NumRollsToTarget(int n, int k, int target) 
    {
        var memo = new int[n+1][];
        for(int i = 0; i < n+1; i++)
        {
            memo[i] = new int[target+1];
            Array.Fill(memo[i], -1);
        }
        
        return Recurse(n, k, target, memo);
    }
}
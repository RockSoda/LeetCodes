public class Solution 
{
    private int Recurse(int n, Dictionary<int, int> memo)
    {
        if(n == 1) return 1;
        
        if(n == 2) return 2;
        
        if(memo.ContainsKey(n)) return memo[n];
        
        return memo[n] = Recurse(n-1, memo) + Recurse(n-2, memo);
    }
    
    public int ClimbStairs(int n) => Recurse(n, []);
}
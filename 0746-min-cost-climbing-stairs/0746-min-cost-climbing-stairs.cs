public class Solution 
{
    private int Recurse(int[] cost, int index, Dictionary<int, int> memo)
    {
        if(index >= cost.Length) return 0;
        
        if(memo.ContainsKey(index)) return memo[index];
        
        return memo[index] = Math.Min(Recurse(cost, index+1, memo)+cost[index], Recurse(cost, index+2, memo)+cost[index]);
    }
    
    public int MinCostClimbingStairs(int[] cost) 
    {
        var map = new Dictionary<int, int>();
        return Math.Min(Recurse(cost, 0, map), Recurse(cost, 1, map));
    }
}
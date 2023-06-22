public class Solution 
{
    private int Recurse(int[] prices, int index, bool isHolding, int[][] memo, int fee)
    {
        if(index >= prices.Length) return 0;
        
        if(memo[index][isHolding ? 1 : 0] != -1) return memo[index][isHolding ? 1 : 0];
        
        return memo[index][isHolding ? 1 : 0] = 
               Math.Max((isHolding ? prices[index] - fee : -prices[index]) +
                        Recurse(prices, index+1, !isHolding, memo, fee),
                        Recurse(prices, index+1, isHolding, memo, fee));
    }
    
    public int MaxProfit(int[] prices, int fee) 
    {
        var memo = new int[prices.Length][];
        for(int i = 0; i < memo.Length; i++)
        {
            memo[i] = new int[2];
            memo[i][0] = -1;
            memo[i][1] = -1;
        }
        
        return Recurse(prices, 0, false, memo, fee);
    }
}
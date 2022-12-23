public class Solution 
{
    private int Recurse(int[] prices, int index, bool isBought, Dictionary<(int, bool), int> memo)
    {
        if(index >= prices.Length) return 0;
        if(memo.ContainsKey((index, isBought))) return memo[(index, isBought)];
        
        int case1 = Recurse(prices, index+1, isBought, memo);
        
        int case2 = 0;
        if(isBought) case2 = Recurse(prices, index+2, false, memo) + prices[index];
        else case2 = Recurse(prices, index+1, true, memo) - prices[index];
        
        return memo[(index, isBought)] = Math.Max(case1, case2);
    }
    
    public int MaxProfit(int[] prices) 
    {
       var memo = new Dictionary<(int, bool), int>();
        
        return Recurse(prices, 0, false, memo);
    }
}
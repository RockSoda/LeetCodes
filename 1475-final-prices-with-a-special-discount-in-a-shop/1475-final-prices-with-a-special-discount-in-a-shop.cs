public class Solution 
{
    public int[] FinalPrices(int[] prices) 
    {
        var output = new int[prices.Length];
        for(int i = 0; i < output.Length; i++)
        {
            output[i] = prices[i];
            for(int j = i+1; j < output.Length; j++)
            {
                if(prices[j] > prices[i]) continue;

                output[i] -= prices[j];
                break;
            }
        }
        return output;
    }
}
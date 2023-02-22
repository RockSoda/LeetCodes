public class Solution 
{
    private int GetDaysNeeded(int[] weights, int midWeight)
    {
        int daysNeeded = 1, currWeight = 0;
        foreach(int weight in weights) 
        {
            if(currWeight + weight > midWeight) 
            {
                daysNeeded++;
                currWeight = 0;
            }
            currWeight = currWeight + weight;
        }
        
        return daysNeeded;
    }
    
    public int ShipWithinDays(int[] weights, int days) 
    {
        int maxWeight = weights.Max();
        int totalWeight = weights.Sum();
        
        while(maxWeight < totalWeight)
        {
            int midWeight = maxWeight + (totalWeight - maxWeight) / 2;
            int daysNeeded = GetDaysNeeded(weights, midWeight);
            
            if(daysNeeded > days)
                maxWeight = midWeight + 1;
            else 
                totalWeight = midWeight;
        }
        
        return maxWeight;
    }
}
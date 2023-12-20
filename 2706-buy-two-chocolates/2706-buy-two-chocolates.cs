public class Solution 
{
    public int BuyChoco(int[] prices, int money) 
    {
        int min1 = 101, min2 = 101;
        
        foreach (var price in prices)
        {
            if (price < min1)
            {
                min2 = min1;
                min1 = price;
            }
            else if (price < min2) min2 = price;
        }
        
        int output = money - (min1 + min2);
        return output >= 0 ? output : money;
    }
}
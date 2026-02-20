public class Solution 
{
    public int NumOfUnplacedFruits(int[] fruits, int[] baskets)
    {
        var isBasketFilled = new bool[baskets.Length];

        bool CanFindNextBasket(int fruit)
        {
            for(int i = 0; i < baskets.Length; i++)
            {
                if(isBasketFilled[i] || baskets[i] < fruit) continue;
                
                isBasketFilled[i] = true;
                return true;
            }

            return false;
        }
        
        var remained = 0;
        foreach(var fruit in fruits)
        {
            if(CanFindNextBasket(fruit)) continue;
            remained++;
        }
        return remained;
    }
}
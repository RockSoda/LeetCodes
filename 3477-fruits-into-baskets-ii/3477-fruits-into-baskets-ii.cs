public class Solution 
{
    public int NumOfUnplacedFruits(int[] fruits, int[] baskets)
    {
        var isBasketFilled = new bool[baskets.Length];

        int GetNextBasketIdx(int fruit)
        {
            for(int i = 0; i < baskets.Length; i++)
            {
                if(isBasketFilled[i] || baskets[i] < fruit) continue;
                
                isBasketFilled[i] = true;
                return i;
            }

            return -1;
        }
        
        var remained = 0;
        foreach(var fruit in fruits)
        {
            var idx = GetNextBasketIdx(fruit);
            if(idx != -1) continue;
            remained++;
        }
        return remained;
    }
}
public class Solution 
{
    private bool CanEatAll(int[] piles, int K, int h)
    {
        var time = 0;
        foreach(var pile in piles)
        {
            time += pile / K;
            if(pile % K != 0) time++;
        }
        
        return time <= h;
    }
    
    public int MinEatingSpeed(int[] piles, int h) 
    {
        int left = 1, right = piles.Max();
        
        while(left < right)
        {
            int K = left + (right - left) / 2;
            
            if(CanEatAll(piles, K, h)) right = K;
            else left = K + 1;
        }
        
        return left;
    }
}
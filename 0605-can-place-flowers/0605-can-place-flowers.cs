public class Solution 
{
    private bool CanPlace(int[] flowerbed, int index)
    {   
        if(flowerbed[index] == 1) return false;
        
        bool isLeftEmpty = true;
        bool isRightEmpty = true;
        
        if(index - 1 >= 0)
            isLeftEmpty = flowerbed[index-1] == 0;
        
        if(index + 1 < flowerbed.Length)
            isRightEmpty = flowerbed[index+1] == 0;
        
        return isLeftEmpty && isRightEmpty;
    }
    
    private bool Helper(int[] flowerbed, int flowers, int index, int[] memo)
    {
        if(flowers == 0) return true;
        if(index >= flowerbed.Length) return flowers == 0;
        
        if(memo[index] != -1) return memo[index] == 1;
        
        if(CanPlace(flowerbed, index))
        {
            flowerbed[index] = 1;
            memo[index] = Helper(flowerbed.ToArray(), flowers-1, index+1, memo) || Helper(flowerbed.ToArray(), flowers-1, index+2, memo) ? 1 : 0;
        }
        else memo[index] = Helper(flowerbed, flowers, index+1, memo) ? 1 : 0;
            
        return memo[index] == 1;
    }
    
    public bool CanPlaceFlowers(int[] flowerbed, int n) 
    {
        if(n == 0) return true;
        if(flowerbed.Length == 1) return flowerbed[0] == 0;
        int[] memo = new int[flowerbed.Length];
        Array.Fill(memo, -1);
        return Helper(flowerbed, n, 0, memo);
    }
}
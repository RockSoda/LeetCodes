public class Solution 
{
    public int LargestAltitude(int[] gain) 
    {
        int curr = 0;
        int max = 0;
        
        foreach(var flex in gain)
        {
            curr += flex;
            
            max = Math.Max(max, curr);
        }
        
        return max;
    }
}
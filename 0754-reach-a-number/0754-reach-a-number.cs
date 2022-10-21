public class Solution 
{
    public int ReachNumber(int target) 
    {
        if(target<0) target = -target;
        
        int step = 0;
        int sum = 0;
        
        while(true)
        {
            step++;
            sum = sum + step;
            
            if(sum == target || (sum > target && (sum - target) % 2 == 0)) return step;
        }
        
        return int.MaxValue;
    }
}
public class Solution 
{
    public bool CanSortArray(int[] nums) 
    {
        var setBits = new int[nums.Length];

        for(int i = 0; i < nums.Length; i++)
            setBits[i] = Convert.ToString(nums[i], 2).Count(c => c == '1');
        
        int prevMax = int.MinValue, 
            prevMin = int.MaxValue, 
            currMax = int.MinValue, 
            currMin = int.MaxValue, 
            prevBit = -1;
            
        for(int i = 0; i < nums.Length; i++)
        {
            int setBit = setBits[i], num = nums[i];
            if(prevBit == setBit)
            {
                currMin = Math.Min(currMin, num);
                currMax = Math.Max(currMax, num);
            }
            else
            {
                if(prevMax >= currMin) return false;
                prevMin = currMin;
                prevMax = currMax;
                currMax = num;
                currMin = num;
                prevBit = setBit;
            }
        }
        
        if(prevMax >= currMin) return false;
        return true;
    }
}
public class Solution 
{
    public int NumSubarrayProductLessThanK(int[] nums, int k) 
    {
        if (k <= 1) return 0;
        
        int product=1, right=-1, left=0, subArrCount=0;
        
        while(++right < nums.Length)
        {
            product *= nums[right];
            
            while(left < nums.Length && product >= k)
                product /= nums[left++];
            
            subArrCount += (right - left) + 1;
        }
        
        return subArrCount;
    }
}
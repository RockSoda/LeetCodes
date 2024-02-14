public class Solution 
{
    public int[] RearrangeArray(int[] nums) 
    {
        var output = new int[nums.Length];
        int positiveIdx = 0, negativeIdx = 1;
        
        foreach(var num in nums)
        {
            bool isPositive = num > 0;
            var idx = isPositive ? positiveIdx : negativeIdx;
            
            output[idx] = num;
            
            if(isPositive) positiveIdx += 2;
            else negativeIdx += 2;
        }
        
        return output;
    }
}
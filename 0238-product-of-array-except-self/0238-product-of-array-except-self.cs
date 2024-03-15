public class Solution 
{
    public int[] ProductExceptSelf(int[] nums) 
    {
        int[] output = new int[nums.Length];
        output[0] = 1;
        
        for(int i = 1; i < output.Length; i++) output[i] = output[i - 1] * nums[i - 1];
        
        int R = 1;
        
        for(int i = output.Length - 2; i >= 0; i--)
        {
            
            R *= nums[i + 1];
            output[i] *=  R;
        }
        
        return output;
    }
}
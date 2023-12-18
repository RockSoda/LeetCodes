public class Solution 
{
    public int MaxProductDifference(int[] nums) 
    {
        (int largest1, int largest2, int smallest1, int smallest2) = (0, 0, 1+(int)Math.Pow(10, 4), 1+(int)Math.Pow(10, 4));
        
        foreach(int num in nums)
        {
            if(num > largest1) (largest1, largest2) = (num, largest1);
            else if(num > largest2) largest2 = num;
            
            if(num < smallest1) (smallest1, smallest2) = (num, smallest1);
            else if(num < smallest2) smallest2 = num;
        }
        
        return largest1*largest2 - smallest1*smallest2;
    }
}
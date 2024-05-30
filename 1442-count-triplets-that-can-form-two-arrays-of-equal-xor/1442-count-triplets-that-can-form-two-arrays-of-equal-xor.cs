public class Solution 
{
    public int CountTriplets(int[] arr) 
    {
        int c = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            int s = 0;
            for(int k = i; k < arr.Length; k++)
            {
                s = s ^ arr[k];
                if(s == 0) c += k - i;
            }
        }
        
        return c;
    }
}
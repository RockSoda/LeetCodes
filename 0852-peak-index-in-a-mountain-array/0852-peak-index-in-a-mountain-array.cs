public class Solution 
{
    public int PeakIndexInMountainArray(int[] arr) 
    {
        int peak = arr[0];
        int idx = 0;
        
        for(int i = 1; i < arr.Length; i++)
        {
            if(arr[i] > peak)
            {
                peak = arr[i];
                idx = i;
            }
        }
        
        return idx;
    }
}
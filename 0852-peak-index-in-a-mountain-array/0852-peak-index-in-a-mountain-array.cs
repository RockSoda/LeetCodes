public class Solution 
{
    public int PeakIndexInMountainArray(int[] arr) 
    {
        int prev = arr[0];
        
        for(int i = 1; i < arr.Length-1; i++)
        {
            var curr = arr[i];
            if(curr > prev && curr > arr[i+1]) return i;
        }
        
        return -1;
    }
}
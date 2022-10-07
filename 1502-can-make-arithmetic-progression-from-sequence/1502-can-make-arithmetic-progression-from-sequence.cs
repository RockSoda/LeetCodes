public class Solution 
{
    public bool CanMakeArithmeticProgression(int[] arr) 
    {
        Array.Sort(arr);
        int d = arr[1] - arr[0];
        
        for(int i = 1; i < arr.Length; i++)
            if(arr[i] != arr[i-1]+d) return false;
        
        return true;
    }
}
public class Solution 
{
    public int MinNumberOperations(int[] target) 
    {
        int oprs = target.First();
        for(int i = 1; i < target.Length; i++)
        {
            int prev = target[i-1], curr = target[i];
            int diff = curr - prev;
            if(diff > 0) oprs += diff;
        }
        return oprs;
    }
}
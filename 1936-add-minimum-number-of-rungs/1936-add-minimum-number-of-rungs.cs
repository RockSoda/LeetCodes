public class Solution 
{
    public int AddRungs(int[] rungs, int dist) 
    {
        int added = 0, index = 0, curr = 0;
        while(index < rungs.Length)
        {
            if(curr + dist < rungs[index])
            {
                int toBeAdded = (rungs[index] - curr - 1) / dist;
                added += toBeAdded;
                curr += toBeAdded * dist;
                continue;
            }
            
            curr = rungs[index++];
        }
        
        return added;
    }
}
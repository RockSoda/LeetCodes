public class Solution 
{
    public int Flipgame(int[] fronts, int[] backs) 
    {
        //output can be found in backs 1 or more times
        //       cannot be found in fronts
        
        var sameVal = new HashSet<int>();
        for(int i = 0; i < fronts.Length; i++)
            if(fronts[i] == backs[i]) sameVal.Add(fronts[i]);
        
        var min = int.MaxValue;
        for(int i = 0; i < fronts.Length; i++)
        {
            if(!sameVal.Contains(fronts[i]) && min > fronts[i]) min = fronts[i];
            
            if(!sameVal.Contains(backs[i]) && min > backs[i]) min = backs[i];
        }
        
        return min == int.MaxValue ? 0 : min;
    }
}
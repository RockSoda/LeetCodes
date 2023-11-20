public class Solution 
{
    public int GarbageCollection(string[] garbage, int[] travel) 
    {
        int M = 0, P = 0, G = 0;
        for (int i = garbage.Length - 1; i > 0; i--)
        {
            int currM = garbage[i].Count(c => c == 'M');
            int currP = garbage[i].Count(c => c == 'P');
            int currG = garbage[i].Count(c => c == 'G');
            
            if(currM > 0 || M > 0) M += currM + travel[i-1];
            if(currP > 0 || P > 0) P += currP + travel[i-1];
            if(currG > 0 || G > 0) G += currG + travel[i-1];
        }
        
        M += garbage[0].Count(c => c == 'M');
        P += garbage[0].Count(c => c == 'P');
        G += garbage[0].Count(c => c == 'G');
        
        return M+P+G;
    }
}
public class Solution 
{
    public string[] FindRelativeRanks(int[] score) 
    {
        var len = score.Length;
        
        var idxs = new int[len];
        
        for(int i = 0; i < len; i++) idxs[i] = i;
        
        Array.Sort(score, idxs);
        
        Array.Reverse(idxs);
        
        var output = new string[len];
        
        for(int i = 0; i < len; i++) 
        {
            var idx = idxs[i];
            switch(i)
            {
                case 0:
                    output[idx] = "Gold Medal";
                    break;
                case 1:
                    output[idx] = "Silver Medal";
                    break;
                case 2:
                    output[idx] = "Bronze Medal";
                    break;
                default:
                    output[idx] = (i+1).ToString();
                    break;
            }
        }
        
        return output;
    }
}
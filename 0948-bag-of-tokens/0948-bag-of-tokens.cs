public class Solution 
{
    public int BagOfTokensScore(int[] tokens, int power) 
    {
        Array.Sort(tokens);
        int left = 0, right = tokens.Length - 1;
        int curr = 0, max = 0;
        
        while (left <= right) 
        {
            if (tokens[left] <= power) 
            {
                power -= tokens[left];
                curr++;
                max = Math.Max(max, curr);
                left++;
            } 
            else if (curr >= 1) 
            {
                power += tokens[right];
                curr--;
                right--;
            } 
            else  break;
        }
        
        return max;
    }
}
public class Solution 
{
    public int MinDeletionSize(string[] strs) 
    {
        int counter = 0;
        for(int i = 0; i < strs.First().Length; i++)
        {
            for(int j = 1; j < strs.Length; j++)
            {
                if(strs[j][i] < strs[j-1][i]) 
                {
                    counter++;
                    break;
                }
            }
        }
        
        return counter;
    }
}
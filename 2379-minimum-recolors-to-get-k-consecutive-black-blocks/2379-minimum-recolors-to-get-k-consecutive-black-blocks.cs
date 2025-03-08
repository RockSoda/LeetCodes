public class Solution 
{
    public int MinimumRecolors(string blocks, int k) 
    {
        int min = blocks.Length, numOfW = 0;
        for(int i = 0; i < blocks.Length; i++)
        {
            if(blocks[i] == 'W') numOfW++;

            if(i+1 < k) continue;

            min = Math.Min(min, numOfW);
            if(blocks[i-k+1] == 'W') numOfW--;
        }
        return min;
    }
}
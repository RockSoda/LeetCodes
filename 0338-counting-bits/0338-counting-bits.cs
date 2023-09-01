public class Solution 
{
    public int[] CountBits(int n) 
    {
        var output = new int[n+1];
        for(int i = 0; i <= n; i++)
            output[i] = Convert.ToString(i, 2).Count(bit => bit == '1');
        return output;
    }
}
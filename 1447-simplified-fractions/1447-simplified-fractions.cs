public class Solution 
{
    private int GCD(int a, int b)
    {
        while (a != 0 && b != 0)
        {
            if (a > b) a %= b;
            else b %= a;
        }

        return a | b;
    }
    
    public IList<string> SimplifiedFractions(int n) 
    {
        var output = new List<string>();
        for(int i = 1; i < n; i++)
        {
            for(int j = 2; j <= n; j++)
            {
                if(i >= j) continue;
                if(GCD(i, j) == 1) output.Add(i + "/" + j);
            }
        }
        
        return output;
    }
}
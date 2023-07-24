public class Solution 
{
    public double MyPow(double x, int n) 
    {
        if (n == 0) return 1;
        
        double curr = x;
        double res = 1;
        long N = Math.Abs((long)n);
        
        for(long i = N; i > 0; i = i / 2)
        {
            if (i % 2 == 1) res *= curr;
            
            curr *= curr;
        }
        
        return n < 0 ? 1 / res : res;
    }
}
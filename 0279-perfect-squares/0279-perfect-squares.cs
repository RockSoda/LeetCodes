public class Solution 
{
    private bool IsPerfect(int n)
    {
        int r = (int)Math.Sqrt(n);
        if(r*r == n) return true;
        
        return false;
    }
    
    public int NumSquares(int n) 
    {
        while(n % 4 == 0) n /= 4;
        
        if(n % 8 == 7) return 4;
        
        if(IsPerfect(n)) return 1;
        
        for(int i = 1; i * i <= n; i++) if(IsPerfect(n - i * i)) return 2;
        
        return 3;
    }
}
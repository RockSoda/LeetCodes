public class Solution 
{
    public int NumberOfMatches(int n) 
    {
        if (n <= 1) return 0;
        
        return (n % 2 == 0) ? n / 2 + NumberOfMatches(n / 2) : (n - 1) / 2 + 1 + NumberOfMatches((n - 1) / 2);
    }
}
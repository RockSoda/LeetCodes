public class Solution 
{
    public int NumberOfMatches(int n) 
    {
        int numOfMatches = 0;
        while(n > 1)
        {
            if(n % 2 == 0)
            {
                numOfMatches += n / 2;
                n /= 2;
            }
            else
            {
                numOfMatches += (n - 1) / 2;
                n = (n - 1) / 2 + 1;
            }
        }
        return numOfMatches;
    }
}
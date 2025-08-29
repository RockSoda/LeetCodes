public class Solution 
{
    public long FlowerGame(int n, int m) 
    {
        long GetNumOfPairs(int x, int y)
        {
            long xnumOfOdds =  x / 2 + (x % 2 == 1 ? 1 : 0);
            long ynumOfEvens =  y / 2;

            return xnumOfOdds * ynumOfEvens;
        }

        return GetNumOfPairs(n, m) + GetNumOfPairs(m, n);
    }
}
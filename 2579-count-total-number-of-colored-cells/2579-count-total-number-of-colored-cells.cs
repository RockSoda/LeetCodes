public class Solution 
{
    public long ColoredCells(int n) 
    {
        long input = (long)n;
        return 1 + 4 * (input * (input - 1)) / 2;
    }
}
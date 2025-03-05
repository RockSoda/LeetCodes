public class Solution 
{
    public long ColoredCells(int n) 
    {
        if (n == 1) return 1;

        return ColoredCells(n-1) + 4 * (n-1);
    }
}
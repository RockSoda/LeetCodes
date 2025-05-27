public class Solution 
{
    public int DifferenceOfSums(int n, int m) 
    {
        var sum = n * (n + 1) / 2;
        var num2 = 0;
        for(int i = 1; i <= n; i++)
        {
            if(i % m == 0) num2 += i;
        }
        return sum - 2 * num2;
    }
}
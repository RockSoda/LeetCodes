public class Solution 
{
    public int DifferenceOfSums(int n, int m) 
    {
        var sum = n * (n + 1) / 2;
        var num2 = 0;
        var multi = 1;

        while(m * multi <= n)
        {
            num2 += m * multi++;
        }

        return sum - 2 * num2;
    }
}
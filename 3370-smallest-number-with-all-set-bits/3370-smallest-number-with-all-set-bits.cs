public class Solution 
{
    public int SmallestNumber(int n) => Convert.ToInt32(new StringBuilder().Append('1', (int) (Math.Log(n, 2)) + 1).ToString(), 2);
}
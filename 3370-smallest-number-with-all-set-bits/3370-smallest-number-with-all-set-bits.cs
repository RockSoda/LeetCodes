public class Solution 
{
    public int SmallestNumber(int n) => (int)Math.Pow(2, Math.Ceiling(Math.Log(n + 1, 2))) - 1;
}
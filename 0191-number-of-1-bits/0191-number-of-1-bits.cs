public class Solution 
{
    public int HammingWeight(uint n) 
        => Convert.ToString(n, 2).Split('1').Length - 1;
}
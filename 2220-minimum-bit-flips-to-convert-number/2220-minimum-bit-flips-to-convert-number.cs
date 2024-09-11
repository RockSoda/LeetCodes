public class Solution 
{
    public int MinBitFlips(int start, int goal) =>
        Convert.ToString(start ^ goal, 2).Count(c => c == '1');
}
public class Solution 
{
    public int CountOdds(int low, int high) =>
        (high - low) / 2 + ((high % 2 == 0 && low % 2 == 0) ? 0 : 1);
}
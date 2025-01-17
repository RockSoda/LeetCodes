public class Solution 
{
    public bool DoesValidArrayExist(int[] derived) 
    {
        int prefix = 0;
        foreach(var curr in derived) prefix ^= curr;

        return prefix == 0;
    }
}
public class Solution 
{
    public int FindTheWinner(int n, int k) 
    {
        if(n == 1) return 1;
        
        return ((FindTheWinner(n-1, k) + k - 1) % n) + 1;
    }
}
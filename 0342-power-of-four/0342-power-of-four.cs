public class Solution 
{
    private double Logn(int n, int r) => Math.Log(n) / Math.Log(r);
    
    public bool IsPowerOfFour(int n) => 
        (n != 0) && Math.Floor(Logn(n, 4)) == Math.Ceiling(Logn(n, 4));
}
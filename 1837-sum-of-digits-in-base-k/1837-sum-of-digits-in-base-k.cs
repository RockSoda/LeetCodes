public class Solution 
{
    private string ConvertToBaseK(int n, int k)
    {
        var sb = new StringBuilder();
        while(n > 0)
        {
            char r = (char)('0' + n % k);
            n /= k;
            sb.Insert(0, r);
        }
        
        return sb.ToString();
    }
    
    public int SumBase(int n, int k) 
    {
        var baseK = ConvertToBaseK(n, k);
        return baseK.Select(digit => digit - '0').Sum();
    }
}
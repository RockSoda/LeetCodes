public class Solution 
{
    public int[] GetNoZeroIntegers(int n) 
    {
        bool ContainsZero(int num)
        {
            while(num > 0)
            {
                if(num % 10 == 0) return true;

                num /= 10;
            }
            return false;
        }

        for(int i = 1; i < n; i++)
        {
            if(!ContainsZero(i) && !ContainsZero(n-i)) return new int[]{ i, n-i };
        }
        
        return null;
    }
}
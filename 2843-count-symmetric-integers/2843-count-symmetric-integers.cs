public class Solution 
{
    public int CountSymmetricIntegers(int low, int high) 
    {
        var ans = 0;

        for(; low <= high; low++)
        {
            var curr = low.ToString();
            if((curr.Length & 1) == 1) continue;

            var half = curr.Length / 2;
            var firstHalf = curr.Take(half).Select(c => c-'0').Sum();
            var secondHalf = curr.Skip(half).Take(half).Select(c => c-'0').Sum();
            if(firstHalf == secondHalf) ans++;
        }

        return ans;
    }
}
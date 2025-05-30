public class Solution 
{
    public int CountSymmetricIntegers(int low, int high) 
    {
        int[] GetIntAry(int num, int len)
        {
            var ary = new int[len];
            int idx = len-1;
            while(num > 0)
            {
                var lastDigit = num % 10;
                ary[idx--] = lastDigit;
                num /= 10;
            }
            return ary;
        }

        var ans = 0;

        for(; low <= high; low++)
        {
            int len = low.ToString().Length;
            if((len & 1) == 1) continue;

            var ary = GetIntAry(low, len);

            var half = ary.Length / 2;
            var firstHalf = ary[..half].Sum();
            var secondHalf = ary[half..].Sum();
            if(firstHalf == secondHalf) ans++;
        }

        return ans;
    }
}
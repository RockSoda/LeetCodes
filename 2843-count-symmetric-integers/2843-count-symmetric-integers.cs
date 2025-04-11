public class Solution 
{
    public int CountSymmetricIntegers(int low, int high) 
    {
        void LoadIntAry(int num, int[] ary)
        {
            int idx = ary.Length-1;
            while(num > 0)
            {
                var lastDigit = num % 10;
                ary[idx--] = lastDigit;
                num /= 10;
            }
        }

        var ans = 0;

        for(; low <= high; low++)
        {
            int len = low.ToString().Length;
            if((len & 1) == 1) continue;

            var ary = new int[len];
            LoadIntAry(low, ary);

            var half = ary.Length / 2;
            var firstHalf = ary[..(ary.Length/2)].Sum();
            var secondHalf = ary[(ary.Length/2)..].Sum();
            if(firstHalf == secondHalf) ans++;
        }

        return ans;
    }
}
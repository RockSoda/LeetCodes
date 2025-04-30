public class Solution 
{
    public int FindNumbers(int[] nums) 
    {
        bool IsEvenNumberOfDigits(int num)
        {
            int count = 0;
            while(num > 0)
            {
                num /= 10;
                count++;
            }
            return (count & 1) == 0;
        }

        int ans = 0;
        foreach(var num in nums)
        {
            if(IsEvenNumberOfDigits(num)) ans++;
        }
        return ans;
    }
}
public class Solution 
{
    public int MaximumSum(int[] nums) 
    {
        int GetSumOfDigits(int num)
        {
            int input = num, output = 0;

            while(input > 0)
            {
                var digit = input % 10;
                output += digit;
                input /= 10;
            }

            return output;
        }

        Array.Sort(nums);
        var sumMap = new Dictionary<int, int>();
        int max = -1;

        for(int i = nums.Length - 1; i >= 0; i--)
        {
            var num = nums[i];
            var currSum = GetSumOfDigits(num);
            
            if(!sumMap.ContainsKey(currSum)) sumMap[currSum] = num;
            else max = Math.Max(sumMap[currSum]+num, max);
        }

        return max;
    }
}
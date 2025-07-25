public class Solution 
{
    public int MaxSum(int[] nums) 
    {
        var sum = 0;
        var visited = new HashSet<int>();
        var max = nums.First();
        foreach(var num in nums)
        {
            if(num < 0)
            {
                max = Math.Max(max, num);
                continue;
            }

            if(visited.Add(num)) sum += num;
        }

        if(visited.Count == 0) return max;

        return sum;
    }
}
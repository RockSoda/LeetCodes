public class Solution 
{
    public int MaxSum(int[] nums) 
    {
        var sum = 0;
        var visited = new HashSet<int>();
        foreach(var num in nums)
        {
            if(num < 0) continue;
            if(visited.Add(num)) sum += num;
        }

        if(visited.Count == 0) return nums.Max();

        return sum;
    }
}
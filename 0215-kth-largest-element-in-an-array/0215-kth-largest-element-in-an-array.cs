public class Solution 
{
    public int FindKthLargest(int[] nums, int k) 
    {
        var pq = new PriorityQueue<int, int>();
        for(int i = 0; i < nums.Length; i++) pq.Enqueue(i, -nums[i]);
        
        while(k > 1)
        {
            pq.Dequeue();
            k--;
        }
        
        return nums[pq.Dequeue()];
    }
}
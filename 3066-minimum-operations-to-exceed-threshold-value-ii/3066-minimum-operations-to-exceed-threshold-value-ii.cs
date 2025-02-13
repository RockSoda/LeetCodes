public class Solution 
{
    public int MinOperations(int[] nums, int k) 
    {
        var pq = new PriorityQueue<long, long>(nums.Select(x => ((long)x, (long)x)));

        var counter = 0;
        while(pq.Count > 1)
        {
            var x = pq.Dequeue();
            var y = pq.Dequeue();

            if(x >= k && y >= k) break;

            var val = Math.Min(x, y) * 2 + Math.Max(x, y);
            pq.Enqueue(val, val);
            counter++;
        }

        return counter;
    }
}
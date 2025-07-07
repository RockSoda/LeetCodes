public class Solution 
{
    public int MaxEvents(int[][] events) 
    {
        var sortedEvents = events.ToList().OrderBy(e => e[0]).ThenBy(e => e[1]).ToList();
        var pq = new PriorityQueue<int, int>();
        
        var count = 0;
        var availableDay = 1;
        foreach (var e in sortedEvents)
        {
            while (pq.TryPeek(out var start, out var end) && Math.Max(start, availableDay) < e[0])
            {
                var s = pq.Dequeue();
                if (end < availableDay) continue;

                count++;
                availableDay = Math.Max(s + 1, availableDay + 1);
            }
            
            pq.Enqueue(e[0], e[1]);
        }

        while (pq.TryDequeue(out var start, out var end))
        {
            if (end < availableDay) continue;
            
            count++;
            availableDay = Math.Max(start + 1, availableDay + 1);
        }

        return count;
    }
}
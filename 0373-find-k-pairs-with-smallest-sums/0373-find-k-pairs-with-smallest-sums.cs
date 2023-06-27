public class Solution
{
    public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k)
    {
        var output = new List<IList<int>>();
        var pq = new PriorityQueue<(int sum, int idx), int>();
        
        void PriorityEnqueue(int num, int idx)
        {
            var sum = num + nums2[idx];
            pq.Enqueue((sum, idx), sum);
        }
        
        foreach(var num in nums1) PriorityEnqueue(num, 0);
        
        while(k-- > 0 && pq.Count > 0)
        {
            var (sum, idx) = pq.Dequeue();
            var num = sum-nums2[idx];
            output.Add(new List<int>{ num, nums2[idx] });
            
            if(idx+1 >= nums2.Length) continue;
            
            PriorityEnqueue(num, idx+1);
        }
        
        return output;
    }
}
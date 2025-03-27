public class Solution 
{
    public int MinimumIndex(IList<int> nums) 
    {
        (int, int) GetDominantAndFreq()
        {
            var map = new Dictionary<int, int>();
            foreach(var num in nums)
                map[num] = map.ContainsKey(num) ? map[num]+1 : 1;

            foreach(var kvp in map)
            {
                if(kvp.Value < nums.Count / 2 + 1) continue;
                return (kvp.Key, kvp.Value);
            }
            return (-1, -1);
        }

        (int dominant, int freq) = GetDominantAndFreq();

        int leftLen = 0, rightLen = nums.Count, leftFreq = 0, rightFreq = freq;

        for(int i = 0; i < nums.Count; i++)
        {
            int curr = nums[i];
            if(curr == dominant)
            {
                leftFreq++;
                rightFreq--;
            }

            leftLen++;
            rightLen--;

            if(leftFreq >= leftLen / 2 + 1 && rightFreq >= rightLen / 2 + 1) return i;
        }

        return -1;
    }
}
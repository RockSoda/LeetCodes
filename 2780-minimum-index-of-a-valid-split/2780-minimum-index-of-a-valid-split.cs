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
                if(IsDominant(kvp.Value, nums.Count)) return (kvp.Key, kvp.Value);
            }
            return (-1, -1);
        }

        bool IsDominant(int freq, int len) => freq >= len / 2 + 1;

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

            if(IsDominant(leftFreq, leftLen) && IsDominant(rightFreq, rightLen)) return i;
        }

        return -1;
    }
}
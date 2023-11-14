public class Solution 
{
    public int CountPalindromicSubsequence(string s) 
    {
        var set = new HashSet<string>();
        
        var map = new Dictionary<char, Queue<int>>();
        
        for(int right = 2; right < s.Length; right++)
        {
            if(!map.ContainsKey(s[right-2])) map[s[right-2]] = new Queue<int>();
            
            map[s[right-2]].Enqueue(right-2);
            
            if(!map.ContainsKey(s[right])) continue;
            
            var left = map[s[right]].Count > 1 ? map[s[right]].Dequeue() : map[s[right]].Peek();
            
            for(int mid = left+1; mid < right; mid++) set.Add(new string(new char[]{ s[left], s[mid], s[right] }));
        }
        
        return set.Count;
    }
}
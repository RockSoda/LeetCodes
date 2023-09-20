public class Solution 
{
    public IList<string> FindRepeatedDnaSequences(string s) 
    {
        var map = new Dictionary<string, int>();
        for(int i = 0; i < s.Length-9; i++)
        {
            var curr = s.Substring(i, 10);
            
            if(!map.ContainsKey(curr)) map[curr] = 0;
            map[curr]++;
        }
        
        return map.Where(kvp => kvp.Value > 1).Select(kvp => kvp.Key).ToList();
    }
}
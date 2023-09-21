public class Solution 
{
    public string GetHint(string secret, string guess) 
    {
        var map = new Dictionary<char, HashSet<int>>();
        for(int i = 0; i < secret.Length; i++)
        {
            var key = secret[i];
            if(!map.ContainsKey(key)) map[key] = new HashSet<int>(); 
            map[key].Add(i);
        }
        
        int bulls = 0, cows = 0;
        var countOccurance = new int[10];
        var couldBeCows = new HashSet<int>();
        
        for(int i = 0; i < guess.Length; i++)
        {
            var c = guess[i];
            
            if(!map.ContainsKey(c) || countOccurance[c-'0'] >= map[c].Count) continue;
            
            if(map[c].Contains(i)) bulls++;
            else
            {
                couldBeCows.Add(i);
                continue;
            }
            
            countOccurance[c-'0']++;
        }
        
        foreach(var index in couldBeCows)
        {
            var c = guess[index];
            
            if(countOccurance[c-'0'] >= map[c].Count) continue;
            
            cows++;
            
            countOccurance[c-'0']++;
        }
        
        return bulls + "A" + cows + "B";
    }
}
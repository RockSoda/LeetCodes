public class Solution 
{
    public int NumOfStrings(string[] patterns, string word) 
    {
        var set = new HashSet<string>();
        for(int i = 0; i < word.Length; i++)
        {
            var sb = new StringBuilder();
            for(int j = i; j < word.Length; j++)
            {
                sb.Append(word[j]);
                set.Add(sb.ToString());
            }
        }
        
        var counter = 0;
        foreach(var pattern in patterns)
            if(set.Contains(pattern)) counter++;
        
        return counter;
    }
}
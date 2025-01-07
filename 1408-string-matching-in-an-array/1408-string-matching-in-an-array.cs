public class Solution 
{
    public IList<string> StringMatching(string[] words) 
    {
        var output = new List<string>();
        var set = new HashSet<int>();
        for(int i = 0; i < words.Length; i++)
        {
            for(int j = 0; j < words.Length; j++)
            {
                if(i == j || set.Contains(j)) continue;
                if(words[i].Contains(words[j]))
                {
                    output.Add(words[j]);
                    set.Add(j);
                } 
            }
        }
        return output;
    }
}
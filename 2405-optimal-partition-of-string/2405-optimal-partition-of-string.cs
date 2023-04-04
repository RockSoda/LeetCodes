public class Solution 
{
    public int PartitionString(string s) 
    {
        var set = new HashSet<char>();
        int counter = 0;
        for(int i = 0; i < s.Length; i++)
        {
            if(set.Add(s[i])) continue;
            
            counter++;
            set.Clear();
            set.Add(s[i]);
        }
        
        return counter+1;
    }
}
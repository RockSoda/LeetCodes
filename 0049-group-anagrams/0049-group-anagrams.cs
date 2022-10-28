public class Solution 
{
    private string GetKey(string str)
    {
        var charAry = str.ToCharArray();
        Array.Sort(charAry);
        return new string(charAry);
    }
    
    public IList<IList<string>> GroupAnagrams(string[] strs) 
    {
        var map = new Dictionary<string, List<string>>();
        foreach(var str in strs)
        {
            var key = GetKey(str);
            if(map.ContainsKey(key)) map[key].Add(str);
            else map[key] = new List<string>{ str };
        }
        
        return new List<IList<string>>(map.Values);
    }
}
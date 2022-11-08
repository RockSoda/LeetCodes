public class Solution 
{
    public string Evaluate(string s, IList<IList<string>> knowledge) 
    {
        var map = new Dictionary<string, string>();
        
        foreach(var k in knowledge) map[k[0]] = k[1];
        
        var output = new StringBuilder();
        
        var key = new StringBuilder();
        bool isKey = false;
        foreach(var c in s)
        {
            if(c == '(')
            {
                isKey = true;
                continue;
            }
            
            if(c == ')')
            {
                output.Append(map.ContainsKey(key.ToString()) ? map[key.ToString()] : "?");
                key.Clear();
                isKey = false;
                continue;
            }
            
            if(isKey) key.Append(c);
            else output.Append(c);
        }
        
        return output.ToString();
        
        
    }
}
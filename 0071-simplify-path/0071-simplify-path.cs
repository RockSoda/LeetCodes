public class Solution 
{
    public string SimplifyPath(string path) 
    {
        var stk = new Stack<string>();
        
        for(int i = 0; i < path.Length; i++)
        {
            char c = path[i];
            if(c == '/') continue;
            
            var sb = new StringBuilder();
            for(; i < path.Length && path[i] != '/'; i++)
                sb.Append(path[i]);
            
            if(sb.ToString() == "..")
            {
                if(stk.Count > 0) stk.Pop();
                continue;
            }
            
            if(sb.ToString() == ".") continue;
            
            stk.Push(sb.ToString());
        }
        
        var output = new StringBuilder();
        
        while(stk.Count > 0)
            output.Insert(0, "/" + stk.Pop());
        
        return output.Length == 0 ? "/" : output.ToString();
    }
}
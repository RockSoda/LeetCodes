public class Solution 
{
    public IList<string> RemoveSubfolders(string[] folder) 
    {
        Array.Sort(folder);
        
        var set = new HashSet<string>();
        
        foreach(string path in folder)
        {
            var arr = path.Split('/', StringSplitOptions.RemoveEmptyEntries);
            var sb = new StringBuilder();
            bool flag = false;
            foreach(string entry in arr)
            {
                sb.Append('/');
                sb.Append(entry);
                if(set.Contains(sb.ToString()))
                {
                    flag = true;
                    break;
                }
            }
            
            if(!flag) set.Add(sb.ToString());
        }
        
        return set.ToList();
    }
}
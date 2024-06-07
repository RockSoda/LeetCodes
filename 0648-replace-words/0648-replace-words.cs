public class Solution 
{
    public string ReplaceWords(IList<string> dictionary, string sentence) 
    {
        var dict = dictionary.OrderBy(s => s.Length).ToHashSet();
        
        var strAry = sentence.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        
        for(int i = 0; i < strAry.Length; i++)
        {
            foreach(var s in dict)
            {
                if(!strAry[i].StartsWith(s)) continue;
                
                strAry[i] = s;
                break;
            }
        }
        
        var sb = new StringBuilder();
        foreach(var str in strAry)
        {
            sb.Append(str);
            sb.Append(" ");
        }
        sb.Remove(sb.Length - 1, 1);
        return sb.ToString();
    }
}
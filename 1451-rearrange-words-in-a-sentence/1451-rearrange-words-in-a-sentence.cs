public class Solution 
{
    public string ArrangeWords(string text) 
    {
        var txtList = text.Split(" ").OrderBy(txt => txt.Length).ToList();
        var strBuilder = new StringBuilder();
        for(int i = 0; i < txtList.Count; i++)
        {
            var txt = txtList[i].ToLower();
            if (i == 0) txt = char.ToUpper(txt[0]) + txt[1..];
            
            strBuilder.Append(txt);
            if (i != txtList.Count-1) strBuilder.Append(" ");
        }
        
        return strBuilder.ToString();
    }
}
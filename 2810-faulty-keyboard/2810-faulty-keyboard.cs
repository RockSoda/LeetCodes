public class Solution 
{
    public string FinalString(string s) 
    {
        var list = new List<char>();
        foreach(var c in s)
        {
            if(c == 'i') list.Reverse();
            else list.Add(c);
        }
        return new string(list.ToArray());
    }
}
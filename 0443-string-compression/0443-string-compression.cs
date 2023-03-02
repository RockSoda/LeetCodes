public class Solution 
{
    public int Compress(char[] chars) 
    {
        var list = new List<char>();
        var prev = chars[0];
        int counter = 0;
        for(int i = 0; i < chars.Length; i++)
        {
            if(prev == chars[i]) counter++;
            else
            {
                list.Add(prev);
                if(counter > 1)
                {
                    foreach(var c in counter.ToString())
                        list.Add(c);
                }
                counter = 0;
                prev = chars[i];
                i--;
            }
        }
        
        if(counter > 0)
        {
            list.Add(prev);
            if(counter > 1)
            {
                foreach(var c in counter.ToString())
                    list.Add(c);
            }
        }
        
        for(int i = 0; i < list.Count; i++)
            chars[i] = list[i];
        
        return list.Count;
    }
}
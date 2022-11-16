public class Solution 
{
    public int FindContentChildren(int[] g, int[] s) 
    {
        Array.Sort(g);
        Array.Sort(s);
        
        int counter = 0;
        foreach(var child in g)
        {
            for(int i = 0; i < s.Length; i++)
            {
                if(s[i] >= child)
                {
                    counter++;
                    s[i] = -1;
                    break;
                }
            }
        }
        
        return counter;
    }
}
public class Solution 
{
    public int ReverseDegree(string s) 
    {
        int GetReversed(char c) => 'z'-c+1;

        var output = 0;
        for(int i = 0; i < s.Length; i++)
        {
            var c = s[i];
            output += GetReversed(c)*(i+1);
        }
        
        return output;
    }
}
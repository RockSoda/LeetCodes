public class Solution 
{
    private int GetDiff(char first, char second, string s)
    {
        int counter = 0;
        for(int i = 0; i < s.Length; i += 2)
        {
            if(s[i] != first) counter++;
            if(s[i+1] != second) counter++;
        }
        
        return counter / 2;
    }
    
    public int MinSwaps(string s) 
    {
        if(s.Length % 2 == 0)
        {
            if(s.Count(c => c == '0') != s.Count(c => c == '1'))
                return -1;
            
            return Math.Min(GetDiff('0', '1', s), GetDiff('1', '0', s));
        }
        else
        {
            int num0 = s.Count(c => c == '0');
            int num1 = s.Count(c => c == '1');
            if(Math.Abs(num0 - num1) != 1) return -1;
            
            char majority = num0 > num1 ? '0' : '1';
            char minority = majority == '0' ? '1' : '0';
            int counter = 0;
            for(int i = 0; i < s.Length - 1; i += 2)
            {
                if(s[i] != majority) counter++;
                if(s[i+1] != minority) counter++;
            }
            counter += s.Last() != majority ? 1 : 0;
            return counter / 2;
        }
        
    }
}
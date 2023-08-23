public class Solution 
{
    
    public string ReorganizeString(string s) 
    {
        var map = new int[26];
        int size = s.Length, mostFreq = 0, i = 0;
        
        foreach(var c in s) 
            if(++map[c-'a'] > map[mostFreq])
                mostFreq = c - 'a';
        
        bool IsPossible() => 
            map[mostFreq] <= (size % 2 == 1 ? 1 : 0) + (size / 2);
        
        if (!IsPossible()) return string.Empty;
        
        char[] output = new char[size];
        
        void FillAry(int freq)
        {
            output[i] = (char)(freq + 'a');
            i += 2;
            map[freq]--;
        }
        
        while(map[mostFreq] > 0) FillAry(mostFreq);
        
        for(int j = 0; j < 26; j++)
        {
            while(map[j] > 0)
            {
                if(i >= size) i = 1;
                FillAry(j);
            }
        }
        
        return new string(output);
    }
}
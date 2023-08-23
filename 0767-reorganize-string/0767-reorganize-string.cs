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
        
        while(map[mostFreq] > 0)
        {
            output[i] = (char)('a' + mostFreq);
            i += 2;
            map[mostFreq]--;
        }
        
        for(int j = 0; j < 26; j++) 
        {
            while(map[j] > 0) 
            {
                if(i >= size) i = 1;
                output[i] = (char)('a' + j);
                map[j]--;
                i += 2;
            }
	    }
        
        return new string(output);
    }
}
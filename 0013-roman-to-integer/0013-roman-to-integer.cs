public class Solution 
{
    public int RomanToInt(string s) 
    {
        int[] map = new int[26];
        map['I' - 'A'] = 1;
        map['V' - 'A'] = 5;
        map['X' - 'A'] = 10;
        map['L' - 'A'] = 50;
        map['C' - 'A'] = 100;
        map['D' - 'A'] = 500;
        map['M' - 'A'] = 1000;

        int GetVal(char c) => map[c - 'A'];

        int output = 0;
        for(int i = s.Length-1; i >= 0; i--)
        {
            int tmp = GetVal(s[i]);
            
            if(i != 0)
            {
                int prev = GetVal(s[i-1]);

                if(prev < tmp)
                {
                    tmp -= prev;
                    i--;
                }
            }

            output += tmp;
        }

        return output;
    }
}


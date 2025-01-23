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

        int output = 0;
        for(int i = s.Length-1; i >= 0; i--)
        {
            int tmp = map[s[i] - 'A'];
            
            if(i != 0)
            {
                int prev = map[s[i-1] - 'A'];

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


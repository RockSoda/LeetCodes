public class Solution 
{
    public int MinSwaps(string s) 
    {
        int left = 0, right = s.Length-1;
        int numOfOpen = 0, numOfSwaps = 0;
        int GetNextOpen()
        {
            for(int i = right; i >= 0; i--)
            {
                if(s[i] == '[') return i;
            }
            return -1;
        }

        while(left < right)
        {
            if (s[left] == ']')
            {
                if (numOfOpen > 0) numOfOpen--;
                else
                {
                    right = GetNextOpen();
                    if(left >= right) break;
                    right--;
                    numOfOpen++;
                    numOfSwaps++;
                }
            }
            else numOfOpen++;

            left++;
        }
        return numOfSwaps;
    }
}
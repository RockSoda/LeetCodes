public class Solution 
{
    public int PossibleStringCount(string word) 
    {
        int possibility = 1;
        for(int i = 0; i < word.Length; i++)
        {
            int counter = 1;
            for(int j = i + 1; j < word.Length; j++)
            {
                if(word[i] != word[j]) break;
                i = j;
                counter++;
            }
            possibility += counter-1;
        }
        return possibility;
    }
}
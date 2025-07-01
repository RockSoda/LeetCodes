public class Solution 
{
    public int PossibleStringCount(string word) 
    {
        int possibility = 1, counter = 1;
        var prev = word[0];
        for(int i = 1; i < word.Length; i++)
        {
            var curr = word[i];

            if (prev == curr) counter++;
            else 
            {
                possibility += counter - 1;
                counter = 1;
                prev = curr;
            }
        }
        return counter > 1 ? possibility + counter - 1 : possibility;
    }
}
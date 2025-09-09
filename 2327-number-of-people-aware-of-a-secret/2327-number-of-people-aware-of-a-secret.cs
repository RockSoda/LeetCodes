public class Solution 
{    
    private int MOD = (int)Math.Pow(10, 9) + 7;

    public int PeopleAwareOfSecret(int n, int delay, int forget) 
    {
        var people = new int[n];
        var knows = new int[n];
        
        people[0] = 1;

        for (int day = 0; day < n; day++)
        {
            if (people[day] == 0) continue;
            for (int d = day; d < n && d < day + forget; d++)
            {
                knows[d] = (knows[d] + people[day]) % MOD;
            }

            for (int d = day + delay; d < day + forget && d < n; d++) 
            {
                people[d] = (people[d] + people[day]) % MOD;
            }
        }
        
        return knows[n-1];
    }
}
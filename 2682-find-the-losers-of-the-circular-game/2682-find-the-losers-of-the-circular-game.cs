public class Solution 
{
    public int[] CircularGameLosers(int n, int k) 
    {
        var players = new HashSet<int>();
        for(int i = 1; i <= n; i++) players.Add(i);

        var curr = 1;
        var rounds = 1;

        do
        {
            players.Remove(curr);
            curr = (curr + rounds * k) % n;
            if(curr == 0) curr = n;
            rounds++;
        }
        while(players.Contains(curr));

        return players.ToArray();
    }
}
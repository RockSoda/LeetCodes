public class Solution 
{
    public int TimeRequiredToBuy(int[] tickets, int k) 
    {
        int target = tickets[k];
        int totalTime = 0;
        for(int i = 0; i < tickets.Length; i++)
        {
            var ticket = tickets[i];
            
            if(ticket >= target) totalTime += i <= k ? target : target - 1;
            else totalTime += ticket;
        }
        return totalTime;
    }
}
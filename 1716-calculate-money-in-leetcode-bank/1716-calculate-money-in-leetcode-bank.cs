public class Solution 
{
    public int TotalMoney(int n) 
    {
        int GetSum (int start, int len)
        {
            int end = start + len - 1;
            return ((start + end) * len) / 2;
        }
        
        int rounds = n / 7;
        int remaind = n % 7;
        
        int money = 0;
        
        for(int i = 1; i <= rounds; i++)
            money += GetSum(i, 7);
        
        money += GetSum(rounds+1, remaind);
        return money;
    }
}
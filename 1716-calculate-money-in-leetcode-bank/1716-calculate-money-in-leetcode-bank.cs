public class Solution 
{
    public int TotalMoney(int n) 
    {
        int rounds = n / 7;
        int remaind = n % 7;
        
        int money = 0;
        
        for(int i = 1; i <= rounds; i++)
            money += ((2 * i + 6) * 7) / 2;
        
        money += ((2 * (rounds + 1) + remaind - 1) * remaind) / 2;
        return money;
    }
}
public class Solution 
{
    public bool LemonadeChange(int[] bills) 
    {
        (int five, int ten) pocket = (0, 0);
        
        foreach(var bill in bills)
        {
            if(bill == 20)
            {
                if(pocket.ten > 0 && pocket.five > 0)
                {
                    pocket.ten--;
                    pocket.five--;
                }
                else
                {
                    pocket.five -= 3;
                    if(pocket.five < 0) return false;
                }
            }
            else if(bill == 10)
            {
                pocket.five--;
                if(pocket.five < 0) return false;
                pocket.ten++;
            }
            else pocket.five++;
        }
        
        return true;
    }
}
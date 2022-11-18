public class Solution 
{
    public bool IsUgly(int n) 
    {
        if(n <= 0) return false;
        
        bool flag = false;
        while(n > 1)
        {
            flag = false;
            if(n % 2 == 0)
            {
                n /= 2;
                flag = true;
            }
            if(n % 3 == 0)
            {
                n /= 3;
                flag = true;
            }
            if(n % 5 == 0)
            {
                n /= 5;
                flag = true;
            }
            
            if(!flag) return false;
        }
        
        return true;
    }
}
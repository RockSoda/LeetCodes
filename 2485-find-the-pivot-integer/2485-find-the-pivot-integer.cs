public class Solution 
{
    public int PivotInteger(int n) 
    {
        int ComputeSum(int n) => n * (n + 1) / 2;
        
        int frontSum = 0;
        int backSum = ComputeSum(n);

        for(int i = 1; i <= n; i++)
        {
            frontSum = ComputeSum(i);
            backSum -= i - 1;
            
            if(backSum == frontSum) return i;
        }
        
        return -1;
    }
}
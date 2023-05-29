public class Solution 
{
    public double CalculateTax(int[][] brackets, int income) 
    {
        int prevUpper = 0;
        double tax = 0;
        var currentIncome = (double)income;
        foreach(var bracket in brackets)
        {
            if(currentIncome <= 0) return tax;
            var upper = bracket[0] - prevUpper;
            
            var amountToBeTaxed = currentIncome >= upper ? (double)upper : currentIncome;
            
            tax += amountToBeTaxed * ((double)(bracket[1]) / 100);
            currentIncome -= amountToBeTaxed;
            prevUpper = bracket[0];
        }
        
        return tax;
    }
}
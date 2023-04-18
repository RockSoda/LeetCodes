public class Solution 
{
    //((1 + x) * x) / 2 = ((x + n) * (n - x + 1)) / 2

    //(1 + x) * x = (x + n) * (n - x + 1)

    //0 = -2x^2 + n^2 + n
    
    //x = ((n^2 + n) / 2)^.5

    public int PivotInteger(int n) 
    {
        var pivot = Math.Sqrt((Math.Pow(n, 2) + n) / 2);
        
        return pivot % 1 == 0 ? (int)pivot : -1;
    }
}
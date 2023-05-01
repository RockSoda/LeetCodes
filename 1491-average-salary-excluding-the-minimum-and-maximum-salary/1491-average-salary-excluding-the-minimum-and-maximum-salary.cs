public class Solution 
{
    public double Average(int[] salary) 
    {
        int max = salary.Max();
        int min = salary.Min();
        int sum = salary.Sum();
        
        return (double)(sum-max-min)/(double)(salary.Length-2);
    }
}
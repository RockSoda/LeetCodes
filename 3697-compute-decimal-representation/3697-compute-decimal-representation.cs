public class Solution 
{
    public int[] DecimalRepresentation(int n) 
    {
        int input = n;
        var output = new List<int>();
        int pow = 0;
        while(input > 0)
        {
            var component = (input%10)*(int)Math.Pow(10, pow);
            if(component > 0) output.Insert(0, component);
            input /= 10;
            pow++;
        }
        return output.ToArray();
    }
}
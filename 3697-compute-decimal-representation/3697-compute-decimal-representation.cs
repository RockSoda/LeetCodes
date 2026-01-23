public class Solution 
{
    public int[] DecimalRepresentation(int n) 
    {
        int input = n;
        var output = new List<int>();
        int mod = 10;
        while(input > 0)
        {
            var component = input % mod;
            if(component > 0) output.Insert(0, component);
            input -= component;
            mod *= 10;
        }
        return output.ToArray();
    }
}
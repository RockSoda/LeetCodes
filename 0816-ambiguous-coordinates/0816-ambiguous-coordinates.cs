public class Solution 
{
    private bool IsLegal(string num)
    {
        //'1' '.'
        if(num.Length == 1) return num != ".";
        
        //'00' '001' '00.01'
        if(num[0] == '0' && num[1] == '0') return false;
        
        int decimalPointIdx = num.IndexOf('.');
        
        //01.2
        if(num[0] == '0' && decimalPointIdx != 1) return false;
        
        //'.1'
        if(decimalPointIdx == 0) return false;
        
        //'123' '01'
        if(decimalPointIdx == -1) return num[0] != '0';
        
        //'0.0' '0.00' '1.0'
        return num.Last() != '0';
    }
    
    private List<string> GetAllDecimals(string num)
    {
        var list = new List<string>();
        
        if(IsLegal(num)) list.Add(num);
        
        for(int i = 1; i < num.Length; i++)
        {
            var currNum = num.Insert(i, ".");
            if(IsLegal(currNum)) list.Add(currNum);
        }
        return list;
    }
    
    public IList<string> AmbiguousCoordinates(string s) 
    {
        var input = s.Substring(1, s.Length-2);
        var output = new List<string>();
        var firstHalf = new StringBuilder();
        
        for(int i = 0; i < input.Length-1; i++)
        {
            firstHalf.Append(input[i]);
            var secondHalf = input.Substring(i+1);
            
            var firstList = GetAllDecimals(firstHalf.ToString());
            var secondList = GetAllDecimals(secondHalf);
            
            foreach(var firstNum in firstList)
                secondList.ForEach(secondNum => output.Add("(" + firstNum + ", " + secondNum + ")"));
        }
        
        return output;
    }
}
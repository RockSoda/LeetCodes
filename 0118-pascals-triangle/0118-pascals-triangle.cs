public class Solution 
{
    public IList<IList<int>> Generate(int numRows) 
    {
        var output = new List<IList<int>>();
        if(numRows == 0) return output;
            
        output.Add(new List<int>{ 1 });
        if(numRows == 1) return output;
        
        output.Add(new List<int>{ 1, 1 });
        if(numRows == 2)  return output;
        
        for(int i = 0; i < numRows-2; i++)
        {
            var lastRow = output.Last();
            int sizeLastRow = lastRow.Count;
            var currentRow = new List<int>();
            
            currentRow.Add(1);
            for(int j = 1; j < sizeLastRow; j++)
                currentRow.Add(lastRow[j-1]+lastRow[j]);
            currentRow.Add(1);
            
            output.Add(currentRow);
        }
        
        return output;
    }
}
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
            var lastRow = output[output.Count-1];
            int sizeLastRow = lastRow.Count;
            var currentRow = new List<int>();
            for(int j = 0; j < sizeLastRow+1; j++)
            {
                if(j == 0 || j == sizeLastRow) currentRow.Add(1);
                else currentRow.Add(lastRow[j-1]+lastRow[j]);
            }
            output.Add(currentRow);
        }
        return output;
    }
}
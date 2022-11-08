public class Solution 
{
    public IList<string> CellsInRange(string s) 
    {
        var output = new List<string>();
        
        var inputAry = s.Split(":");
        
        int startCol = inputAry[0][0]-'A';
        int endCol = inputAry[1][0]-'A';
        
        int startRow = inputAry[0][1]-'0';
        int endRow = inputAry[1][1]-'0';
        
        for(int i = startCol; i <= endCol; i++)
        {
            for(int j = startRow; j <= endRow; j++) output.Add(((char)(i+'A')).ToString()+j);
        }
        
        return output;
    }
}
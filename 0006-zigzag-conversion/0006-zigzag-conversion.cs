public class Solution 
{
    public string Convert(string s, int numRows) 
    {
        if(numRows == 1) return s;
        
        int n = numRows - 2;
        int remain = s.Length % (numRows+n);
        int numCols;
        
        if(remain>numRows)
            numCols = (s.Length/(numRows+n))*(1+n)+1+remain%numRows;
        else
            numCols = (s.Length/(numRows+n))*(1+n)+1;
            
        
        char[][] trav = new char[numRows][];
        for(int i = 0; i < numRows; i++)
        {
            trav[i] = new char[numCols];
            Array.Fill(trav[i], ' ');
        }
        
        int index = 0;
        int rowZZ = numRows-2;
        for(int j = 0; j < numCols; j++)
        {
            if(index % (numRows+n) == 0)
            {
                rowZZ = numRows-2;
                for(int i = 0; i < numRows; i++)
                {
                    try
                    {
                        trav[i][j] = s[index];
                        index++;
                    }
                    catch(Exception e){ }
                }
            }
            else
            {
                trav[rowZZ][j] = s[index];
                index++;
                rowZZ--;
            }
        }
        
        string output = "";
        for(int i = 0; i < numRows; i++)
        {
            for(int j = 0; j < numCols; j++)
            {
                if(trav[i][j] != ' ') output += trav[i][j]+"";
            }
        }
        return output;
    }
}
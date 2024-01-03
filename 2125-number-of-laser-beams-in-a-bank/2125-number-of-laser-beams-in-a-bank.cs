public class Solution 
{
    public int NumberOfBeams(string[] bank) 
    {
        var numOfDevOnRow = new List<int>();
        foreach(var row in bank)
        {
            var numOfDev = row.Count(c => c == '1');
            if(numOfDev > 0) numOfDevOnRow.Add(numOfDev);
        }
        
        var output = 0;
        for(int i = 0; i < numOfDevOnRow.Count - 1; i++)
            output += numOfDevOnRow[i] * numOfDevOnRow[i+1];
        
        return output;
    }
}
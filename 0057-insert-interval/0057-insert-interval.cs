public class Solution
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        var output = new List<int[]>();
        var newAry = new int[] { -1, -1 };
        bool isAdded = false;
        for (int i = 0; i < intervals.Length; i++)
        {
            if (intervals[i][1] < newInterval[0])
                output.Add(intervals[i]);
            else if (intervals[i][0] > newInterval[1])
            {
                if (newAry[1] == -1)
                {
                    if(i > 0 && intervals[i-1][1] > newInterval[1]) 
                        newAry[1] = intervals[i - 1][1];
                    else 
                        newAry[1] = newInterval[1];
                }
                
                if (newAry[0] == -1) newAry[0] = newInterval[0];
                if (!isAdded)
                {
                    output.Add(newAry);
                    isAdded = true;
                }
                output.Add(intervals[i]);
            }
            else if (intervals[i][1] >= newInterval[0] && intervals[i][0] <= newInterval[0] && newAry[0] == -1)
            {
                newAry[0] = intervals[i][0];
            }
            else if (intervals[i][0] <= newInterval[1] && intervals[i][1] >= newInterval[1] && newAry[0] != -1)
            {
                newAry[1] = intervals[i][1];
                if (!isAdded)
                {
                    output.Add(newAry);
                    isAdded = true;
                }
            }
            else if (intervals[i][0] == newInterval[1])
            {
                newAry[1] = intervals[i][1];
            }
        }

        if(!isAdded)
        {
            if (newAry[0] == -1) newAry[0] = newInterval[0];

            if(intervals.Length > 0) 
                newAry[1] = newInterval[1] > intervals.Last()[1] ? newInterval[1] : intervals.Last()[1];
            else 
                newAry[1] = newInterval[1];
            
            output.Add(newAry);
        }

        return output.ToArray();
    }
}
public class Solution 
{
    public bool CheckValidCuts(int n, int[][] rectangles) 
    {
        int GetNumOfCuts(List<(int start, int end)> list)
        {
            var sorted = list.OrderBy(a => a.start).ThenByDescending(a => a.end);

            (int start, int end) prev = (-1, -1);
            int numOfCuts = 0;
            foreach((int start, int end) curr in sorted)
            {
                if(prev == (-1, -1))
                {
                    prev = curr;
                    continue;
                }

                if(curr.start == prev.start) continue;

                if(prev.end > curr.start) 
                {
                    prev = (prev.start, Math.Max(prev.end, curr.end));
                    continue;
                }

                numOfCuts++;
                prev = curr;
            }
            
            return numOfCuts;
        }

        bool CheckVertical()
        {
            var selected = rectangles.Select(rect => (rect[0], rect[2])).ToList();

            return GetNumOfCuts(selected) >= 2;
        }

        bool CheckHorizontal()
        {
            var selected = rectangles.Select(rect => (rect[1], rect[3])).ToList();

            return GetNumOfCuts(selected) >= 2;
        }

        return CheckVertical() || CheckHorizontal();
    }
}
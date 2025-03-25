public class Solution 
{
    public bool CheckValidCuts(int n, int[][] rectangles) 
    {
        bool CheckVertical()
        {
            var sorted = rectangles.OrderBy(rect => rect[0]).ThenByDescending(rect => rect[2]);
            (int l, int r) prev = (-1, -1);
            int numOfCuts = 0;
            foreach(var rect in sorted)
            {
                (int l, int r) curr = (rect[0], rect[2]);
                if(prev == (-1, -1))
                {
                    prev = curr;
                    continue;
                }

                if(curr.l == prev.l) continue;

                if(prev.r > curr.l) 
                {
                    prev = (prev.l, Math.Max(prev.r, curr.r));
                    continue;
                }

                numOfCuts++;
                prev = curr;
            }
            
            return numOfCuts >= 2;
        }

        bool CheckHorizontal()
        {
            var sorted = rectangles.OrderBy(rect => rect[1]).ThenByDescending(rect => rect[3]);
            (int d, int u) prev = (-1, -1);
            int numOfCuts = 0;
            foreach(var rect in sorted)
            {
                (int d, int u) curr = (rect[1], rect[3]);
                if(prev == (-1, -1))
                {
                    prev = curr;
                    continue;
                }

                if(curr.d == prev.d) continue;

                if(prev.u > curr.d)
                {
                    prev = (prev.d, Math.Max(prev.u, curr.u));
                    continue;
                }

                numOfCuts++;
                prev = curr;
            }

            return numOfCuts >= 2;
        }

        return CheckVertical() || CheckHorizontal();
    }
}
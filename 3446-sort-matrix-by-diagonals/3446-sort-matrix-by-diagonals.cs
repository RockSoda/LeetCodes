public class Solution 
{
    public int[][] SortMatrix(int[][] grid) 
    {
        (int, int)[] GetFirstIdxs()
        {
            var startingIdxs = new (int, int)[grid.Length];
            int row = grid.Length-1, col = 0, idx = 0;
            while(row >= 0)
            {
                startingIdxs[idx++] = (row, col);
                row--;
            }
            return startingIdxs;
        }

        (int, int)[] GetSecondIdxs()
        {
            var startingIdxs = new (int, int)[grid[0].Length-1];
            int row = 0, col = 0,idx = 0;
            while(idx < startingIdxs.Length)
            {
                col++;
                startingIdxs[idx++] = (row, col);
            }
            return startingIdxs;
        }

        void SortDiagonal((int, int)[] idxs, bool isAscending)
        {
            foreach((int idxI, int idxJ) in idxs)
            {
                int i = idxI, j = idxJ;
                var idxList = new List<(int, int)>();
                var valList = new List<int>();
                while(i < grid.Length && j < grid[i].Length)
                {
                    idxList.Add((i, j)); 
                    valList.Add(grid[i][j]);
                    i++;
                    j++;
                }
                var list = isAscending ? valList.OrderBy(ele => ele).ToList() : valList.OrderByDescending(ele => ele).ToList();
                int idx = 0;
                foreach((int x, int y) in idxList) grid[x][y] = list[idx++];
            }
        }

        var firstHalf = GetFirstIdxs();
        var secondHalf = GetSecondIdxs();
        
        SortDiagonal(firstHalf, false);
        SortDiagonal(secondHalf, true);
        return grid;
    }
}
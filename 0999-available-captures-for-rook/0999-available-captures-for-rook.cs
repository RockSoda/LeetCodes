public class Solution 
{
    public int NumRookCaptures(char[][] board) 
    {
        (int, int) GetRookPos()
        {
            for(int i = 0; i < board.Length; i++)
            {
                for(int j = 0; j < board[i].Length; j++)
                {
                    if(board[i][j] == 'R') return (i, j);
                }
            }
            return (-1, -1);
        }

        int CaptureVer(int i, int j)
        {
            int idx = i;
            int captured = 0;
            while(idx >= 0)
            {
                if(board[idx][j] == 'p' || board[idx][j] == 'B')
                {
                    if(board[idx][j] == 'p') captured++;
                    break;
                }
                idx--;
            }

            idx = i;
            while(idx < board.Length)
            {
                if(board[idx][j] == 'p' || board[idx][j] == 'B')
                {
                    if(board[idx][j] == 'p')captured++;
                    break;
                }
                idx++;
            }
            return captured;
        }

        
        int CaptureHor(int i, int j)
        {
            int idx = j;
            int captured = 0;
            while(idx >= 0)
            {
                if(board[i][idx] == 'p' || board[i][idx] == 'B')
                {
                    if(board[i][idx] == 'p') captured++;
                    break;
                }
                idx--;
            }

            idx = j;
            while(idx < board[i].Length)
            {
                if(board[i][idx] == 'p' || board[i][idx] == 'B')
                {
                    if(board[i][idx] == 'p') captured++;
                    break;
                }
                idx++;
            }
            return captured;
        }

        (int x, int y) = GetRookPos();
        return CaptureVer(x, y) + CaptureHor(x, y);
    }
}
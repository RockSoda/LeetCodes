public class Solution 
{
    private char GetRevealed(char[][] board, int x, int y)
    {
        if(board[x][y] == 'M') return 'X';
        
        if(board[x][y] != 'E') return '-';
        
        int mines = 0;
        if (x + 1 < board.Length && board[x + 1][y] == 'M') mines++;
        if (y + 1 < board[x].Length && board[x][y + 1] == 'M') mines++;
        if (x + 1 < board.Length && y + 1 < board[x].Length && board[x + 1][y + 1] == 'M') mines++;
        if (x - 1 >= 0 && board[x - 1][y] == 'M') mines++;
        if (y - 1 >= 0 && board[x][y - 1] == 'M') mines++;
        if (x - 1 >= 0 && y - 1 >= 0 && board[x - 1][y - 1] == 'M') mines++;
        if (x - 1 >= 0 && y + 1 < board[x].Length && board[x - 1][y + 1] == 'M') mines++;
        if (x + 1 < board.Length && y - 1 >= 0 && board[x + 1][y - 1] == 'M') mines++;

        if (mines == 0) return 'B';

        return (char)(mines + '0');
    }
    
    private void Reveal(char[][] board, int x, int y)
    {
        if(x < 0 || x >= board.Length || y < 0 || y >= board[x].Length) return;
        
        var c = GetRevealed(board, x, y);
        if(c == '-') return;
        
        board[x][y] = c;
        
        if(board[x][y] == 'B')
        {
            Reveal(board, x+1, y);
            Reveal(board, x, y+1);
            Reveal(board, x+1, y+1);
            Reveal(board, x-1, y);
            Reveal(board, x, y-1);
            Reveal(board, x-1, y-1);
            Reveal(board, x+1, y-1);
            Reveal(board, x-1, y+1);
        }
    }
    
    public char[][] UpdateBoard(char[][] board, int[] click) 
    {
        Reveal(board, click[0], click[1]);
        return board;
    }
}
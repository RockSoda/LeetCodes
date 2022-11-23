public class Solution 
{
    private HashSet<char> Set;
    
    private bool CheckSub(char[][] board, int row, int col)
    {
        Set.Clear();
        for(int i = row; i < row + 3; i++)
        {
            for(int j = col; j < col + 3; j++)
            {
                if(!char.IsDigit(board[i][j])) continue;
                if(!Set.Add(board[i][j])) return false;
            }
        }
        
        return true;
    }
    
    private bool CheckRow(char[][] board, int col)
    {
        Set.Clear();
        for(int i = 0; i < board.Length; i++)
        {
            if(!char.IsDigit(board[i][col])) continue;
            if(!Set.Add(board[i][col])) return false;
        }
        
        return true;
    }
    
    private bool CheckCol(char[][] board, int row)
    {
        Set.Clear();
        for(int i = 0; i < board[row].Length; i++)
        {
            if(!char.IsDigit(board[row][i])) continue;
            if(!Set.Add(board[row][i])) return false;
        }
    
        return true;
    }
    
    public bool IsValidSudoku(char[][] board) 
    {
        Set = new HashSet<char>();
        
        for(int i = 0; i < board.Length; i++)
            if(!CheckCol(board, i)) return false;
        
        for(int i = 0; i < board[0].Length; i++)
            if(!CheckRow(board, i)) return false;
        
        for(int i = 0; i < board.Length; i += 3)
        {
            for(int j = 0; j < board[i].Length; j += 3)
                if(!CheckSub(board, i, j)) return false;
        }
        
        return true;
    }
}
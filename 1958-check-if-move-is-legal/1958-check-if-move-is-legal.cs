public class Solution 
{
    private bool CheckUp(char[][] board, int i, int j, char color)
    {
        int counter = 1;
        for(int row = i-1; row >= 0; row--)
        {
            counter++;
            if(board[row][j] == color && counter >= 3) return true;
            if(board[row][j] == '.') return false;
            if(board[row][j] == color && counter < 3) return false;
        }
        
        return false;
    }
    
    private bool CheckDown(char[][] board, int i, int j, char color)
    {
        int counter = 1;
        for(int row = i+1; row < board.Length; row++)
        {
            counter++;
            if(board[row][j] == color && counter >= 3) return true;
            if(board[row][j] == '.') return false;
            if(board[row][j] == color && counter < 3) return false;
        }
        
        return false;
    }
    
    private bool CheckLeft(char[][] board, int i, int j, char color)
    {
        int counter = 1;
        for(int col = j-1; col >= 0; col--)
        {
            counter++;
            if(board[i][col] == color && counter >= 3) return true;
            if(board[i][col] == '.') return false;
            if(board[i][col] == color && counter < 3) return false;
        }
        
        return false;
    }
    
    private bool CheckRight(char[][] board, int i, int j, char color)
    {
        int counter = 1;
        for(int col = j+1; col < board.Length; col++)
        {
            counter++;
            if(board[i][col] == color && counter >= 3) return true;
            if(board[i][col] == '.') return false;
            if(board[i][col] == color && counter < 3) return false;
        }
        
        return false;
    }
    
    private bool CheckUpLeft(char[][] board, int i, int j, char color)
    {
        int counter = 1;
        int row = i-1;
        int col = j-1;
        
        while(row >= 0 && col >= 0)
        {
            counter++;
            if(board[row][col] == color && counter >= 3) return true;
            if(board[row][col] == '.') return false;
            if(board[row][col] == color && counter < 3) return false;
            row--;
            col--;
        }
        
        return false;
    }
    
    private bool CheckUpRight(char[][] board, int i, int j, char color)
    {
        int counter = 1;
        int row = i-1;
        int col = j+1;
        
        while(row >= 0 && col < board[row].Length)
        {
            counter++;
            if(board[row][col] == color && counter >= 3) return true;
            if(board[row][col] == '.') return false;
            if(board[row][col] == color && counter < 3) return false;
            row--;
            col++;
        }
        
        return false;
    }
    
    private bool CheckDownLeft(char[][] board, int i, int j, char color)
    {
        int counter = 1;
        int row = i+1;
        int col = j-1;
        
        while(row < board.Length && col >= 0)
        {
            counter++;
            if(board[row][col] == color && counter >= 3) return true;
            if(board[row][col] == '.') return false;
            if(board[row][col] == color && counter < 3) return false;
            row++;
            col--;
        }
        
        return false;
    }
    
    private bool CheckDownRight(char[][] board, int i, int j, char color)
    {
        int counter = 1;
        int row = i+1;
        int col = j+1;
        
        while(row < board.Length && col < board[row].Length)
        {
            counter++;
            if(board[row][col] == color && counter >= 3) return true;
            if(board[row][col] == '.') return false;
            if(board[row][col] == color && counter < 3) return false;
            row++;
            col++;
        }
        
        return false;
    }
    
    public bool CheckMove(char[][] board, int rMove, int cMove, char color) 
    {
        board[rMove][cMove] = color;
        
        return 
            CheckUp(board, rMove, cMove, color) ||
            CheckDown(board, rMove, cMove, color) ||
            CheckLeft(board, rMove, cMove, color) ||
            CheckRight(board, rMove, cMove, color) ||
            CheckUpLeft(board, rMove, cMove, color) ||
            CheckUpRight(board, rMove, cMove, color) ||
            CheckDownLeft(board, rMove, cMove, color) ||
            CheckDownRight(board, rMove, cMove, color);
    }
}
public class Solution 
{
    private bool DFS(char[][] board, string word, int index, int i, int j)
    {
        if(index >= word.Length) return true;
        if(i < 0 || i >= board.Length || j < 0 || j >= board[i].Length || board[i][j] != word[index]) return false;
        
        board[i][j] = '-';
        
        bool left = DFS(board, word, index+1, i, j - 1);
        bool right = DFS(board, word, index+1, i, j + 1);
        bool up = DFS(board, word, index+1, i - 1, j);
        bool down = DFS(board, word, index+1, i + 1, j);
        
        board[i][j] = word[index];
        
        return left || right || up || down;
    }
    
    public bool Exist(char[][] board, string word) 
    {
        for(int i = 0; i < board.Length; i++)
        {
            for(int j = 0; j < board[i].Length; j++)
            {
                if(board[i][j] == word.First() && DFS(board, word, 0, i, j))
                    return true;
            }
        }
        
        return false;
    }
}
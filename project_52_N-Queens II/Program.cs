
int n1 = 4;

Console.WriteLine(TotalNQueens(n1));


int TotalNQueens(int n)
{

    char[][] board = new char[n][];

    for (int i = 0; i < board.Length; i++)
    {
        board[i] = new char[n];
        for (int j = 0; j < board.Length; j++)
        {
            board[i][j] = '.';
        }
    }

    int[] result = new int[1];
    SolveBoard(board, result, 0);

    return result[0];
}



void SolveBoard(char[][] board,int[] count,int row)
{
    if(row == board.Length)
    {
        count[0]++;
        return;
    }

    for (int col = 0;col < board.Length;col++)
    {
        if (IsSafe(board,row,col))
        {
            board[row][col] = 'Q';
            SolveBoard(board, count, row + 1);
            board[row][col] = '.';
        }
    }

}

bool IsSafe(char[][] board, int row, int col)
{

    for (int i = 0; i < row; i++)
    {
        if (board[i][col] == 'Q') { return false; }

        int left = col - (row - i);
        int rigth = col + (row - i);

        if(left >= 0 && board[i][left] == 'Q') { return false; }
        if(rigth < board.Length && board[i][rigth] == 'Q') { return false; }
    }

    return true;
}

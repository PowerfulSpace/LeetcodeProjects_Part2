

int n1 = 4;

SolveNQueens(n1);

Console.ReadLine();


IList<IList<string>> SolveNQueens(int n)
{
    IList<IList<string>> res = new List<IList<string>>();
    char[][] board = new char[n][];
    for (int i = 0; i < n; i++)
    {
        board[i] = new string('.', n).ToCharArray();
    }
    Backtrack(res, board, n, 0);
    return res;
}
void Backtrack(IList<IList<string>> res, char[][] board, int n, int row)
{
    if (row == n)
    {
        List<string> currentResult = new List<string>();
        for (int i = 0; i < n; i++)
        {
            currentResult.Add(new string(board[i]));
        }
        res.Add(currentResult);
        return;

    }

    for (int col = 0; col < n; col++)
    {
        if (!IsValidPosition(board, row, col)) continue;

        board[row][col] = 'Q';
        Backtrack(res, board, n, row + 1);
        board[row][col] = '.';
    }
}

bool IsValidPosition(char[][] board, int row, int col)
{
    int n = board.Length;

    for (int i = 0; i < n; i++)
    {
        if (board[row][i] == 'Q' || board[i][col] == 'Q') return false;
    }

    for (int r = row - 1, c = col - 1; r >= 0 && c >= 0; r--, c--)
    {
        if (board[r][c] == 'Q') return false;
    }

    for (int r = row - 1, c = col + 1; r >= 0 && c < n; r--, c++)
    {
        if (board[r][c] == 'Q') return false;
    }

    return true;
}
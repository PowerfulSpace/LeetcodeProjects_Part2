
int n1 = 4;

SolveNQueens(n1);

Console.ReadLine();


IList<IList<string>> SolveNQueens(int n)
{
    var output = new List<IList<string>>();
    if (n == 1)
    {
        output.Add(new List<string>() { "Q" });
        return output;
    }

    char[][] board = new char[n][];

    for (int i = 0; i < n; i++)
    {
        board[i] = new char[n];
        for (int j = 0; j < n; j++)
        {
            board[i][j] = '.';
        }
    }

    SolveBoard(board, output, 0);

    Print(output);

    return output;
}
void SolveBoard(char[][] board, List<IList<string>> output, int row)
{
    if (row == board.Length)
    {
        var solved = new List<string>();

        foreach (var bRow in board)
        {
            solved.Add(string.Join("", bRow));
        }
        output.Add(solved);
        return;
    }

    for (int col = 0; col < board.Length; col++)
    {
        if (IsSafe(board, row, col))
        {
            board[row][col] = 'Q';
            SolveBoard(board, output, row + 1);
            board[row][col] = '.';
        }
    }
}

bool IsSafe(char[][] board, int row, int col)
{
    for (int i = 0; i < row; i++)
    {
        if (board[i][col] == 'Q') return false;

        int leftDiagonal = col - (row - i);
        int righttDiagonal = col + (row - i);

        if (leftDiagonal >= 0 && board[i][leftDiagonal] == 'Q') return false;
        if (righttDiagonal < board.Length && board[i][righttDiagonal] == 'Q') return false;
    }

    return true;
}

void Print(List<IList<string>> output)
{
    Console.WriteLine();

    foreach (var item in output)
    {
        foreach (var item2 in item)
        {
            Console.WriteLine(item2);
        }
        Console.WriteLine();
    }
}


int n1 = 4;

SolveNQueens(n1);

Console.ReadLine();


IList<IList<string>> SolveNQueens(int n)
{
    var output = new List<IList<string>>();

    char[][] board = new char[4][];

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
        List<string> list = new List<string>();
        
        foreach (var item in board)
        {
            list.Add(string.Join("",item));
        }

        output.Add(list);

        return;
    }

    for (int col = 0; col < board.Length; col++)
    {
        if (isSafe(board, row, col))
        {
            board[row][col] = 'Q';
            SolveBoard(board, output, row + 1);
            board[row][col] = '.';
        }

    }

}

bool isSafe(char[][] board, int row, int col)
{

    for (int step = 0; step < row; step++)
    {
        if (board[step][col] == 'Q') { return false; }

        int left = col - (row - step);
        int rigth = col + (row - step);

        if(left >= 0 && board[step][left] == 'Q') { return false; }
        if(rigth < board.Length && board[step][rigth] == 'Q') { return false; }
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

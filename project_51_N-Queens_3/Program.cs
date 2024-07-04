
using System.Text;

int n1 = 4;

SolveNQueens(n1);

Console.ReadLine();


int size;
IList<IList<string>> solutions;
IList<IList<string>> SolveNQueens(int n)
{
    size = n;
    solutions = new List<IList<string>>();
    char[,] emptyBoard = new char[n, n];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            emptyBoard[i, j] = '.';
        }
    }
    Backtrack(0, new HashSet<int>(), new HashSet<int>(), new HashSet<int>(), emptyBoard);

    return solutions;
}
void AddSolution(char[,] board)
{
    IList<string> solution = new List<string>();
    StringBuilder sb;
    for (int i = 0; i < size; i++)
    {
        sb = new StringBuilder();
        for (int j = 0; j < size; j++)
        {
            sb.Append(board[i, j]);
        }
        solution.Add(sb.ToString());
    }
    solutions.Add(solution);
}

void Backtrack(int row, HashSet<int> cols, HashSet<int> ds, HashSet<int> ads, char[,] board)
{
    if (row == size)
    {
        AddSolution(board);
        return;
    }

    for (int col = 0; col < size; col++)
    {
        int cd = row - col;
        int cad = row + col;
        if (cols.Contains(col) || ds.Contains(cd) || ads.Contains(cad))
        {
            continue;
        }
        cols.Add(col);
        ds.Add(cd);
        ads.Add(cad);
        board[row, col] = 'Q';

        Backtrack(row + 1, cols, ds, ads, board);

        cols.Remove(col);
        ds.Remove(cd);
        ads.Remove(cad);
        board[row, col] = '.';
    }
}
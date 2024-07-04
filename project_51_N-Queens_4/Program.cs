

int n1 = 4;

SolveNQueens(n1);

Console.ReadLine();

IList<IList<string>> results = new List<IList<string>>();
IList<IList<string>> SolveNQueens(int n)
{
    IList<IList<string>> results = new List<IList<string>>();

    // Helper function to create the board configuration from queen positions
    List<string> CreateBoard(List<int> state)
    {
        List<string> board = new List<string>();
        for (int i = 0; i < n; i++)
        {
            char[] row = new char[n];
            Array.Fill(row, '.');
            row[state[i]] = 'Q';
            board.Add(new string(row));
        }
        return board;
    }

    // The backtracking function
    void Backtrack(int row, bool[] cols, bool[] diagonals, bool[] antiDiagonals, List<int> state)
    {
        // If we've reached the end of the rows, it means we've found a solution
        if (row == n)
        {
            results.Add(CreateBoard(state));
            return;
        }

        for (int col = 0; col < n; col++)
        {
            // Calculate the diagonal and anti-diagonal
            int diag = row - col + n - 1;
            int antiDiag = row + col;

            // Check if the position is under attack
            if (cols[col] || diagonals[diag] || antiDiagonals[antiDiag])
            {
                continue;
            }

            // Add the position to our state
            cols[col] = true;
            diagonals[diag] = true;
            antiDiagonals[antiDiag] = true;
            state.Add(col);

            // Move to the next row
            Backtrack(row + 1, cols, diagonals, antiDiagonals, state);

            // Remove the position from our state (backtrack)
            cols[col] = false;
            diagonals[diag] = false;
            antiDiagonals[antiDiag] = false;
            state.RemoveAt(state.Count - 1);
        }
    }

    // Initial call to the backtracking function
    Backtrack(0, new bool[n], new bool[2 * n - 1], new bool[2 * n - 1], new List<int>());
    return results;
}
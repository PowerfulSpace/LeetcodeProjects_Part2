



int[][] grid1 = new int[3][]
{
    new int[3] {1,3,1 },
    new int[3] {1,5,1 },
    new int[3] {4,2,1 }
};
int[][] grid2 = new int[2][]
{
    new int[3] {1,2,5 },
    new int[3] {3,2,1}
};

int[][] grid3 = new int[7][]
{
    new int[8] {1, 4, 8, 6, 2, 2, 1, 7 },
    new int[8] {4, 7, 3, 1, 4, 5, 5, 1 },
    new int[8] {8, 8, 2, 1, 1, 8, 0, 1 },
    new int[8] {8, 9, 2, 9, 8, 0, 8, 9 },
    new int[8] {5, 7, 5, 7, 1, 8, 5, 5 },
    new int[8] {7, 0, 9, 4, 5, 6, 5, 6 },
    new int[8] {4, 9, 9, 7, 9, 1, 9, 0 }
};

Console.WriteLine(MinPathSum(grid1));
Console.WriteLine(MinPathSum(grid2));
Console.WriteLine(MinPathSum(grid3));


Console.ReadLine();


int MinPathSum(int[][] grid)
{
    int col = 1; // skips 0, 0
    for (int row = 0; row < grid.Length; ++row)
    {
        while (col < grid[row].Length)
        {
            int cost = int.MaxValue;
            if (row - 1 >= 0)
            {
                cost = grid[row - 1][col];
            }
            if (col - 1 >= 0 && grid[row][col - 1] < cost)
            {
                cost = grid[row][col - 1];
            }

            grid[row][col] += cost;

            ++col;
        }
        col = 0;
    }

    int lastRow = grid.Length - 1;
    int lastCol = grid[lastRow].Length - 1;
    return grid[lastRow][lastCol];
}

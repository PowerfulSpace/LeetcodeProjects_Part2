

int[][] grid1 = new int[3][]
{
    new int[3] {1,3,1 },
    new int[3] {1,5,1 },
    new int[3] {4,2,1 }
};
int[][] grid2 = new int[2][]
{
    new int[3] {1,2,3 },
    new int[3] {4,5,6}
};

int[][] grid3 = new int[1][]
{
    new int[4] {9,1,4,8 }
};

Console.WriteLine(MinPathSum(grid1));
Console.WriteLine(MinPathSum(grid2));
Console.WriteLine(MinPathSum(grid3));


Console.ReadLine();


int MinPathSum(int[][] grid)
{
    int[] array = { int.MaxValue,0 };
    int result = GetPathSum(grid, 0, 0, 0, array);
    return array[0];
}

int GetPathSum(int[][] grid, int y, int x, int sum, int[] minSum)
{
    if (y > grid.Length || x > grid[0].Length) { return sum; }

    if (minSum[1] == (grid[0].Length + grid.Length) - 1)
    {
        minSum[0] = Math.Min(sum, minSum[0]);

        return sum;
    }

    for (int i = x; i < grid[0].Length; i++)
    {
        if (y < grid.Length)
        {
            sum += grid[y][i];
            minSum[1] += 1;
            sum = GetPathSum(grid, y, i + 1, sum, minSum);
        }

        sum = GetPathSum(grid, y + 1, i, sum, minSum);

        if (y < grid.Length)
        {
            sum -= grid[y][i];
            minSum[1] -= 1;
        }
    }

    return sum;
}
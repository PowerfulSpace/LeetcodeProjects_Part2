



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
    int[,] pathSum = new int[grid.Length, grid[0].Length];

    CalculateArray(grid, pathSum);

    int y = grid.Length - 1;
    int x = grid[0].Length - 1;

    int sum = grid[y][x];

    while (y != 0 || x != 0)
    {
        if (y == 0)
        {
            while (x != 0)
            {
                sum += grid[y][x - 1];
                x--;
            }
            break;
        }
        if (x == 0)
        {
            while (y != 0)
            {
                sum += grid[y - 1][ x];
                y--;
            }
            break;
        }

        if (pathSum[y - 1, x] < pathSum[y, x - 1])
        {
            sum += grid[y - 1][ x];
            y--;
        }
        else
        {
            sum += grid[y][x - 1];
            x--;
        }
    }

    return sum;
}

void CalculateArray(int[][] grid, int[,] pathSum)
{
    pathSum[0, 0] = grid[0][0];
    for (int i = 1; i < grid[0].Length; i++)
    {
        pathSum[0, i] = pathSum[0, i - 1] + grid[0][i];
    }
    for (int i = 1; i < grid.Length; i++)
    {
        pathSum[i, 0] = pathSum[i - 1, 0] + grid[i][0];
    }

    for (int i = 1; i < grid.Length; i++)
    {
        for (int j = 1; j < grid[i].Length; j++)
        {
            pathSum[i, j] = pathSum[i,j] + pathSum[i - 1, j] + pathSum[i, j - 1];
        }
    }
}

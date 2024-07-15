

int[][] grid1 = new int[3][]
{
    new int[3] {1,3,1 },
    new int[3] {1,5,1 },
    new int[3] {4,2,1 }
};

Console.WriteLine(MinPathSum(grid1));


Console.ReadLine();


int MinPathSum(int[][] grid)
{

    int result = GetPathSum(grid, 0,0,0);
    return result;
}

int GetPathSum(int[][] grid, int y, int x, int sum)
{
    if (y > grid.Length) { return sum; }
    if (y == grid.Length && x == grid[0].Length - 1)
    { 
        return sum;
    }

    for (int i = x; i < grid.Length; i++)
    {
        int result = 0;

        if(y < grid.Length)
        {
            sum += grid[y][i];
            sum = GetPathSum(grid, y, i + 1, sum);
        }
        
        result = GetPathSum(grid, y + 1, i, sum);

        sum = Math.Min(sum, result);

        if (y < grid.Length)
        {
            sum -= grid[y][i];
        }  
    }

    return sum;
}



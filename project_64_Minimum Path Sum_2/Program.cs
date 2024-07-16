

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
    List<int> result = new List<int>();
    GetPathSum(grid,result);
    return 1;
}

void GetPathSum(int[][] grid, List<int> list)
{
    for (int i = 1; i < grid.Length; i++)
    {
        for (int j = 1; j < grid[i].Length; j++)
        {

        }
    }
}
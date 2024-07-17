

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

int[][] grid5 = new int[7][]
{
    new int[8] {1, 4, 8, 6, 2, 2, 1, 7 },
    new int[8] {4, 7, 3, 1, 4, 5, 5, 1 },
    new int[8] {8, 8, 2, 1, 1, 8, 0, 1 },
    new int[8] {8, 9, 2, 9, 8, 0, 8, 9 },
    new int[8] {5, 7, 5, 7, 1, 8, 5, 5 },
    new int[8] {7, 0, 9, 4, 5, 6, 5, 6 },
    new int[8] {4, 9, 9, 7, 9, 1, 9, 0 }
};

//Console.WriteLine(MinPathSum(grid1));
//Console.WriteLine(MinPathSum(grid2));
//Console.WriteLine(MinPathSum(grid3));
Console.WriteLine(MinPathSum(grid5));


Console.ReadLine();

Stack<int> TEST = null;
int MinPathSum(int[][] grid)
{
    TEST = new Stack<int>();
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

        TestMethod(sum);
        return sum;
    }

    for (int i = x; i < grid[0].Length; i++)
    {
        if (y < grid.Length)
        {
            TEST.Push(grid[y][i]);
            sum += grid[y][i];
            minSum[1] += 1;
            sum = GetPathSum(grid, y, i + 1, sum, minSum);
        }

        sum = GetPathSum(grid, y + 1, i, sum, minSum);

        if (y < grid.Length)
        {
            TEST.Pop();
            sum -= grid[y][i];
            minSum[1] -= 1;
        }
    }

    return sum;
}

void TestMethod(int sum)
{
    Console.WriteLine();
    Console.WriteLine(sum);
    foreach (var item in TEST)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine(new string('-',20));
}
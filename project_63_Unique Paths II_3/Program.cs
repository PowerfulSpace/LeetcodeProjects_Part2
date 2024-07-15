
int[][] array1 = new int[3][]
{
    new int[3] {0,0,0},
    new int[3] {0,1,0},
    new int[3] {0,0,0}
};

int[][] array2 = new int[2][]
{
    new int[2] {0,1},
    new int[2] {0,0}
};

int[][] array3 = new int[5][]
{
    new int[4] {0,1,0,0},
    new int[4] {1,0,0,0},
    new int[4] {0,0,0,0},
    new int[4] {0,0,0,0},
    new int[4] {0,0,0,0}
};


Console.WriteLine(UniquePathsWithObstacles(array1));
Console.WriteLine(UniquePathsWithObstacles(array2));
Console.WriteLine(UniquePathsWithObstacles(array3));



Console.ReadLine();



int UniquePathsWithObstacles(int[][] obstacleGrid)
{
    var m = obstacleGrid.Length;
    var n = obstacleGrid[0].Length;
    var map = new int[m + 1, n + 1];

    map[1, 0] = 1;

    for (int x = 1; x < m + 1; x++)
    {
        for (int y = 1; y < n + 1; y++)
        {
            if (obstacleGrid[x - 1][y - 1] == 0)
            {
                map[x, y] = map[x - 1, y] + map[x, y - 1];
            }
            else
            {
                map[x, y] = 0;
            }
        }
    }

    return map[m, n];
}










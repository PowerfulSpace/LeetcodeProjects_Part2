
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
    var prev = new int[obstacleGrid[0].Length];
    var cur = new int[obstacleGrid[0].Length];

    if (obstacleGrid[0][0] == 1 || obstacleGrid[obstacleGrid.Length - 1][obstacleGrid[0].Length - 1] == 1)
    {
        return 0;
    }

    cur[0] = obstacleGrid[0][0] == 1 ? 0 : 1;

    for (int j = 1; j < obstacleGrid[0].Length; j++)
    {
        cur[j] = obstacleGrid[0][j] == 1 || cur[j - 1] == 0 ? 0 : 1;
    }
    prev = cur;

    for (int i = 1; i < obstacleGrid.Length; i++)
    {
        for (int j = 0; j < obstacleGrid[0].Length; j++)
        {
            if (j == 0)
            {
                cur[j] = obstacleGrid[i][j] == 1 || prev[j] == 0 ? 0 : 1;
            }
            else
            {
                cur[j] = obstacleGrid[i][j] == 1 ? 0 : prev[j] + cur[j - 1];
            }
        }

        prev = cur;
    }

    return cur[cur.Length - 1];
}











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

int[][] array3 = new int[3][]
{
    new int[2] {0,10},
    new int[2] {1,1},
    new int[2] {0,0}
};

//Console.WriteLine(UniquePathsWithObstacles(array1));
//Console.WriteLine(UniquePathsWithObstacles(array2));
Console.WriteLine(UniquePathsWithObstacles(array3));

Console.ReadLine();



int UniquePathsWithObstacles(int[][] obstacleGrid)
{
    if (obstacleGrid[0][0] == 1 || obstacleGrid[obstacleGrid.Length - 1][obstacleGrid[0].Length - 1] == 1) { return 0; }

    int[][] array = Filling(obstacleGrid);

    bool isClosed = true;

    for (int i = 1; i < array.Length; i++)
    {
        isClosed = true;
        for (int j = 1; j < array[0].Length; j++)
        {
            if (array[i][j] == 0) { continue; }
            else
            {
                array[i][j] = array[i - 1][j] + array[i][j - 1];
                isClosed = false;
            }
            
        }
        if(isClosed) { return 0; }
    }

    return array[array.Length - 1][array[0].Length - 1];
}



int[][] Filling(int[][] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array[0].Length; j++)
        {
            if (array[i][j] == 0)
                array[i][j] = 1;
            else
                array[i][j] = 0;
        }
    }
    return array;
}


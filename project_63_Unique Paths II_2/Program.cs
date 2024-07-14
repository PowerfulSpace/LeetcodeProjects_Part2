
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
    new int[4] {0,0,0,0},
    new int[4] {0,1,0,0},
    new int[4] {0,0,0,0},
    new int[4] {0,0,1,0},
    new int[4] {0,0,0,0}
};

int[][] array4 = new int[7][]
{
    new int[2] {0,0},
    new int[2] {0,0},
    new int[2] {1,0},
    new int[2] {0,0},
    new int[2] {0,1},
    new int[2] {0,0},
    new int[2] {0,0}
};

int[][] array5 = new int[29][]
{
    new int[18] {0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0},
    new int[18] {0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0},
    new int[18] {1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1, 1, 0, 1},
    new int[18] {0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    new int[18] {0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    new int[18] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0},
    new int[18] {0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0},
    new int[18] {1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
    new int[18] {0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0},
    new int[18] {0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0},
    new int[18] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    new int[18] {1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0},
    new int[18] {0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
    new int[18] {0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
    new int[18] {0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1},
    new int[18] {0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0},
    new int[18] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1},
    new int[18] {1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0},
    new int[18] {0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 1, 0, 0, 1, 0, 1, 1, 0},
    new int[18] {0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    new int[18] {0, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0},
    new int[18] {0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 1, 0, 1, 1, 1, 0, 0},
    new int[18] {0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 1},
    new int[18] {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0},
    new int[18] {1, 0, 0, 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    new int[18] {0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    new int[18] {0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0},
    new int[18] {1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1},
    new int[18] {1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0}

};


Console.WriteLine(UniquePathsWithObstacles(array1));
Console.WriteLine(UniquePathsWithObstacles(array2));
Console.WriteLine(UniquePathsWithObstacles(array3));
Console.WriteLine(UniquePathsWithObstacles(array4));
//Console.WriteLine(UniquePathsWithObstacles(array5));

Console.ReadLine();



int UniquePathsWithObstacles(int[][] obstacleGrid)
{
    if (obstacleGrid[0][0] == 1 || obstacleGrid[obstacleGrid.Length - 1][obstacleGrid[0].Length - 1] == 1) { return 0; }

    int[][] array = Filling(obstacleGrid);

    if (array[array.Length - 1][array[0].Length - 1] == 0) { return 0; }

    for (int i = 1; i < array.Length; i++)
    {
        for (int j = 1; j < array[0].Length; j++)
        {
            if (array[i][j] == -1) { continue; }
            else
            {
                int a = array[i - 1][j] == -1 ? 0 : array[i - 1][j];
                int b = array[i][j - 1] == -1 ? 0 : array[i][j - 1];

                array[i][j] = a + b;
            }

        }
    }

    return array[array.Length - 1][array[0].Length - 1];
}



int[][] Filling(int[][] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int x = i; x < array[0].Length; x++)
        {

            if (array[i][x] == 0)
            {
                array[i][x] = 1;
            }
            else
            {
                array[i][x] = -1;
                break;
                
            }        
        }

        if (i < array[0].Length)
        {
            for (int y = i + 1; y < array.Length; y++)
            {

                if (array[y][i] == 0)
                {
                    array[y][i] = 1;
                }
                else
                {
                    array[y][i] = -1;
                    break;
                }

            }
        }
    }
    return array;
}


void Print(int [][] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array[0].Length; j++)
        {
            Console.Write("{0,2} ", array[i][j]);
        }
        Console.WriteLine();
    }
}

int[][] array1 = new int[3][]
{
    new int[3]{1,1,1},
    new int[3]{1,0,1},
    new int[3]{1,1,1}
};

int[][] array2 = new int[3][]
{
    new int[4]{0,1,2,0},
    new int[4]{3,4,5,2},
    new int[4]{1,3,1,5}
};

SetZeroes(array1);
SetZeroes(array2);


Console.ReadLine();

void SetZeroes(int[][] matrix)
{
    int indexCol = 0;
    int indexRow = 0;

    for (int i = 0; i < matrix.Length; i++)
    {
        for (int j = 0; j < matrix[0].Length; j++)
        {
            if (matrix[i][j] == 0)
            {
                matrix[i][j] = int.MaxValue - 5;
            }
        }
    }

    while (indexCol < matrix[0].Length || indexCol < matrix.Length)
    {
        if (indexCol < matrix[0].Length)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                if (matrix[row][indexCol] == int.MaxValue - 5)
                {
                    SettingTheLineToZero(matrix, indexCol, row, "row");
                }
            }

        }
        if (indexRow < matrix.Length)
        {
            for (int col = 0; col < matrix[0].Length; col++)
            {
                if (matrix[indexRow][col] == int.MaxValue - 5)
                {
                    SettingTheLineToZero(matrix, col, indexRow, "col");
                }
            }
        }
        indexCol++;
        indexRow++;
    }

    for (int i = 0; i < matrix.Length; i++)
    {
        for (int j = 0; j < matrix[0].Length; j++)
        {
            if (matrix[i][j] == int.MaxValue - 5)
            {
                matrix[i][j] = 0;
            }
        }
    }

}

void SettingTheLineToZero(int[][] matrix, int indexCol, int indexRow, string direction)
{
    if (direction == "col")
    {
        for (int col = 0; col < matrix[0].Length; col++)
        {
            if (matrix[indexRow][col] != int.MaxValue - 5)
            {
                matrix[indexRow][col] = 0;
            }   
        }
    }
    else if (direction == "row")
    {
        for (int row = 0; row < matrix.Length; row++)
        {
            if (matrix[row][indexCol] != int.MaxValue - 5)
            {
                matrix[row][indexCol] = 0;
            }
        }
    }
}
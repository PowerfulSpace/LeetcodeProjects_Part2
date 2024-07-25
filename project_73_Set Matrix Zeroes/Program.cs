
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

    while (indexCol < matrix[0].Length || indexCol < matrix.Length)
    {
        if (indexRow < matrix.Length)
        {
            for (int col = indexCol; col < matrix[0].Length; col++)
            {
                if (matrix[indexRow][col] == 0)
                {
                    SettingTheLineToZero(matrix, col, indexRow, "col");
                }
            }
        }
        if (indexCol < matrix[0].Length)
        {
            for (int row = indexRow; row < matrix.Length; row++)
            {
                if (matrix[row][indexCol] == 0)
                {
                    SettingTheLineToZero(matrix, indexCol, row, "row");
                }
            }
        }
           
        indexCol++;
        indexRow++;
    }
}

void SettingTheLineToZero(int[][] matrix,int indexCol, int indexRow, string direction)
{
    if (direction == "col")
    {
        for (int col = 0; col < matrix[0].Length; col++)
        {
            matrix[indexRow][col] = 0;
        }
    }
    else if (direction == "row")
    {
        for (int row = 0; row < matrix.Length; row++)
        {
            matrix[row][indexCol] = 0;
        }
    }
}
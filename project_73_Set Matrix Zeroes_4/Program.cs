
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

//SetZeroes(array1);
SetZeroes(array2);


Console.ReadLine();

void SetZeroes(int[][] matrix)
{
    int n = matrix.Length;
    int m = matrix[0].Length;
    bool isFirstRowZero = false;
    bool isFirstColZero = false;
    for (int j = 0; j < m; j++)
    {
        if (matrix[0][j] == 0)
        {
            isFirstRowZero = true;
            break;
        }
    }
    for (int i = 0; i < n; i++)
    {
        if (matrix[i][0] == 0)
        {
            isFirstColZero = true;
            break;
        }
    }
    for (int i = 1; i < n; i++)
    {
        for (int j = 1; j < m; j++)
        {
            if (matrix[i][j] == 0)
            {
                matrix[i][0] = 0;
                matrix[0][j] = 0;
            }
        }
    }
    for (int i = 1; i < n; i++)
    {
        if (matrix[i][0] == 0)
        {
            for (int j = 1; j < m; j++)
            {
                matrix[i][j] = 0;
            }
        }
    }
    for (int j = 1; j < m; j++)
    {
        if (matrix[0][j] == 0)
        {
            for (int i = 1; i < n; i++)
            {
                matrix[i][j] = 0;
            }
        }
    }

    if (isFirstRowZero)
    {
        for (int j = 0; j < m; j++)
        {
            matrix[0][j] = 0;
        }
    }
    if (isFirstColZero)
    {
        for (int i = 0; i < n; i++)
            matrix[i][0] = 0;
    }
}

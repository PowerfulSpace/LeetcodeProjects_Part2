
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




    HashSet<int> rows = new();
    HashSet<int> cols = new();
    for (int i = 0; i < matrix.Length; i++)
    {
        for (int j = 0; j < matrix[0].Length; j++)
        {
            if (matrix[i][j] == 0)
            {
                rows.Add(i);
                cols.Add(j);
            }
        }
    }
    for (int i = 0; i < matrix.Length; i++)
    {
        for (int j = 0; j < matrix[0].Length; j++)
        {
            if (rows.Contains(i) || cols.Contains(j))
            {
                matrix[i][j] = 0;
            }
        }
    }
}

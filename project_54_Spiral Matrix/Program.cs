
int[][] matrix1 = new int[3][];
matrix1[0] = new int[3] { 1, 2, 3 };
matrix1[1] = new int[3] { 4, 5, 6 };
matrix1[2] = new int[3] { 7, 8, 9 };

SpiralOrder(matrix1);

Console.ReadLine();




IList<int> SpiralOrder(int[][] matrix)
{
    List<int> result = new List<int>();

    bool[][] matrixLock = CreateEmptyMatrix(matrix);

    int length = matrix.Length * matrix[0].Length;

    int x = 0;
    int y = 0;

    for (int i = 0; i < length; i++)
    {
        if(x < matrixLock[0].Length && x >= 0)
        {
            if (matrixLock[y][x] ==false)
            {
                result.Add(matrix[y][x]);
                matrixLock[y][x] = true;

                if(x < matrixLock[0].Length) { x++; }
            }
        }
        else
        {

            y++;
        }
    }


    return result;
}

bool[][] CreateEmptyMatrix(int[][] matrix)
{
    bool[][] matrixLock = new bool[matrix.Length][];

    for (int i = 0; i < matrix.Length; i++)
    {
        matrixLock[i] = new bool[matrix[i].Length];
    }
    return matrixLock;
}

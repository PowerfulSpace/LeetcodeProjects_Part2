
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

    int count = matrix.Length * matrix[0].Length;
    int lengthX = matrix[0].Length;
    int lengthY = matrix.Length;

    Stack<int> x = new Stack<int>();
    Stack<int> y = new Stack<int>();

    y.Push(0);
    x.Push(0);
    //Добавить реализацию начального добавленнного элемента
    //Упростить переходы

    while(count != 0)
    {
        int numY = y.Peek();
        int numX = x.Peek();

        if (numY < lengthX && matrixLock[numY][numX] == false)
        {
            result.Add(matrix[numY][numX]);
            matrixLock[numY][numX] = true;

            x.Push(x.Peek() + 1);
            count--;
        }
        else if (numY + 1 < lengthY && matrixLock[numY + 1][numX] == false)
        {
            numY = y.Peek() + 1;

            result.Add(matrix[numY][numX]);
            matrixLock[numY][numX] = true;

            y.Push(y.Peek() + 1);
            count--;
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

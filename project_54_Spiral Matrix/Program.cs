
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
    //result.Add(matrix[0][0]);
    //matrixLock[0][0] = true;
    bool drive = true;
    int side = 0;
    //Добавить проверку на второй круг

    while (drive)
    {

        switch (side)
        {
            case 0:
                if (x.Peek() < lengthX)
                {
                    if (matrixLock[y.Peek()][x.Peek()] == false)
                    {
                        matrixLock[y.Peek()][x.Peek()] = true;
                        if (x.Peek() < lengthX - 1)
                        {
                            x.Push(x.Peek() + 1);
                        }
                        else
                        {
                            y.Push(y.Peek() + 1);
                            side = 1;
                        }
                    }
                }
                else { side = 1; }
                break;
            case 1:
                if (y.Peek() < lengthY)
                {
                    if (matrixLock[y.Peek()][x.Peek()] == false)
                    {
                        matrixLock[y.Peek()][x.Peek()] = true;
                        if (y.Peek() < lengthY - 1)
                        {
                            y.Push(y.Peek() + 1);
                        }
                        else
                        {
                            x.Pop();
                            side = 2;
                        }
                    }
                }
                else { side = 2; }
                break;
            case 2:
                if (x.Peek() >= 0)
                {
                    if (matrixLock[y.Peek()][x.Peek()] == false)
                    {
                        matrixLock[y.Peek()][x.Peek()] = true;
                        if (x.Peek() > 0)
                        {
                            x.Pop();
                        }
                        else
                        {
                            y.Pop();
                            side = 3;
                        }
                    }
                }
                else { side = 3; }
                break;
            case 3:
                if (y.Peek() >= 0)
                {
                    if (matrixLock[y.Peek()][x.Peek()] == false)
                    {
                        matrixLock[y.Peek()][x.Peek()] = true;
                        if (y.Peek() > 0)
                        {
                            y.Pop();
                        }
                        else
                        {
                            x.Push(x.Peek() + 1);
                            side = 0;
                        }
                    }
                }
                else { side = 0; }
                break;
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

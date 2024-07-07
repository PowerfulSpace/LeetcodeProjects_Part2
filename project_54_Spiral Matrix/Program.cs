
int[][] matrix1 = new int[3][];
matrix1[0] = new int[3] { 1, 2, 3 };
matrix1[1] = new int[3] { 4, 5, 6 };
matrix1[2] = new int[3] { 7, 8, 9 };

SpiralOrder(matrix1);

Console.ReadLine();




IList<int> SpiralOrder(int[][] matrix)
{
    List<int> result = new List<int>();
    HashSet<int> set = new HashSet<int>();

   
    if (matrix.Length == 1)
    {
        result.AddRange(matrix[0]);
        return result;
    }
    if (matrix[0].Length == 1)
    {
        foreach (var item in matrix)
        {
            result.Add(item[0]);
        }
        return result;
    }

    bool[][] matrixLock = CreateEmptyMatrix(matrix);

    int count = matrix.Length * matrix[0].Length;
    int lengthX = matrix[0].Length;
    int lengthY = matrix.Length;

    Stack<int> x = new Stack<int>();
    Stack<int> y = new Stack<int>();

    y.Push(0);
    x.Push(0);
    //result.Add(matrix[0][0]);
    set.Add(matrix[0][0]);
    //matrixLock[0][0] = true;
    bool drive = true;
    int side = 0;
    //Добавить проверку на второй круг

    while (drive)
    {

        switch (side)
        {
            case 0:
                if (x.Peek() < lengthX && matrixLock[y.Peek()][x.Peek()] == false)
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
                else if (x.Peek() < lengthX && matrixLock[y.Peek()][x.Peek()] == true)
                {
                    if(x.Peek() + 1 < lengthX) { x.Push(x.Peek() + 1); }

                    if (y.Peek() + 1 < lengthY) { y.Push(y.Peek() + 1); }

                    drive = !matrixLock[y.Peek()][x.Peek()];
                }
                else { side = 1; }
                break;
            case 1:
                if (y.Peek() < lengthY && matrixLock[y.Peek()][x.Peek()] == false)
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
                else if (y.Peek() < lengthY && matrixLock[y.Peek()][x.Peek()] == true)
                {
                    if(y.Count > 1) { x.Pop(); }
                    if(x.Count > 1) { y.Pop(); }
                    
                    drive = !matrixLock[y.Peek()][x.Peek()];
                }
                else { side = 2; }
                break;
            case 2:
                if (x.Peek() >= 0 && matrixLock[y.Peek()][x.Peek()] == false)
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
                else if (x.Peek() >= 0 && matrixLock[y.Peek()][x.Peek()] == true)
                {
                    if(x.Count > 1) { x.Pop(); }
                    if(y.Peek() + 1 < lengthY) { y.Push(y.Peek() + 1); }

                    drive = !matrixLock[y.Peek()][x.Peek()];
                }
                else { side = 3; }
                break;
            case 3:
                if (y.Peek() >= 0 && matrixLock[y.Peek()][x.Peek()] == false)
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
                else if (y.Peek() >= 0 && matrixLock[y.Peek()][x.Peek()] == true)
                {
                    //x.Push(x.Peek() + 1);
                    //y.Pop();

                    //drive = !matrixLock[y.Peek()][x.Peek()];

                    side = 0;
                }
                else { side = 0; }
                break;
        }

        //result.Add(matrix[y.Peek()][x.Peek()]);
        set.Add(matrix[y.Peek()][x.Peek()]);
    }

    result.AddRange(set);

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




int m1 = 3, n1 = 7;
int m2 = 3, n2 = 2;

//Console.WriteLine(UniquePaths(m1, n1));
Console.WriteLine(UniquePaths(m2, n2));


Console.ReadLine();




int UniquePaths(int m, int n)
{
    int[,] array = new int[m,n];

    Print(array);

    int result = GetFoundPaths(array,0,0,0);

    return result;
}

int GetFoundPaths(int[,] array, int cY, int cX, int count)
{

    if (array[array.GetLength(0) - 1, array.GetLength(1) - 1] == 1)
    {
        count++;
        return count;
    }

    for (int x = cX; x < array.GetLength(1); x++)
    {
        if (cY < array.GetLength(0))
        {
            array[cY, x] = 1;
            count = GetFoundPaths(array, cY, x + 1, count);
        }

        for (int y = cY; y < array.GetLength(0); y++)
        {
            array[y, cX] = 1;
            count = GetFoundPaths(array, y + 1, cX, count);
            array[y, cX] = 0;
        }
        if (cY < array.GetLength(0))
        {
            array[cY, x] = 0;
        }
        return count;
    }
   

    return count;
}

void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}



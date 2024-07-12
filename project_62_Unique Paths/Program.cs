


int m1 = 3, n1 = 7;
int m2 = 3, n2 = 2;

Console.WriteLine(UniquePaths(m1, n1));
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
    if(cY > array.GetLength(0) -1) { return count; }
    if (cY == array.GetLength(0) - 1 && cX == array.GetLength(1) - 1)
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
        count = GetFoundPaths(array, cY + 1, cX, count);

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
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}



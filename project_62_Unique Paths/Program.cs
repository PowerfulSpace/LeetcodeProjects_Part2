


int m1 = 3, n1 = 7;
int m2 = 3, n2 = 2;

Console.WriteLine(UniquePaths(m1, n1));
Console.WriteLine(UniquePaths(m2, n2));


Console.ReadLine();




int UniquePaths(int m, int n)
{
    int[,] array = new int[m,n];

    Print(array);

    return m + n;
}

int GetFoundPaths(int[,] array, int cX,int cY, int count)
{
    if (array[array.GetLength(0), array.GetLength(1)] == 1)
    {
        count++;
        return count;
    }

    for (int x = cX; x < array.GetLength(1); x++)
    {
        array[cY, x] = 1;
        count = GetFoundPaths(array, cY,x + 1,count);

        for (int y = cY; y < array.GetLength(1); y++)
        {
            array[y, cX] = 1;
            count = GetFoundPaths(array, y + 1, cX, count);
            array[y, cX] = 0;
        }

        array[cY, x] = 0;
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



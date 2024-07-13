


int m1 = 3, n1 = 7;
int m2 = 3, n2 = 2;
int m3 = 23, n3 = 12;


Console.WriteLine(UniquePaths(m1, n1));
Console.WriteLine(UniquePaths(m2, n2));
Console.WriteLine(UniquePaths(m3, n3));


Console.ReadLine();




int UniquePaths(int m, int n)
{
    int[,] array = Filling(m,n);

    for (int i = 1; i < m; i++)
    {
        for (int j = 1; j < n; j++)
        {
            array[i, j] = array[i - 1, j] + array[i, j - 1];
        }
    }

    return array[m - 1, n - 1];
}


int[,] Filling(int m,int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < n; i++)
    {
        array[0, i] = 1;
    }
    for (int i = 0; i < m; i++)
    {
        array[i, 0] = 1;
    }
    return array;
}


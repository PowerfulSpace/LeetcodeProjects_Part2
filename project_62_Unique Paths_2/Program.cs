


int m1 = 3, n1 = 7;
int m2 = 3, n2 = 2;
int m3 = 23, n3 = 12;

int m4 = 3, n4 = 7;
int m5 = 4, n5 = 8;
int m6 = 5, n6 = 9;

Console.WriteLine(UniquePaths(m4, n4));
Console.WriteLine(UniquePaths(m5, n5));
Console.WriteLine(UniquePaths(m6, n6));

//Console.WriteLine(UniquePaths(m1, n1));
//Console.WriteLine(UniquePaths(m2, n2));

//var sw = new Stopwatch();

//sw.Start();
//Console.WriteLine(UniquePaths(m3, n3));
//sw.Stop();
//Console.WriteLine(sw.Elapsed);


Console.ReadLine();




int UniquePaths(int m, int n)
{
    int result = GetFoundPaths(m,n, 0, 0, 0);

    return result;
}

int GetFoundPaths(int yLength,int xLength, int y, int x, int count)
{
    if (y > yLength - 1) { return count; }
    if (y == yLength - 1 && x == xLength - 1)
    {
        count++;
        return count;
    }

    for (int i = x; i < xLength; i++)
    {
        if (y < yLength)
        {
            count = GetFoundPaths(yLength, xLength, y, i + 1, count);
        }
        count = GetFoundPaths(yLength, xLength, y + 1, x, count);

        return count;
    }

    return count;
}

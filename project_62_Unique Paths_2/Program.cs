


int m1 = 3, n1 = 7;
int m2 = 3, n2 = 2;

Console.WriteLine(UniquePaths(m1, n1));
Console.WriteLine(UniquePaths(m2, n2));


Console.ReadLine();




int UniquePaths(int m, int n)
{
    int result = GetFoundPaths(m,n, 0, 0, 0);

    return result;
}

int GetFoundPaths(int yLength,int xLength, int cY, int cX, int count)
{
    if (cY > yLength - 1) { return count; }
    if (cY == yLength - 1 && cX == xLength - 1)
    {
        count++;
        return count;
    }

    for (int x = cX; x < xLength; x++)
    {
        if (cY < yLength)
        {
            count = GetFoundPaths(yLength, xLength, cY, x + 1, count);
        }
        count = GetFoundPaths(yLength, xLength, cY + 1, cX, count);

        return count;
    }

    return count;
}

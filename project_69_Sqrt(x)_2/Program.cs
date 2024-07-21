
int x1 = 4;
int x2 = 8;
int x3 = 2147483647;


//Console.WriteLine(MySqrt(x1));
Console.WriteLine(MySqrt(x2));
Console.WriteLine(MySqrt(x3));


Console.ReadLine();


int MySqrt(int x)
{
    if (x == 0 || x == 1)
        return x;

    int start = 1;
    int end = x;
    int cur, curres = 0;

    while ((start < end) && (end - start > 1))
    {
        cur = start + (end - start) / 2;
        curres = x / cur;

        if (curres == cur)
            return cur;
        if (curres < cur)
        {
            end = cur;

        }
        else
        {
            start = cur;

        }
    }

    return start;
}



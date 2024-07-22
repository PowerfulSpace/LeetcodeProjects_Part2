
int n1 = 2;
int n2 = 3;
int n3 = 5;

//Console.WriteLine(ClimbStairs(n1));
//Console.WriteLine(ClimbStairs(n2));
Console.WriteLine(ClimbStairs(n3));

Console.ReadLine();

int ClimbStairs(int n)
{
    int[] s = new int[n + 1];
    if (n > 0) s[1] = 1;
    if (n > 1) s[2] = 2;
    if (n > 2)
    {
        for (int i = 3; i <= n; i++)
        {
            s[i] = s[i - 1] + s[i - 2];
        }
    }
    return s[n];

}



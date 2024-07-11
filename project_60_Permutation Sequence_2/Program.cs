


int n1 = 3, k1 = 3;
int n2 = 4, k2 = 9;
int n3 = 3, k3 = 1;

Console.WriteLine(GetPermutation(n1, k1));
Console.WriteLine(GetPermutation(n2, k2));
Console.WriteLine(GetPermutation(n3, k3));

Console.ReadLine();


string GetPermutation(int n, int k)
{
    var numbs = Enumerable.Range(1, n).ToList();
    var fact = Factorial(n);
    string res = "";
    for (int i = n; i >= 1; i--)
    {
        fact = fact / i;
        var part = (k - 1) / fact;
        res += numbs[part].ToString();
        numbs.RemoveAt(part);
        k = k - part * fact;
    }
    return res;
}

int Factorial(int n)
{
    if (n > 1)
        return Factorial(n - 1) * n;
    else
        return 1;
}
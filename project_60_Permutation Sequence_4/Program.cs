

int n1 = 3, k1 = 3;
int n2 = 4, k2 = 9;
int n3 = 3, k3 = 1;

Console.WriteLine(GetPermutation(n1, k1));
Console.WriteLine(GetPermutation(n2, k2));
Console.WriteLine(GetPermutation(n3, k3));

Console.ReadLine();


string GetPermutation(int n, int k)
{
    string ans = string.Empty;
    int fact = 1;
    List<int> numbers = new List<int>();
    //Initialize a list that has n natural numbers.
    //Also calculate the (n-1)! to be used 
    for (int i = 1; i < n; i++)
    {
        numbers.Add(i);
        fact *= i;
    }
    numbers.Add(n);
    k = k - 1;//As we use 0 based indexing, reduce the k by 1
    while (true)
    {
        var ind = k / fact;
        ans += numbers[ind];
        numbers.RemoveAt(ind);
        if (numbers.Count == 0)
        {
            break;
        }
        k = k % fact;
        fact = fact / numbers.Count;
    }

    return ans;
}



using System.Text;

int n1 = 3, k1 = 3;
int n2 = 4, k2 = 9;
int n3 = 3, k3 = 1;

Console.WriteLine(GetPermutation(n1, k1));
Console.WriteLine(GetPermutation(n2, k2));
Console.WriteLine(GetPermutation(n3, k3));

Console.ReadLine();


string GetPermutation(int n, int k)
{
    int[] factorial = new int[n + 1];
    List<int> arr = new List<int>();

    factorial[0] = 1;
    for (int i = 1; i <= n; i++)
    {
        factorial[i] = factorial[i - 1] * i;
        arr.Add(i);
    }

    k--;
    StringBuilder sb = new StringBuilder();
    for (int i = 1; i <= n; i++)
    {
        int index = k / factorial[n - i];
        sb.Append(arr[index]);
        arr.RemoveAt(index);
        k -= index * factorial[n - i];
    }

    return sb.ToString();
}
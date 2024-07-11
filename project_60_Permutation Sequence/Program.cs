

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
    StringBuilder sb = new StringBuilder();
    GetSequence(new HashSet<int>(), n, k, new int[1], sb);
    return sb.ToString();
}


void GetSequence(HashSet<int> s, int n, int k, int[] count, StringBuilder sb)
{
    if (s.Count == n)
    {
        count[0]++;
        if (count[0] == k)
        {
            sb.Append(string.Concat(s));
        }
        return;
    }

    for (int i = 1; i <= n; i++)
    {
        if (s.Add(i))
        {
            GetSequence(s, n, k, count, sb);

            s.Remove(i);

            if(sb.Length > 0) { return; }
        }
    }

    return;
}
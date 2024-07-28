
int n1 = 4, k1 = 2;
int n2 = 1, k2 = 1;


Combine(n1, k1);
Combine(n2, k2);


Console.ReadLine();

IList<IList<int>> Combine(int n, int k)
{
    List<IList<int>> result = new List<IList<int>>();
    List<int> list = new List<int>();
    GetArraysRanges(1, n, k, list, result);
    return result;
}

void GetArraysRanges(int i, int n, int k, List<int> list, List<IList<int>> result)
{
    if (list.Count == k)
    {
        result.Add(new List<int>(list));
        return;
    }
    if (i > n)
    {
        return;
    }
    for (int j = i; j <= n; ++j)
    {
        list.Add(j);
        GetArraysRanges(j + 1,n,k,list,result);
        list.RemoveAt(list.Count - 1);
    }
}
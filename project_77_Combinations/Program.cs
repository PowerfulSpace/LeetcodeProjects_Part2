
int n1 = 4, k1 = 2;
int n2 = 1, k2 = 1;


Combine(n1, k1);
Combine(n2, k2);


Console.ReadLine();

IList<IList<int>> Combine(int n, int k)
{
    List<IList<int>> result = new List<IList<int>>();

    if (n == 1) { result.Add(new List<int>() { 1}); }

    for (int i = 1; i < n; i++)
    {
        List<int> list = new List<int>();
        list.Add(i);
        int index = i;

        while (index > n)
        {
            for (int j = 0; j < k; j++)
            {
                list.Add(index);
            }

            index++;
            result.Add(list);
        }
       
    }

   


    return result;
}
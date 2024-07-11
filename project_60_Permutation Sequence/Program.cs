

using System.Text;

int n1 = 3, k1 = 3;
int n2 = 4, k2 = 9;
int n3 = 3, k3 = 1;

Console.WriteLine(GetPermutation(n1,k1));
//Console.WriteLine(GetPermutation(n2,k2));
//Console.WriteLine(GetPermutation(n3,k3));

Console.ReadLine();


string GetPermutation(int n, int k)
{
    string result = GetSequence(new StringBuilder(),1,n,k,0, "");
    return result;
}


string GetSequence(StringBuilder s,int index, int n, int k, int count,string result)
{
    if(s.Length == 3)
    {
        count++;
        if (count == k)
        {
            result = s.ToString();
        }
        return result;
    }

    for (int i = index; i <= n;i++)
    {
        s.Append(i);
        GetSequence(s,i + 1,n, k,count,result);
        s.Length--;
    }

    return result;
}


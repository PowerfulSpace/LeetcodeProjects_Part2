
using System.Text;

string s1 = "ADOBECODEBANC", t1 = "ABC";
string s2 = "a", t2 = "a";
string s3 = "aa", t3 = "aa";


Console.WriteLine(MinWindow(s1, t1));
Console.WriteLine(MinWindow(s2, t2));
Console.WriteLine(MinWindow(s3, t3));


Console.ReadLine();


string MinWindow(string s, string t)
{
    if (s.Length < t.Length) { return ""; }

    Dictionary<char, int> demanding = new Dictionary<char, int>();
    StringBuilder sb = new StringBuilder();

    Rewrite(demanding, t);

    int length = t.Length;

    int minCount = int.MaxValue;
    int count = 0;

    int head = 0;
    int index = 0;

    while (index < s.Length)
    {
        if (demanding.ContainsKey(s[index]) && demanding[s[index]] != 0)
        {
            if(length == t.Length) { head = index;}

            demanding[s[index]]--;
            length--;
        }

        if (length == 0)
        {
            count = index - head;
            if (minCount > count)
            {
                sb.Clear();
                minCount = count;
                sb.Append(s.Substring(head,count + 1));
            }

            length = t.Length;
            Rewrite(demanding, t);

            head++;
            index = head;
            continue;
        }

        index++;
    }



    return sb.ToString();
}

void Rewrite(Dictionary<char, int> demanding, string t)
{
    for (int i = 0; i < t.Length; i++)
    {
        if (demanding.ContainsKey(t[i]))
        {
            demanding[t[i]]++;
        }
        else
        {
            demanding.Add(t[i], 1);
        }
    }
}

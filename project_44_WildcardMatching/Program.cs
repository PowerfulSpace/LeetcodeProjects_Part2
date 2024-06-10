
using System.Text;

string s1 = "aa";
string p1 = "a";

string s2 = "aa";
string p2 = "*";

string s3 = "cb";
string p3 = "?a";

string s4 = "acdcb";
string p4 = "a*c?b";

//Console.WriteLine(IsMatch(s1, p1));
//Console.WriteLine(IsMatch(s2, p2));
//Console.WriteLine(IsMatch(s3, p3));
Console.WriteLine(IsMatch(s4, p4));

Console.ReadLine();

bool IsMatch(string s, string p)
{
    StringBuilder pattern = new StringBuilder(p);

    for (int i = 0; i < p.Length; i++)
    {
        if (pattern[i] == '?')
        {
            pattern[i] = s[i];
        }
        if (pattern[i] == '*')
        {
            var item = s[i];
            pattern[i] = item;
            i++;

            while (i < s.Length && s[i] == item)
            {
                pattern.Insert(i, item);
                i++;
            }        
        }
    }

    if (s == pattern.ToString())
    {
        return true;
    }
    else
    {
        return false;
    }

}

using System.Text;
using System.Text.RegularExpressions;

string s1 = "aa";
string p1 = "a";

string s2 = "aa";
string p2 = "*";

string s3 = "cb";
string p3 = "?a";

Console.WriteLine(IsMatch(s1, p1));
Console.WriteLine(IsMatch(s2, p2));
Console.WriteLine(IsMatch(s3, p3));

Console.ReadLine();

bool IsMatch(string s, string p)
{
    //* - Соответствует любому символу, любой последовательности
    //? - соответствует 1 любому символу

    StringBuilder pattern = new StringBuilder();

    if (p.Contains('*') || p.Contains('?'))
    {
        switch (p)
        {
            case "*":
                pattern.Clear();
                pattern.Append(@".\*");
                break;
            default:
                pattern.Append(p);
                break;
        }

        if (p.Contains("?"))
        {
            int index = p.IndexOf("?");
            pattern[index] = '.';
        }
    }
    else
    {
        if(s.Length != p.Length) { return false; }

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != p[i])
            {
                return false;
            }
        }
        return true;
    }
   
  


    var result = Regex.IsMatch(s, pattern.ToString());

    return result;
}
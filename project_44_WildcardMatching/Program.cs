
using System.Text;

string s1 = "aa";
string p1 = "a";

string s2 = "aa";
string p2 = "*";

string s3 = "cb";
string p3 = "?a";

string s4 = "acdcb";
string p4 = "a*c?b";

string s5 = "adceb";
string p5 = "*a*b";

string s6 = "";
string p6 = "*****";

string s7 = "a";
string p7 = "aa";

string s8 = "abcabczzzde";
string p8 = "*abc???de*";

string s9 = "aab";
string p9 = "c*a*b";

//Console.WriteLine(IsMatch(s1, p1));
//Console.WriteLine(IsMatch(s2, p2));
//Console.WriteLine(IsMatch(s3, p3));
//Console.WriteLine(IsMatch(s4, p4));
//Console.WriteLine(IsMatch(s5, p5));
//Console.WriteLine(IsMatch(s6, p6));
//Console.WriteLine(IsMatch(s7, p7));
//Console.WriteLine(IsMatch(s8, p8));
Console.WriteLine(IsMatch(s9, p9));

Console.ReadLine();

bool IsMatch(string s, string p)
{

    if (s.Length < p.Length && !p.Contains('*')) { return false; }

    StringBuilder str = new StringBuilder(s);
    char item = '\0';

    for (int i = 0; i < p.Length; i++)
    {
        if (p[i] == '*')
        {

            if (i + 1 < p.Length)
            {
                item = p[i + 1];
                if(item == '*') { break; }
            }

            while (str.Length != 0 && str[0] != item)
            {
                i++;
                str.Remove(0, 1);
            }
            if(str.Length > 0)
            {
                i++;
                str.Remove(0, 1);
            }
        }
        else if(p[i] == '?' || str[0] == p[i])
        {
            //i++;
            str.Remove(0, 1);
        }
    }

    if(str.Length > 0) { return false; }


    return true;
}
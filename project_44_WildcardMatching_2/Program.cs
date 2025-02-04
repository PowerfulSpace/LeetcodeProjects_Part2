﻿
using System.Text.RegularExpressions;
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

string s10 = "abefcdgiescdfimde";
string p10 = "ab*cd?i*de";

Console.WriteLine(IsMatch(s1, p1));
Console.WriteLine(IsMatch(s2, p2));
Console.WriteLine(IsMatch(s3, p3));
Console.WriteLine(IsMatch(s4, p4));
Console.WriteLine(IsMatch(s5, p5));
Console.WriteLine(IsMatch(s6, p6));
Console.WriteLine(IsMatch(s7, p7));
Console.WriteLine(IsMatch(s8, p8));
Console.WriteLine(IsMatch(s9, p9));
Console.WriteLine(IsMatch(s10, p10));

Console.ReadLine();

bool IsMatch(string s, string p)
{
    string question = @".{1}";
    string star = @"[^*?]*";

    StringBuilder pattern = new StringBuilder(p);

    for (int i = 0; i < pattern.Length; i++)
    {
        if (pattern[i] == '*')
        {
            pattern.Remove(i, 1);
            pattern.Insert(i, star);
            i += 5;
            continue;
        }
        if (pattern[i] == '?')
        {
            pattern.Remove(i, 1);
            pattern.Insert(i, question);
            i += 3;
            continue;
        }
    }
    pattern.Insert(0, '^');
    pattern.Append('$');

    Regex regex = new Regex(pattern.ToString());

    bool result = regex.IsMatch(s);

    return result;
}

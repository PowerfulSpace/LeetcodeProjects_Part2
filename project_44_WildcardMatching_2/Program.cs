
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
    List<char> chars = new List<char>(s);

    Examination(chars, p, 0,0);

    chars.RemoveAll(x => x == '-');

    bool result = chars.Count == 0 ? true : false;

    return result;
}

void Examination(List<char> s, string p, int indexS, int indexP)
{
    if (indexS >= s.Count || indexP >= p.Length) { return; }


    if (p[indexP] == s[indexS] || p[indexP] == '?')
    {
        Examination(s, p, indexS + 1, indexP + 1);
        s[indexS] = '-';
    }
    else if (p[indexP] == '*')
    {
        if (indexP < p.Length && p[indexP + 1] == s[indexS])
        {
            indexP+=2;
        }
        Examination(s, p, indexS+1, indexP);
        s[indexS] = '-';
    }

}
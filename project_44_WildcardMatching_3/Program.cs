
using System.Text;
using System.Text.RegularExpressions;

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

string s11 = "abbabaaabbabbaababbabbbbbabbbabbbabaaaaababababbbabababaabbababaa" +
    "bbbbbbaaaabababbbaabbbbaabbbbababababbaabbaababaabbbababababbbbaaabbbbbaba" +
    "aaabbababbbbaababaabbababbbbbababbbabaaaaaaaabbbbbaabaaababaaaabb";
string p11 = "**aa*****ba*a*bb**aa*ab****a*aaaaaa***a*aaaa**bbabb*b*b**aaaaaaaaa*a********ba*bbb***a*ba*bb*bb**a*b*bb";

//Console.WriteLine(IsMatch(s1, p1));
//Console.WriteLine(IsMatch(s2, p2));
//Console.WriteLine(IsMatch(s3, p3));
//Console.WriteLine(IsMatch(s4, p4));
//Console.WriteLine(IsMatch(s5, p5));
Console.WriteLine(IsMatch(s6, p6));
//Console.WriteLine(IsMatch(s7, p7));
//Console.WriteLine(IsMatch(s8, p8));
//Console.WriteLine(IsMatch(s9, p9));
//Console.WriteLine(IsMatch(s10, p10));
Console.WriteLine(IsMatch(s11, p11));

Console.ReadLine();

bool IsMatch(string s, string p)
{
    if (p == "*") return true;

    int sLocation = 0;
    int pLocation = 0;

    int pStar = -1;
    int lastMatch = -1;


    while (sLocation < s.Length)
    {
        char sChar = s[sLocation];

        if (pLocation < p.Length && (p[pLocation] == '?' || sChar == p[pLocation]))
        {
            sLocation++;
            pLocation++;
        }
        else if (pLocation < p.Length && p[pLocation] == '*')
        {
            pStar = pLocation;
            lastMatch = sLocation;
            pLocation++;
        }
        else if (pStar == -1)
        {
            return false;
        }
        else
        {
            pLocation = pStar + 1;
            sLocation = lastMatch + 1;
            lastMatch = sLocation;
        }
    }

    while (pLocation < p.Length && p[pLocation] == '*') pLocation++;

    return pLocation == p.Length;
}

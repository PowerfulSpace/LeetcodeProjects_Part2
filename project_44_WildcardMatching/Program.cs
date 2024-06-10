
using System.Text.RegularExpressions;

string s1 = "aa";
string p1 = "a";

string s2 = "aa";
string p2 = "*";

string s3 = "cb";
string p3 = "?a";

Console.WriteLine(IsMatch(s1,p1));
Console.WriteLine(IsMatch(s2,p2));
Console.WriteLine(IsMatch(s3,p3));

Console.ReadLine();

bool IsMatch(string s, string p)
{

    var result = Regex.IsMatch(s, p);

    return result;
}
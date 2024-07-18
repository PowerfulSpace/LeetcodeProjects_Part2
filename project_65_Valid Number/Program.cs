
using System.Text.RegularExpressions;

string s1 = "0";
string s2 = "e";
string s3 = ".";
string s4 = "3.";
string s5 = "e9.";
string s6 = "0e";


//Console.WriteLine(IsNumber(s1));
//Console.WriteLine(IsNumber(s2));
//Console.WriteLine(IsNumber(s3));
//Console.WriteLine(IsNumber(s4));
//Console.WriteLine(IsNumber(s5));
Console.WriteLine(IsNumber(s6));


Console.ReadLine();


bool IsNumber(string s)
{
    Regex reg = new Regex(@"^\s*[+-]?(\d+(\.\d*)?|\.\d+)([Ee][+-]?\d+)?\s*$");
    return reg.IsMatch(s);
}

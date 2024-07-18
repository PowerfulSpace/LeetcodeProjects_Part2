
string s1 = "0";
string s2 = "e";
string s3 = ".";


Console.WriteLine(IsNumber(s1));
Console.WriteLine(IsNumber(s2));
Console.WriteLine(IsNumber(s3));


Console.ReadLine();



bool IsNumber(string s)
{
    return Char.IsDigit(s.ToCharArray()[0]);
}
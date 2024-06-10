

using System.Numerics;
using System.Text;

string numA1 = "2";
string numA2 = "3";

string numB1 = "123";
string numB2 = "456";

string numC1 = "9333852702227987";
string numC2 = "85731737104263";

string numD1 = "65";
string numD2 = "4";



//Console.WriteLine(Multiply(numA1, numA2));
Console.WriteLine(Multiply(numB1, numB2));
Console.WriteLine(Multiply(numC1, numC2));
Console.WriteLine(Multiply(numD1, numD2));

Console.ReadLine();

string Multiply(string num1, string num2)
{
    BigInteger numb1, numb2, ans;
    numb1 = BigInteger.Parse(num1);
    numb2 = BigInteger.Parse(num2);
    ans = numb1 * numb2;
    return ans.ToString();
}

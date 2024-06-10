

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
    if (num1 == "0" || num2 == "0")
    {
        return "0";
    }
    var product = new int[num1.Length + num2.Length];
    for (var i = num1.Length - 1; i > -1; i--)
    {
        for (var j = num2.Length - 1; j > -1; j--)
        {
            product[i + j + 1] += (num1[i] - '0') * (num2[j] - '0');
        }
    }
    var carry = 0;
    for (var i = product.Length - 1; i > -1; i--)
    {
        var temp = (product[i] + carry) % 10;
        carry = (product[i] + carry) / 10;
        product[i] = temp;
    }
    var sb = new StringBuilder();
    foreach (var i in product)
    {
        if (!(sb.Length == 0 && i == 0)) sb.Append(i);
    }
    return sb.Length == 0 ? "0" : sb.ToString();
}

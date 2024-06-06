


string numA1 = "2";
string numA2 = "3";

string numB1 = "123";
string numB2 = "456";

string numC1 = "9333852702227987";
string numC2 = "85731737104263";

//Console.WriteLine(Multiply(numA1, numA2));
//Console.WriteLine(Multiply(numB1, numB2));
Console.WriteLine(Multiply(numC1, numC2));

Console.ReadLine();

string Multiply(string num1, string num2)
{
    decimal a = decimal.Parse(num1);
    decimal b = decimal.Parse(num2);

    string result = Convert.ToString(a * b);
    return result;
}
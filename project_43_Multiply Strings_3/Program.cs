

using System.Text;

string numA1 = "2";
string numA2 = "3";

string numB1 = "123";
string numB2 = "456";

string numC1 = "9333852702227987";
string numC2 = "85731737104263";

string numD1 = "65";
string numD2 = "4";



Console.WriteLine(Multiply(numA1, numA2));
Console.WriteLine(Multiply(numB1, numB2));
Console.WriteLine(Multiply(numC1, numC2));
Console.WriteLine(Multiply(numD1, numD2));

Console.ReadLine();

string Multiply(string num1, string num2)
{
    if (num1 == "0" || num2 == "0")
        return "0";

    int m = num1.Length, n = num2.Length;
    //the length of the result of multiplying two numbers can never exceed the sum of the length of both numbers

    int[] result = new int[m + n];
    for (int i = m - 1; i >= 0; i--)
    {
        for (int j = n - 1; j >= 0; j--)
        {
            int mul = (num1[i] - '0') * (num2[j] - '0');
            int sum = mul + result[i + j + 1];

            result[i + j + 1] = sum % 10;//hold the last digit
            result[i + j] += sum / 10; //add what you have in the preceeding index to the integer divisiio
        }
    }

    //with stringbuilder you can append values of several data types


    StringBuilder sb = new StringBuilder();
    foreach (int num in result)
    {
        if (!(sb.Length == 0 && num == 0))
        {
            sb.Append(num);
        }

    }

    return sb.Length == 0 ? "0" : sb.ToString();
}

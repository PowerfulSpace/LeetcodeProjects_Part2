

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
    int[] digits = new int[num1.Length + num2.Length];

    for (int i = num1.Length - 1; i > -1; i--)
    {
        for (int j = num2.Length - 1; j > -1; j--)
        {
            int digit1 = num1[i] - '0';
            int digit2 = num2[j] - '0';
            int sum = digits[i + j + 1] + digit1 * digit2;

            digits[i + j + 1] = sum % 10;
            digits[i + j] += sum / 10;
        }
    }

    StringBuilder stringBuilder = new();

    int index = 0;
    //for skip leading zeroes
    while (index < digits.Length - 1 && digits[index] == 0)
    {
        index++;
    }

    for (int i = index; i < digits.Length; i++)
    {
        stringBuilder.Append(digits[i]);
    }

    return stringBuilder.ToString();
}

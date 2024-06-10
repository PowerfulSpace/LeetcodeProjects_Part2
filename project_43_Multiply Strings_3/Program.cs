

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
//Console.WriteLine(Multiply(numB1, numB2));
Console.WriteLine(Multiply(numC1, numC2));
Console.WriteLine(Multiply(numD1, numD2));

Console.ReadLine();

string Multiply(string num1, string num2)
{
    if (num1 == "0" || num2 == "0") return "0";

    //this should be a string
    //then you use index in string to then do math
    //this will reduce memory usage
    var number = new List<int>();

    for (int i = num1.Length - 1; i >= 0; i--)
    {
        int n1 = Convert.ToInt32(num1.Substring(i, 1));
        int n1Position = num1.Length - 1 - i;

        for (int j = num2.Length - 1; j >= 0; j--)
        {
            int n2 = Convert.ToInt32(num2.Substring(j, 1));
            int n2Position = num2.Length - 1 - j;

            int product = n1 * n2;
            int position = n1Position + n2Position;

            while (number.Count - 1 < position)
            {
                number.Add(0);
            }

            number[position] += product;

            while (number[position] >= 10)
            {
                number[position] -= 10;

                if (number.Count <= position + 1)
                {
                    number.Add(0);
                }

                number[position + 1]++;
            }
        }
    }

    string output = string.Empty;

    for (int i = number.Count - 1; i >= 0; i--)
    {
        output += number[i].ToString();
    }

    return output;
}

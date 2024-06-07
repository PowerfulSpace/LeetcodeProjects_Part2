


using System.Text;

string numA1 = "2";
string numA2 = "3";

string numB1 = "123";
string numB2 = "456";

string numC1 = "9333852702227987";
string numC2 = "85731737104263";

Console.WriteLine(Multiply(numA1, numA2));
//Console.WriteLine(Multiply(numB1, numB2));
//Console.WriteLine(Multiply(numC1, numC2));

Console.ReadLine();

string Multiply(string num1, string num2)
{
    string a = "346";
    string b = "843";

    int indexA = a.Length - 1;
    int indexB = b.Length - 1;

    StringBuilder sb = new StringBuilder(a);

    for (int i = 0; i < Math.Max(a.Length,b.Length); i++)
    {
        if(indexA > 0 && indexB > 0)
        {
            int a1 = Convert.ToInt32(char.ConvertFromUtf32(a[indexA]));
            int b1 = Convert.ToInt32(char.ConvertFromUtf32(b[indexB]));

            int s = a1 * b1;

            indexA--;
            indexB--;
        }
    }


    return "1";
}
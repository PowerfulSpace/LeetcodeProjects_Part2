

string a1 = "11";
string b1 = "1";

string a2 = "1010";
string b2 = "1011";

string a3 = "0";
string b3 = "0";

string a4 = "10100000100100110110010000010101111011011001101110111111111101000000101111001110001111100001101";
string b4 = "110101001011101110001111100110001010100001101011101010000011011011001011101111001100000011011110011";


//Console.WriteLine(AddBinary(a1, b1));
//Console.WriteLine(AddBinary(a2, b2));
//Console.WriteLine(AddBinary(a3, b3));
Console.WriteLine(AddBinary(a4, b4));

Console.ReadLine();



//возводить в степень каждый раз когда попадается еденица, на индекс

string AddBinary(string a, string b)
{
    if (a[0] == '0' && b[0] == '0') { return "0"; }

    double sumA = GetSum(a);
    double sumB = GetSum(b);
    double sum = sumA + sumB;

    string result = DecimalToBinary((ulong)sum);

    return result;
}


double GetSum(string s)
{
    double sum = 0;
    int indexBaniry = 0;

    for (int i = s.Length - 1; i >= 0; i--)
    {
        if (s[i] == '1')
        {
            sum += indexBaniry == 0 ? 1 : Math.Pow(2, indexBaniry);
        }

        indexBaniry++;
    }

    return sum;
}


string DecimalToBinary(ulong number)
{
    string binaryNumber = string.Empty;
    while (number > 0)
    {
        binaryNumber = (number % 2) + binaryNumber;
        number /= 2;
    }

    return binaryNumber;
}
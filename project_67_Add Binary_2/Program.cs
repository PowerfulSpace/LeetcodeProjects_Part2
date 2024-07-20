



string a1 = "11";
string b1 = "1";

string a2 = "1010";
string b2 = "1011";

string a3 = "0";
string b3 = "0";

Console.WriteLine(AddBinary(a1, b1));
Console.WriteLine(AddBinary(a2, b2));
Console.WriteLine(AddBinary(a3, b3));

Console.ReadLine();



//возводить в степень каждый раз когда попадается еденица, на индекс

string AddBinary(string a, string b)
{
    Dictionary<int, int> binary = new Dictionary<int, int>()
    {
        [0] = 1,
        [1] = 2,
        [2] = 4,
        [3] = 8,
        [4] = 16,
        [5] = 32,
        [6] = 64,
        [7] = 128
    };

    double sumA = GetSum(a);
    double sumB = GetSum(b);
    double result = sumA + sumB;


    return "1";
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
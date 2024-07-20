

using System.Text;

string a1 = "11";
string b1 = "1";

string a2 = "1010";
string b2 = "1011";

string a3 = "0";
string b3 = "0";

string a4 = "10100000100100110110010000010101111011011001101110111111111101000000101111001110001111100001101";
string b4 = "110101001011101110001111100110001010100001101011101010000011011011001011101111001100000011011110011";


Console.WriteLine(AddBinary(a1, b1));
Console.WriteLine(AddBinary(a2, b2));
Console.WriteLine(AddBinary(a3, b3));
Console.WriteLine(AddBinary(a4, b4));

Console.ReadLine();


string AddBinary(string a, string b)
{
    int i = a.Length - 1;
    int j = b.Length - 1;
    var sb = new StringBuilder();
    for (int carry = 0; i >= 0 || j >= 0 || carry > 0; --i, --j)
    {
        carry += i >= 0 ? a[i] - '0' : 0;
        carry += j >= 0 ? b[j] - '0' : 0;
        sb.Append(carry % 2);
        carry /= 2;
    }
    var ans = sb.ToString().ToCharArray();
    Array.Reverse(ans);
    return new string(ans);
}


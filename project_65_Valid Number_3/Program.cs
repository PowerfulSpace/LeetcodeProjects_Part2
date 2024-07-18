

string s1 = "0";
string s2 = "e";
string s3 = ".";
string s4 = "3.";
string s5 = "e9.";
string s6 = "0e";


//Console.WriteLine(IsNumber(s1));
//Console.WriteLine(IsNumber(s2));
//Console.WriteLine(IsNumber(s3));
//Console.WriteLine(IsNumber(s4));
//Console.WriteLine(IsNumber(s5));
Console.WriteLine(IsNumber(s6));


Console.ReadLine();


bool IsNumber(string s)
{
    var allowSign = true;
    var allowDecimal = true;
    var allowExp = true;
    var seenNumber = false;
    foreach (var ch in s)
    {
        if (ch == '+' || ch == '-')
        {
            if (!allowSign)
            {
                return false;
            }
            allowSign = false;
            continue;
        }

        if (ch == '.')
        {
            if (!allowDecimal)
            {
                return false;
            }

            allowDecimal = false;
            allowSign = false;
        }
        else if (ch == 'e' || ch == 'E')
        {
            if (!seenNumber || !allowExp)
            {
                return false;
            }

            allowSign = true;
            allowDecimal = false;
            allowExp = false;
            seenNumber = false;
        }
        else if (!char.IsDigit(ch))
        {
            return false;
        }
        else
        {
            seenNumber = true;
            allowSign = false;
        }
    }

    return seenNumber;
}

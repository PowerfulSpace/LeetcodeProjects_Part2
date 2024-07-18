

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
    List<Token> tokens = Tokenize(s);

    return Parse(tokens);
}

List<Token> Tokenize(string s)
{
    List<Token> tokens = new();
    Token t;
    for (var i = 0; i < s.Length; i++)
    {
        if (isSign(s[i]))
        {
            t = Token.SIGN;
        }
        else if (isDigit(s[i]))
        {
            while (i < s.Length - 1 && isDigit(s[i + 1]))
            {
                i++;
            }
            t = Token.NUM;
        }
        else if (isDot(s[i]))
        {
            t = Token.DOT;
        }
        else if (isE(s[i]))
        {
            t = Token.E;
        }
        else
        {
            t = Token.ILLEGAL;
        }
        tokens.Add(t);
    }

    tokens.Add(Token.EOF);
    return tokens;
}




bool isSign(char c)
{
    return c == '+' || c == '-';
}
bool isDigit(char c)
{
    return 0x30 <= c && c <= 0x39;
}
bool isE(char c)
{
    return c == 'e' || c == 'E';
}

bool isDot(char c)
{
    return c == '.';
}


bool Parse(List<Token> tokens)
{
    bool seenDot = false;
    bool seenE = false;
    bool seenNumBeforeE = false;
    for (var i = 0; i < tokens.Count; i++)
    {
        if (tokens[i] == Token.EOF)
        {
            break;
        }
        else if (tokens[i] == Token.SIGN)
        {
            if ((i == 0 || tokens[i - 1] == Token.E) &&
                tokens[i + 1] == Token.NUM || tokens[i + 1] == Token.DOT) continue;

            return false;
        }
        else if (tokens[i] == Token.NUM)
        {
            if (tokens[i + 1] != Token.SIGN)
            {
                if (!seenE)
                {
                    seenNumBeforeE = true;
                }
                continue;
            }

            return false;
        }
        else if (tokens[i] == Token.DOT)
        {
            if (!seenE && !seenDot && (tokens[i + 1] == Token.NUM ||
                (i > 0 && (tokens[i - 1] == Token.NUM || tokens[i - 1] == Token.SIGN))))
            {
                seenDot = true;
                continue;
            }

            return false;
        }
        else if (tokens[i] == Token.E)
        {
            if (i > 0 && !seenE && (tokens[i - 1] == Token.NUM || tokens[i - 1] == Token.DOT) &&
                tokens[i + 1] != Token.EOF)
            {
                seenE = true;
                continue;
            }
            return false;
        }
        else if (tokens[i] == Token.ILLEGAL)
        {
            return false;
        }
    }

    return seenNumBeforeE;
}


enum Token
{
    SIGN,
    NUM,
    DOT,
    E,
    ILLEGAL,
    EOF
}
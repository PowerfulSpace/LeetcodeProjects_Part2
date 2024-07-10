
string input1 = "Hello World";
string input2 = "   fly me   to   the moon  ";
string input3 = "a ";

Console.WriteLine(LengthOfLastWord(input1));
Console.WriteLine(LengthOfLastWord(input2));
Console.WriteLine(LengthOfLastWord(input3));




Console.ReadLine();


int LengthOfLastWord(string s)
{
    s = s.Trim();
    int count = 0;

    for (int i = s.Length - 1; i >= 0; i--)
    {
        if (s[i] == ' ') { break; }       
        count++;
    }

    return count;
}
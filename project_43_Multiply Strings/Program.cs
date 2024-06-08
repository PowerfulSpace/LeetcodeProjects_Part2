



string numA1 = "2";
string numA2 = "3";

string numB1 = "123";
string numB2 = "456";

string numC1 = "9333852702227987";
string numC2 = "85731737104263";

string numD1 = "4";
string numD2 = "65";

//Console.WriteLine(Multiply(numA1, numA2));
//Console.WriteLine(Multiply(numB1, numB2));
//Console.WriteLine(Multiply(numC1, numC2));
Console.WriteLine(Multiply(numD1, numD2));

Console.ReadLine();

string Multiply(string num1, string num2)
{
    if (num1 == null && num2 == null) { return null!; }
    if (num1 == null || num2 == null)
    {
        return num1 == null ? num2 : num2 == null ? num1 : num2;
    }

    int[] array1 = GetArrayDigits(num1);
    int[] array2 = GetArrayDigits(num2);
    //int[] result = new int[Math.Max(num1.Length, num2.Length) * 2];
    List<int> result = new List<int>();

    int multiplicationResult = 0;
    int remainder = 0;
    int integer = 0;

    int index = 0;

    for (int i = array1.Length - 1; i >= 0; i--)
    {
        multiplicationResult = 0;
        remainder = 0;
        integer = 0;

        for (int j = array2.Length - 1; j >= 0; j--)
        {
            multiplicationResult = array1[i] * array2[j];
            multiplicationResult += integer;

            remainder = multiplicationResult % 10;
            integer = multiplicationResult / 10;

            result.Add(remainder);
        }
        if(integer > 0) { result.Add(integer); }
    }



    return "1";
}

int[] GetArrayDigits(string num1)
{
    int[] array = new int[num1.Length];
    for (int i = 0; i < num1.Length; i++)
    {
        array[i] = Convert.ToInt32(char.ConvertFromUtf32(num1[i]));
    }
    return array;
}


int[] digits1 = { 1, 2, 3 };
int[] digits2 = { 4, 3, 2, 1 };
int[] digits3 = { 9 };
int[] digits4 = { 9, 1, 9, 9 };
int[] digits5 = { 9, 9 };


Print(PlusOne(digits1));
Print(PlusOne(digits2));
Print(PlusOne(digits3));
Print(PlusOne(digits4));
Print(PlusOne(digits5));

Console.ReadLine();


int[] PlusOne(int[] digits)
{
    var output = new List<int>();
    var carry = 1;
    var index = 0;
    for (int i = digits.Length - 1; i >= 0; i--)
    {
        output.Insert(0, (digits[i] + carry) % 10);
        carry = (digits[i] + carry) / 10;
        index++;
    }
    if (carry != 0)
    {
        output.Insert(0, carry);
    }

    return output.ToArray();
}


void Print(int[] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


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
    for (int i = digits.Length - 1; i >= 0; i--)
    {
        if (digits[i] < 9)
        {
            digits[i]++;
            return digits;
        }
        digits[i] = 0;
    }
    int[] result = new int[digits.Length + 1];
    result[0] = 1;
    return result;
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
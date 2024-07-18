

int[] digits1 = { 1, 2, 3 };
int[] digits2 = { 4, 3, 2, 1 };
int[] digits3 = { 9 };
int[] digits4 = { 9, 1, 9, 9 };
int[] digits5 = { 9,9 };


Print(PlusOne(digits1));
Print(PlusOne(digits2));
Print(PlusOne(digits3));
Print(PlusOne(digits4));
Print(PlusOne(digits5));

Console.ReadLine();


int[] PlusOne(int[] digits)
{
    if(digits.Length == 0) return digits;

    Stack<int> stack = new Stack<int>();
    List<int> result = new List<int>();
    int add = 1;

    for (int i = digits.Length - 1; i >= 0; i--)
    {
        if(digits[i] + add > 9)
        {
            int count = 0;

            while(i >= 0 && digits[i] == 9)
            {
                count++;
                i--;
            }
            stack.Push(0);

            while(count != 1)
            {
                stack.Push(0);
                count--;
            }
        }
        if (i >= 0)
        {
            stack.Push(digits[i] + add);
            add = 0;
        }
      

    }

    if (add == 1) { stack.Push(1); }

    while (stack.Count > 0)
    {
        result.Add(stack.Pop());
    }

    return result.ToArray();
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
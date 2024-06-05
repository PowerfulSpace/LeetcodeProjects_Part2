

int[] input1 = { 1, 2, 0 };
int[] input2 = { 3, 4, -1, 1 };
int[] input3 = { 7, 8, 9, 11, 12 };
int[] input4 = { 0, 2, 2, 1, 1 };

Console.WriteLine(FirstMissingPositive(input1));
Console.WriteLine(FirstMissingPositive(input2));
Console.WriteLine(FirstMissingPositive(input3));
Console.WriteLine(FirstMissingPositive(input4));

Console.ReadLine();


int FirstMissingPositive(int[] nums)
{
    bool first = false;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] == 1)
            first = true;
        if (nums[i] <= 0 || nums[i] > nums.Length)
            nums[i] = 1;
    }
    if (!first)
        return 1;

    for (int i = 0; i < nums.Length; i++)
    {
        int val = int.Abs(nums[i]);
        if (nums[val - 1] > 0)
            nums[val - 1] = -nums[val - 1];
    }
    int result = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] > 0)
        {
            result = i;
            break;
        }
    }
    if (result == 0)
        return nums.Length + 1;
    return result + 1;
}
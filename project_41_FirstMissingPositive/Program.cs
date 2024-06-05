

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
    int digit = 1;
    Array.Sort(nums);

    for (int i = 0; i < nums.Length; i++)
	{
		if (nums[i] <= 0) { continue; }

        while (i + 1 < nums.Length && nums[i] == nums[i+1])
        {
            i++;
        }

        if (nums[i] == digit) { digit++; continue; }

        if (digit > nums[i]) { break; }
    }
    return digit;
}


int[] input1 = { 1, 2, 0 };
int[] input2 = { 3, 4, -1, 1 };
int[] input3 = { 7, 8, 9, 11, 12 };

Console.WriteLine(FirstMissingPositive(input1));
Console.WriteLine(FirstMissingPositive(input2));
Console.WriteLine(FirstMissingPositive(input3));

Console.ReadLine();


int FirstMissingPositive(int[] nums)
{
    int digit = 1;
    Array.Sort(nums);
    

    for (int i = 0; i < nums.Length; i++)
	{
		if (nums[i] <= 0) { continue; }

        if(nums[i] == digit) {  digit++; }
	}
    return digit;
}
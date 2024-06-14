

int[] nums1 = { 2, 3, 1, 1, 4 };
int[] nums2 = { 2, 3, 0, 1, 4 };
int[] nums3 = { 0};
int[] nums4 = { 1, 1, 1, 1 };
int[] nums5 = { 2,1 };
int[] nums6 = { 1, 2, 1, 1, 1 };


Console.WriteLine(Jump(nums1));
Console.WriteLine(Jump(nums2));
Console.WriteLine(Jump(nums3));
Console.WriteLine(Jump(nums4));
Console.WriteLine(Jump(nums5));
Console.WriteLine(Jump(nums6));

Console.ReadLine();


int Jump(int[] nums)
{
	if(nums.Length <= 1) return 0;

	int count = 0;
	int index = 0;

	while (index < nums.Length &&  nums[index] != 0)
	{
		index += nums[index] + 1;
        count++;
    }

    return count; 
}


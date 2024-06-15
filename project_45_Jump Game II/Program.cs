

int[] nums1 = { 2, 3, 1, 1, 4 };
int[] nums2 = { 2, 3, 0, 1, 4 };
int[] nums3 = { 0};
int[] nums4 = { 1, 1, 1, 1 };
int[] nums5 = { 2,1 };
int[] nums6 = { 1, 2, 1, 1, 1 };
int[] nums7 = { 4, 1, 1, 3, 1, 1, 1 };


Console.WriteLine(Jump(nums1));
Console.WriteLine(Jump(nums2));
Console.WriteLine(Jump(nums3));
Console.WriteLine(Jump(nums4));
Console.WriteLine(Jump(nums5));
Console.WriteLine(Jump(nums6));
Console.WriteLine(Jump(nums7));

Console.ReadLine();


int Jump(int[] nums)
{
	if(nums.Length <= 1) return 0;

	int countStep = 0;
	int maxStep = nums[0];
	int step = nums[0];
	int index = 0;

	for (int i = 1; i < nums.Length; i++)
	{
		if (i < maxStep)
		{
			if (nums[i] + maxStep > step)
			{
				step = nums[i] + maxStep;
				index = i;
            }
		}
		else if(i == maxStep)
		{
			i = index;
			maxStep = step;
			countStep++;
        }
	}
	if(step > nums.Length)
	{
        countStep++;
    }

    return countStep; 
}


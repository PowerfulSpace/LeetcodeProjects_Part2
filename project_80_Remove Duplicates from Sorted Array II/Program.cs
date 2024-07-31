

int[] nums1 = { 1, 1, 1, 2, 2, 3 };
int[] nums2 = { 0, 0, 1, 1, 1, 1, 2, 3, 3 };

//Console.WriteLine(RemoveDuplicates(nums1));
Console.WriteLine(RemoveDuplicates(nums2));

Console.ReadLine();



int RemoveDuplicates(int[] nums)
{
	Dictionary<int,int> dict = new Dictionary<int,int>();
	int count = 0;

	for (int i = 0; i < nums.Length; i++)
	{
        if (dict.ContainsKey(nums[i]))
        {
            if (dict[nums[i]] < 2)
            {
                dict[nums[i]]++;
            }
            else
            {
                if (i + 1 < nums.Length - count)
                {
                    nums[i] = nums[i + 1 + count];
                    count++;
                    i--;
                }
            }
        }
        else
        {
            dict[nums[i]] = 1;
        }
    }

    return 1;
}


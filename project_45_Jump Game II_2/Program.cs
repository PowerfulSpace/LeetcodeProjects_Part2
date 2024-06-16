


int[] nums1 = { 2, 3, 1, 1, 4 };
int[] nums2 = { 2, 3, 0, 1, 4 };
int[] nums3 = { 0 };
int[] nums4 = { 1, 1, 1, 1 };
int[] nums5 = { 2, 1 };
int[] nums6 = { 1, 2, 1, 1, 1 };
int[] nums7 = { 4, 1, 1, 3, 1, 1, 1 };
int[] nums8 = { 3,2, 1 };
int[] nums9 = { 3, 4, 3, 2, 5, 4, 3 };
int[] nums10 = { 1, 2, 3, 4, 5 };


Console.WriteLine(Jump(nums1));
Console.WriteLine(Jump(nums2));
Console.WriteLine(Jump(nums3));
Console.WriteLine(Jump(nums4));
Console.WriteLine(Jump(nums5));
Console.WriteLine(Jump(nums6));
Console.WriteLine(Jump(nums7));
Console.WriteLine(Jump(nums8));
Console.WriteLine(Jump(nums9));
Console.WriteLine(Jump(nums10));

Console.ReadLine();


int Jump(int[] nums)
{
    if (nums.Length <= 1) return 0;

    int count = 0;
    int index = 1;

    for (int i = 0; i < nums.Length - 1; i++)
    {
        if (nums[i] >= nums.Length - 1)
        {
            return count+1;
        }
        if (nums[i] == 1)
        {
            count++;
            continue;
        }
        int sum = nums[i];
        for (int j = i + 1; j <= nums[i] + i && j < nums.Length; j++)
        {          
            if (j < nums.Length && sum <= nums[i] + nums[j])
            {
                sum = nums[i] + nums[j];
                index = j;
            }
        }
        //if (i + nums[index] >= nums.Length)
        //{
        //    return count + 1;
        //}
        if (sum != 0)
        {
            i = index - 1;
            count++;
        }
    }

    return count;
}


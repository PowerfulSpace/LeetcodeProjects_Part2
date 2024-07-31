

int[] nums1 = { 1, 1, 1, 2, 2, 3 };
int[] nums2 = { 0, 0, 1, 1, 1, 1, 2, 3, 3 };
int[] nums3 = { 1, 1, 1, 1 };

Console.WriteLine(RemoveDuplicates(nums1));
Console.WriteLine(RemoveDuplicates(nums2));
Console.WriteLine(RemoveDuplicates(nums3));

Console.ReadLine();



int RemoveDuplicates(int[] nums)
{
    int i = 0;
    foreach (var n in nums)
    {
        if (i >= 2)
        {
            int afds = nums[i - 2];
        }
        

        if (i == 0 || i == 1 || nums[i - 2] != n)
        {
            nums[i] = n;
            i++;
        }
    }

    return i;
}

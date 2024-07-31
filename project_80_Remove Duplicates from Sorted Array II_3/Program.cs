

int[] nums1 = { 1, 1, 1, 2, 2, 3 };
int[] nums2 = { 0, 0, 1, 1, 1, 1, 2, 3, 3 };
int[] nums3 = { 1, 1, 1, 1 };

Console.WriteLine(RemoveDuplicates(nums1));
Console.WriteLine(RemoveDuplicates(nums2));
Console.WriteLine(RemoveDuplicates(nums3));

Console.ReadLine();



int RemoveDuplicates(int[] nums)
{
    int index = 0;
    foreach (var n in nums)
    {
        if (index >= 2)
        {
            int afds = nums[index - 2];
        }
        

        if (index == 0 || index == 1 || nums[index - 2] != n)
        {
            nums[index] = n;
            index++;
        }
    }

    return index;
}

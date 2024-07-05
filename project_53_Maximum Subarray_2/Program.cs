

int[] nums1 = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
int[] nums2 = { 1 };
int[] nums3 = { 5, 4, -1, 7, 8 };
int[] nums4 = { -2, -1 };

Console.WriteLine(MaxSubArray(nums1));
Console.WriteLine(MaxSubArray(nums2));
Console.WriteLine(MaxSubArray(nums3));
Console.WriteLine(MaxSubArray(nums4));


Console.ReadLine();


int MaxSubArray(int[] nums)
{
    int MaxSumSoFar = nums[0];
    int current = nums[0];

    for (int i = 1; i < nums.Length; i++)
    {
        current = Math.Max(nums[i], current + nums[i]);
        MaxSumSoFar = Math.Max(current, MaxSumSoFar);
    }
    return MaxSumSoFar;
}

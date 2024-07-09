
int[] nums1 = { 2, 3, 1, 1, 4 };
int[] nums2 = { 3, 2, 1, 0, 4 };
int[] nums3 = { 1 };
int[] nums4 = { 1, 2, 3 };
int[] nums5 = { 1, 0, 1, 0 };


Console.WriteLine(CanJump(nums1));
Console.WriteLine(CanJump(nums2));
Console.WriteLine(CanJump(nums3));
Console.WriteLine(CanJump(nums4));
Console.WriteLine(CanJump(nums5));

Console.ReadLine();


bool CanJump(int[] nums)
{
    int step = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (i > step) return false;
        step = Math.Max(step, i + nums[i]);
        if(step >= nums.Length -1) { return true; }
    }
    return true;
}

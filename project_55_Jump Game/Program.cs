
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
    if(nums.Length == 1) { return true; }
    if(nums[0] == 0) { return false; }

    bool result = IsSuccessfulJump(nums,0);
    return result;
}



bool IsSuccessfulJump(int[] nums,int index)
{
    if(index > nums.Length - 1) { return false; }
    if(index == nums.Length - 1) { return true; }

    for (int i = index; i < nums.Length; i++)
    {
        int digit = nums[i];
        if(digit == 0) { break; }

        while(digit > 0)
        {
            bool result = IsSuccessfulJump(nums, i + digit);
            if(result) return true;

            digit--;
        }

    }

    return false;
}

int[] nums1 = { 2, 3, 1, 1, 4 };
int[] nums2 = { 3, 2, 1, 0, 4 };
int[] nums3 = { 1 };
int[] nums4 = { 1, 2, 3 };


Console.WriteLine(CanJump(nums1));
Console.WriteLine(CanJump(nums2));
Console.WriteLine(CanJump(nums3));
Console.WriteLine(CanJump(nums4));

Console.ReadLine();


bool CanJump(int[] nums)
{
    if(nums.Length == 1) { return true; }

    bool result = IsSuccessfulJump(nums,0, 0);
    return result;
}



bool IsSuccessfulJump(int[] nums,int index,int num)
{
    if(index > nums.Length - 1) { return false; }
    if(index + num == nums.Length - 1) { return true; }

    for (int i = index; i < nums.Length; i++)
    {
        int digit = nums[i];

        while(digit > 0)
        {
            bool result = IsSuccessfulJump(nums, i,i + digit);
            if(result) return true;

            digit--;
        }
    }

    return false;
}
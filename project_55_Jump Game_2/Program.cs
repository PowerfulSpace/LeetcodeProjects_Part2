
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
    if (nums.Length <= 1) return true;
    else if (nums[0] == 0) return false;

    int steps = 1;
    int currentIndex = 0;
    int lastIndex = nums.Length - 1;

    while (currentIndex < lastIndex)
    {
        int currentNum = nums[currentIndex];

        if (currentIndex + currentNum >= lastIndex) return true;

        int nextIndex = -1;
        int nextMaxJump = 0;

        for (int i = 1; i <= currentNum; i++)
        {
            if (i + nums[currentIndex + i] > nextMaxJump)
            {
                nextIndex = i + currentIndex;
                nextMaxJump = i + nums[currentIndex + i];
            }
        }

        if (nextIndex == -1) return false;

        steps++;
        currentIndex = nextIndex;
    }

    return steps > 0;
}

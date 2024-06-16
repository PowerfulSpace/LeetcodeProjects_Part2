


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
    if (nums.Length <= 1 || nums[0] == 0) return 0;

    int currentIndex = 0;
    int endIndex = nums.Length - 1;

    int count = 1;

    while (currentIndex < endIndex)
    {
        int currentNum = nums[currentIndex];

        if(currentNum + currentIndex >= endIndex) { return count; }

        int maxJump = 0;
        int nextIndex = -1;

        for (int step = 1; step <= currentNum; step++)
        {
            if (nums[currentIndex + step] + step > maxJump)
            {
                maxJump = nums[currentIndex + step] + step;
                nextIndex = currentIndex + step;
            }
        }

        if(nextIndex == -1) { return 0; }

        count++;
        currentIndex = nextIndex;   
    }



   
    return count;
}


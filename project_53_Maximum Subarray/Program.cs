

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
    if (nums.Length == 1) return nums[0];

    int temporarySum = 0;

    int maxSum = 0;
    int maxSumIndexStart = 0;
    int maxSumIndexEnd = 0;

    int startIndex = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        if (temporarySum + nums[i] > 0)
        {
            if (startIndex == 0) { startIndex = i; }

            temporarySum += nums[i];

            if (maxSum < temporarySum)
            {
                maxSumIndexStart = startIndex;
                maxSumIndexEnd = i;
                maxSum = temporarySum;
            }
        }
        else
        {
            startIndex = 0;
            temporarySum = 0;
        }
    }

    if (nums[0] != 0 && maxSum == 0)
    {
        maxSum = nums.Max();
    }


    return maxSum;
}




int[] nums1 = { 2, 3, 1, 1, 4 };
int[] nums2 = { 2, 3, 0, 1, 4 };
int[] nums3 = { 0 };
int[] nums4 = { 1, 1, 1, 1 };
int[] nums5 = { 2, 1 };
int[] nums6 = { 1, 2, 1, 1, 1 };
int[] nums7 = { 4, 1, 1, 3, 1, 1, 1 };
int[] nums8 = { 3, 2, 1 };
int[] nums9 = { 3, 4, 3, 2, 5, 4, 3 };
int[] nums10 = { 1, 2, 3, 4, 5 };
int[] nums11 = { 1, 0, 0, 0, 0, 5 };


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
Console.WriteLine(Jump(nums11));

Console.ReadLine();


int Jump(int[] nums)
{
    var current = 0;
    var max = 0;
    var jumps = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        if (current >= nums.Length - 1)
        {
            break;
        }

        max = int.Max(max, i + nums[i]);

        if (current == i)
        {
            current = max;
            jumps++;
        }

    }

    return jumps;
}
